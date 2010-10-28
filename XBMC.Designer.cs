namespace iMon.XBMC
{
    partial class XBMC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XBMC));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.miGeneralClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miXbmc = new System.Windows.Forms.ToolStripMenuItem();
            this.miXbmcConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.miXbmcDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miXbmcInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miImon = new System.Windows.Forms.ToolStripMenuItem();
            this.miImonInitialize = new System.Windows.Forms.ToolStripMenuItem();
            this.miImonUninitialize = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miAboutXbmcOniMon = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.pNavigation = new System.Windows.Forms.Panel();
            this.iLOptions = new System.Windows.Forms.ImageList(this.components);
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tpImon = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbImonGeneralUninitializeOnError = new System.Windows.Forms.CheckBox();
            this.cbImonGeneralAutoInitialize = new System.Windows.Forms.CheckBox();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbGeneralTrayHideOnMinimize = new System.Windows.Forms.CheckBox();
            this.cbGeneralTrayHideOnClose = new System.Windows.Forms.CheckBox();
            this.cbGeneralTrayStartMinimized = new System.Windows.Forms.CheckBox();
            this.cbGeneralTrayEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGeneralStartupConnect = new System.Windows.Forms.CheckBox();
            this.cbGeneralStartupAuto = new System.Windows.Forms.CheckBox();
            this.tpXBMC = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudXbmcConnectionInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXbmcConnectionPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXbmcConnectionUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbXbmcConnectionPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXbmcConnectionIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuXBMC = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuImon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbXbmcIdleStaticTextEnable = new System.Windows.Forms.CheckBox();
            this.cbXbmcIdleTime = new System.Windows.Forms.CheckBox();
            this.tbXbmcIdleStaticText = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbXbmcPlayingShowProgress = new System.Windows.Forms.CheckBox();
            this.cbXbmcPlayingShowMediaType = new System.Windows.Forms.CheckBox();
            this.cbXbmcPlayingVideoCodecs = new System.Windows.Forms.CheckBox();
            this.cbXbmcPlayingAudioCodecs = new System.Windows.Forms.CheckBox();
            this.bXbmcPlayingVideoCodecs = new System.Windows.Forms.Button();
            this.bXbmcPlayingAudioCodecs = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbXbmcIconsSoundSystemEnable = new System.Windows.Forms.CheckBox();
            this.cbXbmcIconsSoundSystem = new System.Windows.Forms.ComboBox();
            this.cbXbmcIconsSPDIF = new System.Windows.Forms.CheckBox();
            this.cbXbmcIconsVolEnable = new System.Windows.Forms.CheckBox();
            this.cbXbmcIconsScreen = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbXbmcPlayingShuffleEnable = new System.Windows.Forms.CheckBox();
            this.cbXbmcPlayingRepeatEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudXbmcIconsUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tbXbmcMovieSingleText = new System.Windows.Forms.TextBox();
            this.rbXbmcMovieSingleText = new System.Windows.Forms.RadioButton();
            this.rbXbmcMovieCustomText = new System.Windows.Forms.RadioButton();
            this.bXbmcMovieCustomTextEdit = new System.Windows.Forms.Button();
            this.cbXbmcTvMediaTypeIcon = new System.Windows.Forms.CheckBox();
            this.cbXbmcTvShowTvHdtvIcon = new System.Windows.Forms.CheckBox();
            this.bXbmcTvCustomTextEdit = new System.Windows.Forms.Button();
            this.rbXbmcTvCustomText = new System.Windows.Forms.RadioButton();
            this.rbXbmcTvSingleText = new System.Windows.Forms.RadioButton();
            this.tbXbmcTvSingleText = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudImonLcdScrollingDelay = new System.Windows.Forms.NumericUpDown();
            this.bNavigationXbmc = new iMon.XBMC.NavigationButton();
            this.bNavigationImon = new iMon.XBMC.NavigationButton();
            this.bNavigationGeneral = new iMon.XBMC.NavigationButton();
            this.menu.SuspendLayout();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.pNavigation.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tpImon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpXBMC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXbmcConnectionInterval)).BeginInit();
            this.trayMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXbmcIconsUpdateInterval)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImonLcdScrollingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGeneral,
            this.miXbmc,
            this.miImon,
            this.miAbout});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(487, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // miGeneral
            // 
            this.miGeneral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGeneralClose});
            this.miGeneral.Name = "miGeneral";
            this.miGeneral.Size = new System.Drawing.Size(59, 20);
            this.miGeneral.Text = "General";
            // 
            // miGeneralClose
            // 
            this.miGeneralClose.Name = "miGeneralClose";
            this.miGeneralClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.miGeneralClose.Size = new System.Drawing.Size(148, 22);
            this.miGeneralClose.Text = "Close";
            this.miGeneralClose.Click += new System.EventHandler(this.miGeneralClose_Click);
            // 
            // miXbmc
            // 
            this.miXbmc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miXbmcConnect,
            this.miXbmcDisconnect,
            this.toolStripSeparator2,
            this.miXbmcInfo});
            this.miXbmc.Name = "miXbmc";
            this.miXbmc.Size = new System.Drawing.Size(52, 20);
            this.miXbmc.Text = "XBMC";
            // 
            // miXbmcConnect
            // 
            this.miXbmcConnect.Name = "miXbmcConnect";
            this.miXbmcConnect.Size = new System.Drawing.Size(154, 22);
            this.miXbmcConnect.Text = "Connect";
            this.miXbmcConnect.Click += new System.EventHandler(this.miXbmcConnect_Click);
            // 
            // miXbmcDisconnect
            // 
            this.miXbmcDisconnect.Enabled = false;
            this.miXbmcDisconnect.Name = "miXbmcDisconnect";
            this.miXbmcDisconnect.Size = new System.Drawing.Size(154, 22);
            this.miXbmcDisconnect.Text = "Disconnect";
            this.miXbmcDisconnect.Click += new System.EventHandler(this.miXbmcDisconnect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // miXbmcInfo
            // 
            this.miXbmcInfo.Enabled = false;
            this.miXbmcInfo.Name = "miXbmcInfo";
            this.miXbmcInfo.Size = new System.Drawing.Size(154, 22);
            this.miXbmcInfo.Text = "Build unknown";
            // 
            // miImon
            // 
            this.miImon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miImonInitialize,
            this.miImonUninitialize});
            this.miImon.Enabled = false;
            this.miImon.Name = "miImon";
            this.miImon.Size = new System.Drawing.Size(51, 20);
            this.miImon.Text = "iMON";
            // 
            // miImonInitialize
            // 
            this.miImonInitialize.Name = "miImonInitialize";
            this.miImonInitialize.Size = new System.Drawing.Size(132, 22);
            this.miImonInitialize.Text = "Initialize";
            this.miImonInitialize.Click += new System.EventHandler(this.miImonInitialize_Click);
            // 
            // miImonUninitialize
            // 
            this.miImonUninitialize.Name = "miImonUninitialize";
            this.miImonUninitialize.Size = new System.Drawing.Size(132, 22);
            this.miImonUninitialize.Text = "Uninitialize";
            this.miImonUninitialize.Click += new System.EventHandler(this.miImonUninitialize_Click);
            // 
            // miAbout
            // 
            this.miAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAboutHelp,
            this.toolStripSeparator1,
            this.miAboutXbmcOniMon});
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(52, 20);
            this.miAbout.Text = "About";
            // 
            // miAboutHelp
            // 
            this.miAboutHelp.Name = "miAboutHelp";
            this.miAboutHelp.Size = new System.Drawing.Size(191, 22);
            this.miAboutHelp.Text = "Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // miAboutXbmcOniMon
            // 
            this.miAboutXbmcOniMon.Name = "miAboutXbmcOniMon";
            this.miAboutXbmcOniMon.Size = new System.Drawing.Size(191, 22);
            this.miAboutXbmcOniMon.Text = "About XBMC on iMon";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitter.Location = new System.Drawing.Point(0, 24);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.pNavigation);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.tabOptions);
            this.splitter.Size = new System.Drawing.Size(487, 429);
            this.splitter.SplitterDistance = 83;
            this.splitter.TabIndex = 1;
            // 
            // pNavigation
            // 
            this.pNavigation.BackColor = System.Drawing.Color.White;
            this.pNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNavigation.Controls.Add(this.bNavigationXbmc);
            this.pNavigation.Controls.Add(this.bNavigationImon);
            this.pNavigation.Controls.Add(this.bNavigationGeneral);
            this.pNavigation.Location = new System.Drawing.Point(4, 4);
            this.pNavigation.Name = "pNavigation";
            this.pNavigation.Size = new System.Drawing.Size(76, 425);
            this.pNavigation.TabIndex = 0;
            // 
            // iLOptions
            // 
            this.iLOptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLOptions.ImageStream")));
            this.iLOptions.TransparentColor = System.Drawing.Color.Transparent;
            this.iLOptions.Images.SetKeyName(0, "General");
            this.iLOptions.Images.SetKeyName(1, "GeneralActive");
            this.iLOptions.Images.SetKeyName(2, "GeneralHover");
            this.iLOptions.Images.SetKeyName(3, "iMON");
            this.iLOptions.Images.SetKeyName(4, "iMONActive");
            this.iLOptions.Images.SetKeyName(5, "iMONHover");
            this.iLOptions.Images.SetKeyName(6, "XBMC");
            this.iLOptions.Images.SetKeyName(7, "XBMCActive");
            this.iLOptions.Images.SetKeyName(8, "XBMCHover");
            // 
            // tabOptions
            // 
            this.tabOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptions.Controls.Add(this.tpImon);
            this.tabOptions.Controls.Add(this.tpGeneral);
            this.tabOptions.Controls.Add(this.tpXBMC);
            this.tabOptions.Location = new System.Drawing.Point(-11, -24);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(420, 463);
            this.tabOptions.TabIndex = 0;
            // 
            // tpImon
            // 
            this.tpImon.BackColor = System.Drawing.SystemColors.Control;
            this.tpImon.Controls.Add(this.groupBox13);
            this.tpImon.Controls.Add(this.groupBox3);
            this.tpImon.Location = new System.Drawing.Point(4, 22);
            this.tpImon.Name = "tpImon";
            this.tpImon.Padding = new System.Windows.Forms.Padding(3);
            this.tpImon.Size = new System.Drawing.Size(412, 292);
            this.tpImon.TabIndex = 1;
            this.tpImon.Text = "iMON";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbImonGeneralUninitializeOnError);
            this.groupBox3.Controls.Add(this.cbImonGeneralAutoInitialize);
            this.groupBox3.Location = new System.Drawing.Point(9, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 68);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // cbImonGeneralUninitializeOnError
            // 
            this.cbImonGeneralUninitializeOnError.AutoSize = true;
            this.cbImonGeneralUninitializeOnError.Location = new System.Drawing.Point(7, 44);
            this.cbImonGeneralUninitializeOnError.Name = "cbImonGeneralUninitializeOnError";
            this.cbImonGeneralUninitializeOnError.Size = new System.Drawing.Size(209, 17);
            this.cbImonGeneralUninitializeOnError.TabIndex = 1;
            this.cbImonGeneralUninitializeOnError.Text = "Uninitialize when iMON reports an error";
            this.cbImonGeneralUninitializeOnError.UseVisualStyleBackColor = true;
            // 
            // cbImonGeneralAutoInitialize
            // 
            this.cbImonGeneralAutoInitialize.AutoSize = true;
            this.cbImonGeneralAutoInitialize.Location = new System.Drawing.Point(7, 20);
            this.cbImonGeneralAutoInitialize.Name = "cbImonGeneralAutoInitialize";
            this.cbImonGeneralAutoInitialize.Size = new System.Drawing.Size(253, 17);
            this.cbImonGeneralAutoInitialize.TabIndex = 0;
            this.cbImonGeneralAutoInitialize.Text = "Automatically initialize when XBMC is connected";
            this.cbImonGeneralAutoInitialize.UseVisualStyleBackColor = true;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tpGeneral.Controls.Add(this.groupBox4);
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(412, 292);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbGeneralTrayHideOnMinimize);
            this.groupBox4.Controls.Add(this.cbGeneralTrayHideOnClose);
            this.groupBox4.Controls.Add(this.cbGeneralTrayStartMinimized);
            this.groupBox4.Controls.Add(this.cbGeneralTrayEnabled);
            this.groupBox4.Location = new System.Drawing.Point(9, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 115);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tray Icon";
            // 
            // cbGeneralTrayHideOnMinimize
            // 
            this.cbGeneralTrayHideOnMinimize.AutoSize = true;
            this.cbGeneralTrayHideOnMinimize.Location = new System.Drawing.Point(25, 66);
            this.cbGeneralTrayHideOnMinimize.Name = "cbGeneralTrayHideOnMinimize";
            this.cbGeneralTrayHideOnMinimize.Size = new System.Drawing.Size(205, 17);
            this.cbGeneralTrayHideOnMinimize.TabIndex = 3;
            this.cbGeneralTrayHideOnMinimize.Text = "Hide in Windows tray when minimizing";
            this.cbGeneralTrayHideOnMinimize.UseVisualStyleBackColor = true;
            // 
            // cbGeneralTrayHideOnClose
            // 
            this.cbGeneralTrayHideOnClose.AutoSize = true;
            this.cbGeneralTrayHideOnClose.Location = new System.Drawing.Point(25, 89);
            this.cbGeneralTrayHideOnClose.Name = "cbGeneralTrayHideOnClose";
            this.cbGeneralTrayHideOnClose.Size = new System.Drawing.Size(191, 17);
            this.cbGeneralTrayHideOnClose.TabIndex = 2;
            this.cbGeneralTrayHideOnClose.Text = "Hide in Windows tray when closing";
            this.cbGeneralTrayHideOnClose.UseVisualStyleBackColor = true;
            // 
            // cbGeneralTrayStartMinimized
            // 
            this.cbGeneralTrayStartMinimized.AutoSize = true;
            this.cbGeneralTrayStartMinimized.Location = new System.Drawing.Point(25, 43);
            this.cbGeneralTrayStartMinimized.Name = "cbGeneralTrayStartMinimized";
            this.cbGeneralTrayStartMinimized.Size = new System.Drawing.Size(175, 17);
            this.cbGeneralTrayStartMinimized.TabIndex = 1;
            this.cbGeneralTrayStartMinimized.Text = "Start minimized to Windows tray";
            this.cbGeneralTrayStartMinimized.UseVisualStyleBackColor = true;
            // 
            // cbGeneralTrayEnabled
            // 
            this.cbGeneralTrayEnabled.AutoSize = true;
            this.cbGeneralTrayEnabled.Location = new System.Drawing.Point(7, 20);
            this.cbGeneralTrayEnabled.Name = "cbGeneralTrayEnabled";
            this.cbGeneralTrayEnabled.Size = new System.Drawing.Size(232, 17);
            this.cbGeneralTrayEnabled.TabIndex = 0;
            this.cbGeneralTrayEnabled.Text = "Show Windows tray icon with current status";
            this.cbGeneralTrayEnabled.UseVisualStyleBackColor = true;
            this.cbGeneralTrayEnabled.CheckedChanged += new System.EventHandler(this.cbGeneralTrayEnabled_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGeneralStartupConnect);
            this.groupBox2.Controls.Add(this.cbGeneralStartupAuto);
            this.groupBox2.Location = new System.Drawing.Point(9, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Startup";
            // 
            // cbGeneralStartupConnect
            // 
            this.cbGeneralStartupConnect.AutoSize = true;
            this.cbGeneralStartupConnect.Location = new System.Drawing.Point(7, 44);
            this.cbGeneralStartupConnect.Name = "cbGeneralStartupConnect";
            this.cbGeneralStartupConnect.Size = new System.Drawing.Size(171, 17);
            this.cbGeneralStartupConnect.TabIndex = 1;
            this.cbGeneralStartupConnect.Text = "Connect with XBMC on startup";
            this.cbGeneralStartupConnect.UseVisualStyleBackColor = true;
            // 
            // cbGeneralStartupAuto
            // 
            this.cbGeneralStartupAuto.AutoSize = true;
            this.cbGeneralStartupAuto.Enabled = false;
            this.cbGeneralStartupAuto.Location = new System.Drawing.Point(7, 20);
            this.cbGeneralStartupAuto.Name = "cbGeneralStartupAuto";
            this.cbGeneralStartupAuto.Size = new System.Drawing.Size(140, 17);
            this.cbGeneralStartupAuto.TabIndex = 0;
            this.cbGeneralStartupAuto.Text = "Auto start with Windows";
            this.cbGeneralStartupAuto.UseVisualStyleBackColor = true;
            // 
            // tpXBMC
            // 
            this.tpXBMC.BackColor = System.Drawing.SystemColors.Control;
            this.tpXBMC.Controls.Add(this.panel1);
            this.tpXBMC.Location = new System.Drawing.Point(4, 22);
            this.tpXBMC.Name = "tpXBMC";
            this.tpXBMC.Padding = new System.Windows.Forms.Padding(3);
            this.tpXBMC.Size = new System.Drawing.Size(412, 437);
            this.tpXBMC.TabIndex = 2;
            this.tpXBMC.Text = "XBMC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudXbmcConnectionInterval);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbXbmcConnectionPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbXbmcConnectionUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbXbmcConnectionPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbXbmcConnectionIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "seconds";
            // 
            // nudXbmcConnectionInterval
            // 
            this.nudXbmcConnectionInterval.Location = new System.Drawing.Point(94, 73);
            this.nudXbmcConnectionInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudXbmcConnectionInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudXbmcConnectionInterval.Name = "nudXbmcConnectionInterval";
            this.nudXbmcConnectionInterval.Size = new System.Drawing.Size(40, 20);
            this.nudXbmcConnectionInterval.TabIndex = 9;
            this.nudXbmcConnectionInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retry interval:";
            // 
            // tbXbmcConnectionPassword
            // 
            this.tbXbmcConnectionPassword.Location = new System.Drawing.Point(251, 47);
            this.tbXbmcConnectionPassword.Name = "tbXbmcConnectionPassword";
            this.tbXbmcConnectionPassword.PasswordChar = '*';
            this.tbXbmcConnectionPassword.Size = new System.Drawing.Size(110, 20);
            this.tbXbmcConnectionPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // tbXbmcConnectionUsername
            // 
            this.tbXbmcConnectionUsername.Location = new System.Drawing.Point(70, 47);
            this.tbXbmcConnectionUsername.Name = "tbXbmcConnectionUsername";
            this.tbXbmcConnectionUsername.Size = new System.Drawing.Size(113, 20);
            this.tbXbmcConnectionUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // tbXbmcConnectionPort
            // 
            this.tbXbmcConnectionPort.Location = new System.Drawing.Point(296, 19);
            this.tbXbmcConnectionPort.Name = "tbXbmcConnectionPort";
            this.tbXbmcConnectionPort.Size = new System.Drawing.Size(65, 20);
            this.tbXbmcConnectionPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // tbXbmcConnectionIp
            // 
            this.tbXbmcConnectionIp.Location = new System.Drawing.Point(34, 20);
            this.tbXbmcConnectionIp.Name = "tbXbmcConnectionIp";
            this.tbXbmcConnectionIp.Size = new System.Drawing.Size(215, 20);
            this.tbXbmcConnectionIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "XBMC on iMon\r\nDisconnected";
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuOpen,
            this.toolStripSeparator5,
            this.trayMenuXBMC,
            this.trayMenuImon,
            this.toolStripSeparator4,
            this.trayMenuClose});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.trayMenu.Size = new System.Drawing.Size(159, 104);
            // 
            // trayMenuOpen
            // 
            this.trayMenuOpen.Name = "trayMenuOpen";
            this.trayMenuOpen.Size = new System.Drawing.Size(158, 22);
            this.trayMenuOpen.Text = "Open";
            this.trayMenuOpen.Click += new System.EventHandler(this.trayMenuOpen_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // trayMenuXBMC
            // 
            this.trayMenuXBMC.Name = "trayMenuXBMC";
            this.trayMenuXBMC.Size = new System.Drawing.Size(158, 22);
            this.trayMenuXBMC.Text = "XBMC: Connect";
            this.trayMenuXBMC.Click += new System.EventHandler(this.trayMenuXBMC_Click);
            // 
            // trayMenuImon
            // 
            this.trayMenuImon.Enabled = false;
            this.trayMenuImon.Name = "trayMenuImon";
            this.trayMenuImon.Size = new System.Drawing.Size(158, 22);
            this.trayMenuImon.Text = "iMON: Initialize";
            this.trayMenuImon.Click += new System.EventHandler(this.trayMenuImon_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // trayMenuClose
            // 
            this.trayMenuClose.Name = "trayMenuClose";
            this.trayMenuClose.Size = new System.Drawing.Size(158, 22);
            this.trayMenuClose.Text = "Close";
            this.trayMenuClose.Click += new System.EventHandler(this.trayMenuClose_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox11);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Controls.Add(this.groupBox10);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Location = new System.Drawing.Point(9, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 426);
            this.panel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbXbmcIdleTime);
            this.groupBox5.Controls.Add(this.tbXbmcIdleStaticText);
            this.groupBox5.Controls.Add(this.cbXbmcIdleStaticTextEnable);
            this.groupBox5.Location = new System.Drawing.Point(6, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 71);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Idle";
            // 
            // cbXbmcIdleStaticTextEnable
            // 
            this.cbXbmcIdleStaticTextEnable.AutoSize = true;
            this.cbXbmcIdleStaticTextEnable.Location = new System.Drawing.Point(7, 20);
            this.cbXbmcIdleStaticTextEnable.Name = "cbXbmcIdleStaticTextEnable";
            this.cbXbmcIdleStaticTextEnable.Size = new System.Drawing.Size(101, 17);
            this.cbXbmcIdleStaticTextEnable.TabIndex = 0;
            this.cbXbmcIdleStaticTextEnable.Text = "Show static text";
            this.cbXbmcIdleStaticTextEnable.UseVisualStyleBackColor = true;
            this.cbXbmcIdleStaticTextEnable.CheckedChanged += new System.EventHandler(this.cbXbmcIdleStaticTextEnable_CheckedChanged);
            // 
            // cbXbmcIdleTime
            // 
            this.cbXbmcIdleTime.AutoSize = true;
            this.cbXbmcIdleTime.Enabled = false;
            this.cbXbmcIdleTime.Location = new System.Drawing.Point(192, 19);
            this.cbXbmcIdleTime.Name = "cbXbmcIdleTime";
            this.cbXbmcIdleTime.Size = new System.Drawing.Size(111, 17);
            this.cbXbmcIdleTime.TabIndex = 2;
            this.cbXbmcIdleTime.Text = "Show current time";
            this.cbXbmcIdleTime.UseVisualStyleBackColor = true;
            // 
            // tbXbmcIdleStaticText
            // 
            this.tbXbmcIdleStaticText.Location = new System.Drawing.Point(34, 43);
            this.tbXbmcIdleStaticText.Name = "tbXbmcIdleStaticText";
            this.tbXbmcIdleStaticText.Size = new System.Drawing.Size(149, 20);
            this.tbXbmcIdleStaticText.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbXbmcPlayingRepeatEnable);
            this.groupBox6.Controls.Add(this.cbXbmcPlayingShuffleEnable);
            this.groupBox6.Controls.Add(this.bXbmcPlayingAudioCodecs);
            this.groupBox6.Controls.Add(this.bXbmcPlayingVideoCodecs);
            this.groupBox6.Controls.Add(this.cbXbmcPlayingAudioCodecs);
            this.groupBox6.Controls.Add(this.cbXbmcPlayingVideoCodecs);
            this.groupBox6.Controls.Add(this.cbXbmcPlayingShowMediaType);
            this.groupBox6.Controls.Add(this.cbXbmcPlayingShowProgress);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(6, 309);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(369, 117);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Icons during playback";
            // 
            // cbXbmcPlayingShowProgress
            // 
            this.cbXbmcPlayingShowProgress.AutoSize = true;
            this.cbXbmcPlayingShowProgress.Location = new System.Drawing.Point(7, 20);
            this.cbXbmcPlayingShowProgress.Name = "cbXbmcPlayingShowProgress";
            this.cbXbmcPlayingShowProgress.Size = new System.Drawing.Size(96, 17);
            this.cbXbmcPlayingShowProgress.TabIndex = 0;
            this.cbXbmcPlayingShowProgress.Text = "Show progress";
            this.cbXbmcPlayingShowProgress.UseVisualStyleBackColor = true;
            // 
            // cbXbmcPlayingShowMediaType
            // 
            this.cbXbmcPlayingShowMediaType.AutoSize = true;
            this.cbXbmcPlayingShowMediaType.Location = new System.Drawing.Point(192, 20);
            this.cbXbmcPlayingShowMediaType.Name = "cbXbmcPlayingShowMediaType";
            this.cbXbmcPlayingShowMediaType.Size = new System.Drawing.Size(107, 17);
            this.cbXbmcPlayingShowMediaType.TabIndex = 1;
            this.cbXbmcPlayingShowMediaType.Text = "Show media type";
            this.cbXbmcPlayingShowMediaType.UseVisualStyleBackColor = true;
            // 
            // cbXbmcPlayingVideoCodecs
            // 
            this.cbXbmcPlayingVideoCodecs.AutoSize = true;
            this.cbXbmcPlayingVideoCodecs.Location = new System.Drawing.Point(7, 44);
            this.cbXbmcPlayingVideoCodecs.Name = "cbXbmcPlayingVideoCodecs";
            this.cbXbmcPlayingVideoCodecs.Size = new System.Drawing.Size(120, 17);
            this.cbXbmcPlayingVideoCodecs.TabIndex = 2;
            this.cbXbmcPlayingVideoCodecs.Text = "Show video codecs";
            this.cbXbmcPlayingVideoCodecs.UseVisualStyleBackColor = true;
            // 
            // cbXbmcPlayingAudioCodecs
            // 
            this.cbXbmcPlayingAudioCodecs.AutoSize = true;
            this.cbXbmcPlayingAudioCodecs.Location = new System.Drawing.Point(192, 44);
            this.cbXbmcPlayingAudioCodecs.Name = "cbXbmcPlayingAudioCodecs";
            this.cbXbmcPlayingAudioCodecs.Size = new System.Drawing.Size(120, 17);
            this.cbXbmcPlayingAudioCodecs.TabIndex = 3;
            this.cbXbmcPlayingAudioCodecs.Text = "Show audio codecs";
            this.cbXbmcPlayingAudioCodecs.UseVisualStyleBackColor = true;
            // 
            // bXbmcPlayingVideoCodecs
            // 
            this.bXbmcPlayingVideoCodecs.Location = new System.Drawing.Point(34, 67);
            this.bXbmcPlayingVideoCodecs.Name = "bXbmcPlayingVideoCodecs";
            this.bXbmcPlayingVideoCodecs.Size = new System.Drawing.Size(100, 23);
            this.bXbmcPlayingVideoCodecs.TabIndex = 4;
            this.bXbmcPlayingVideoCodecs.Text = "Edit mapping ...";
            this.bXbmcPlayingVideoCodecs.UseVisualStyleBackColor = true;
            // 
            // bXbmcPlayingAudioCodecs
            // 
            this.bXbmcPlayingAudioCodecs.Location = new System.Drawing.Point(219, 67);
            this.bXbmcPlayingAudioCodecs.Name = "bXbmcPlayingAudioCodecs";
            this.bXbmcPlayingAudioCodecs.Size = new System.Drawing.Size(100, 23);
            this.bXbmcPlayingAudioCodecs.TabIndex = 5;
            this.bXbmcPlayingAudioCodecs.Text = "Edit mapping ...";
            this.bXbmcPlayingAudioCodecs.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudXbmcIconsUpdateInterval);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.cbXbmcIconsScreen);
            this.groupBox7.Controls.Add(this.cbXbmcIconsVolEnable);
            this.groupBox7.Controls.Add(this.cbXbmcIconsSPDIF);
            this.groupBox7.Controls.Add(this.cbXbmcIconsSoundSystem);
            this.groupBox7.Controls.Add(this.cbXbmcIconsSoundSystemEnable);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(6, 187);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(369, 116);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "General icons";
            // 
            // cbXbmcIconsSoundSystemEnable
            // 
            this.cbXbmcIconsSoundSystemEnable.AutoSize = true;
            this.cbXbmcIconsSoundSystemEnable.Location = new System.Drawing.Point(6, 45);
            this.cbXbmcIconsSoundSystemEnable.Name = "cbXbmcIconsSoundSystemEnable";
            this.cbXbmcIconsSoundSystemEnable.Size = new System.Drawing.Size(120, 17);
            this.cbXbmcIconsSoundSystemEnable.TabIndex = 0;
            this.cbXbmcIconsSoundSystemEnable.Text = "Show sound system";
            this.cbXbmcIconsSoundSystemEnable.UseVisualStyleBackColor = true;
            // 
            // cbXbmcIconsSoundSystem
            // 
            this.cbXbmcIconsSoundSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXbmcIconsSoundSystem.FormattingEnabled = true;
            this.cbXbmcIconsSoundSystem.Items.AddRange(new object[] {
            "1.0 Mono",
            "2.0 Stereo",
            "2.1 Stereo",
            "4.0 Quad",
            "4.1 Surround",
            "5.1 Surround",
            "5.1 Side",
            "7.1 Surround"});
            this.cbXbmcIconsSoundSystem.Location = new System.Drawing.Point(33, 69);
            this.cbXbmcIconsSoundSystem.Name = "cbXbmcIconsSoundSystem";
            this.cbXbmcIconsSoundSystem.Size = new System.Drawing.Size(121, 21);
            this.cbXbmcIconsSoundSystem.TabIndex = 1;
            // 
            // cbXbmcIconsSPDIF
            // 
            this.cbXbmcIconsSPDIF.AutoSize = true;
            this.cbXbmcIconsSPDIF.Location = new System.Drawing.Point(191, 72);
            this.cbXbmcIconsSPDIF.Name = "cbXbmcIconsSPDIF";
            this.cbXbmcIconsSPDIF.Size = new System.Drawing.Size(62, 17);
            this.cbXbmcIconsSPDIF.TabIndex = 2;
            this.cbXbmcIconsSPDIF.Text = "S/PDIF";
            this.cbXbmcIconsSPDIF.UseVisualStyleBackColor = true;
            // 
            // cbXbmcIconsVolEnable
            // 
            this.cbXbmcIconsVolEnable.AutoSize = true;
            this.cbXbmcIconsVolEnable.Enabled = false;
            this.cbXbmcIconsVolEnable.Location = new System.Drawing.Point(6, 97);
            this.cbXbmcIconsVolEnable.Name = "cbXbmcIconsVolEnable";
            this.cbXbmcIconsVolEnable.Size = new System.Drawing.Size(135, 17);
            this.cbXbmcIconsVolEnable.TabIndex = 3;
            this.cbXbmcIconsVolEnable.Text = "Show VOL if not muted";
            this.cbXbmcIconsVolEnable.UseVisualStyleBackColor = true;
            // 
            // cbXbmcIconsScreen
            // 
            this.cbXbmcIconsScreen.AutoSize = true;
            this.cbXbmcIconsScreen.Enabled = false;
            this.cbXbmcIconsScreen.Location = new System.Drawing.Point(191, 97);
            this.cbXbmcIconsScreen.Name = "cbXbmcIconsScreen";
            this.cbXbmcIconsScreen.Size = new System.Drawing.Size(131, 17);
            this.cbXbmcIconsScreen.TabIndex = 4;
            this.cbXbmcIconsScreen.Text = "Show screen indicator";
            this.cbXbmcIconsScreen.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.bXbmcMovieCustomTextEdit);
            this.groupBox8.Controls.Add(this.rbXbmcMovieCustomText);
            this.groupBox8.Controls.Add(this.rbXbmcMovieSingleText);
            this.groupBox8.Controls.Add(this.tbXbmcMovieSingleText);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(6, 432);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(369, 100);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Playing a movie";
            // 
            // cbXbmcPlayingShuffleEnable
            // 
            this.cbXbmcPlayingShuffleEnable.AutoSize = true;
            this.cbXbmcPlayingShuffleEnable.Location = new System.Drawing.Point(7, 97);
            this.cbXbmcPlayingShuffleEnable.Name = "cbXbmcPlayingShuffleEnable";
            this.cbXbmcPlayingShuffleEnable.Size = new System.Drawing.Size(95, 17);
            this.cbXbmcPlayingShuffleEnable.TabIndex = 6;
            this.cbXbmcPlayingShuffleEnable.Text = "Show Shuffled";
            this.cbXbmcPlayingShuffleEnable.UseVisualStyleBackColor = true;
            // 
            // cbXbmcPlayingRepeatEnable
            // 
            this.cbXbmcPlayingRepeatEnable.AutoSize = true;
            this.cbXbmcPlayingRepeatEnable.Location = new System.Drawing.Point(192, 97);
            this.cbXbmcPlayingRepeatEnable.Name = "cbXbmcPlayingRepeatEnable";
            this.cbXbmcPlayingRepeatEnable.Size = new System.Drawing.Size(91, 17);
            this.cbXbmcPlayingRepeatEnable.TabIndex = 7;
            this.cbXbmcPlayingRepeatEnable.Text = "Show Repeat";
            this.cbXbmcPlayingRepeatEnable.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Update interval:";
            // 
            // nudXbmcIconsUpdateInterval
            // 
            this.nudXbmcIconsUpdateInterval.Location = new System.Drawing.Point(94, 19);
            this.nudXbmcIconsUpdateInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudXbmcIconsUpdateInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudXbmcIconsUpdateInterval.Name = "nudXbmcIconsUpdateInterval";
            this.nudXbmcIconsUpdateInterval.Size = new System.Drawing.Size(40, 20);
            this.nudXbmcIconsUpdateInterval.TabIndex = 10;
            this.nudXbmcIconsUpdateInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.bXbmcTvCustomTextEdit);
            this.groupBox9.Controls.Add(this.rbXbmcTvCustomText);
            this.groupBox9.Controls.Add(this.rbXbmcTvSingleText);
            this.groupBox9.Controls.Add(this.tbXbmcTvSingleText);
            this.groupBox9.Controls.Add(this.cbXbmcTvShowTvHdtvIcon);
            this.groupBox9.Controls.Add(this.cbXbmcTvMediaTypeIcon);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(6, 538);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(369, 118);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Playing a tv episode";
            // 
            // groupBox10
            // 
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(6, 662);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(369, 85);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Playing a song";
            // 
            // groupBox11
            // 
            this.groupBox11.Enabled = false;
            this.groupBox11.Location = new System.Drawing.Point(6, 753);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(369, 97);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Playing a music video";
            // 
            // groupBox12
            // 
            this.groupBox12.Enabled = false;
            this.groupBox12.Location = new System.Drawing.Point(6, 856);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(369, 97);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Viewing a picture slideshow";
            // 
            // tbXbmcMovieSingleText
            // 
            this.tbXbmcMovieSingleText.Location = new System.Drawing.Point(33, 40);
            this.tbXbmcMovieSingleText.Name = "tbXbmcMovieSingleText";
            this.tbXbmcMovieSingleText.Size = new System.Drawing.Size(330, 20);
            this.tbXbmcMovieSingleText.TabIndex = 1;
            // 
            // rbXbmcMovieSingleText
            // 
            this.rbXbmcMovieSingleText.AutoSize = true;
            this.rbXbmcMovieSingleText.Location = new System.Drawing.Point(6, 20);
            this.rbXbmcMovieSingleText.Name = "rbXbmcMovieSingleText";
            this.rbXbmcMovieSingleText.Size = new System.Drawing.Size(102, 17);
            this.rbXbmcMovieSingleText.TabIndex = 2;
            this.rbXbmcMovieSingleText.TabStop = true;
            this.rbXbmcMovieSingleText.Text = "Show single text";
            this.rbXbmcMovieSingleText.UseVisualStyleBackColor = true;
            // 
            // rbXbmcMovieCustomText
            // 
            this.rbXbmcMovieCustomText.AutoSize = true;
            this.rbXbmcMovieCustomText.Location = new System.Drawing.Point(7, 69);
            this.rbXbmcMovieCustomText.Name = "rbXbmcMovieCustomText";
            this.rbXbmcMovieCustomText.Size = new System.Drawing.Size(124, 17);
            this.rbXbmcMovieCustomText.TabIndex = 3;
            this.rbXbmcMovieCustomText.TabStop = true;
            this.rbXbmcMovieCustomText.Text = "Show custom text list";
            this.rbXbmcMovieCustomText.UseVisualStyleBackColor = true;
            // 
            // bXbmcMovieCustomTextEdit
            // 
            this.bXbmcMovieCustomTextEdit.Location = new System.Drawing.Point(137, 66);
            this.bXbmcMovieCustomTextEdit.Name = "bXbmcMovieCustomTextEdit";
            this.bXbmcMovieCustomTextEdit.Size = new System.Drawing.Size(50, 23);
            this.bXbmcMovieCustomTextEdit.TabIndex = 4;
            this.bXbmcMovieCustomTextEdit.Text = "Edit";
            this.bXbmcMovieCustomTextEdit.UseVisualStyleBackColor = true;
            // 
            // cbXbmcTvMediaTypeIcon
            // 
            this.cbXbmcTvMediaTypeIcon.AutoSize = true;
            this.cbXbmcTvMediaTypeIcon.Location = new System.Drawing.Point(7, 20);
            this.cbXbmcTvMediaTypeIcon.Name = "cbXbmcTvMediaTypeIcon";
            this.cbXbmcTvMediaTypeIcon.Size = new System.Drawing.Size(147, 17);
            this.cbXbmcTvMediaTypeIcon.TabIndex = 0;
            this.cbXbmcTvMediaTypeIcon.Text = "Show TV media type icon";
            this.cbXbmcTvMediaTypeIcon.UseVisualStyleBackColor = true;
            // 
            // cbXbmcTvShowTvHdtvIcon
            // 
            this.cbXbmcTvShowTvHdtvIcon.AutoSize = true;
            this.cbXbmcTvShowTvHdtvIcon.Location = new System.Drawing.Point(191, 20);
            this.cbXbmcTvShowTvHdtvIcon.Name = "cbXbmcTvShowTvHdtvIcon";
            this.cbXbmcTvShowTvHdtvIcon.Size = new System.Drawing.Size(134, 17);
            this.cbXbmcTvShowTvHdtvIcon.TabIndex = 1;
            this.cbXbmcTvShowTvHdtvIcon.Text = "Show TV / HDTV icon";
            this.cbXbmcTvShowTvHdtvIcon.UseVisualStyleBackColor = true;
            // 
            // bXbmcTvCustomTextEdit
            // 
            this.bXbmcTvCustomTextEdit.Location = new System.Drawing.Point(137, 89);
            this.bXbmcTvCustomTextEdit.Name = "bXbmcTvCustomTextEdit";
            this.bXbmcTvCustomTextEdit.Size = new System.Drawing.Size(50, 23);
            this.bXbmcTvCustomTextEdit.TabIndex = 8;
            this.bXbmcTvCustomTextEdit.Text = "Edit";
            this.bXbmcTvCustomTextEdit.UseVisualStyleBackColor = true;
            // 
            // rbXbmcTvCustomText
            // 
            this.rbXbmcTvCustomText.AutoSize = true;
            this.rbXbmcTvCustomText.Location = new System.Drawing.Point(7, 92);
            this.rbXbmcTvCustomText.Name = "rbXbmcTvCustomText";
            this.rbXbmcTvCustomText.Size = new System.Drawing.Size(124, 17);
            this.rbXbmcTvCustomText.TabIndex = 7;
            this.rbXbmcTvCustomText.TabStop = true;
            this.rbXbmcTvCustomText.Text = "Show custom text list";
            this.rbXbmcTvCustomText.UseVisualStyleBackColor = true;
            // 
            // rbXbmcTvSingleText
            // 
            this.rbXbmcTvSingleText.AutoSize = true;
            this.rbXbmcTvSingleText.Location = new System.Drawing.Point(6, 43);
            this.rbXbmcTvSingleText.Name = "rbXbmcTvSingleText";
            this.rbXbmcTvSingleText.Size = new System.Drawing.Size(102, 17);
            this.rbXbmcTvSingleText.TabIndex = 6;
            this.rbXbmcTvSingleText.TabStop = true;
            this.rbXbmcTvSingleText.Text = "Show single text";
            this.rbXbmcTvSingleText.UseVisualStyleBackColor = true;
            // 
            // tbXbmcTvSingleText
            // 
            this.tbXbmcTvSingleText.Location = new System.Drawing.Point(33, 63);
            this.tbXbmcTvSingleText.Name = "tbXbmcTvSingleText";
            this.tbXbmcTvSingleText.Size = new System.Drawing.Size(330, 20);
            this.tbXbmcTvSingleText.TabIndex = 5;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.nudImonLcdScrollingDelay);
            this.groupBox13.Controls.Add(this.label8);
            this.groupBox13.Location = new System.Drawing.Point(9, 105);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(386, 47);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "LCD text scrolling";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Delay [ms]:";
            // 
            // nudImonLcdScrollingDelay
            // 
            this.nudImonLcdScrollingDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudImonLcdScrollingDelay.Location = new System.Drawing.Point(72, 19);
            this.nudImonLcdScrollingDelay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudImonLcdScrollingDelay.Name = "nudImonLcdScrollingDelay";
            this.nudImonLcdScrollingDelay.Size = new System.Drawing.Size(50, 20);
            this.nudImonLcdScrollingDelay.TabIndex = 1;
            this.nudImonLcdScrollingDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudImonLcdScrollingDelay.ThousandsSeparator = true;
            this.nudImonLcdScrollingDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // bNavigationXbmc
            // 
            this.bNavigationXbmc.ActiveImageIndex = 7;
            this.bNavigationXbmc.BackColor = System.Drawing.Color.Transparent;
            this.bNavigationXbmc.DefaultImageIndex = 6;
            this.bNavigationXbmc.FlatAppearance.BorderSize = 0;
            this.bNavigationXbmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationXbmc.HoverImageIndex = 8;
            this.bNavigationXbmc.ImageIndex = 6;
            this.bNavigationXbmc.ImageList = this.iLOptions;
            this.bNavigationXbmc.Location = new System.Drawing.Point(-1, 147);
            this.bNavigationXbmc.Margin = new System.Windows.Forms.Padding(0);
            this.bNavigationXbmc.Name = "bNavigationXbmc";
            this.bNavigationXbmc.Size = new System.Drawing.Size(74, 74);
            this.bNavigationXbmc.TabIndex = 5;
            this.bNavigationXbmc.UseVisualStyleBackColor = false;
            this.bNavigationXbmc.Click += new System.EventHandler(this.bNavigationXbmc_Click);
            // 
            // bNavigationImon
            // 
            this.bNavigationImon.ActiveImageIndex = 4;
            this.bNavigationImon.BackColor = System.Drawing.Color.Transparent;
            this.bNavigationImon.DefaultImageIndex = 3;
            this.bNavigationImon.FlatAppearance.BorderSize = 0;
            this.bNavigationImon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationImon.HoverImageIndex = 5;
            this.bNavigationImon.ImageIndex = 3;
            this.bNavigationImon.ImageList = this.iLOptions;
            this.bNavigationImon.Location = new System.Drawing.Point(-1, 73);
            this.bNavigationImon.Margin = new System.Windows.Forms.Padding(0);
            this.bNavigationImon.Name = "bNavigationImon";
            this.bNavigationImon.Size = new System.Drawing.Size(74, 74);
            this.bNavigationImon.TabIndex = 4;
            this.bNavigationImon.UseVisualStyleBackColor = false;
            this.bNavigationImon.Click += new System.EventHandler(this.bNavigationImon_Click);
            // 
            // bNavigationGeneral
            // 
            this.bNavigationGeneral.ActiveImageIndex = 1;
            this.bNavigationGeneral.BackColor = System.Drawing.Color.Transparent;
            this.bNavigationGeneral.DefaultImageIndex = 0;
            this.bNavigationGeneral.FlatAppearance.BorderSize = 0;
            this.bNavigationGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationGeneral.HoverImageIndex = 2;
            this.bNavigationGeneral.ImageIndex = 0;
            this.bNavigationGeneral.ImageList = this.iLOptions;
            this.bNavigationGeneral.Location = new System.Drawing.Point(-1, -1);
            this.bNavigationGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.bNavigationGeneral.Name = "bNavigationGeneral";
            this.bNavigationGeneral.Size = new System.Drawing.Size(74, 74);
            this.bNavigationGeneral.TabIndex = 3;
            this.bNavigationGeneral.UseVisualStyleBackColor = false;
            this.bNavigationGeneral.Click += new System.EventHandler(this.bNavigationGeneral_Click);
            // 
            // XBMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 453);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "XBMC";
            this.Text = "XBMC on iMON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xbmc_FormClosing);
            this.Load += new System.EventHandler(this.xbmc_Load);
            this.Resize += new System.EventHandler(this.XBMC_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.ResumeLayout(false);
            this.pNavigation.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tpImon.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpGeneral.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpXBMC.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXbmcConnectionInterval)).EndInit();
            this.trayMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXbmcIconsUpdateInterval)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImonLcdScrollingDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miGeneral;
        private System.Windows.Forms.ToolStripMenuItem miXbmc;
        private System.Windows.Forms.ToolStripMenuItem miXbmcConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miXbmcInfo;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miAboutHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miAboutXbmcOniMon;
        private System.Windows.Forms.ToolStripMenuItem miGeneralClose;
        private System.Windows.Forms.ToolStripMenuItem miImon;
        private System.Windows.Forms.ToolStripMenuItem miImonInitialize;
        private System.Windows.Forms.ToolStripMenuItem miImonUninitialize;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.ImageList iLOptions;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpImon;
        private System.Windows.Forms.TabPage tpXBMC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbXbmcConnectionPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXbmcConnectionUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbXbmcConnectionPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXbmcConnectionIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudXbmcConnectionInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem miXbmcDisconnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbGeneralTrayStartMinimized;
        private System.Windows.Forms.CheckBox cbGeneralTrayEnabled;
        private System.Windows.Forms.CheckBox cbGeneralStartupConnect;
        private System.Windows.Forms.CheckBox cbGeneralStartupAuto;
        private System.Windows.Forms.CheckBox cbGeneralTrayHideOnClose;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem trayMenuXBMC;
        private System.Windows.Forms.ToolStripMenuItem trayMenuImon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem trayMenuClose;
        private System.Windows.Forms.CheckBox cbGeneralTrayHideOnMinimize;
        private System.Windows.Forms.CheckBox cbImonGeneralUninitializeOnError;
        private System.Windows.Forms.CheckBox cbImonGeneralAutoInitialize;
        private System.Windows.Forms.Panel pNavigation;
        private NavigationButton bNavigationGeneral;
        private NavigationButton bNavigationXbmc;
        private NavigationButton bNavigationImon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbXbmcIdleTime;
        private System.Windows.Forms.TextBox tbXbmcIdleStaticText;
        private System.Windows.Forms.CheckBox cbXbmcIdleStaticTextEnable;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbXbmcPlayingAudioCodecs;
        private System.Windows.Forms.CheckBox cbXbmcPlayingVideoCodecs;
        private System.Windows.Forms.CheckBox cbXbmcPlayingShowMediaType;
        private System.Windows.Forms.CheckBox cbXbmcPlayingShowProgress;
        private System.Windows.Forms.Button bXbmcPlayingAudioCodecs;
        private System.Windows.Forms.Button bXbmcPlayingVideoCodecs;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbXbmcIconsSoundSystemEnable;
        private System.Windows.Forms.ComboBox cbXbmcIconsSoundSystem;
        private System.Windows.Forms.CheckBox cbXbmcIconsScreen;
        private System.Windows.Forms.CheckBox cbXbmcIconsVolEnable;
        private System.Windows.Forms.CheckBox cbXbmcIconsSPDIF;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown nudXbmcIconsUpdateInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbXbmcPlayingRepeatEnable;
        private System.Windows.Forms.CheckBox cbXbmcPlayingShuffleEnable;
        private System.Windows.Forms.Button bXbmcMovieCustomTextEdit;
        private System.Windows.Forms.RadioButton rbXbmcMovieCustomText;
        private System.Windows.Forms.RadioButton rbXbmcMovieSingleText;
        private System.Windows.Forms.TextBox tbXbmcMovieSingleText;
        private System.Windows.Forms.CheckBox cbXbmcTvShowTvHdtvIcon;
        private System.Windows.Forms.CheckBox cbXbmcTvMediaTypeIcon;
        private System.Windows.Forms.Button bXbmcTvCustomTextEdit;
        private System.Windows.Forms.RadioButton rbXbmcTvCustomText;
        private System.Windows.Forms.RadioButton rbXbmcTvSingleText;
        private System.Windows.Forms.TextBox tbXbmcTvSingleText;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.NumericUpDown nudImonLcdScrollingDelay;
        private System.Windows.Forms.Label label8;


    }
}

