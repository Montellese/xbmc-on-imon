﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

using iMon.DisplayApi;
using iMon.XBMC.Properties;
using System.Threading;

namespace iMon.XBMC
{
    internal partial class DisplayHandler : BackgroundWorker
    {
        #region Private variables

        private Semaphore semReady;
        private Semaphore semWork;

        private iMonWrapperApi imon;
        private bool lcd;
        private bool vfd;
        private object displayLock = new object();

        private object queueLock = new object();
        private List<Text> queue;
        private int position;

        private Dictionary<iMonLcdIcons, bool> icons;

        #endregion

        #region Public variables

        #endregion

        #region Constructor

        public DisplayHandler(iMonWrapperApi imon)
        {
            if (imon == null)
            {
                throw new ArgumentNullException("imon");
            }

            this.imon = imon;
            this.imon.StateChanged += stateChanged;
            this.queue = new List<Text>();

            this.icons = new Dictionary<iMonLcdIcons, bool>(Enum.GetValues(typeof(iMonLcdIcons)).Length);
            foreach (iMonLcdIcons icon in Enum.GetValues(typeof(iMonLcdIcons)))
            {
                this.icons.Add(icon, false);
            }

            this.WorkerReportsProgress = false;
            this.WorkerSupportsCancellation = true;

            this.semReady = new Semaphore(0, 1);
            this.semWork = new Semaphore(0, 1);
        }

        #endregion

        #region Overrides of BackgroundWorker

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            while (!this.CancellationPending)
            {
                // Wait until a connection has been established
                this.semReady.WaitOne();

                Logging.Log("Display Handler", "Start working");

                if (this.lcd)
                {
                    foreach (KeyValuePair<iMonLcdIcons, bool> icon in this.icons)
                    {
                        this.imon.LCD.Icons.Set(icon.Key, icon.Value);
                    }
                }

                if (this.queue.Count > 0)
                {
                    this.display(this.queue[0]);

                    if (this.queue.Count > 1)
                    {
                        this.position = 1;
                    }
                }

                while (!this.CancellationPending && (this.lcd || this.vfd))
                {
                    this.semWork.WaitOne();

                    lock (this.queueLock)
                    {
                        if (this.position >= this.queue.Count) 
                        {
                            this.position = 0;
                        }

                        this.display(this.queue[this.position]);

                        if (this.queue.Count > this.position + 1)
                        {
                            this.position += 1;
                        }
                    }
                }

                Logging.Log("Display Handler", "Stop working");
            }

            Logging.Log("Display Handler", "Cancelled");

            this.imon.LCD.ScrollFinished -= lcdScrollFinished;
        }

        #endregion

        #region Public functions

        public void SetText(string text)
        {
            this.SetText(text, text, string.Empty, 0);
        }

        public void SetText(string text, int delay)
        {
            this.SetText(text, text, string.Empty, delay);
        }

        public void SetText(string lcd, string vfdUpper, string vfdLower)
        {
            this.SetText(lcd, vfdUpper, vfdLower, 0);
        }

        public void SetText(string lcd, string vfdUpper, string vfdLower, int delay)
        {
            lock (this.queueLock)
            {
                Logging.Log("Display Handler", "Setting text to \"" + lcd + "\"");

                this.queue.Clear();
                this.queue.Add(new Text(lcd, vfdUpper, vfdLower, delay));
                this.position = 0;

                this.update();
            }
        }

        public void AddText(string lcd, string vfdUpper, string vfdLower)
        {
            this.AddText(lcd, vfdUpper, vfdLower, 0);
        }

        public void AddText(string lcd, string vfdUpper, string vfdLower, int delay)
        {
            lock (this.queueLock)
            {
                Logging.Log("Display Handler", "Adding text \"" + lcd + "\" to the queue");

                this.queue.Add(new Text(lcd, vfdUpper, vfdLower, delay));

                if (this.queue.Count == 1)
                {
                    this.update();
                }
            }
        }

        public void SetProgress(int position, int total)
        {
            if (this.lcd)
            {
                this.imon.LCD.SetProgress(position, total);
            }
        }

        public void SetProgress(TimeSpan position, TimeSpan total)
        {
            if (this.lcd)
            {
                this.imon.LCD.SetProgress(Convert.ToInt32(position.TotalMilliseconds), Convert.ToInt32(total.TotalMilliseconds));
            }
        }

        public void SetIcon(iMonLcdIcons icon, bool show)
        {
            this.icons[icon] = show;

            if (this.lcd)
            {
                Logging.Log("Display Handler", "Setting LCD icon " + icon + " to " + show); 
                
                this.imon.LCD.Icons.Set(icon, show);
            }
        }

        public void SetIcons(IEnumerable<iMonLcdIcons> iconList, bool show)
        {
            foreach (iMonLcdIcons icon in iconList)
            {
                if (this.lcd) 
                {
                    Logging.Log("Display Handler", "Setting LCD icon " + icon + " to " + show);
                }

                this.icons[icon] = show;
            }

            if (this.lcd)
            {
                this.imon.LCD.Icons.Set(iconList, show);
            }
        }

        public void HideAllIcons()
        {
            foreach (iMonLcdIcons icon in Enum.GetValues(typeof(iMonLcdIcons)))
            {
                this.icons[icon] = false;
            }

            if (this.lcd)
            {
                Logging.Log("Display Handler", "Hiding all LCD icons");

                this.imon.LCD.Icons.HideAll();
            }
        }

        #endregion

        #region Event handlers

        private void update()
        {
            try
            {
                this.semWork.Release();
            }
            catch (SemaphoreFullException)
            { }
        }

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

                    this.semReady.Release();
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
            Thread.Sleep(Settings.Default.ImonLcdScrollingDelay);

            Logging.Log("Display Handler", "Scrolling finished");

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

                this.update();
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
                    Logging.Log("Display Handler", "LCD.SetText: " + text.Lcd);

                    this.imon.LCD.SetText(text.Lcd);
                }
                if (this.vfd)
                {
                    Logging.Log("Display Handler", "VFD.SetText: " + text.VfdUpper + "; " + text.VfdLower);
                    
                    this.imon.VFD.SetText(text.VfdUpper, text.VfdLower);
                }

                if (text.Delay > 0)
                {
                    Logging.Log("Display Handler", "Showing text for " + text.Delay + "ms");

                    System.Threading.Thread.Sleep(text.Delay);
                }
            }
        }

        #endregion
    }
}
