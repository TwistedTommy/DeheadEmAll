using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Serilog;
using Serilog.Sinks.LogEmAll;

namespace DeheadEmAll
{
    /// <summary>
    /// The DeheadEmAll Class which interacts with the Main Program Class.
    /// </summary>
    public class DeheadEmAll : INotifyPropertyChanged
    {
        #region Constructors

        /// <summary>
        /// DeheadEmAll Constructor
        /// </summary>
        public DeheadEmAll()
        {
            // Construct a DeheadEmAll object.
        }

        #endregion

        #region INotifyPropertyChanged

        /// PropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// NotifyPropertyChanged
        /// </summary>
        /// <param name="pName"></param>
        private void NotifyPropertyChanged(String pName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pName));
        }

        #endregion

        #region Private Members

        // Private members.
        private readonly string _strAppName = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductName;
        private readonly string _strAppVersion = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductVersion;
        private readonly string _strAppCopyright = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).LegalCopyright;
        private string _strCommandSwitch = "-deheadall";
        private string _strPathROMsDir = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ROMs");
        private string _strPathROMsDeheadedDir = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ROMsDeheaded");
        private string _strPathOptionsFile = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Options", "Options - DeheadEmAll.xml");
        private string _strPathLogFile = "";
        private bool _boolNES = true;
        private bool _boolFDS = true;
        private bool _boolLynx = true;
        private bool _boolA7800 = true;
        private ListStringLog _logLines = new ListStringLog();

        #endregion

        #region Getters/Setters Public Accessors

        /// AppName
        public string AppName
        {
            get { return _strAppName; }
            set { }
        }
        /// AppVersion
        public string AppVersion
        {
            get { return _strAppVersion; }
            set { }
        }
        /// AppCopyright
        public string AppCopyright
        {
            get { return _strAppCopyright; }
            set { }
        }
        /// CommandSwitch
        public string CommandSwitch
        {
            get { return _strCommandSwitch; }
            set { _strCommandSwitch = value; }
        }
        /// PathROMsDir
        public string PathROMsDir
        {
            get { return _strPathROMsDir; }
            set { _strPathROMsDir = value; NotifyPropertyChanged("PathROMsDir"); }
        }
        /// PathROMsDeheadedDir
        public string PathROMsDeheadedDir
        {
            get { return _strPathROMsDeheadedDir; }
            set { _strPathROMsDeheadedDir = value; NotifyPropertyChanged("PathROMsDeheadedDir"); }
        }
        /// PathLogFile
        public string PathLogFile
        {
            get { return _strPathLogFile; }
            set { _strPathLogFile = value; }
        }
        /// PathOptionsFile
        public string PathOptionsFile
        {
            get { return _strPathOptionsFile; }
            set { _strPathOptionsFile = value; }
        }
        /// A7800
        public bool A7800
        {
            get { return _boolA7800; }
            set { _boolA7800 = value; NotifyPropertyChanged("A7800"); }
        }
        /// NES
        public bool NES
        {
            get { return _boolNES; }
            set { _boolNES = value; NotifyPropertyChanged("NES"); }
        }
        /// Lynx
        public bool Lynx
        {
            get { return _boolLynx; }
            set { _boolLynx = value; NotifyPropertyChanged("Lynx"); }
        }
        /// FDS
        public bool FDS
        {
            get { return _boolFDS; }
            set { _boolFDS = value; NotifyPropertyChanged("FDS"); }
        }
        /// LogLines
        public ListStringLog LogLines
        {
            get { return _logLines; }
            set { _logLines = value; }
        }

        #endregion

        #region Startup Tasks

        /// <summary>
        /// Performs the startup tasks.
        /// </summary>
        public void StartupTasks()
        {
            // 
        }

        #endregion

        #region Options

        /// <summary>
        /// Loads the options passed from the options file.
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public bool LoadOptionsFromFile(string strPath = null)
        {
            try
            {
                if (strPath != null)
                {
                    PathOptionsFile = strPath;
                }

                if (File.Exists(PathOptionsFile) == true)
                {
                    // Load the options from the XML file.
                    XDocument xdocOptions = XDocument.Load(PathOptionsFile);

                    // Set the variables.
                    if (xdocOptions.Element("Options") == null) { Log.Information("Options file is corrupt or outdated (Options)"); }
                    else
                    {
                        if (xdocOptions.Element("Options").Element("Paths") == null) { Log.Information("Options file is corrupt or outdated (Paths)"); }
                        else
                        {
                            if (xdocOptions.Element("Options").Element("Paths").Element("PathROMsDir") != null && xdocOptions.Element("Options").Element("Paths").Element("PathROMsDir").Value != "") { PathROMsDir = xdocOptions.Element("Options").Element("Paths").Element("PathROMsDir").Value; }
                            else { Log.Information("Options file is corrupt or outdated (PathROMsDir)"); }
                            if (xdocOptions.Element("Options").Element("Paths").Element("PathROMsDeheadedDir") != null && xdocOptions.Element("Options").Element("Paths").Element("PathROMsDeheadedDir").Value != "") { PathROMsDeheadedDir = xdocOptions.Element("Options").Element("Paths").Element("PathROMsDeheadedDir").Value; }
                            else { Log.Information("Options file is corrupt or outdated (PathROMsDeheadedDir)"); }
                        }
                        if (xdocOptions.Element("Options").Element("ROMs") == null) { Log.Information("Options file is corrupt or outdated (ROMs)"); }
                        else
                        {
                            if (xdocOptions.Element("Options").Element("ROMs").Element("A7800") != null) { A7800 = Convert.ToBoolean(xdocOptions.Element("Options").Element("ROMs").Element("A7800").Value); }
                            else { Log.Information("Options file is corrupt or outdated (A7800)"); }
                            if (xdocOptions.Element("Options").Element("ROMs").Element("FDS") != null) { FDS = Convert.ToBoolean(xdocOptions.Element("Options").Element("ROMs").Element("FDS").Value); }
                            else { Log.Information("Options file is corrupt or outdated (FDS)"); }
                            if (xdocOptions.Element("Options").Element("ROMs").Element("NES") != null) { NES = Convert.ToBoolean(xdocOptions.Element("Options").Element("ROMs").Element("NES").Value); }
                            else { Log.Information("Options file is corrupt or outdated (NES)"); }
                            if (xdocOptions.Element("Options").Element("ROMs").Element("Lynx") != null) { Lynx = Convert.ToBoolean(xdocOptions.Element("Options").Element("ROMs").Element("Lynx").Value); }
                            else { Log.Information("Options file is corrupt or outdated (Lynx)"); }
                        }
                    }

                    // Print to screen
                    Log.Information("Options file loaded (" + PathOptionsFile + ")");

                    // Return a bool value.
                    return true;
                }
                else
                {
                    // Print to screen
                    Log.Information("Options file was not found");

                    // Return a bool value.
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Loading options file failed");
                Log.Error("Error: " + ex.Message);

                // Return a bool value.
                return false;
            }
        }

        /// <summary>
        /// Loads the options passed from the command line.
        /// </summary>
        /// <param name="strArgs"></param>
        public void LoadOptionsFromCLI(string[] strArgs)
        {
            try
            {
                foreach (string strArg in strArgs)
                {
                    if (Regex.IsMatch(strArg, "^-", RegexOptions.IgnoreCase) == true)
                    {
                        // Set the command switch.
                        CommandSwitch = strArg;
                    }
                    if (Regex.IsMatch(strArg, "^RD:", RegexOptions.IgnoreCase) == true)
                    {
                        // Set the path to the ROMs directory.
                        PathROMsDir = strArg.Substring(3);
                    }
                    if (Regex.IsMatch(strArg, "^RE:", RegexOptions.IgnoreCase) == true)
                    {
                        // Set the path to the deheadered ROMs directory.
                        PathROMsDeheadedDir = strArg.Substring(3);
                    }
                    if (Regex.IsMatch(strArg, "^LF:", RegexOptions.IgnoreCase) == true)
                    {
                        // Set the path to the log file.
                        PathLogFile = strArg.Substring(3);
                    }
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Setting options from CLI failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Saves a new options file.
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public bool SaveOptionsToFile(string strPath = null)
        {
            try
            {
                if (strPath != null)
                {
                    PathOptionsFile = strPath;
                }

                // Print to screen
                Log.Information("Saving options file ...");

                // Create a new options XDocument.
                XDocument xdocOptions = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("This is a DeheadEmAll options file"),
                    new XComment("WARNING: Using invalid values might cause this app to crash!"),
                    new XElement("Options",
                        new XAttribute("Version", AppVersion),
                        new XElement("Paths",
                            new XElement("PathROMsDir", PathROMsDir),
                            new XElement("PathROMsDeheadedDir", PathROMsDeheadedDir)
                        ),
                        new XElement("ROMs",
                            new XElement("A7800", A7800),
                            new XElement("FDS", FDS),
                            new XElement("NES", NES),
                            new XElement("Lynx", Lynx)
                        )
                    )
                );

                // Create options file directory if it doesn't exist.
                if (Directory.Exists(Path.GetDirectoryName(PathOptionsFile)) == false) Directory.CreateDirectory(Path.GetDirectoryName(PathOptionsFile));

                // Save the contents of the options XDocument to the file.
                xdocOptions.Save(PathOptionsFile);

                // Print to screen
                Log.Information("Options file saved (" + PathOptionsFile + ")");

                // Return a bool value.
                return true;
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Information("Saving options to file failed");
                Log.Information(ex.Message);

                // Return a bool value.
                return false;
            }
        }

        #endregion

        #region Log

        /// <summary>
        /// Saves the log to a text file.
        /// </summary>
        public void SaveLogToFile()
        {
            try
            {
                // Determine if the user selected a log filename.
                if (PathLogFile.Length > 0)
                {
                    // Get the log file directory name.
                    FileInfo fi = new FileInfo(PathLogFile);

                    // Create log file directory if it doesn't exist.
                    if (Directory.Exists(fi.DirectoryName) == false) Directory.CreateDirectory(fi.DirectoryName);

                    // Save the contents of the log to a text file.
                    File.WriteAllLines(PathLogFile, LogLines);

                    // Print to screen
                    Log.Information("Log file saved (" + PathLogFile + ")");
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Saving log file failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        #endregion

        #region CLI Commands

        /// <summary>
        /// Updates the application title.
        /// </summary>
        /// <param name="strTitle"></param>
        /// <returns></returns>
        public bool UpdateTitle(string strTitle = "")
        {
            try
            {
                Console.Title = AppName + " v" + AppVersion + strTitle;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Processes the command switch.
        /// </summary>
        public void ProcessCommandSwitch()
        {
            switch (CommandSwitch)
            {
                case "-deheadall":
                    StartupTasks();                     // Check and set the activation and options variables from the WWW.
                    DeheaderFDSROMs();                  // Deheader all FDS ROMs.
                    DeheaderNESROMs();                  // Deheader all NES ROMs.
                    DeheaderA7800ROMs();                // Deheader all A7800 ROMs.
                    DeheaderLynxROMs();                 // Deheader all Lynx ROMs.
                    break;
                case "-deheadallselected":
                    StartupTasks();                     // Check and set the activation and options variables from the WWW.
                    DeheaderAllSelectedROMs();            // Deheader all selected FDS/NES/A7800/Lynx ROMs in the options file.
                    break;
                case "-deheadfds":
                    StartupTasks();                     // Check and set the activation and options variables from the WWW.
                    DeheaderFDSROMs();                  // Deheader all FDS ROMs.
                    break;
                case "-deheadnes":
                    StartupTasks();                     // Check and set the activation and options variables from the WWW.
                    DeheaderNESROMs();                  // Deheader all NES ROMs.
                    break;
                case "-deheada7800":
                    StartupTasks();                     // Check and set the activation and options variables from the WWW.
                    DeheaderA7800ROMs();                // Deheader all A7800 ROMs.
                    break;
                case "-deheadlynx":
                    StartupTasks();                     // Check and set the activation and options variables from the WWW.
                    DeheaderLynxROMs();                 // Deheader all Lynx ROMs.
                    break;
                case "-saveoptions":
                    SaveOptionsToFile();                // Saves a new default options file.
                    break;
                case "-license":
                    PrintLicense();                     // Print the license text.
                    break;
                case "-version":
                    // Do nothing.		                // Do nothing.
                    break;
                default:
                    PrintHelp();                        // Print the help text.
                    break;
            }
        }

        #endregion

        #region Checkers

        /// <summary>
        /// Checks the ROMs directory path.
        /// </summary>
        /// <returns></returns>
        public bool PathROMsDirCheck()
        {
            // Check if the directory exists.
            if (Directory.Exists(PathROMsDir) == true)
            {
                // Print to screen and set the return value.
                Log.Debug("The ROMs directory path does exist (" + PathROMsDir + ")");
                return true;
            }
            else
            {
                // Print to screen and set the return value.
                Log.Information("The ROMs directory path does not exist (" + PathROMsDir + ")");
                return false;
            }
        }

        /// <summary>
        /// Checks the deheadered ROMs directory path.
        /// </summary>
        /// <returns></returns>
        public bool PathROMsDeheadedDirCheck()
        {
            // Check if the directory exists.
            if (Directory.Exists(PathROMsDeheadedDir) == true)
            {
                // Print to screen and set the return value.
                Log.Debug("The deheadered ROMs directory path does exist (" + PathROMsDeheadedDir + ")");
                return true;
            }
            else
            {
                // Print to screen and set the return value.
                Log.Information("The deheadered ROMs directory path does not exist (" + PathROMsDeheadedDir + ")");
                return false;
            }
        }

        #endregion

        #region ROM Deheaderers

        /// <summary>
        /// Deheaders all selected ROMs.
        /// </summary>
        public void DeheaderAllSelectedROMs()
        {
            try
            {
                // Print to screen
                Log.Information("Deheadering all selected ROMs ...");

                // Declarations
                int intCounterTotalDeheaded = 0;                                            // Total deheadered counter
                int intCountArrDirFiles = 0;                                                // Total loop count
                string strPathROMsDir = PathROMsDir;                                        // Path to the ROMs directory
                string strPathROMsDeheadedDir = PathROMsDeheadedDir;                        // Path to the deheadered ROMs directory

                // Checkers
                bool boolPathROMsDirCheck = PathROMsDirCheck();
                bool boolPathROMsDeheadedDirCheck = PathROMsDeheadedDirCheck();

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
                        if ((fiInputFile.Extension == ".fds" || fiInputFile.Extension == ".nes") && (FDS == true || NES == true) && fiInputFile.Length > 16)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                        else if (fiInputFile.Extension == ".lnx" && Lynx == true && fiInputFile.Length > 64)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                        else if (fiInputFile.Extension == ".a78" && A7800 == true && fiInputFile.Length > 128)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                    }

                    // Stop the stopwatch.
                    stopWatch.Stop();

                    // Print to screen
                    Log.Information("Deheadered " + intCounterTotalDeheaded + " ROMs in " + stopWatch.Elapsed);
                }

                // Print to screen
                Log.Information("Deheadering all selected ROMs completed");
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Deheadering all selected ROMs failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Deheaders all possible FDS ROMs.
        /// </summary>
        public void DeheaderFDSROMs()
        {
            try
            {
                // Print to screen
                Log.Information("Deheadering all possible FDS ROMs ...");

                // Declarations
                int intCounterTotalDeheaded = 0;                                            // Total deheadered counter
                int intCountArrDirFiles = 0;                                                // Total loop count
                string strPathROMsDir = PathROMsDir;                                        // Path to the ROMs directory
                string strPathROMsDeheadedDir = PathROMsDeheadedDir;                        // Path to the deheadered ROMs directory

                // Checkers
                bool boolPathROMsDirCheck = PathROMsDirCheck();
                bool boolPathROMsDeheadedDirCheck = PathROMsDeheadedDirCheck();

                // Check the paths and directories.
                if (boolPathROMsDirCheck != false && boolPathROMsDeheadedDirCheck != false)
                {
                    // Print to screen
                    Log.Information("Options: ROMs Directory (" + strPathROMsDir + ")");
                    Log.Information("Options: ROMsDeheaded Directory (" + strPathROMsDeheadedDir + ")");

                    // Get the directory files array and count.
                    string[] arrDirFiles = Directory.GetFiles(strPathROMsDir, "*.fds", SearchOption.AllDirectories);
                    intCountArrDirFiles = arrDirFiles.Count();

                    // Create and start a stopwatch.
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    // Main loop - Deheader all of the ROMs.
                    foreach (string strPathFile in arrDirFiles)
                    {
                        FileInfo fiInputFile = new FileInfo(strPathFile);
                        if (fiInputFile.Length > 16)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                    }

                    // Stop the stopwatch.
                    stopWatch.Stop();

                    // Print to screen
                    Log.Information("Deheadered " + intCounterTotalDeheaded + " ROMs in " + stopWatch.Elapsed);
                }

                // Print to screen
                Log.Information("Deheadering all possible FDS ROMs completed");
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Deheadering all possible FDS ROMs failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Deheaders all possible NES ROMs.
        /// </summary>
        public void DeheaderNESROMs()
        {
            try
            {
                // Print to screen
                Log.Information("Deheadering all possible NES ROMs ...");

                // Declarations
                int intCounterTotalDeheaded = 0;                                            // Total deheadered counter
                int intCountArrDirFiles = 0;                                                // Total loop count
                string strPathROMsDir = PathROMsDir;                                        // Path to the ROMs directory
                string strPathROMsDeheadedDir = PathROMsDeheadedDir;                        // Path to the deheadered ROMs directory

                // Checkers
                bool boolPathROMsDirCheck = PathROMsDirCheck();
                bool boolPathROMsDeheadedDirCheck = PathROMsDeheadedDirCheck();

                // Check the paths and directories.
                if (boolPathROMsDirCheck != false && boolPathROMsDeheadedDirCheck != false)
                {
                    // Print to screen
                    Log.Information("Options: ROMs Directory (" + strPathROMsDir + ")");
                    Log.Information("Options: ROMsDeheaded Directory (" + strPathROMsDeheadedDir + ")");

                    // Get the directory files array and count.
                    string[] arrDirFiles = Directory.GetFiles(strPathROMsDir, "*.nes", SearchOption.AllDirectories);
                    intCountArrDirFiles = arrDirFiles.Count();

                    // Create and start a stopwatch.
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    // Main loop - Deheader all of the ROMs.
                    foreach (string strPathFile in arrDirFiles)
                    {
                        FileInfo fiInputFile = new FileInfo(strPathFile);
                        if (fiInputFile.Length > 16)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                    }

                    // Stop the stopwatch.
                    stopWatch.Stop();

                    // Print to screen
                    Log.Information("Deheadered " + intCounterTotalDeheaded + " ROMs in " + stopWatch.Elapsed);
                }

                // Print to screen
                Log.Information("Deheadering all possible NES ROMs completed");
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Deheadering all possible NES ROMs failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Deheaders all possible A7800 ROMs.
        /// </summary>
        public void DeheaderA7800ROMs()
        {
            try
            {
                // Print to screen
                Log.Information("Deheadering all possible 7800 ROMs ...");

                // Declarations
                int intCounterTotalDeheaded = 0;                                            // Total deheadered counter
                int intCountArrDirFiles = 0;                                                // Total loop count
                string strPathROMsDir = PathROMsDir;                                        // Path to the ROMs directory
                string strPathROMsDeheadedDir = PathROMsDeheadedDir;                        // Path to the deheadered ROMs directory

                // Checkers
                bool boolPathROMsDirCheck = PathROMsDirCheck();
                bool boolPathROMsDeheadedDirCheck = PathROMsDeheadedDirCheck();

                // Check the paths and directories.
                if (boolPathROMsDirCheck != false && boolPathROMsDeheadedDirCheck != false)
                {
                    // Print to screen
                    Log.Information("Options: ROMs Directory (" + strPathROMsDir + ")");
                    Log.Information("Options: ROMsDeheaded Directory (" + strPathROMsDeheadedDir + ")");

                    // Get the directory files array and count.
                    string[] arrDirFiles = Directory.GetFiles(strPathROMsDir, "*.a78", SearchOption.AllDirectories);
                    intCountArrDirFiles = arrDirFiles.Count();

                    // Create and start a stopwatch.
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    // Main loop - Deheader all of the ROMs.
                    foreach (string strPathFile in arrDirFiles)
                    {
                        FileInfo fiInputFile = new FileInfo(strPathFile);
                        if (fiInputFile.Length > 128)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                    }

                    // Stop the stopwatch.
                    stopWatch.Stop();

                    // Print to screen
                    Log.Information("Deheadered " + intCounterTotalDeheaded + " ROMs in " + stopWatch.Elapsed);
                }

                // Print to screen
                Log.Information("Deheadering all possible 7800 ROMs completed");
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Deheadering all possible 7800 ROMs failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Deheaders all possible Lynx ROMs.
        /// </summary>
        public void DeheaderLynxROMs()
        {
            try
            {
                // Print to screen
                Log.Information("Deheadering all possible Lynx ROMs ...");

                // Declarations
                int intCounterTotalDeheaded = 0;                                            // Total deheadered counter
                int intCountArrDirFiles = 0;                                                // Total loop count
                string strPathROMsDir = PathROMsDir;                                        // Path to the ROMs directory
                string strPathROMsDeheadedDir = PathROMsDeheadedDir;                        // Path to the deheadered ROMs directory

                // Checkers
                bool boolPathROMsDirCheck = PathROMsDirCheck();
                bool boolPathROMsDeheadedDirCheck = PathROMsDeheadedDirCheck();

                // Check the paths and directories.
                if (boolPathROMsDirCheck != false && boolPathROMsDeheadedDirCheck != false)
                {
                    // Print to screen
                    Log.Information("Options: ROMs Directory (" + strPathROMsDir + ")");
                    Log.Information("Options: ROMsDeheaded Directory (" + strPathROMsDeheadedDir + ")");

                    // Get the directory files array and count.
                    string[] arrDirFiles = Directory.GetFiles(strPathROMsDir, "*.lnx", SearchOption.AllDirectories);
                    intCountArrDirFiles = arrDirFiles.Count();

                    // Create and start a stopwatch.
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    // Main loop - Deheader all of the ROMs.
                    foreach (string strPathFile in arrDirFiles)
                    {
                        FileInfo fiInputFile = new FileInfo(strPathFile);
                        if (fiInputFile.Length > 64)
                        {
                            Log.Information("Deheadering: " + fiInputFile.FullName);
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
                    }

                    // Stop the stopwatch.
                    stopWatch.Stop();

                    // Print to screen
                    Log.Information("Deheadered " + intCounterTotalDeheaded + " ROMs in " + stopWatch.Elapsed);
                }

                // Print to screen
                Log.Information("Deheadering all possible Lynx ROMs completed");
            }
            catch (Exception ex)
            {
                // Print to screen
                Log.Error("Error: Deheadering all possible Lynx ROMs failed");
                Log.Error("Error: " + ex.Message);
            }
        }

        #endregion

        #region Printers

        /// <summary>
        /// EnumerateLines
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public IEnumerable<string> EnumerateLines(TextReader reader)
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }

        /// <summary>
        /// ReadAllResourceLines
        /// </summary>
        /// <param name="resourceText"></param>
        /// <returns></returns>
        public string[] ReadAllResourceLines(string resourceText)
        {
            using (StringReader reader = new StringReader(resourceText))
            {
                return EnumerateLines(reader).ToArray();
            }
        }

        /// <summary>
        /// Prints the help text.
        /// </summary>
        public void PrintHelp()
        {
            // Read all of the lines of the file into an array.
            string[] arrLines = ReadAllResourceLines(Properties.Resources.DeheadEmAll_HELP_CMD);

            // Loop through each line of the array.
            foreach (string strLine in arrLines)
            {
                // Print to screen.
                Log.Information(strLine);
            }
        }

        /// <summary>
        /// Prints the license text.
        /// </summary>
        public void PrintLicense()
        {
            // Read all of the lines of the file into an array.
            string[] arrLines = ReadAllResourceLines(Properties.Resources.DeheadEmAll_LICENSE);

            // Loop through each line of the array.
            foreach (string strLine in arrLines)
            {
                // Print to screen.
                Log.Information(strLine);
            }
        }

        /// <summary>
        /// Prints the version and copyright notice texts.
        /// </summary>
        public void PrintVersion()
        {
            // Print to screen
            Log.Information("-------------------------------------------------------------------------");
            Log.Information(AppName + " v" + AppVersion);
            Log.Information(AppCopyright);
            Log.Information("-------------------------------------------------------------------------");
        }

        #endregion
    }
}
