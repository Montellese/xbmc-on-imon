using System;
using System.Windows.Forms;

using iMon.DisplayApi;
using iMon.XBMC.Properties;
using System.Drawing;

namespace iMon.XBMC
{
    public partial class XBMC : Form
    {
        public XBMC()
        {
            this.InitializeComponent();
            // Needed to avoid a flicker if "Hide on startup" is activated
            this.Opacity = 0;

            this.tabOptions.SelectTab(this.tpGeneral);
            this.bNavigationGeneral.Activate();

            this.trayIcon.ContextMenuStrip = this.trayMenu;

            this.constructor();
        }

        #region GUI action handling

        private void xbmc_Load(object sender, EventArgs e)
        {
            if (Settings.Default.GeneralTrayEnabled && Settings.Default.GeneralTrayStartMinimized)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    this.Hide();
                    this.Opacity = 1;
                }));
            }
            else
            {
                this.Opacity = 1;
            }
        }

        private void xbmc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.closing)
            {
                this.close(false);

                e.Cancel = true;
            }
        }

        private void XBMC_Resize(object sender, EventArgs e)
        {
            if (Settings.Default.GeneralTrayEnabled && Settings.Default.GeneralTrayHideOnMinimize)
            {
                this.Hide();
            }
        }

        private void miGeneralClose_Click(object sender, EventArgs e)
        {
            this.close(true);
        }

        private void miImonInitialize_Click(object sender, EventArgs e)
        {
            this.iMonInitialize();
        }

        private void miImonUninitialize_Click(object sender, EventArgs e)
        {
            this.iMonUninitialize();
        }

        private void miXbmcConnect_Click(object sender, EventArgs e)
        {
            this.xbmcConnect(false);
        }

        private void miXbmcDisconnect_Click(object sender, EventArgs e)
        {
            this.xbmcDisconnect(true);
        }

        private void bNavigationGeneral_Click(object sender, EventArgs e)
        {
            this.tabOptions.SelectTab(this.tpGeneral);

            //this.bNavigationGeneral.Activate();
            this.bNavigationImon.Deactivate();
            this.bNavigationXbmc.Deactivate();
        }

        private void bNavigationImon_Click(object sender, EventArgs e)
        {
            this.tabOptions.SelectTab(this.tpImon);

            this.bNavigationGeneral.Deactivate();
            //this.bNavigationImon.Activate();
            this.bNavigationXbmc.Deactivate();
        }

        private void bNavigationXbmc_Click(object sender, EventArgs e)
        {
            this.tabOptions.SelectTab(this.tpXBMC);

            this.bNavigationGeneral.Deactivate();
            this.bNavigationImon.Deactivate();
            //this.bNavigationXbmc.Activate();
        }

        private void cbGeneralTrayEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.cbGeneralTrayStartMinimized.Enabled = this.cbGeneralTrayEnabled.Checked;
            this.cbGeneralTrayHideOnMinimize.Enabled = this.cbGeneralTrayEnabled.Checked;
            this.cbGeneralTrayHideOnClose.Enabled = this.cbGeneralTrayEnabled.Checked;
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void trayMenuOpen_Click(object sender, EventArgs e)
        {
            this.trayIcon_DoubleClick(sender, e);
        }

        private void trayMenuClose_Click(object sender, EventArgs e)
        {
            this.close(true);
        }

        private void trayMenuXBMC_Click(object sender, EventArgs e)
        {
            if (this.xbmc.IsAlive)
            {
                this.xbmcDisconnect(true);
            }
            else
            {
                this.xbmcConnect(false);
            }
        }

        private void trayMenuImon_Click(object sender, EventArgs e)
        {
            if (this.imon.IsInitialized)
            {
                this.iMonUninitialize();
            }
            else
            {
                this.iMonInitialize();
            }
        }

        #endregion

        #region Event handling

        private void wrapperApi_StateChanged(object sender, iMonStateChangedEventArgs e)
        {
            this.iMonStateChanged(e.IsInitialized);
        }

        private void wrapperApi_Error(object sender, iMonErrorEventArgs e)
        {
            this.iMonError(e.Type);
        }

        #endregion

        private void bNavigationGeneral_MouseHover(object sender, EventArgs e)
        {
            this.bNavigationGeneral.BackColor = Color.Transparent;
        }
    }
}
