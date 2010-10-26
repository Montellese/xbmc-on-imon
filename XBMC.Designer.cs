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
            this.pNavigation = new System.Windows.Forms.Panel();
            this.bNavigationGeneral = new System.Windows.Forms.Button();
            this.bNavigationImon = new System.Windows.Forms.Button();
            this.bNavigationXbmc = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
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
            this.pNavigation.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(533, 24);
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
            this.splitter.IsSplitterFixed = true;
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
            this.splitter.Size = new System.Drawing.Size(533, 260);
            this.splitter.SplitterDistance = 128;
            this.splitter.TabIndex = 1;
            // 
            // iLOptions
            // 
            this.iLOptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLOptions.ImageStream")));
            this.iLOptions.TransparentColor = System.Drawing.Color.Transparent;
            this.iLOptions.Images.SetKeyName(0, "Options.png");
            this.iLOptions.Images.SetKeyName(1, "iMON.png");
            this.iLOptions.Images.SetKeyName(2, "XBMC.png");
            // 
            // tabOptions
            // 
            this.tabOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptions.Controls.Add(this.tpImon);
            this.tabOptions.Controls.Add(this.tpGeneral);
            this.tabOptions.Controls.Add(this.tpXBMC);
            this.tabOptions.Location = new System.Drawing.Point(-10, -48);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(420, 318);
            this.tabOptions.TabIndex = 0;
            // 
            // tpImon
            // 
            this.tpImon.BackColor = System.Drawing.SystemColors.Control;
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
            this.tpXBMC.Controls.Add(this.groupBox1);
            this.tpXBMC.Location = new System.Drawing.Point(4, 22);
            this.tpXBMC.Name = "tpXBMC";
            this.tpXBMC.Padding = new System.Windows.Forms.Padding(3);
            this.tpXBMC.Size = new System.Drawing.Size(412, 292);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 103);
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
            this.tbXbmcConnectionPassword.Location = new System.Drawing.Point(260, 47);
            this.tbXbmcConnectionPassword.Name = "tbXbmcConnectionPassword";
            this.tbXbmcConnectionPassword.PasswordChar = '*';
            this.tbXbmcConnectionPassword.Size = new System.Drawing.Size(120, 20);
            this.tbXbmcConnectionPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // tbXbmcConnectionUsername
            // 
            this.tbXbmcConnectionUsername.Location = new System.Drawing.Point(70, 47);
            this.tbXbmcConnectionUsername.Name = "tbXbmcConnectionUsername";
            this.tbXbmcConnectionUsername.Size = new System.Drawing.Size(120, 20);
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
            this.tbXbmcConnectionPort.Location = new System.Drawing.Point(312, 19);
            this.tbXbmcConnectionPort.Name = "tbXbmcConnectionPort";
            this.tbXbmcConnectionPort.Size = new System.Drawing.Size(68, 20);
            this.tbXbmcConnectionPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(277, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // tbXbmcConnectionIp
            // 
            this.tbXbmcConnectionIp.Location = new System.Drawing.Point(34, 20);
            this.tbXbmcConnectionIp.Name = "tbXbmcConnectionIp";
            this.tbXbmcConnectionIp.Size = new System.Drawing.Size(225, 20);
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
            // pNavigation
            // 
            this.pNavigation.BackColor = System.Drawing.Color.White;
            this.pNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNavigation.Controls.Add(this.bNavigationXbmc);
            this.pNavigation.Controls.Add(this.bNavigationImon);
            this.pNavigation.Controls.Add(this.bNavigationGeneral);
            this.pNavigation.Location = new System.Drawing.Point(4, 4);
            this.pNavigation.Name = "pNavigation";
            this.pNavigation.Size = new System.Drawing.Size(116, 253);
            this.pNavigation.TabIndex = 0;
            // 
            // bNavigationGeneral
            // 
            this.bNavigationGeneral.BackColor = System.Drawing.Color.Transparent;
            this.bNavigationGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bNavigationGeneral.FlatAppearance.BorderSize = 0;
            this.bNavigationGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationGeneral.ImageIndex = 0;
            this.bNavigationGeneral.ImageList = this.iLOptions;
            this.bNavigationGeneral.Location = new System.Drawing.Point(23, 8);
            this.bNavigationGeneral.Name = "bNavigationGeneral";
            this.bNavigationGeneral.Size = new System.Drawing.Size(68, 68);
            this.bNavigationGeneral.TabIndex = 0;
            this.bNavigationGeneral.UseVisualStyleBackColor = false;
            this.bNavigationGeneral.Click += new System.EventHandler(this.bNavigationGeneral_Click);
            this.bNavigationGeneral.MouseHover += new System.EventHandler(this.bNavigationGeneral_MouseHover);
            // 
            // bNavigationImon
            // 
            this.bNavigationImon.BackColor = System.Drawing.Color.Transparent;
            this.bNavigationImon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bNavigationImon.FlatAppearance.BorderSize = 0;
            this.bNavigationImon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationImon.ImageIndex = 1;
            this.bNavigationImon.ImageList = this.iLOptions;
            this.bNavigationImon.Location = new System.Drawing.Point(23, 93);
            this.bNavigationImon.Name = "bNavigationImon";
            this.bNavigationImon.Size = new System.Drawing.Size(68, 68);
            this.bNavigationImon.TabIndex = 1;
            this.bNavigationImon.UseVisualStyleBackColor = false;
            this.bNavigationImon.Click += new System.EventHandler(this.bNavigationImon_Click);
            // 
            // bNavigationXbmc
            // 
            this.bNavigationXbmc.BackColor = System.Drawing.Color.Transparent;
            this.bNavigationXbmc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bNavigationXbmc.FlatAppearance.BorderSize = 0;
            this.bNavigationXbmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNavigationXbmc.ImageIndex = 2;
            this.bNavigationXbmc.ImageList = this.iLOptions;
            this.bNavigationXbmc.Location = new System.Drawing.Point(23, 174);
            this.bNavigationXbmc.Name = "bNavigationXbmc";
            this.bNavigationXbmc.Size = new System.Drawing.Size(68, 68);
            this.bNavigationXbmc.TabIndex = 2;
            this.bNavigationXbmc.UseVisualStyleBackColor = false;
            this.bNavigationXbmc.Click += new System.EventHandler(this.bNavigationXbmc_Click);
            // 
            // XBMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 284);
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
            this.pNavigation.ResumeLayout(false);
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
        private System.Windows.Forms.Button bNavigationXbmc;
        private System.Windows.Forms.Button bNavigationImon;
        private System.Windows.Forms.Button bNavigationGeneral;


    }
}

