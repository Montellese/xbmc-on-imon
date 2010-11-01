using System;
using System.Collections.Generic;
using System.Text;

namespace iMon.XBMC
{
    internal partial class XbmcHandler
    {
        public struct ControlState
        {
            #region Private variables

            string window;
            string control;

            #endregion

            #region Public variables

            public string Window
            {
                get { return this.window; }
                set { this.window = value != null ? value : string.Empty; }
            }

            public string Control
            {
                get { return this.control; }
                set { this.control = value != null ? value : string.Empty; }
            }

            #endregion

            #region Constructor

            public ControlState(string window, string control)
            {
                if (window == null)
                {
                    window = string.Empty;
                }
                if (control == null)
                {
                    control = string.Empty;
                }

                this.window = window;
                this.control = control;
            }

            #endregion
        }
    }
}
