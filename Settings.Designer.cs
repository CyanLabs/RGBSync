namespace RGBSync
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settiingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.chkCM = new System.Windows.Forms.CheckBox();
            this.chkMSI = new System.Windows.Forms.CheckBox();
            this.chkShowNotification = new System.Windows.Forms.CheckBox();
            this.chkNovation = new System.Windows.Forms.CheckBox();
            this.chkCorsairCue = new System.Windows.Forms.CheckBox();
            this.chkLogitech = new System.Windows.Forms.CheckBox();
            this.chkCorsairLink = new System.Windows.Forms.CheckBox();
            this.tabCorsairLink = new System.Windows.Forms.TabPage();
            this.GrpLink1 = new System.Windows.Forms.GroupBox();
            this.LblLinkChDesc = new System.Windows.Forms.Label();
            this.ChkLinkCh2 = new System.Windows.Forms.CheckBox();
            this.ChkLinkCh1 = new System.Windows.Forms.CheckBox();
            this.GrpLink2 = new System.Windows.Forms.GroupBox();
            this.NumLinkCh1Amount = new System.Windows.Forms.NumericUpDown();
            this.LblLinkCh1Amount = new System.Windows.Forms.Label();
            this.LblLinkCh1Type = new System.Windows.Forms.Label();
            this.DDLinkCh1Type = new System.Windows.Forms.ComboBox();
            this.GrpLink3 = new System.Windows.Forms.GroupBox();
            this.NumLinkCh2Amount = new System.Windows.Forms.NumericUpDown();
            this.LblLinkCh2Amount = new System.Windows.Forms.Label();
            this.LblLinkCh2Type = new System.Windows.Forms.Label();
            this.DDLinkCh2Type = new System.Windows.Forms.ComboBox();
            this.LblCopyright = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabCorsairLink.SuspendLayout();
            this.GrpLink1.SuspendLayout();
            this.GrpLink2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLinkCh1Amount)).BeginInit();
            this.GrpLink3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLinkCh2Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "RGBSync is active";
            this.notifyIcon1.BalloonTipTitle = "RGBSync";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RGBSync";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settiingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 54);
            // 
            // settiingsToolStripMenuItem
            // 
            this.settiingsToolStripMenuItem.Name = "settiingsToolStripMenuItem";
            this.settiingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settiingsToolStripMenuItem.Text = "&Settings";
            this.settiingsToolStripMenuItem.Click += new System.EventHandler(this.settiingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::RGBSync.Properties.Resources.RGBSyncLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(270, 387);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 26);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save Settings";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabCorsairLink);
            this.tabControl1.Location = new System.Drawing.Point(12, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 287);
            this.tabControl1.TabIndex = 3;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.chkCM);
            this.tabGeneral.Controls.Add(this.chkMSI);
            this.tabGeneral.Controls.Add(this.chkShowNotification);
            this.tabGeneral.Controls.Add(this.chkNovation);
            this.tabGeneral.Controls.Add(this.chkCorsairCue);
            this.tabGeneral.Controls.Add(this.chkLogitech);
            this.tabGeneral.Controls.Add(this.chkCorsairLink);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(378, 261);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // chkCM
            // 
            this.chkCM.AutoSize = true;
            this.chkCM.Checked = global::RGBSync.Properties.Settings.Default.UseCM;
            this.chkCM.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseCM", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCM.Location = new System.Drawing.Point(187, 52);
            this.chkCM.Name = "chkCM";
            this.chkCM.Size = new System.Drawing.Size(152, 17);
            this.chkCM.TabIndex = 4;
            this.chkCM.Text = "Use CoolerMaster Devices";
            this.chkCM.UseVisualStyleBackColor = true;
            // 
            // chkMSI
            // 
            this.chkMSI.AutoSize = true;
            this.chkMSI.Checked = global::RGBSync.Properties.Settings.Default.UseMSI;
            this.chkMSI.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseMSI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMSI.Location = new System.Drawing.Point(187, 29);
            this.chkMSI.Name = "chkMSI";
            this.chkMSI.Size = new System.Drawing.Size(109, 17);
            this.chkMSI.TabIndex = 4;
            this.chkMSI.Text = "Use MSI Devices";
            this.chkMSI.UseVisualStyleBackColor = true;
            // 
            // chkShowNotification
            // 
            this.chkShowNotification.AutoSize = true;
            this.chkShowNotification.Checked = global::RGBSync.Properties.Settings.Default.ShowNotification;
            this.chkShowNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowNotification.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "ShowNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShowNotification.Location = new System.Drawing.Point(95, 98);
            this.chkShowNotification.Name = "chkShowNotification";
            this.chkShowNotification.Size = new System.Drawing.Size(161, 17);
            this.chkShowNotification.TabIndex = 4;
            this.chkShowNotification.Text = "Show Notifcation On Startup";
            this.chkShowNotification.UseVisualStyleBackColor = true;
            // 
            // chkNovation
            // 
            this.chkNovation.AutoSize = true;
            this.chkNovation.Checked = global::RGBSync.Properties.Settings.Default.UseNovation;
            this.chkNovation.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseNovation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNovation.Location = new System.Drawing.Point(187, 6);
            this.chkNovation.Name = "chkNovation";
            this.chkNovation.Size = new System.Drawing.Size(133, 17);
            this.chkNovation.TabIndex = 4;
            this.chkNovation.Text = "Use Novation Devices";
            this.chkNovation.UseVisualStyleBackColor = true;
            // 
            // chkCorsairCue
            // 
            this.chkCorsairCue.AutoSize = true;
            this.chkCorsairCue.Checked = global::RGBSync.Properties.Settings.Default.UseCorsairCue;
            this.chkCorsairCue.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseCorsairCue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCorsairCue.Location = new System.Drawing.Point(6, 6);
            this.chkCorsairCue.Name = "chkCorsairCue";
            this.chkCorsairCue.Size = new System.Drawing.Size(144, 17);
            this.chkCorsairCue.TabIndex = 0;
            this.chkCorsairCue.Text = "Use Corsair Cue Devices";
            this.chkCorsairCue.UseVisualStyleBackColor = true;
            // 
            // chkLogitech
            // 
            this.chkLogitech.AutoSize = true;
            this.chkLogitech.Checked = global::RGBSync.Properties.Settings.Default.UseLogitech;
            this.chkLogitech.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseLogitech", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLogitech.Location = new System.Drawing.Point(6, 52);
            this.chkLogitech.Name = "chkLogitech";
            this.chkLogitech.Size = new System.Drawing.Size(131, 17);
            this.chkLogitech.TabIndex = 2;
            this.chkLogitech.Text = "Use Logitech Devices";
            this.chkLogitech.UseVisualStyleBackColor = true;
            // 
            // chkCorsairLink
            // 
            this.chkCorsairLink.AutoSize = true;
            this.chkCorsairLink.Checked = global::RGBSync.Properties.Settings.Default.UseCorsairLink;
            this.chkCorsairLink.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseCorsairLink", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCorsairLink.Location = new System.Drawing.Point(6, 29);
            this.chkCorsairLink.Name = "chkCorsairLink";
            this.chkCorsairLink.Size = new System.Drawing.Size(145, 17);
            this.chkCorsairLink.TabIndex = 1;
            this.chkCorsairLink.Text = "Use Corsair Link Devices";
            this.chkCorsairLink.UseVisualStyleBackColor = true;
            // 
            // tabCorsairLink
            // 
            this.tabCorsairLink.Controls.Add(this.GrpLink1);
            this.tabCorsairLink.Controls.Add(this.GrpLink2);
            this.tabCorsairLink.Controls.Add(this.GrpLink3);
            this.tabCorsairLink.Location = new System.Drawing.Point(4, 22);
            this.tabCorsairLink.Name = "tabCorsairLink";
            this.tabCorsairLink.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorsairLink.Size = new System.Drawing.Size(378, 261);
            this.tabCorsairLink.TabIndex = 1;
            this.tabCorsairLink.Text = "WIP";
            this.tabCorsairLink.UseVisualStyleBackColor = true;
            // 
            // GrpLink1
            // 
            this.GrpLink1.Controls.Add(this.LblLinkChDesc);
            this.GrpLink1.Controls.Add(this.ChkLinkCh2);
            this.GrpLink1.Controls.Add(this.ChkLinkCh1);
            this.GrpLink1.Location = new System.Drawing.Point(6, 6);
            this.GrpLink1.Name = "GrpLink1";
            this.GrpLink1.Size = new System.Drawing.Size(366, 67);
            this.GrpLink1.TabIndex = 1;
            this.GrpLink1.TabStop = false;
            this.GrpLink1.Text = "Channels";
            // 
            // LblLinkChDesc
            // 
            this.LblLinkChDesc.AutoSize = true;
            this.LblLinkChDesc.Location = new System.Drawing.Point(25, 23);
            this.LblLinkChDesc.Name = "LblLinkChDesc";
            this.LblLinkChDesc.Size = new System.Drawing.Size(137, 13);
            this.LblLinkChDesc.TabIndex = 0;
            this.LblLinkChDesc.Text = "Which channels to enable?";
            this.LblLinkChDesc.Visible = false;
            // 
            // ChkLinkCh2
            // 
            this.ChkLinkCh2.AutoSize = true;
            this.ChkLinkCh2.Checked = global::RGBSync.Properties.Settings.Default.UseCorsairLinkCh2;
            this.ChkLinkCh2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkLinkCh2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseCorsairLinkCh2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkLinkCh2.Location = new System.Drawing.Point(266, 23);
            this.ChkLinkCh2.Name = "ChkLinkCh2";
            this.ChkLinkCh2.Size = new System.Drawing.Size(74, 17);
            this.ChkLinkCh2.TabIndex = 1;
            this.ChkLinkCh2.Text = "Channel 2";
            this.ChkLinkCh2.UseVisualStyleBackColor = true;
            this.ChkLinkCh2.Visible = false;
            // 
            // ChkLinkCh1
            // 
            this.ChkLinkCh1.AutoSize = true;
            this.ChkLinkCh1.Checked = global::RGBSync.Properties.Settings.Default.UseCorsairLinkCh1;
            this.ChkLinkCh1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkLinkCh1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RGBSync.Properties.Settings.Default, "UseCorsairLinkCh1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkLinkCh1.Location = new System.Drawing.Point(181, 23);
            this.ChkLinkCh1.Name = "ChkLinkCh1";
            this.ChkLinkCh1.Size = new System.Drawing.Size(74, 17);
            this.ChkLinkCh1.TabIndex = 0;
            this.ChkLinkCh1.Text = "Channel 1";
            this.ChkLinkCh1.UseVisualStyleBackColor = true;
            this.ChkLinkCh1.Visible = false;
            // 
            // GrpLink2
            // 
            this.GrpLink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpLink2.Controls.Add(this.NumLinkCh1Amount);
            this.GrpLink2.Controls.Add(this.LblLinkCh1Amount);
            this.GrpLink2.Controls.Add(this.LblLinkCh1Type);
            this.GrpLink2.Controls.Add(this.DDLinkCh1Type);
            this.GrpLink2.Enabled = false;
            this.GrpLink2.Location = new System.Drawing.Point(6, 76);
            this.GrpLink2.Name = "GrpLink2";
            this.GrpLink2.Size = new System.Drawing.Size(366, 88);
            this.GrpLink2.TabIndex = 0;
            this.GrpLink2.TabStop = false;
            this.GrpLink2.Text = "Channel 1";
            this.GrpLink2.Visible = false;
            // 
            // NumLinkCh1Amount
            // 
            this.NumLinkCh1Amount.Location = new System.Drawing.Point(286, 59);
            this.NumLinkCh1Amount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumLinkCh1Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLinkCh1Amount.Name = "NumLinkCh1Amount";
            this.NumLinkCh1Amount.Size = new System.Drawing.Size(74, 20);
            this.NumLinkCh1Amount.TabIndex = 3;
            this.NumLinkCh1Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblLinkCh1Amount
            // 
            this.LblLinkCh1Amount.AutoSize = true;
            this.LblLinkCh1Amount.Location = new System.Drawing.Point(23, 61);
            this.LblLinkCh1Amount.Name = "LblLinkCh1Amount";
            this.LblLinkCh1Amount.Size = new System.Drawing.Size(233, 13);
            this.LblLinkCh1Amount.TabIndex = 2;
            this.LblLinkCh1Amount.Text = "How many of the above device are connected?\r\n";
            // 
            // LblLinkCh1Type
            // 
            this.LblLinkCh1Type.AutoSize = true;
            this.LblLinkCh1Type.Location = new System.Drawing.Point(23, 26);
            this.LblLinkCh1Type.Name = "LblLinkCh1Type";
            this.LblLinkCh1Type.Size = new System.Drawing.Size(210, 13);
            this.LblLinkCh1Type.TabIndex = 1;
            this.LblLinkCh1Type.Text = "What device is connected to this channel?";
            // 
            // DDLinkCh1Type
            // 
            this.DDLinkCh1Type.FormattingEnabled = true;
            this.DDLinkCh1Type.Items.AddRange(new object[] {
            "HD Fans",
            "LED Strips"});
            this.DDLinkCh1Type.Location = new System.Drawing.Point(239, 23);
            this.DDLinkCh1Type.Name = "DDLinkCh1Type";
            this.DDLinkCh1Type.Size = new System.Drawing.Size(121, 21);
            this.DDLinkCh1Type.TabIndex = 0;
            // 
            // GrpLink3
            // 
            this.GrpLink3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpLink3.Controls.Add(this.NumLinkCh2Amount);
            this.GrpLink3.Controls.Add(this.LblLinkCh2Amount);
            this.GrpLink3.Controls.Add(this.LblLinkCh2Type);
            this.GrpLink3.Controls.Add(this.DDLinkCh2Type);
            this.GrpLink3.Enabled = false;
            this.GrpLink3.Location = new System.Drawing.Point(6, 167);
            this.GrpLink3.Name = "GrpLink3";
            this.GrpLink3.Size = new System.Drawing.Size(366, 88);
            this.GrpLink3.TabIndex = 1;
            this.GrpLink3.TabStop = false;
            this.GrpLink3.Text = "Channel 2";
            this.GrpLink3.Visible = false;
            // 
            // NumLinkCh2Amount
            // 
            this.NumLinkCh2Amount.Location = new System.Drawing.Point(286, 59);
            this.NumLinkCh2Amount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumLinkCh2Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLinkCh2Amount.Name = "NumLinkCh2Amount";
            this.NumLinkCh2Amount.Size = new System.Drawing.Size(74, 20);
            this.NumLinkCh2Amount.TabIndex = 3;
            this.NumLinkCh2Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblLinkCh2Amount
            // 
            this.LblLinkCh2Amount.AutoSize = true;
            this.LblLinkCh2Amount.Location = new System.Drawing.Point(23, 61);
            this.LblLinkCh2Amount.Name = "LblLinkCh2Amount";
            this.LblLinkCh2Amount.Size = new System.Drawing.Size(233, 13);
            this.LblLinkCh2Amount.TabIndex = 2;
            this.LblLinkCh2Amount.Text = "How many of the above device are connected?\r\n";
            // 
            // LblLinkCh2Type
            // 
            this.LblLinkCh2Type.AutoSize = true;
            this.LblLinkCh2Type.Location = new System.Drawing.Point(23, 26);
            this.LblLinkCh2Type.Name = "LblLinkCh2Type";
            this.LblLinkCh2Type.Size = new System.Drawing.Size(210, 13);
            this.LblLinkCh2Type.TabIndex = 1;
            this.LblLinkCh2Type.Text = "What device is connected to this channel?";
            // 
            // DDLinkCh2Type
            // 
            this.DDLinkCh2Type.FormattingEnabled = true;
            this.DDLinkCh2Type.Items.AddRange(new object[] {
            "HD Fans",
            "LED Strips"});
            this.DDLinkCh2Type.Location = new System.Drawing.Point(239, 23);
            this.DDLinkCh2Type.Name = "DDLinkCh2Type";
            this.DDLinkCh2Type.Size = new System.Drawing.Size(121, 21);
            this.DDLinkCh2Type.TabIndex = 0;
            // 
            // LblCopyright
            // 
            this.LblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCopyright.AutoSize = true;
            this.LblCopyright.Location = new System.Drawing.Point(9, 394);
            this.LblCopyright.Name = "LblCopyright";
            this.LblCopyright.Size = new System.Drawing.Size(252, 13);
            this.LblCopyright.TabIndex = 5;
            this.LblCopyright.Text = "Copyright © Cyanlabs 2017 - Powered by RGB.NET";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 416);
            this.Controls.Add(this.LblCopyright);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabCorsairLink.ResumeLayout(false);
            this.GrpLink1.ResumeLayout(false);
            this.GrpLink1.PerformLayout();
            this.GrpLink2.ResumeLayout(false);
            this.GrpLink2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLinkCh1Amount)).EndInit();
            this.GrpLink3.ResumeLayout(false);
            this.GrpLink3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLinkCh2Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkLogitech;
        private System.Windows.Forms.CheckBox chkCorsairLink;
        private System.Windows.Forms.CheckBox chkCorsairCue;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabCorsairLink;
        private System.Windows.Forms.GroupBox GrpLink1;
        private System.Windows.Forms.Label LblLinkChDesc;
        private System.Windows.Forms.CheckBox ChkLinkCh2;
        private System.Windows.Forms.CheckBox ChkLinkCh1;
        private System.Windows.Forms.GroupBox GrpLink3;
        private System.Windows.Forms.NumericUpDown NumLinkCh2Amount;
        private System.Windows.Forms.Label LblLinkCh2Amount;
        private System.Windows.Forms.Label LblLinkCh2Type;
        private System.Windows.Forms.ComboBox DDLinkCh2Type;
        private System.Windows.Forms.GroupBox GrpLink2;
        private System.Windows.Forms.NumericUpDown NumLinkCh1Amount;
        private System.Windows.Forms.Label LblLinkCh1Amount;
        private System.Windows.Forms.Label LblLinkCh1Type;
        private System.Windows.Forms.ComboBox DDLinkCh1Type;
        private System.Windows.Forms.CheckBox chkCM;
        private System.Windows.Forms.CheckBox chkNovation;
        private System.Windows.Forms.CheckBox chkMSI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settiingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkShowNotification;
        private System.Windows.Forms.Label LblCopyright;
    }
}

