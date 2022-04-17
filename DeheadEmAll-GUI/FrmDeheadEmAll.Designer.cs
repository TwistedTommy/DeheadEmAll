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
            this.tsslSpring = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.gbSystem = new System.Windows.Forms.GroupBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbLogLevel = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblLogLevel = new System.Windows.Forms.Label();
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
            this.gbSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCommand,
            this.tsmiView});
            resources.ApplyResources(this.msMain, "msMain");
            this.msMain.Name = "msMain";
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
            resources.ApplyResources(this.tsmiCommand, "tsmiCommand");
            // 
            // tsmiDeheaderROMs
            // 
            resources.ApplyResources(this.tsmiDeheaderROMs, "tsmiDeheaderROMs");
            this.tsmiDeheaderROMs.Name = "tsmiDeheaderROMs";
            this.tsmiDeheaderROMs.Click += new System.EventHandler(this.DeheadROMs_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // tsmiLoadOptions
            // 
            resources.ApplyResources(this.tsmiLoadOptions, "tsmiLoadOptions");
            this.tsmiLoadOptions.Name = "tsmiLoadOptions";
            this.tsmiLoadOptions.Click += new System.EventHandler(this.LoadOptions_Click);
            // 
            // tsmiSaveOptions
            // 
            resources.ApplyResources(this.tsmiSaveOptions, "tsmiSaveOptions");
            this.tsmiSaveOptions.Name = "tsmiSaveOptions";
            this.tsmiSaveOptions.Click += new System.EventHandler(this.SaveOptions_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // tsmiSaveLog
            // 
            resources.ApplyResources(this.tsmiSaveLog, "tsmiSaveLog");
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // tsmiExit
            // 
            resources.ApplyResources(this.tsmiExit, "tsmiExit");
            this.tsmiExit.Name = "tsmiExit";
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
            resources.ApplyResources(this.tsmiView, "tsmiView");
            // 
            // tsmiLog
            // 
            this.tsmiLog.Checked = true;
            this.tsmiLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiLog.Name = "tsmiLog";
            resources.ApplyResources(this.tsmiLog, "tsmiLog");
            this.tsmiLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Checked = true;
            this.tsmiOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiOptions.Name = "tsmiOptions";
            resources.ApplyResources(this.tsmiOptions, "tsmiOptions");
            this.tsmiOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            resources.ApplyResources(this.tsmiHelp, "tsmiHelp");
            this.tsmiHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // tsmiLicense
            // 
            this.tsmiLicense.Name = "tsmiLicense";
            resources.ApplyResources(this.tsmiLicense, "tsmiLicense");
            this.tsmiLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // tsmiToolba
            // 
            this.tsmiToolba.Checked = true;
            this.tsmiToolba.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolba.Name = "tsmiToolba";
            resources.ApplyResources(this.tsmiToolba, "tsmiToolba");
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
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.Name = "tsMain";
            // 
            // tsbDeheaderROMs
            // 
            this.tsbDeheaderROMs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbDeheaderROMs, "tsbDeheaderROMs");
            this.tsbDeheaderROMs.Name = "tsbDeheaderROMs";
            this.tsbDeheaderROMs.Click += new System.EventHandler(this.DeheadROMs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsbLoadOptions
            // 
            this.tsbLoadOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbLoadOptions, "tsbLoadOptions");
            this.tsbLoadOptions.Name = "tsbLoadOptions";
            this.tsbLoadOptions.Click += new System.EventHandler(this.LoadOptions_Click);
            // 
            // tsbSaveOptions
            // 
            this.tsbSaveOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbSaveOptions, "tsbSaveOptions");
            this.tsbSaveOptions.Name = "tsbSaveOptions";
            this.tsbSaveOptions.Click += new System.EventHandler(this.SaveOptions_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsbSaveLog
            // 
            this.tsbSaveLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbSaveLog, "tsbSaveLog");
            this.tsbSaveLog.Name = "tsbSaveLog";
            this.tsbSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // tsbViewLog
            // 
            this.tsbViewLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbViewLog, "tsbViewLog");
            this.tsbViewLog.Name = "tsbViewLog";
            this.tsbViewLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // tsbViewOptions
            // 
            this.tsbViewOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbViewOptions, "tsbViewOptions");
            this.tsbViewOptions.Name = "tsbViewOptions";
            this.tsbViewOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // tsbViewHelp
            // 
            this.tsbViewHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbViewHelp, "tsbViewHelp");
            this.tsbViewHelp.Name = "tsbViewHelp";
            this.tsbViewHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsbViewLicense
            // 
            this.tsbViewLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbViewLicense, "tsbViewLicense");
            this.tsbViewLicense.Name = "tsbViewLicense";
            this.tsbViewLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tsbViewToolbar
            // 
            this.tsbViewToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbViewToolbar, "tsbViewToolbar");
            this.tsbViewToolbar.Name = "tsbViewToolbar";
            this.tsbViewToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbCancel,
            this.tspbDeheaderProgress,
            this.tsslStatusMessage,
            this.tsslSpring});
            resources.ApplyResources(this.ssMain, "ssMain");
            this.ssMain.Name = "ssMain";
            // 
            // tsddbCancel
            // 
            this.tsddbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsddbCancel, "tsddbCancel");
            this.tsddbCancel.Image = global::DeheadEmAll_GUI.Properties.Resources.Cancel_16x16;
            this.tsddbCancel.Name = "tsddbCancel";
            this.tsddbCancel.ShowDropDownArrow = false;
            this.tsddbCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tspbDeheaderProgress
            // 
            this.tspbDeheaderProgress.Name = "tspbDeheaderProgress";
            resources.ApplyResources(this.tspbDeheaderProgress, "tspbDeheaderProgress");
            // 
            // tsslStatusMessage
            // 
            this.tsslStatusMessage.Name = "tsslStatusMessage";
            resources.ApplyResources(this.tsslStatusMessage, "tsslStatusMessage");
            // 
            // tsslSpring
            // 
            this.tsslSpring.Name = "tsslSpring";
            resources.ApplyResources(this.tsslSpring, "tsslSpring");
            this.tsslSpring.Spring = true;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabOptions);
            this.tcMain.Controls.Add(this.tabHelp);
            this.tcMain.Controls.Add(this.tabLicense);
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtblLog);
            resources.ApplyResources(this.tabLog, "tabLog");
            this.tabLog.Name = "tabLog";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // rtblLog
            // 
            resources.ApplyResources(this.rtblLog, "rtblLog");
            this.rtblLog.Name = "rtblLog";
            this.rtblLog.ReadOnly = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.gbSystem);
            this.tabOptions.Controls.Add(this.gbROMs);
            this.tabOptions.Controls.Add(this.gbPaths);
            resources.ApplyResources(this.tabOptions, "tabOptions");
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // gbROMs
            // 
            resources.ApplyResources(this.gbROMs, "gbROMs");
            this.gbROMs.Controls.Add(this.chkA7800);
            this.gbROMs.Controls.Add(this.chkLynx);
            this.gbROMs.Controls.Add(this.chkNES);
            this.gbROMs.Controls.Add(this.chkFDS);
            this.gbROMs.Name = "gbROMs";
            this.gbROMs.TabStop = false;
            // 
            // chkA7800
            // 
            resources.ApplyResources(this.chkA7800, "chkA7800");
            this.chkA7800.Checked = true;
            this.chkA7800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkA7800.Name = "chkA7800";
            this.chkA7800.UseVisualStyleBackColor = true;
            // 
            // chkLynx
            // 
            resources.ApplyResources(this.chkLynx, "chkLynx");
            this.chkLynx.Checked = true;
            this.chkLynx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLynx.Name = "chkLynx";
            this.chkLynx.UseVisualStyleBackColor = true;
            // 
            // chkNES
            // 
            resources.ApplyResources(this.chkNES, "chkNES");
            this.chkNES.Checked = true;
            this.chkNES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNES.Name = "chkNES";
            this.chkNES.UseVisualStyleBackColor = true;
            // 
            // chkFDS
            // 
            resources.ApplyResources(this.chkFDS, "chkFDS");
            this.chkFDS.Checked = true;
            this.chkFDS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFDS.Name = "chkFDS";
            this.chkFDS.UseVisualStyleBackColor = true;
            // 
            // gbPaths
            // 
            resources.ApplyResources(this.gbPaths, "gbPaths");
            this.gbPaths.Controls.Add(this.txtPathROMsDeheaderedDir);
            this.gbPaths.Controls.Add(this.txtPathROMsDir);
            this.gbPaths.Controls.Add(this.lblROMsDeheaderedDir);
            this.gbPaths.Controls.Add(this.lblROMsDir);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.TabStop = false;
            // 
            // txtPathROMsDeheaderedDir
            // 
            resources.ApplyResources(this.txtPathROMsDeheaderedDir, "txtPathROMsDeheaderedDir");
            this.txtPathROMsDeheaderedDir.Name = "txtPathROMsDeheaderedDir";
            this.txtPathROMsDeheaderedDir.ReadOnly = true;
            this.txtPathROMsDeheaderedDir.Click += new System.EventHandler(this.ChangeROMsDeheaderedDir_Click);
            // 
            // txtPathROMsDir
            // 
            resources.ApplyResources(this.txtPathROMsDir, "txtPathROMsDir");
            this.txtPathROMsDir.Name = "txtPathROMsDir";
            this.txtPathROMsDir.ReadOnly = true;
            this.txtPathROMsDir.Click += new System.EventHandler(this.ChangeROMsDir_Click);
            // 
            // lblROMsDeheaderedDir
            // 
            resources.ApplyResources(this.lblROMsDeheaderedDir, "lblROMsDeheaderedDir");
            this.lblROMsDeheaderedDir.Name = "lblROMsDeheaderedDir";
            // 
            // lblROMsDir
            // 
            resources.ApplyResources(this.lblROMsDir, "lblROMsDir");
            this.lblROMsDir.Name = "lblROMsDir";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.rtbHelp);
            resources.ApplyResources(this.tabHelp, "tabHelp");
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // rtbHelp
            // 
            resources.ApplyResources(this.rtbHelp, "rtbHelp");
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.rtbLicense);
            resources.ApplyResources(this.tabLicense, "tabLicense");
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // rtbLicense
            // 
            resources.ApplyResources(this.rtbLicense, "rtbLicense");
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
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
            // gbSystem
            // 
            resources.ApplyResources(this.gbSystem, "gbSystem");
            this.gbSystem.Controls.Add(this.lblLogLevel);
            this.gbSystem.Controls.Add(this.lblLanguage);
            this.gbSystem.Controls.Add(this.cbLogLevel);
            this.gbSystem.Controls.Add(this.cbLanguage);
            this.gbSystem.Name = "gbSystem";
            this.gbSystem.TabStop = false;
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items")});
            this.cbLanguage.Name = "cbLanguage";
            // 
            // cbLogLevel
            // 
            resources.ApplyResources(this.cbLogLevel, "cbLogLevel");
            this.cbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogLevel.FormattingEnabled = true;
            this.cbLogLevel.Items.AddRange(new object[] {
            resources.GetString("cbLogLevel.Items")});
            this.cbLogLevel.Name = "cbLogLevel";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // lblLogLevel
            // 
            resources.ApplyResources(this.lblLogLevel, "lblLogLevel");
            this.lblLogLevel.Name = "lblLogLevel";
            // 
            // FrmDeheadEmAll
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmDeheadEmAll";
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
            this.gbSystem.ResumeLayout(false);
            this.gbSystem.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel tsslSpring;
        private Serilog.Sinks.LogEmAll.RichTextBoxLog rtblLog;
        private System.Windows.Forms.ToolStripProgressBar tspbDeheaderProgress;
        private System.Windows.Forms.GroupBox gbSystem;
        private System.Windows.Forms.Label lblLogLevel;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbLogLevel;
        private System.Windows.Forms.ComboBox cbLanguage;
    }
}

