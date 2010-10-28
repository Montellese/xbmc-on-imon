using System;
using System.Windows.Forms;

using iMon.XBMC.Properties;

using iMon.DisplayApi;
using XBMC.JsonRpc;
using System.Threading;

namespace iMon.XBMC
{
    public partial class XBMC
    {
        #region Variables

        private bool closing;

        private iMonWrapperApi imon;
        private DisplayHandler text;
        private XbmcJsonRpcConnection xbmc;
        private XbmcHandler xbmcHandler;

        private delegate bool XbmcConnectingDelegate(bool auto);
        XbmcConnectingDelegate xbmcConnectingDeletage;
        private System.Windows.Forms.Timer xbmcConnectionTimer;

        #endregion

        #region General functions

        private void constructor()
        {
            this.xbmcConnectionTimer = new System.Windows.Forms.Timer();
            this.xbmcConnectionTimer.Tick += xbmcTryConnect;

            this.settingsUpdate();
            this.setupSettingsChanges(this.tabOptions);

            // Setting up iMON
            this.imon = new iMonWrapperApi();
            this.imon.StateChanged += wrapperApi_StateChanged;
            this.imon.Error += wrapperApi_Error;

            this.text = new DisplayHandler(this.imon);

            // Setting up XBMC
            this.xbmc = new XbmcJsonRpcConnection(Settings.Default.XbmcIp, Settings.Default.XbmcPort,
                                                  Settings.Default.XbmcUsername, Settings.Default.XbmcPassword);
            this.xbmc.System.Hibernating += xbmcShutdown;
            this.xbmc.System.ShuttingDown += xbmcShutdown;
            this.xbmc.System.Rebooting += xbmcShutdown;
            this.xbmc.System.Sleeping += xbmcShutdown;
            this.xbmc.System.Suspending += xbmcShutdown;
            this.xbmc.Aborted += xbmcShutdown;

            this.xbmcHandler = new XbmcHandler(this.xbmc, this.text);

            this.xbmcConnectingDeletage = new XbmcConnectingDelegate(xbmcConnecting);

            if (Settings.Default.GeneralStartupConnect)
            {
                this.xbmcConnect(true);
            }
        }

        private void close(bool force)
        {
            if (!force && Settings.Default.GeneralTrayEnabled && Settings.Default.GeneralTrayHideOnClose)
            {
                this.Hide();
                return;
            }

            this.closing = true;
            this.iMonUninitialize();
            this.xbmcDisconnect(true);
            this.Close();
        }

        private void setupSettingsChanges(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).CheckedChanged += settingsChanged;
                }
                else if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Leave += settingsChanged;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).ValueChanged += settingsChanged;
                }
                else if (ctrl.Controls.Count > 0)
                {
                    this.setupSettingsChanges(ctrl);
                }
            }
        }

        private void showBalloonTip(string text, ToolTipIcon icon)
        {
            this.trayIcon.ShowBalloonTip(5000, "XBMC on iMON", text, icon);
        }

        #endregion

        #region Settings functions

        private void settingsChanged(object sender, EventArgs e)
        {
            this.settingsSave();
        }

        private void settingsUpdate()
        {
            this.cbGeneralStartupAuto.Checked = Settings.Default.GeneralStartupAuto;
            this.cbGeneralStartupConnect.Checked = Settings.Default.GeneralStartupConnect;

            this.cbGeneralTrayEnabled.Checked = Settings.Default.GeneralTrayEnabled;
            this.cbGeneralTrayStartMinimized.Checked = Settings.Default.GeneralTrayStartMinimized;
            this.cbGeneralTrayHideOnMinimize.Checked = Settings.Default.GeneralTrayHideOnMinimize;
            this.cbGeneralTrayHideOnClose.Checked = Settings.Default.GeneralTrayHideOnClose;

            this.cbImonGeneralAutoInitialize.Checked = Settings.Default.ImonAutoInitialize;
            this.cbImonGeneralUninitializeOnError.Checked = Settings.Default.ImonUninitializeOnError;

            this.nudImonLcdScrollingDelay.Value = Settings.Default.ImonLcdScrollingDelay;

            this.tbXbmcConnectionIp.Text = Settings.Default.XbmcIp;
            this.tbXbmcConnectionPort.Text = Settings.Default.XbmcPort.ToString();
            this.tbXbmcConnectionUsername.Text = Settings.Default.XbmcUsername;
            this.tbXbmcConnectionPassword.Text = Settings.Default.XbmcPassword;
            this.nudXbmcConnectionInterval.Value = Settings.Default.XbmcConnectionInterval;

            this.cbXbmcIdleStaticTextEnable.Checked = Settings.Default.XbmcIdleStaticTextEnable;
            this.tbXbmcIdleStaticText.Text = Settings.Default.XbmcIdleStaticText;

            this.trayIcon.Visible = Settings.Default.GeneralTrayEnabled;
            this.xbmcConnectionTimer.Interval = Settings.Default.XbmcConnectionInterval * 1000;

            if (Settings.Default.ImonAutoInitialize &&  this.imon != null && 
                !this.imon.IsInitialized && this.xbmc != null && this.xbmc.IsAlive)
            {
                this.iMonInitialize();
            }
        }

        private void settingsSave()
        {
            if (Settings.Default.GeneralStartupAuto != this.cbGeneralStartupAuto.Checked)
            {
                // TODO: Handle auto start with windows
            }
            if (Settings.Default.GeneralStartupConnect != this.cbGeneralStartupConnect.Checked)
            {
                if (this.cbGeneralStartupConnect.Checked && !this.xbmc.IsAlive)
                {
                    this.xbmcConnect(true);
                }
                else if (!this.cbGeneralStartupConnect.Checked && this.xbmcConnectionTimer.Enabled)
                {
                    this.xbmcConnectionTimer.Stop();
                }
            }
            if (Settings.Default.XbmcConnectionInterval != Convert.ToInt32(this.nudXbmcConnectionInterval.Value)) 
            {
                this.xbmcConnectionTimer.Interval = Convert.ToInt32(this.nudXbmcConnectionInterval.Value) * 1000;
            }

            Settings.Default.GeneralStartupAuto = this.cbGeneralStartupAuto.Checked;
            Settings.Default.GeneralStartupConnect = this.cbGeneralStartupConnect.Checked;

            Settings.Default.GeneralTrayEnabled = this.cbGeneralTrayEnabled.Checked;
            Settings.Default.GeneralTrayStartMinimized = this.cbGeneralTrayStartMinimized.Checked;
            Settings.Default.GeneralTrayHideOnMinimize = this.cbGeneralTrayHideOnMinimize.Checked;
            Settings.Default.GeneralTrayHideOnClose = this.cbGeneralTrayHideOnClose.Checked;

            Settings.Default.ImonAutoInitialize = this.cbImonGeneralAutoInitialize.Checked;
            Settings.Default.ImonUninitializeOnError = this.cbImonGeneralUninitializeOnError.Checked;

            Settings.Default.ImonLcdScrollingDelay = Convert.ToInt32(this.nudImonLcdScrollingDelay.Value);

            Settings.Default.XbmcIp = this.tbXbmcConnectionIp.Text;
            Settings.Default.XbmcPort = Int32.Parse(this.tbXbmcConnectionPort.Text);
            Settings.Default.XbmcUsername = this.tbXbmcConnectionUsername.Text;
            Settings.Default.XbmcPassword = this.tbXbmcConnectionPassword.Text;
            Settings.Default.XbmcConnectionInterval = Convert.ToInt32(this.nudXbmcConnectionInterval.Value);

            Settings.Default.XbmcIdleStaticTextEnable = this.cbXbmcIdleStaticTextEnable.Checked;
            Settings.Default.XbmcIdleStaticText = this.tbXbmcIdleStaticText.Text;

            Settings.Default.Save();
            this.xbmcHandler.Update();

            this.trayIcon.Visible = Settings.Default.GeneralTrayEnabled;
        }

        #endregion

        #region iMON functions

        private void iMonInitialize()
        {
            this.imon.Initialize();
        }

        private void iMonUninitialize()
        {
            if (this.imon != null && this.imon.IsInitialized)
            {
                this.imon.Uninitialize();
                //this.imon.StateChanged -= wrapperApi_StateChanged;
                //this.imon.Error -= wrapperApi_Error;
            }
        }

        private void iMonStateChanged(bool isInitialized)
        {
            this.miImonInitialize.Enabled = !isInitialized;
            this.miImonUninitialize.Enabled = isInitialized;

            if (isInitialized)
            {
                string display = string.Empty;

                if ((this.imon.DisplayType & iMonDisplayType.LCD) == iMonDisplayType.LCD)
                {
                    display = "LCD";
                }
                if ((this.imon.DisplayType & iMonDisplayType.VFD) == iMonDisplayType.VFD)
                { 
                    if (string.IsNullOrEmpty(display))
                    {
                        display = "VFD";
                    }
                    else 
                    {
                        display += " & VFD";
                    }
                }

                this.trayIcon.Text = "XBMC on iMON" + Environment.NewLine + "Running";
                this.showBalloonTip("Connected to XBMC at " + Settings.Default.XbmcIp + ":" + Settings.Default.XbmcPort +
                                    Environment.NewLine + "iMON " + display + " initialized", ToolTipIcon.Info);

                this.trayMenuImon.Text = "iMON: Uninitialize"; 
            }
            else
            {
                this.trayIcon.Text = "XBMC on iMON" + Environment.NewLine + "Connected";
                this.showBalloonTip("iMON uninitialized", ToolTipIcon.Warning);

                this.trayMenuImon.Text = "iMON: Initialize";
            }
        }

        private void iMonError(iMonErrorType error)
        {
            switch (error)
            {
                case iMonErrorType.Unknown:
                    this.showBalloonTip("Unknown error in iMON", ToolTipIcon.Error);
                    break;

                case iMonErrorType.OutOfMemory:
                    this.showBalloonTip("iMON is out of memory!" + Environment.NewLine +
                                        "Please restart XBMC on iMON.", ToolTipIcon.Warning);
                    break;

                case iMonErrorType.InvalidPointer:
                case iMonErrorType.InvalidArguments:
                    this.showBalloonTip("Invalid arguments in a call to iMON", ToolTipIcon.Warning);
                    break;

                case iMonErrorType.ApiNotInitialized:
                case iMonErrorType.NotInitialized:
                    this.showBalloonTip("Invalid operation because" + Environment.NewLine + 
                                        "iMON is not initialized.", ToolTipIcon.Error);
                    break;

                case iMonErrorType.NotInPluginMode:
                    this.showBalloonTip("Invalid operation because" + Environment.NewLine + 
                                        "iMON is not in plugin mode.", ToolTipIcon.Error);
                    break;

                case iMonErrorType.iMonClosed:
                    this.showBalloonTip("iMON Manager has been closed.", ToolTipIcon.Info);
                    break;

                case iMonErrorType.HardwareDisconnected:
                    this.showBalloonTip("The iMON Display has been disconnected.", ToolTipIcon.Warning);
                    break;

                case iMonErrorType.PluginModeAlreadyInUse:
                    this.showBalloonTip("Cannot use iMON Display because it" + Environment.NewLine + 
                                        "is already used by another application.", ToolTipIcon.Error);
                    break;

                case iMonErrorType.HardwareNotConnected:
                    this.showBalloonTip("Cannot use iMON Display because" + Environment.NewLine +
                                        "it is not connected.", ToolTipIcon.Error);
                    break;

                case iMonErrorType.HardwareNotSupported:
                    this.showBalloonTip("Cannot use iMON Display because" + Environment.NewLine +
                                        "this hardware is not supported.", ToolTipIcon.Error);
                    break;

                case iMonErrorType.PluginModeDisabled:
                    this.showBalloonTip("Plugin mode must be" + Environment.NewLine +
                                        "enabled in iMON Manager.", ToolTipIcon.Error);
                    break;

                case iMonErrorType.iMonNotResponding:
                    this.showBalloonTip("iMON is not responding." + Environment.NewLine +
                                        "Please restart iMON Manager.", ToolTipIcon.Error);
                    break;
            }

            if (Settings.Default.ImonUninitializeOnError)
            {
                this.iMonUninitialize();
            }
        }

        #endregion

        #region XBMC functions

        private void xbmcTryConnect(object sender, EventArgs e)
        {
            this.xbmcConnectionTimer.Stop();

            this.xbmcConnect(true);
        }

        private void xbmcConnect(bool auto)
        {
            if (!this.xbmc.IsAlive)
            {
                this.xbmcConnectingDeletage.BeginInvoke(auto, xbmcConnectingFinished, auto);
            }
        }

        private bool xbmcConnecting(bool auto) 
        {
            return this.xbmc.Open();
        }

        private void xbmcConnectingFinished(IAsyncResult ar)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate() { this.xbmcConnectingFinished(ar); }));
                return;
            }

            bool auto = (bool)ar.AsyncState;

            if (this.xbmcConnectingDeletage.EndInvoke(ar) && this.xbmc.IsAlive)
            {
                this.trayIcon.Text = "XBMC on iMON" + Environment.NewLine + "Connected";
                if (!Settings.Default.ImonAutoInitialize)
                {
                    this.showBalloonTip("Connected to XBMC at " + Settings.Default.XbmcIp + ":" + 
                                        Settings.Default.XbmcPort, ToolTipIcon.Info);
                }

                this.miXbmcConnect.Enabled = false;
                this.miXbmcDisconnect.Enabled = true;
                this.miXbmcInfo.Text = "Build " + this.xbmc.Xbmc.BuildVersion + "(" + this.xbmc.Xbmc.BuildDate + ")";

                this.miImon.Enabled = true;
                this.miImonInitialize.Enabled = true;
                this.miImonUninitialize.Enabled = false;

                this.trayMenuXBMC.Text = "XBMC: Disconnect";
                this.trayMenuImon.Text = "iMON: Initialize";
                this.trayMenuImon.Enabled = true;

                if (Settings.Default.ImonAutoInitialize)
                {
                    this.iMonInitialize();
                }
            }
            else if (!auto)
            {
                if (MessageBox.Show("Cannot connect to XBMC at" + Environment.NewLine + Settings.Default.XbmcIp + ":" + Settings.Default.XbmcPort, "XBMC Connection",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    this.xbmcConnect(false);
                }
            }
            else
            {
                this.xbmcConnectionTimer.Start();
            }
        }

        private void xbmcDisconnect(bool forceClose)
        {
            this.iMonUninitialize();
            if (forceClose)
            {
                this.xbmc.Close();
            }
            else
            {
                this.trayIcon.Text = "XBMC on iMON" + Environment.NewLine + "Disconnected";
                this.showBalloonTip("XBMC disconnected", ToolTipIcon.Warning);
            }

            this.miXbmcConnect.Enabled = true;
            this.miXbmcDisconnect.Enabled = false;
            this.miXbmcInfo.Text = "Build unknown";

            this.miImon.Enabled = false;

            this.trayMenuXBMC.Text = "XBMC: Connect";
            this.trayMenuImon.Text = "iMON: Initialize";
            this.trayMenuImon.Enabled = false;

            if (Settings.Default.GeneralStartupConnect && !forceClose)
            {
                this.xbmcConnectionTimer.Start();
            }
        }

        private void xbmcShutdown(object sender, EventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate() { this.xbmcShutdown(sender, args); }));
                return;
            }

            this.text.SetText("XBMC Shutdown", "XBMC", "Shutdown");
            System.Threading.Thread.Sleep(2000);
            this.xbmcDisconnect(false);
        }

        #endregion
    }
}