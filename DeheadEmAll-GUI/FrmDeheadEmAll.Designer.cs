namespace DeheadEmAll_GUI
{
    partial class FrmDeheadEmAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeheadEmAll));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeheaderROMs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLoadOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiToolba = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbDeheaderROMs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSaveLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbViewLog = new System.Windows.Forms.ToolStripButton();
            this.tsbViewOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbViewHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbViewLicense = new System.Windows.Forms.ToolStripButton();
            this.tsbViewToolbar = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsddbCancel = new System.Windows.Forms.ToolStripDropDownButton();
            this.tspbDeheaderProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.rtblLog = new Serilog.Sinks.LogEmAll.RichTextBoxLog();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.gbROMs = new System.Windows.Forms.GroupBox();
            this.chkA7800 = new System.Windows.Forms.CheckBox();
            this.chkLynx = new System.Windows.Forms.CheckBox();
            this.chkNES = new System.Windows.Forms.CheckBox();
            this.chkFDS = new System.Windows.Forms.CheckBox();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.txtPathROMsDeheaderedDir = new System.Windows.Forms.TextBox();
            this.txtPathROMsDir = new System.Windows.Forms.TextBox();
            this.lblROMsDeheaderedDir = new System.Windows.Forms.Label();
            this.lblROMsDir = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.bgwStartupTasks = new System.ComponentModel.BackgroundWorker();
            this.bgwDeheaderROMs = new System.ComponentModel.BackgroundWorker();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.gbROMs.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.tabLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCommand,
            this.tsmiView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // tsmiCommand
            // 
            this.tsmiCommand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeheaderROMs,
            this.toolStripSeparator8,
            this.tsmiLoadOptions,
            this.tsmiSaveOptions,
            this.toolStripSeparator9,
            this.tsmiSaveLog,
            this.toolStripSeparator10,
            this.tsmiExit});
            this.tsmiCommand.Name = "tsmiCommand";
            this.tsmiCommand.Size = new System.Drawing.Size(90, 20);
            this.tsmiCommand.Text = "DeheadEmAll";
            // 
            // tsmiDeheaderROMs
            // 
            this.tsmiDeheaderROMs.Enabled = false;
            this.tsmiDeheaderROMs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeheaderROMs.Image")));
            this.tsmiDeheaderROMs.Name = "tsmiDeheaderROMs";
            this.tsmiDeheaderROMs.Size = new System.Drawing.Size(159, 22);
            this.tsmiDeheaderROMs.Text = "Deheader ROMs";
            this.tsmiDeheaderROMs.Click += new System.EventHandler(this.DeheadROMs_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiLoadOptions
            // 
            this.tsmiLoadOptions.Enabled = false;
            this.tsmiLoadOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLoadOptions.Image")));
            this.tsmiLoadOptions.Name = "tsmiLoadOptions";
            this.tsmiLoadOptions.Size = new System.Drawing.Size(159, 22);
            this.tsmiLoadOptions.Text = "Load Options";
            this.tsmiLoadOptions.Click += new System.EventHandler(this.LoadOptions_Click);
            // 
            // tsmiSaveOptions
            // 
            this.tsmiSaveOptions.Enabled = false;
            this.tsmiSaveOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveOptions.Image")));
            this.tsmiSaveOptions.Name = "tsmiSaveOptions";
            this.tsmiSaveOptions.Size = new System.Drawing.Size(159, 22);
            this.tsmiSaveOptions.Text = "Save Options";
            this.tsmiSaveOptions.Click += new System.EventHandler(this.SaveOptions_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiSaveLog
            // 
            this.tsmiSaveLog.Enabled = false;
            this.tsmiSaveLog.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveLog.Image")));
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Size = new System.Drawing.Size(159, 22);
            this.tsmiSaveLog.Text = "Save Log";
            this.tsmiSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(156, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(159, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLog,
            this.toolStripSeparator4,
            this.tsmiOptions,
            this.toolStripSeparator5,
            this.tsmiHelp,
            this.toolStripSeparator6,
            this.tsmiLicense,
            this.toolStripSeparator7,
            this.tsmiToolba});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiLog
            // 
            this.tsmiLog.Checked = true;
            this.tsmiLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLog.Name = "tsmiLog";
            this.tsmiLog.Size = new System.Drawing.Size(116, 22);
            this.tsmiLog.Text = "Log";
            this.tsmiLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Checked = true;
            this.tsmiOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(116, 22);
            this.tsmiOptions.Text = "Options";
            this.tsmiOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(116, 22);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmiLicense
            // 
            this.tsmiLicense.Name = "tsmiLicense";
            this.tsmiLicense.Size = new System.Drawing.Size(116, 22);
            this.tsmiLicense.Text = "License";
            this.tsmiLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmiToolba
            // 
            this.tsmiToolba.Checked = true;
            this.tsmiToolba.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolba.Name = "tsmiToolba";
            this.tsmiToolba.Size = new System.Drawing.Size(116, 22);
            this.tsmiToolba.Text = "Toolbar";
            this.tsmiToolba.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDeheaderROMs,
            this.toolStripSeparator1,
            this.tsbLoadOptions,
            this.tsbSaveOptions,
            this.toolStripSeparator2,
            this.tsbSaveLog,
            this.toolStripSeparator3,
            this.tsbViewLog,
            this.tsbViewOptions,
            this.tsbViewHelp,
            this.tsbViewLicense,
            this.tsbViewToolbar});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(784, 39);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbDeheaderROMs
            // 
            this.tsbDeheaderROMs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeheaderROMs.Enabled = false;
            this.tsbDeheaderROMs.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeheaderROMs.Image")));
            this.tsbDeheaderROMs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeheaderROMs.Name = "tsbDeheaderROMs";
            this.tsbDeheaderROMs.Size = new System.Drawing.Size(36, 36);
            this.tsbDeheaderROMs.Text = "Deheader ROMs";
            this.tsbDeheaderROMs.Click += new System.EventHandler(this.DeheadROMs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbLoadOptions
            // 
            this.tsbLoadOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadOptions.Enabled = false;
            this.tsbLoadOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadOptions.Image")));
            this.tsbLoadOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadOptions.Name = "tsbLoadOptions";
            this.tsbLoadOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbLoadOptions.Text = "Load Options";
            this.tsbLoadOptions.Click += new System.EventHandler(this.LoadOptions_Click);
            // 
            // tsbSaveOptions
            // 
            this.tsbSaveOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveOptions.Enabled = false;
            this.tsbSaveOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveOptions.Image")));
            this.tsbSaveOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveOptions.Name = "tsbSaveOptions";
            this.tsbSaveOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveOptions.Text = "Save Options";
            this.tsbSaveOptions.Click += new System.EventHandler(this.SaveOptions_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbSaveLog
            // 
            this.tsbSaveLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveLog.Enabled = false;
            this.tsbSaveLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveLog.Image")));
            this.tsbSaveLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveLog.Name = "tsbSaveLog";
            this.tsbSaveLog.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveLog.Text = "Save Log";
            this.tsbSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbViewLog
            // 
            this.tsbViewLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewLog.Image")));
            this.tsbViewLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewLog.Name = "tsbViewLog";
            this.tsbViewLog.Size = new System.Drawing.Size(36, 36);
            this.tsbViewLog.Text = "Log";
            this.tsbViewLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // tsbViewOptions
            // 
            this.tsbViewOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewOptions.Image")));
            this.tsbViewOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewOptions.Name = "tsbViewOptions";
            this.tsbViewOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbViewOptions.Text = "Options";
            this.tsbViewOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // tsbViewHelp
            // 
            this.tsbViewHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewHelp.Image")));
            this.tsbViewHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewHelp.Name = "tsbViewHelp";
            this.tsbViewHelp.Size = new System.Drawing.Size(36, 36);
            this.tsbViewHelp.Text = "Help";
            this.tsbViewHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsbViewLicense
            // 
            this.tsbViewLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewLicense.Image")));
            this.tsbViewLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewLicense.Name = "tsbViewLicense";
            this.tsbViewLicense.Size = new System.Drawing.Size(36, 36);
            this.tsbViewLicense.Text = "License";
            this.tsbViewLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tsbViewToolbar
            // 
            this.tsbViewToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewToolbar.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewToolbar.Image")));
            this.tsbViewToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewToolbar.Name = "tsbViewToolbar";
            this.tsbViewToolbar.Size = new System.Drawing.Size(36, 36);
            this.tsbViewToolbar.Text = "Toolbar";
            this.tsbViewToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbCancel,
            this.tspbDeheaderProgress,
            this.tsslStatusMessage,
            this.toolStripStatusLabel1});
            this.ssMain.Location = new System.Drawing.Point(0, 428);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(784, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "ssMain";
            // 
            // tsddbCancel
            // 
            this.tsddbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbCancel.Enabled = false;
            this.tsddbCancel.Image = global::DeheadEmAll_GUI.Properties.Resources.Cancel_16x16;
            this.tsddbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbCancel.Name = "tsddbCancel";
            this.tsddbCancel.ShowDropDownArrow = false;
            this.tsddbCancel.Size = new System.Drawing.Size(20, 20);
            this.tsddbCancel.Text = "Cancel";
            this.tsddbCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tspbDeheaderProgress
            // 
            this.tspbDeheaderProgress.Name = "tspbDeheaderProgress";
            this.tspbDeheaderProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // tsslStatusMessage
            // 
            this.tsslStatusMessage.Name = "tsslStatusMessage";
            this.tsslStatusMessage.Size = new System.Drawing.Size(148, 17);
            this.tsslStatusMessage.Text = "Performing startup tasks ...";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(399, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabOptions);
            this.tcMain.Controls.Add(this.tabHelp);
            this.tcMain.Controls.Add(this.tabLicense);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(784, 365);
            this.tcMain.TabIndex = 3;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtblLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(776, 339);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = " Log ";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // rtblLog
            // 
            this.rtblLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtblLog.Location = new System.Drawing.Point(6, 6);
            this.rtblLog.Name = "rtblLog";
            this.rtblLog.ReadOnly = true;
            this.rtblLog.Size = new System.Drawing.Size(764, 327);
            this.rtblLog.TabIndex = 0;
            this.rtblLog.Text = "";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.gbROMs);
            this.tabOptions.Controls.Add(this.gbPaths);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(776, 339);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = " Options ";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // gbROMs
            // 
            this.gbROMs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbROMs.Controls.Add(this.chkA7800);
            this.gbROMs.Controls.Add(this.chkLynx);
            this.gbROMs.Controls.Add(this.chkNES);
            this.gbROMs.Controls.Add(this.chkFDS);
            this.gbROMs.Location = new System.Drawing.Point(6, 6);
            this.gbROMs.Name = "gbROMs";
            this.gbROMs.Size = new System.Drawing.Size(764, 42);
            this.gbROMs.TabIndex = 2;
            this.gbROMs.TabStop = false;
            this.gbROMs.Text = "ROMs";
            // 
            // chkA7800
            // 
            this.chkA7800.AutoSize = true;
            this.chkA7800.Checked = true;
            this.chkA7800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkA7800.Location = new System.Drawing.Point(6, 19);
            this.chkA7800.Name = "chkA7800";
            this.chkA7800.Size = new System.Drawing.Size(87, 17);
            this.chkA7800.TabIndex = 3;
            this.chkA7800.Text = "A7800 (.a78)";
            this.chkA7800.UseVisualStyleBackColor = true;
            // 
            // chkLynx
            // 
            this.chkLynx.AutoSize = true;
            this.chkLynx.Checked = true;
            this.chkLynx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLynx.Location = new System.Drawing.Point(178, 19);
            this.chkLynx.Name = "chkLynx";
            this.chkLynx.Size = new System.Drawing.Size(73, 17);
            this.chkLynx.TabIndex = 2;
            this.chkLynx.Text = "Lynx (.lnx)";
            this.chkLynx.UseVisualStyleBackColor = true;
            // 
            // chkNES
            // 
            this.chkNES.AutoSize = true;
            this.chkNES.Checked = true;
            this.chkNES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNES.Location = new System.Drawing.Point(257, 19);
            this.chkNES.Name = "chkNES";
            this.chkNES.Size = new System.Drawing.Size(77, 17);
            this.chkNES.TabIndex = 1;
            this.chkNES.Text = "NES (.nes)";
            this.chkNES.UseVisualStyleBackColor = true;
            // 
            // chkFDS
            // 
            this.chkFDS.AutoSize = true;
            this.chkFDS.Checked = true;
            this.chkFDS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFDS.Location = new System.Drawing.Point(99, 19);
            this.chkFDS.Name = "chkFDS";
            this.chkFDS.Size = new System.Drawing.Size(73, 17);
            this.chkFDS.TabIndex = 0;
            this.chkFDS.Text = "FDS (.fds)";
            this.chkFDS.UseVisualStyleBackColor = true;
            // 
            // gbPaths
            // 
            this.gbPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaths.Controls.Add(this.txtPathROMsDeheaderedDir);
            this.gbPaths.Controls.Add(this.txtPathROMsDir);
            this.gbPaths.Controls.Add(this.lblROMsDeheaderedDir);
            this.gbPaths.Controls.Add(this.lblROMsDir);
            this.gbPaths.Location = new System.Drawing.Point(6, 54);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(764, 71);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Paths";
            // 
            // txtPathROMsDeheaderedDir
            // 
            this.txtPathROMsDeheaderedDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathROMsDeheaderedDir.Location = new System.Drawing.Point(133, 45);
            this.txtPathROMsDeheaderedDir.Name = "txtPathROMsDeheaderedDir";
            this.txtPathROMsDeheaderedDir.ReadOnly = true;
            this.txtPathROMsDeheaderedDir.Size = new System.Drawing.Size(625, 20);
            this.txtPathROMsDeheaderedDir.TabIndex = 5;
            this.txtPathROMsDeheaderedDir.Click += new System.EventHandler(this.ChangeROMsDeheaderedDir_Click);
            // 
            // txtPathROMsDir
            // 
            this.txtPathROMsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathROMsDir.Location = new System.Drawing.Point(133, 19);
            this.txtPathROMsDir.Name = "txtPathROMsDir";
            this.txtPathROMsDir.ReadOnly = true;
            this.txtPathROMsDir.Size = new System.Drawing.Size(625, 20);
            this.txtPathROMsDir.TabIndex = 4;
            this.txtPathROMsDir.Click += new System.EventHandler(this.ChangeROMsDir_Click);
            // 
            // lblROMsDeheaderedDir
            // 
            this.lblROMsDeheaderedDir.AutoSize = true;
            this.lblROMsDeheaderedDir.Location = new System.Drawing.Point(6, 48);
            this.lblROMsDeheaderedDir.Name = "lblROMsDeheaderedDir";
            this.lblROMsDeheaderedDir.Size = new System.Drawing.Size(121, 13);
            this.lblROMsDeheaderedDir.TabIndex = 3;
            this.lblROMsDeheaderedDir.Text = "ROMs Deheadered Dir: ";
            // 
            // lblROMsDir
            // 
            this.lblROMsDir.AutoSize = true;
            this.lblROMsDir.Location = new System.Drawing.Point(6, 22);
            this.lblROMsDir.Name = "lblROMsDir";
            this.lblROMsDir.Size = new System.Drawing.Size(59, 13);
            this.lblROMsDir.TabIndex = 2;
            this.lblROMsDir.Text = "ROMs Dir: ";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.rtbHelp);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(776, 339);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = " Help ";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // rtbHelp
            // 
            this.rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelp.Location = new System.Drawing.Point(6, 6);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(764, 341);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.rtbLicense);
            this.tabLicense.Location = new System.Drawing.Point(4, 22);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(776, 339);
            this.tabLicense.TabIndex = 3;
            this.tabLicense.Text = " License ";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // rtbLicense
            // 
            this.rtbLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLicense.Location = new System.Drawing.Point(6, 6);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(764, 327);
            this.rtbLicense.TabIndex = 0;
            this.rtbLicense.Text = "";
            // 
            // bgwStartupTasks
            // 
            this.bgwStartupTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartupTasks_DoWork);
            this.bgwStartupTasks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StartupTasks_RunWorkerCompleted);
            // 
            // bgwDeheaderROMs
            // 
            this.bgwDeheaderROMs.WorkerReportsProgress = true;
            this.bgwDeheaderROMs.WorkerSupportsCancellation = true;
            this.bgwDeheaderROMs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DeheaderROMs_DoWork);
            this.bgwDeheaderROMs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DeheaderROMs_ProgressChanged);
            this.bgwDeheaderROMs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DeheaderROMs_RunWorkerCompleted);
            // 
            // FrmDeheadEmAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmDeheadEmAll";
            this.Text = "DeheadEmAll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Shown += new System.EventHandler(this.Fprm_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.gbROMs.ResumeLayout(false);
            this.gbROMs.PerformLayout();
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommand;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadOptions;
        private System.Windows.Forms.ToolStripButton tsbSaveOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSaveLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbViewLog;
        private System.Windows.Forms.ToolStripButton tsbViewOptions;
        private System.Windows.Forms.ToolStripButton tsbViewHelp;
        private System.Windows.Forms.ToolStripButton tsbViewLicense;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolba;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusMessage;
        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.RichTextBox rtbLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbViewToolbar;
        private System.ComponentModel.BackgroundWorker bgwStartupTasks;
        private System.ComponentModel.BackgroundWorker bgwDeheaderROMs;
        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.TextBox txtPathROMsDeheaderedDir;
        private System.Windows.Forms.TextBox txtPathROMsDir;
        private System.Windows.Forms.Label lblROMsDeheaderedDir;
        private System.Windows.Forms.Label lblROMsDir;
        private System.Windows.Forms.GroupBox gbROMs;
        private System.Windows.Forms.CheckBox chkA7800;
        private System.Windows.Forms.CheckBox chkLynx;
        private System.Windows.Forms.CheckBox chkNES;
        private System.Windows.Forms.CheckBox chkFDS;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeheaderROMs;
        private System.Windows.Forms.ToolStripButton tsbDeheaderROMs;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCancel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Serilog.Sinks.LogEmAll.RichTextBoxLog rtblLog;
        private System.Windows.Forms.ToolStripProgressBar tspbDeheaderProgress;
    }
}

