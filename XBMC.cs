using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Sockets;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using iMon.XBMC.Dialogs;
using iMon.XBMC.Properties;

using iMon.DisplayApi;
using XBMC.JsonRpc;

namespace iMon.XBMC
{
    public partial class XBMC : Form
    {
        #region Private variables

        private MappingDialog mappingDialog;

        #endregion

        #region Constructor

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

        #endregion

        #region GUI action handling

        private void xbmc_Load(object sender, EventArgs e)
        {
            if (Settings.Default.GeneralTrayEnabled && Settings.Default.GeneralTrayStartMinimized)
            {
                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    Logging.Log("Minimizing application to tray at startup");
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
            if (!this.closing && !Environment.HasShutdownStarted)
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

        private void cbXbmcIdleStaticTextEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.tbXbmcIdleStaticText.Enabled = this.cbXbmcIdleStaticTextEnable.Checked;
        }

        private void cbImonSoundSystemEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.cbImonSoundSystem.Enabled = this.cbImonSoundSystemEnable.Checked;
            this.cbImonSoundSystemSPDIF.Enabled = this.cbImonSoundSystemEnable.Checked;
        }

        private void cbXbmcControlModeEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.cbXbmcControlModeDisableDuringPlayback.Enabled = this.cbXbmcControlModeEnable.Checked;
            this.cbXbmcControlModeRemoveBrackets.Enabled = this.cbXbmcControlModeEnable.Checked;
            this.cbXbmcControlModeShowWindow.Enabled = this.cbXbmcControlModeEnable.Checked;
        }

        private void cbXbmcPlayingVideoCodecs_CheckedChanged(object sender, EventArgs e)
        {
            this.bXbmcPlayingVideoCodecs.Enabled = this.cbXbmcPlayingVideoCodecs.Checked;
        }

        private void cbXbmcPlayingAudioCodecs_CheckedChanged(object sender, EventArgs e)
        {
            this.bXbmcPlayingAudioCodecs.Enabled = this.cbXbmcPlayingAudioCodecs.Checked;
        }

        private void bXbmcPlayingVideoCodecs_Click(object sender, EventArgs e)
        {
            using (this.mappingDialog = new MappingDialog("Video Codec Mapping", "Video Codec Icons", "Video Codecs", 
                JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(Settings.Default.XbmcIconsPlaybackVideoCodecsMappings)))
            {
                if (this.mappingDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Settings.Default.XbmcIconsPlaybackVideoCodecsMappings = JsonConvert.SerializeObject(this.mappingDialog.Mapping);
                    this.settingsSave();
                }
            }
        }

        private void bXbmcPlayingAudioCodecs_Click(object sender, EventArgs e)
        {
            using (this.mappingDialog = new MappingDialog("Audio Codec Mapping", "Audio Codec Icons", "Audio Codecs",
                JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(Settings.Default.XbmcIconsPlaybackAudioCodecsMappings)))
            {
                if (this.mappingDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Settings.Default.XbmcIconsPlaybackAudioCodecsMappings = JsonConvert.SerializeObject(this.mappingDialog.Mapping);
                    this.settingsSave();
                }
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

        private void wrapperApi_iMon_LogError(object sender, iMonLogErrorEventArgs e)
        {
            Logging.Error("iMON", e.Message, e.Exception);
        }

        private void wrapperApi_iMon_Log(object sender, iMonLogEventArgs e)
        {
            Logging.Log("iMON", e.Message, null);
        }

        private void wrapperApi_XBMC_LogError(object sender, XbmcJsonRpcLogErrorEventArgs e)
        {
            if (e.Exception != null && e.Exception is SocketException)
            {
                // We don't want to fill the error log with SocketExceptions
                return;
            }
            
            Logging.Error("XBMC", e.Message, e.Exception);
        }

        private void wrapperApi_XBMC_Log(object sender, XbmcJsonRpcLogEventArgs e)
        {
            Logging.Log("XBMC", e.Message, null);
        }

        #endregion
    }
}
