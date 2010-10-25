using System;
using System.Collections.Generic;

using iMon.DisplayApi;

namespace iMon.XBMC
{
    internal partial class DisplayTextHandler : IDisposable
    {
        #region Private variables

        private bool disposed;

        private iMonWrapperApi imon;
        private bool lcd;
        private bool vfd;
        private object displayLock = new object();

        private object queueLock = new object();
        private List<Text> queue;
        private int position;

        #endregion

        #region Public variables

        #endregion

        #region Constructor

        public DisplayTextHandler(iMonWrapperApi imon)
        {
            if (imon == null)
            {
                throw new ArgumentNullException("imon");
            }

            this.imon = imon;

            this.queue = new List<Text>();

            this.imon.StateChanged += stateChanged;
        }

        #endregion

        #region Implementations of IDisposable

        public void Dispose()
        {
            if (!this.disposed)
            {
                if (this.lcd)
                {
                    this.imon.LCD.ScrollFinished -= lcdScrollFinished;
                }

                this.disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        #endregion

        #region Public functions

        public void Set(string lcd, string vfdUpper, string vfdLower)
        {
            this.Set(lcd, vfdUpper, vfdLower, 0);
        }

        public void Set(string lcd, string vfdUpper, string vfdLower, int delay)
        {
            lock (this.queueLock)
            {
                this.queue.Clear();
                this.queue.Add(new Text(lcd, vfdUpper, vfdLower, delay));
                this.position = 0;

                this.display(this.queue[0]);
            }
        }

        public void Add(string lcd, string vfdUpper, string vfdLower)
        {
            this.Add(lcd, vfdUpper, vfdLower, 0);
        }

        public void Add(string lcd, string vfdUpper, string vfdLower, int delay)
        {
            lock (this.queueLock)
            {
                this.queue.Add(new Text(lcd, vfdUpper, vfdLower, delay));
            }
        }

        #endregion

        #region Event handlers

        private void stateChanged(object sender, iMonStateChangedEventArgs e)
        {
            lock (this.displayLock)
            {
                if (e.IsInitialized)
                {
                    iMonDisplayType display = this.imon.DisplayType;
                    if ((display & iMonDisplayType.LCD) == iMonDisplayType.LCD)
                    {
                        this.imon.LCD.ScrollFinished += lcdScrollFinished;
                        this.lcd = true;
                    }
                    if ((display & iMonDisplayType.VFD) == iMonDisplayType.VFD)
                    {
                        this.vfd = true;
                    }

                    this.Set("XBMC", "XBMC", string.Empty);
                }
                else
                {
                    this.lcd = false;
                    this.vfd = false;
                }
            }
        }

        private void lcdScrollFinished(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);

            lock (this.queueLock)
            {
                if (this.position >= this.queue.Count)
                {
                    this.position = 0;
                }

                if (this.queue.Count == 0)
                {
                    return;
                }

                this.display(this.queue[this.position]);

                if (this.queue[this.position].Delay > 0)
                {
                    System.Threading.Thread.Sleep(this.queue[this.position].Delay);
                }

                this.position += 1;
            }
        }

        #endregion

        #region Private functions

        private void display(Text text)
        {
            lock (this.displayLock)
            {
                if (this.lcd)
                {
                    this.imon.LCD.SetText(text.Lcd);
                }
                if (this.vfd)
                {
                    this.imon.VFD.SetText(text.VfdUpper, text.VfdLower);
                }
            }
        }

        #endregion
    }
}
