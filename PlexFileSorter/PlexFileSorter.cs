using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace PlexFileSorter
{
    /// <summary>
    /// This class will run as a Windows Service intended to monitor what files have been added to the filesystem and triggering some actions as a response
    /// </summary>
    public partial class PlexFileSorter : ServiceBase
    {
        #region Private variables

        /// <summary>
        /// Keeps a list of all the file watcher listeners, predefined on an XML file
        /// </summary>
        private List<CustomFolderSettings> listFolders;

        /// <summary>
        /// Keeps a list of all the file system watchers in execution.
        /// </summary>
        private List<FileSystemWatcher> listFileSystemWatcher;

        /// <summary>
        /// Name of the XML file where resides the specification of folders and extensions to be monitored
        /// </summary>
        private string fileNameXML;

        #endregion
        ArrayList databaseArrayList = new ArrayList();

        string logSource = "Plex File Sorter";//"Windows Logs";
        string logLog = "Application";

        int eventId = 1;
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlexFileSorter()
        {
            InitializeComponent();

            if (!EventLog.SourceExists(logSource))
            {
                EventLog.CreateEventSource(logSource, logLog);
            }

            eventLog1.Source = logSource;
            eventLog1.Log = logLog;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Event automatically fired when the service is started by Windows
        /// </summary>
        /// <param name="args">array of arguments</param>
        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Started Plex file sorter");

            // Initialize the list of filesystem Watchers based on the XML configuration file
            PopulateListFileSystemWatchers();

            // Start the file system watcher for each of the file specification and folders found on the List<>
            StartFileSystemWatcher();
        }

        /// <summary>
        /// Event automatically fired when the service is stopped by Windows
        /// </summary>
        protected override void OnStop()
        {
            if (listFileSystemWatcher != null)
            {
                foreach (FileSystemWatcher fsw in listFileSystemWatcher)
                {
                    // Stop listening
                    fsw.EnableRaisingEvents = false;

                    // Record a log entry into Windows Event Log
                    CustomLogEvent(string.Format("Stopped monitoring files in the folder ({0})", fsw.Path));

                    // Dispose the Object
                    fsw.Dispose();
                }

                // Cleans the list
                listFileSystemWatcher.Clear();
            }

            eventLog1.WriteEntry("Stopped Plex file sorter");
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Stops the main execution of the Windows Service
        /// </summary>
        private void StopMainExecution()
        {
            if (listFileSystemWatcher != null)
            {
                foreach (FileSystemWatcher fsw in listFileSystemWatcher)
                {
                    // Stop listening
                    fsw.EnableRaisingEvents = false;

                    // Record a log entry into Windows Event Log
                    CustomLogEvent(string.Format("Stopped monitoring files in the folder ({0})", fsw.Path));

                    // Dispose the Object
                    fsw.Dispose();
                }

                // Cleans the list
                listFileSystemWatcher.Clear();
            }
        }

        /// <summary>
        /// Start the file system watcher for each of the file specification and folders found on the List<>
        /// </summary>
        private void StartFileSystemWatcher()
        {
            // Creates a new instance of the list
            this.listFileSystemWatcher = new List<FileSystemWatcher>();

            // Loop the list to process each of the folder specifications found
            foreach (CustomFolderSettings customFolder in listFolders)
            {
                DirectoryInfo dir = new DirectoryInfo(customFolder.FolderPath);

                // Checks whether the SystemWatcher is enabled and also the directory is a valid location
                if (dir.Exists)
                {
                    // Creates a new instance of FileSystemWatcher
                    FileSystemWatcher fileSWatch = new FileSystemWatcher();

                    // Sets the filter
                    fileSWatch.Filter = customFolder.FolderFilter;

                    // Sets the folder location
                    fileSWatch.Path = customFolder.FolderPath;

                    // Subscribe to notify filters
                    fileSWatch.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                    // Associate the event that will be triggered when a new file is added to the monitored folder, using a lambda Expression                    
                    fileSWatch.Created += (senderObj, fileSysArgs) => FileSWatch_Created(senderObj, fileSysArgs, customFolder.Database, customFolder.ContentType, customFolder.StorageLocation);

                    // Begin watching
                    fileSWatch.EnableRaisingEvents = true;

                    // Add the systemWatcher to the list
                    listFileSystemWatcher.Add(fileSWatch);

                    // Record a log entry into Windows Event Log
                    CustomLogEvent(string.Format("Starting to monitor files with extension ({0}) in the folder ({1})", fileSWatch.Filter, fileSWatch.Path));
                }
                else
                {
                    // Record a log entry into Windows Event Log
                    CustomLogEvent(string.Format("File system monitor cannot start because the folder ({0}) does not exist", customFolder.FolderPath));
                }
            }
        }

        /// <summary>
        /// This event is triggered when a file is created on a monitored folder
        /// </summary>
        /// <param name="sender">Object raising the event</param>
        /// <param name="e">List of arguments - FileSystemEventArgs</param>
        /// /// <param name="database">Address for database text file for the filewatchers folder/file type</param>
        void FileSWatch_Created(object sender, FileSystemEventArgs e, string database, string contentType, string storageLocation)
        {
            LoadArrayList(database);
            string[] fileEntries = {e.FullPath};
            if (Directory.Exists(e.FullPath))
                fileEntries = Directory.GetFiles(e.FullPath, "*", SearchOption.AllDirectories);
            foreach (string fileName in fileEntries)
                if (Regex.IsMatch(Path.GetExtension(fileName), @"(\.mkv)|(\.avi)|(\.mp4)|(\.srt)", RegexOptions.IgnoreCase))
                    CustomLogEvent(CheckFile(fileName, contentType, storageLocation)); // Searches if the file is in the database and reports if it was sorted.
            databaseArrayList.Clear();
            databaseArrayList.TrimToSize();
        }

        /// <summary>
        /// Record messages and logs into the Windows Event log
        /// </summary>
        /// <param name="message">Message to be recorded into the Windows Event log</param>
        private void CustomLogEvent(string message, EventLogEntryType type = EventLogEntryType.Information)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;
            message = dt.ToLocalTime() + ": " + message;

            eventLog1.WriteEntry(message, type, eventId++);
        }

        /// <summary>
        /// Reads an XML file and populates a list of <CustomFolderSettings>
        /// </summary>
        private void PopulateListFileSystemWatchers()
        {
            /// Get the XML file name from the APP.Config file
            fileNameXML = ConfigurationManager.AppSettings["XMLFileFolderSettings"];

            // Creates an instance of XMLSerializer
            XmlSerializer deserializer = new XmlSerializer(typeof(List<CustomFolderSettings>));

            TextReader reader = new StreamReader(fileNameXML);
            object obj = deserializer.Deserialize(reader);

            // Close the TextReader object
            reader.Close();

            // Obtains a list of strongly typed CustomFolderSettings from XML Input data
            listFolders = obj as List<CustomFolderSettings>;
        }

        /// <summary>
        /// Loads the folder/file type database into an arrayList
        /// </summary>
        private void LoadArrayList(string database)
        {
            string[] lines = File.ReadAllLines(database);
            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });
                databaseArrayList.Add(col);
            }
        }

        /// <summary>
        /// Matches the file name to the database and return the destination information
        /// </summary>
        private string CheckFile(string executableFile, string contentType, string storageLocation)
        {
            foreach (string[] item in databaseArrayList)
            {
                if (executableFile.ToLower().Contains(item[1].ToLower()))
                {
                    int episodeNumber;
                    Regex r;
                    switch (contentType)
                    {
                        case "Anime":
                            r = new Regex(@"\d+(?=\s?\[?\d{3,4}p])", RegexOptions.IgnoreCase);
                            Match episodePos = r.Match(executableFile);
                            if (episodePos.Success)
                            {
                                if (int.TryParse(episodePos.Value, out int failedPositioning))
                                    episodeNumber = int.Parse(episodePos.Value);
                                else
                                    return "Error: Failed to convert episode number to string for " + executableFile;
                            }
                            else
                                return "Error: Failed to find episode number for " + executableFile;
                            if (int.TryParse(item[3], out int failedOffset))
                                return SortFile(executableFile, item[0], "S" + item[2] + "E" + (episodeNumber - int.Parse(item[3])).ToString("D3"), item[4], storageLocation);
                            else
                                return "Error: The episode offset is not correctly configured for " + item[0] + ".";
                        case "TV Show":
                            r = new Regex(@"[S][\d]+[E][\d]+", RegexOptions.IgnoreCase);
                            Match seasonNumberEpisodeNumber = r.Match(executableFile);
                            return SortFile(executableFile, item[0], seasonNumberEpisodeNumber.Value.ToUpper(), item[2], storageLocation);
                        default:
                            return "Error: Something has gone wrong with the content type in CheckFile() from PlexFileSorter.cs";
                    }

                }

            }
            return "Error: Nothing was found in the " + contentType + " database that matches: " + executableFile;
        }

        /// <summary>
        /// Moves the file to the new destination (renaming it in the process)
        /// </summary>
        private string SortFile(string executableFile, string seriesName, string seasonNumberEpisodeNumber, string driveLetter, string storageLocation)
        {
            try
            {
                if (File.Exists(@executableFile))
                {
                    String destinationFile = driveLetter + ":/" + storageLocation + "/" + seriesName + "/Season " + seasonNumberEpisodeNumber.Substring(1, seasonNumberEpisodeNumber.IndexOf("E") - 1) + "/" + seasonNumberEpisodeNumber + " - " + seriesName + (Path.GetExtension(executableFile) == ".srt" ? ".eng.srt" : Path.GetExtension(executableFile));
                    new System.IO.FileInfo(@destinationFile).Directory.Create();
                    if (File.Exists(@destinationFile))
                    {
                        if (executableFile.ToLower().Contains("repack") || executableFile.ToLower().Contains("proper"))
                        {
                            System.IO.File.SetAttributes(@destinationFile, FileAttributes.Normal);
                            System.IO.File.Delete(@destinationFile);
                            System.IO.File.Move(@executableFile, @destinationFile);
                            return "Success: " + destinationFile + " was replaced with a newer version.";
                        }
                        else
                        {
                            return "Error: Cannot move " + executableFile + " because " + destinationFile + " already exists.";
                        }
                } else
                    {
                        System.IO.File.Move(@executableFile, @destinationFile);
                        return "Success: " + destinationFile + " was sorted.";
                    }
                }
                else
                    return "Error: " + executableFile + " was modifed before it could be sorted.";
            }
            catch (Exception e)
            {
                return "Error: Failed moving " + executableFile + " (" + e.ToString() + ")";
            }
        }

        #endregion

    }
}
