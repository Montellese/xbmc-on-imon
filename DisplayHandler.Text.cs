using System;
using System.Collections.Generic;
using System.Text;

namespace iMon.XBMC
{
    internal partial class DisplayHandler
    {
        private struct Text
        {
            #region Private variables

            private string lcd;
            private string vfdUpper;
            private string vfdLower;

            private int delay;

            #endregion

            #region Public variables

            public string Lcd
            {
                get { return this.lcd; }
            }

            public string VfdUpper
            {
                get { return this.vfdUpper; }
            }

            public string VfdLower
            {
                get { return this.vfdLower; }
            }

            public int Delay
            {
                get { return this.delay; }
            }

            #endregion

            #region Constructor

            public Text(string lcd, string vfdUpper, string vfdLower)
            {
                if (lcd == null)
                {
                    this.lcd = string.Empty;
                }
                else
                {
                    this.lcd = lcd;
                }
                if (vfdUpper == null)
                {
                    this.vfdUpper = string.Empty;
                }
                else
                {
                    this.vfdUpper = vfdUpper;
                }
                if (vfdLower == null)
                {
                    this.vfdLower = string.Empty;
                }
                else
                {
                    this.vfdLower = vfdLower;
                }

                this.delay = 0;
            }

            public Text(string lcd, string vfdUpper, string vfdLower, int delay)
                : this(lcd, vfdUpper, vfdLower)
            {
                if (this.delay >= 0)
                {
                    this.delay = delay;
                }
            }

            #endregion
        }
    }
}
