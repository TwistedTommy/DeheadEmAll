using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Serilog;

namespace DeheadEmAll_GUI
{
    /// <summary>
    /// The DeheadEmAll Class which interacts with the Main Program Class.
    /// </summary>
    public partial class FrmDeheadEmAll : Form
    {
        #region Constructors

        DeheadEmAll.DeheadEmAll DHEA = new DeheadEmAll.DeheadEmAll();

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmDeheadEmAll()
        {
            InitializeComponent();

            // Print the version.
            DHEA.PrintVersion();

            // Load the options passed from the command line arguments.
            DHEA.LoadOptionsFromCLI(Environment.GetCommandLineArgs());

            // Load the options passed from the default options file.
            DHEA.LoadOptionsFromFile();

            // Add data bindings.
            chkA7800.DataBindings.Add("Checked", DHEA, "A7800");
            chkNES.DataBindings.Add("Checked", DHEA, "NES");
            chkLynx.DataBindings.Add("Checked", DHEA, "Lynx");
            chkFDS.DataBindings.Add("Checked", DHEA, "FDS");
            txtPathROMsDir.DataBindings.Add("Text", DHEA, "PathROMsDir");
            txtPathROMsDeheaderedDir.DataBindings.Add("Text", DHEA, "PathROMsDeheadedDir");
            cbLanguage.DataBindings.Add("SelectedItem", DHEA, "Language");
            cbLogLevel.DataBindings.Add("SelectedItem", DHEA, "LogLevel");

            // Update the title.
            UpdateTitle();

            // Hide the Help and License tabs.
            tcMain.TabPages.Remove(tabHelp);
            tcMain.TabPages.Remove(tabLicense);

            // Load the GUI RichTextBoxes from resources.
            rtbHelp.Text = DeheadEmAll.Properties.Resources.DeheadEmAll_HELP;
            rtbLicense.Text = DeheadEmAll.Properties.Resources.DeheadEmAll_LICENSE;
        }

        #endregion

        #region Getters/Setters Public Accessors

        /// LogLines
        public string[] LogLines
        {
            get { return rtblLog.Lines; }
            set { rtblLog.Lines = value; }
        }

        #endregion

        #region Log

        /// <summary>
        /// Saves the log to a text file.
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        private bool SaveLogToFile(string strPath = null)
        {
            try
            {
                if (strPath != null)
                {
                    DHEA.PathLogFile = strPath;
                }

                // Determine if the user selected a log filename.
                if (DHEA.PathLogFile.Length == 0)
                {
                    // Return a bool value.
                    return false;
                }
                else
                {
                    // Print to screen
                    Log.Information("Saving log file ...");

                    // Create log file directory if it doesn't exist.
                    if (Directory.Exists(Path.GetDirectoryName(DHEA.PathLogFile)) == false) Directory.CreateDirectory(Path.GetDirectoryName(DHEA.PathLogFile));

                    // Save the contents of the log to a text file.
                    File.WriteAllLines(DHEA.PathLogFile, LogLines);

                    // Print to screen
                    Log.Information("Log file saved (" + DHEA.PathLogFile + ")");

                    // Return a bool value.
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Saving log file failed");
                Log.Error(ex.Message);

                // Return a bool value.
                return false;
            }
        }

        #endregion

        #region Startup Tasks

        /// <summary>
        /// Performs the startup tasks BGW DoWork.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Run startup tasks.
            DHEA.StartupTasks();
        }

        /// <summary>
        /// Startup tasks BGW RunWorkerCompleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Log.Warning("Startup tasks canceled");
                Log.Information("Ready");
            }
            else if (e.Error != null)
            {
                Log.Error("Startup tasks failed");
                Log.Error(e.Error.Message);
                Log.Information("Ready");
            }
            else
            {
                Log.Information("Ready");
            }

            // Update the status message label.
            UpdateStatusMessage("Ready");

            // Enable buttons.
            EnableAllButtons();
        }

        #endregion

        #region GUI Methods

        /// <summary>
        /// Changes the path to the ROMs directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeROMsDir_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Create and initialize a FolderBrowserDialog for the ROMs directory.
            FolderBrowserDialog fbdPathRomsDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a path to the ROMs directory: ",
                SelectedPath = Path.GetFullPath(DHEA.PathROMsDir)
            };

            // Determine if the user selected a folder name from the FolderBrowserDialog.
            if (fbdPathRomsDir.ShowDialog() == DialogResult.OK)
            {
                // Set both variables for compatibility for Windows .Net and Mono.
                this.DHEA.PathROMsDir = fbdPathRomsDir.SelectedPath;
                txtPathROMsDir.Text = fbdPathRomsDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdPathRomsDir.Dispose();

            // Enable all buttons.
            EnableAllButtons();
        }

        /// <summary>
        /// Changes the path to the ROMs deheadered directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeROMsDeheaderedDir_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Create and initialize a FolderBrowserDialog for the ROMs deheadered directory.
            FolderBrowserDialog fbdPathRomsDeheadedDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a path to the ROMs deheadered directory: ",
                SelectedPath = Path.GetFullPath(DHEA.PathROMsDeheadedDir)
            };

            // Determine if the user selected a folder name from the FolderBrowserDialog.
            if (fbdPathRomsDeheadedDir.ShowDialog() == DialogResult.OK)
            {
                // Set both variables for compatibility for Windows .Net and Mono.
                this.DHEA.PathROMsDeheadedDir = fbdPathRomsDeheadedDir.SelectedPath;
                txtPathROMsDeheaderedDir.Text = fbdPathRomsDeheadedDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdPathRomsDeheadedDir.Dispose();

            // Enable all buttons.
            EnableAllButtons();
        }

        /// <summary>
        /// Cancels the current backgroundworker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (bgwDeheaderROMs.WorkerSupportsCancellation == true)
            {
                // Print to screen
                Log.Information("Cancellation pending after current operation ...");

                // Update the status message label.
                UpdateStatusMessage("Cancellation Pending ...");

                // Disable the cancel button.
                tsddbCancel.Enabled = false;

                // Cancel the asynchronous operation.
                bgwDeheaderROMs.CancelAsync();
            }
        }

        /// <summary>
        /// Loads an options file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadOptions_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize an OpenFileDialog for the options file.
                OpenFileDialog ofdOptions = new OpenFileDialog
                {
                    DefaultExt = "*.xml",
                    Filter = "XML Files|*.xml",
                    Title = "Please enter a path to the options file: ",
                    InitialDirectory = Path.GetDirectoryName(DHEA.PathOptionsFile)
                };

                // Determine if the user selected a file name from the OpenFileDialog.
                if (ofdOptions.ShowDialog() == DialogResult.OK && ofdOptions.FileName.Length > 0)
                {
                    // Set the options file path.
                    DHEA.PathOptionsFile = ofdOptions.FileName;

                    // Select the Log tab.
                    if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

                    // Load the options.
                    DHEA.LoadOptionsFromFile();

                    // Print to screen
                    Log.Information("Ready");
                }

                // Dispose of the OpenFileDialog.
                ofdOptions.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Loading options failed");
                Log.Error(ex.Message);
                Log.Information("Ready");
            }
        }

        /// <summary>
        /// Saves an options file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveOptions_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize a SaveFileDialog for the options file.
                SaveFileDialog sfdOptions = new SaveFileDialog
                {
                    DefaultExt = "*.xml",
                    Filter = "XML Files|*.xml",
                    FileName = "Options - DeheadEmAll.xml",
                    Title = "Please enter a path to the options file: ",
                    InitialDirectory = Path.GetDirectoryName(DHEA.PathOptionsFile)
                };

                // Determine if the user selected a file name from the SaveFileDialog.
                if (sfdOptions.ShowDialog() == DialogResult.OK && sfdOptions.FileName.Length > 0)
                {
                    // Set the options file path.
                    DHEA.PathOptionsFile = sfdOptions.FileName;

                    // Select the Log tab.
                    if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

                    // Save the options.
                    DHEA.SaveOptionsToFile();

                    // Print to screen
                    Log.Information("Ready");
                }

                // Dispose of the SaveFileDialog.
                sfdOptions.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Saving options failed");
                Log.Error(ex.Message);
                Log.Information("Ready");
            }
        }

        /// <summary>
        /// Saves a log file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize a SaveFileDialog for the log file.
                SaveFileDialog sfdLog = new SaveFileDialog
                {
                    DefaultExt = "*.txt",
                    Filter = "TXT Files|*.txt",
                    FileName = "DeheadEmAll-Log-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
                    Title = "Please enter a path to the log file: ",
                    InitialDirectory = Path.Combine(Application.StartupPath, "Logs")
                };

                // Determine if the user selected a log filename.
                if (sfdLog.ShowDialog() == DialogResult.OK && sfdLog.FileName.Length > 0)
                {
                    // Set the log file path.
                    DHEA.PathLogFile = sfdLog.FileName;

                    // Select the Log tab.
                    if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

                    // Save the log.
                    SaveLogToFile(DHEA.PathLogFile);

                    // Print to screen
                    Log.Information("Ready");
                }

                // Dispose of the SaveFileDialog.
                sfdLog.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Saving log file failed");
                Log.Error(ex.Message);
                Log.Information("Ready");
            }
        }

        /// <summary>
        /// Toggles the visibility of the log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewLog_Click(object sender, EventArgs e)
        {
            if (tsmiLog.Checked)
            {
                tsmiLog.Checked = false;
                tcMain.TabPages.Remove(tabLog);
            }
            else
            {
                tsmiLog.Checked = true;
                tcMain.TabPages.Add(tabLog);
                tcMain.SelectTab(tabLog);
            }
        }

        /// <summary>
        /// Toggles the visibility of the options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewOptions_Click(object sender, EventArgs e)
        {
            if (tsmiOptions.Checked)
            {
                tsmiOptions.Checked = false;
                tcMain.TabPages.Remove(tabOptions);
            }
            else
            {
                tsmiOptions.Checked = true;
                tcMain.TabPages.Add(tabOptions);
                tcMain.SelectTab(tabOptions);
            }
        }

        /// <summary>
        /// Toggles the visibility of the help.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHelp_Click(object sender, EventArgs e)
        {
            if (tsmiHelp.Checked)
            {
                tsmiHelp.Checked = false;
                tcMain.TabPages.Remove(tabHelp);
            }
            else
            {
                tsmiHelp.Checked = true;
                tcMain.TabPages.Add(tabHelp);
                tcMain.SelectTab(tabHelp);
            }
        }

        /// <summary>
        /// Toggles the visibility of the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewLicense_Click(object sender, EventArgs e)
        {
            if (tsmiLicense.Checked)
            {
                tsmiLicense.Checked = false;
                tcMain.TabPages.Remove(tabLicense);
            }
            else
            {
                tsmiLicense.Checked = true;
                tcMain.TabPages.Add(tabLicense);
                tcMain.SelectTab(tabLicense);
            }
        }

        /// <summary>
        /// Toggles the visibility of the toolbar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewToolbar_Click(object sender, EventArgs e)
        {
            if (tsMain.Visible)
            {
                tsMain.Visible = false;
                tsmiToolba.Checked = false;
            }
            else
            {
                tsMain.Visible = true;
                tsmiToolba.Checked = true;
            }
        }

        /// <summary>
        /// After the form is shown, performs the startup tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fprm_Shown(object sender, EventArgs e)
        {
            // Perform the application startup tasks.
            bgwStartupTasks.RunWorkerAsync();
        }

        /// <summary>
        /// Exits the WinForms app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Check some things to make sure it is safe to exit the WinForms application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwDeheaderROMs.IsBusy == true)
            {
                if (MessageBox.Show("The ROMs deheaderer is currently running. Exiting now may cause corrupt or incomplete files! Are you sure you want to exit now?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Enables all of the buttons.
        /// </summary>
        private void EnableAllButtons()
        {
            // Enable all Menu Item buttons.
            tsmiCommand.Enabled = true;
            tsmiExit.Enabled = true;
            tsmiDeheaderROMs.Enabled = true;
            tsmiLoadOptions.Enabled = true;
            tsmiSaveOptions.Enabled = true;
            tsmiSaveLog.Enabled = true;

            // Enable all Toolbar buttons.
            tsbDeheaderROMs.Enabled = true;
            tsbLoadOptions.Enabled = true;
            tsbSaveOptions.Enabled = true;
            tsbSaveLog.Enabled = true;

            // Enable all Options buttons.
            txtPathROMsDir.Enabled = true;
            txtPathROMsDeheaderedDir.Enabled = true;

            // Enable all Options checkboxes.
            chkA7800.Enabled = true;
            chkFDS.Enabled = true;
            chkLynx.Enabled = true;
            chkNES.Enabled = true;
        }

        /// <summary>
        /// Disables all of the buttons.
        /// </summary>
        private void DisableAllButtons()
        {
            // Disable all Menu Item buttons.
            tsmiCommand.Enabled = false;
            tsmiExit.Enabled = false;
            tsmiDeheaderROMs.Enabled = false;
            tsmiLoadOptions.Enabled = false;
            tsmiSaveOptions.Enabled = false;
            tsmiSaveLog.Enabled = false;

            // Disable all Toolbar buttons.
            tsbDeheaderROMs.Enabled = false;
            tsbLoadOptions.Enabled = false;
            tsbSaveOptions.Enabled = false;
            tsbSaveLog.Enabled = false;

            // Disable all Options buttons.
            txtPathROMsDir.Enabled = false;
            txtPathROMsDeheaderedDir.Enabled = false;

            // Disable all Options checkboxes.
            chkA7800.Enabled = false;
            chkFDS.Enabled = false;
            chkLynx.Enabled = false;
            chkNES.Enabled = false;
        }

        /// <summary>
        /// Updates the application title.
        /// </summary>
        /// <param name="strTitle"></param>
        /// <returns></returns>
        public bool UpdateTitle(string strTitle = "")
        {
            try
            {
                if (this.InvokeRequired && !this.IsDisposed)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        // Update the application title.
                        this.Text = DHEA.AppName + " v" + DHEA.AppVersion + strTitle;
                    }));
                }
                else if (!this.IsDisposed)
                {
                    // Update the application title.
                    this.Text = DHEA.AppName + " v" + DHEA.AppVersion + strTitle;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Updates the progress status message label.
        /// </summary>
        /// <param name="strMsg"></param>
        private void UpdateStatusMessage(string strMsg)
        {
            // Update the status message label.
            tsslStatusMessage.Text = strMsg;
        }

        /// <summary>
        /// Updates the deheader progress bar.
        /// </summary>
        /// <param name="intPercentage"></param>
        private void UpdateDeheaderProgress(int intPercentage)
        {
            // Update the build progress status progress bar.
            tspbDeheaderProgress.Value = intPercentage;
        }

        #endregion

        #region Deheader ROMs

        /// <summary>
        /// Deheaders all of the selected ROMs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeheadROMs_Click(object sender, EventArgs e)
        {
            // Select the Log tab.
            if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

            // Disable all buttons.
            DisableAllButtons();

            // Enable the cancel button.
            tsddbCancel.Enabled = true;

            // Change the log background color.
            // rtblLog.BackColor = Color.LightGreen;

            // Update the status message label.
            UpdateStatusMessage("Deheadering ROMs ...");

            // Print to screen
            Log.Information("Deheadering all selected ROMs ...");

            // Deheader ROMs.
            bgwDeheaderROMs.RunWorkerAsync();
        }

        /// <summary>
        /// Deheaders all of the selected ROMs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeheaderROMs_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Declarations
                BackgroundWorker worker = sender as BackgroundWorker;           // Background worker
                int intProgress = 0;                                            // Background worker progress
                int intCountTotalFilesProcessed = 0;                            // Total files processed
                int intCounterTotalDeheaded = 0;                                // Total deheadered counter
                int intCountArrDirFiles = 0;                                    // Total loop count
                string strPathROMsDir = DHEA.PathROMsDir;                       // Path to the ROMs directory
                string strPathROMsDeheadedDir = DHEA.PathROMsDeheadedDir;       // Path to the deheadered ROMs directory

                // Checkers
                bool boolPathROMsDirCheck = DHEA.PathROMsDirCheck();
                bool boolPathROMsDeheadedDirCheck = DHEA.PathROMsDeheadedDirCheck();

                // Check the paths and directories.
                if (boolPathROMsDirCheck != false && boolPathROMsDeheadedDirCheck != false)
                {
                    // Print to screen
                    Log.Information("Options: ROMs Directory (" + strPathROMsDir + ")");
                    Log.Information("Options: ROMsDeheaded Directory (" + strPathROMsDeheadedDir + ")");

                    // Get the directory files array and count.
                    string[] arrDirFiles = Directory.GetFiles(strPathROMsDir, "*.*", SearchOption.AllDirectories);
                    intCountArrDirFiles = arrDirFiles.Count();

                    // Create and start a stopwatch.
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    // Main loop - Deheader all of the ROMs.
                    foreach (string strPathFile in arrDirFiles)
                    {
                        FileInfo fiInputFile = new FileInfo(strPathFile);
                        if ((fiInputFile.Extension == ".fds" || fiInputFile.Extension == ".nes") && (DHEA.FDS == true || DHEA.NES == true) && fiInputFile.Length > 16)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
                            // UpdateStatusMessage("Deheadering " + (intCountTotalFilesProcessed + 1) + " of " + intCountArrDirFiles + " ROMs ...");
                            int intOutputFileLength = (int)(fiInputFile.Length - 16);
                            byte[] arrOutputFileBytes = new byte[intOutputFileLength];
                            using (BinaryReader reader = new BinaryReader(new FileStream(fiInputFile.FullName, FileMode.Open)))
                            {
                                reader.BaseStream.Seek(16, SeekOrigin.Begin);
                                reader.Read(arrOutputFileBytes, 0, intOutputFileLength);
                            }
                            File.WriteAllBytes(Path.Combine(strPathROMsDeheadedDir, fiInputFile.Name), arrOutputFileBytes);
                            intCounterTotalDeheaded++;
                        }
                        else if (fiInputFile.Extension == ".lnx" && DHEA.Lynx == true && fiInputFile.Length > 64)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
                            // UpdateStatusMessage("Deheadering " + (intCountTotalFilesProcessed + 1) + " of " + intCountArrDirFiles + " ROMs ...");
                            int intOutputFileLength = (int)(fiInputFile.Length - 64);
                            byte[] arrOutputFileBytes = new byte[intOutputFileLength];
                            using (BinaryReader reader = new BinaryReader(new FileStream(fiInputFile.FullName, FileMode.Open)))
                            {
                                reader.BaseStream.Seek(64, SeekOrigin.Begin);
                                reader.Read(arrOutputFileBytes, 0, intOutputFileLength);
                            }
                            File.WriteAllBytes(Path.Combine(strPathROMsDeheadedDir, fiInputFile.Name), arrOutputFileBytes);
                            intCounterTotalDeheaded++;
                        }
                        else if (fiInputFile.Extension == ".a78" && DHEA.A7800 == true && fiInputFile.Length > 128)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
                            // UpdateStatusMessage("Deheadering " + (intCountTotalFilesProcessed + 1) + " of " + intCountArrDirFiles + " ROMs ...");
                            int intOutputFileLength = (int)(fiInputFile.Length - 128);
                            byte[] arrOutputFileBytes = new byte[intOutputFileLength];
                            using (BinaryReader reader = new BinaryReader(new FileStream(fiInputFile.FullName, FileMode.Open)))
                            {
                                reader.BaseStream.Seek(128, SeekOrigin.Begin);
                                reader.Read(arrOutputFileBytes, 0, intOutputFileLength);
                            }
                            File.WriteAllBytes(Path.Combine(strPathROMsDeheadedDir, fiInputFile.Name), arrOutputFileBytes);
                            intCounterTotalDeheaded++;
                        }
                        else
                        {
                            Log.Information("Skipping: " + fiInputFile.FullName);
                            // UpdateStatusMessage("Skipping " + (intCountTotalFilesProcessed + 1) + " of " + intCountArrDirFiles + " ROMs ...");
                        }

                        // Increment the progress bar.
                        intCountTotalFilesProcessed++;
                        intProgress = (int)((double)intCountTotalFilesProcessed / (double)intCountArrDirFiles * 100);
                        worker.ReportProgress(intProgress);

                        // Check if the background worker is pending cancellation.
                        if (worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                    }

                    // Stop the stopwatch.
                    stopWatch.Stop();

                    // Print to screen
                    Log.Information("Deheadered " + intCounterTotalDeheaded + " ROMs in " + stopWatch.Elapsed);
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// DeheaderROMs ProgressChanged.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeheaderROMs_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Display the changed progress status.
            UpdateDeheaderProgress(e.ProgressPercentage);
        }

        /// <summary>
        /// DeheaderROMs RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeheaderROMs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Log.Warning("Deheadering all selected ROMs canceled");
                Log.Information("Ready");
            }
            else if (e.Error != null)
            {
                Log.Error("Deheadering all selected ROMs failed");
                Log.Error(e.Error.Message);
                Log.Information("Ready");
            }
            else
            {
                Log.Information("Deheadering all selected ROMs completed");
                Log.Information("Ready");
            }

            // Reset the log background color.
            // rtblLog.BackColor = SystemColors.Control;

            // Reset the progress bar.
            UpdateDeheaderProgress(0);

            // Update the status message label.
            UpdateStatusMessage("Ready");

            // Disable the cancel button.
            tsddbCancel.Enabled = false;

            // Enable all buttons.
            EnableAllButtons();
        }

        #endregion
    }
}
