using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PlexFileSorterGUI
{
    public partial class BackgroundProcess : Form
    {
        /// <summary>
        /// Keeps a list of all the file watcher listeners, predefined on an XML file
        /// </summary>
        private List<CustomFolderSettings> listFolders;

        /// <summary>
        /// Keeps a list of all the file system watchers in execution.
        /// </summary>
        private List<FileSystemWatcher> listFileSystemWatcher;
        public bool alldisabled;

        /// <summary>
        /// Name of the XML file where resides the specification of folders and extensions to be monitored
        /// </summary>
        private string fileNameXML;

        public BackgroundProcess()
        {
            InitializeComponent();

            PopulateListFileSystemWatchers();
            StartFileSystemWatcher();
        }

        public void ResetFileSystemWatchers()
        {
            PopulateListFileSystemWatchers();
            StartFileSystemWatcher();
        }

        private void StartFileSystemWatcher()
        {
            // Creates a new instance of the list
            this.listFileSystemWatcher = new List<FileSystemWatcher>();
            int disabledCount = 0;
            // Loop the list to process each of the folder specifications found
            foreach (CustomFolderSettings customFolder in listFolders)
            {
                if (customFolder.Enabled) // Checks whether the SystemWatcher is enabled
                {
                    if (customFolder.FolderPath != "" || customFolder.StorageLocation != "") //Checks if 
                    {
                        DirectoryInfo dir = new DirectoryInfo(customFolder.FolderPath);
                        if (dir.Exists) // Checks if the directory is a valid location
                        {
                            // Creates a new instance of FileSystemWatcher
                            FileSystemWatcher fileSWatch = new FileSystemWatcher
                            {
                                Filter = customFolder.FolderFilter, // Sets the filter
                                Path = customFolder.FolderPath // Sets the folder location
                            };

                            // Associate the event that will be triggered when a new file is added to the monitored folder, using a lambda Expression                    
                            fileSWatch.Created += (senderObj, fileSysArgs) => FileSWatch_Created(senderObj, fileSysArgs, customFolder.ContentType, customFolder.StorageLocation);

                            // Begin watching
                            fileSWatch.EnableRaisingEvents = true;

                            // Add the systemWatcher to the list
                            listFileSystemWatcher.Add(fileSWatch);
                        }
                        else
                        {
                            MessageBox.Show((customFolder.ContentType == 0 ? "TVShow" : "Anime") + " download directory could not be found.");
                            new FolderSettings().ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show((customFolder.ContentType == 0 ? "TVShow" : "Anime") + " download directory OR save path is empty.");
                        new FolderSettings().ShowDialog();
                    }
                } else
                {
                    disabledCount++;
                }
            }
            if (disabledCount == this.listFolders.Count)
                alldisabled = true;
        }

        /// <summary>
        /// This event is triggered when a file is created on a monitored folder
        /// </summary>
        /// <param name="sender">Object raising the event</param>
        /// <param name="e">List of arguments - FileSystemEventArgs</param>
        /// /// <param name="database">Address for database text file for the filewatchers folder/file type</param>
        void FileSWatch_Created(object sender, FileSystemEventArgs e, int contentType, string storageLocation)
        {
            string[] fileEntries = { e.FullPath };
            if (Directory.Exists(e.FullPath))
                fileEntries = Directory.GetFiles(e.FullPath, "*", SearchOption.AllDirectories);
            foreach (string fileName in fileEntries)
                if (Regex.IsMatch(Path.GetExtension(fileName), @"(\.mkv)|(\.avi)|(\.mp4)|(\.srt)", RegexOptions.IgnoreCase))
                    CheckFile(fileName, contentType, storageLocation); // Searches if the file is in the database and reports if it was sorted.
        }

        /// <summary>
        /// Reads an XML file and populates a list of <CustomFolderSettings>
        /// </summary>
        private void PopulateListFileSystemWatchers()
        {
            /// Get the XML file name from the APP.Config file
            fileNameXML = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\CustomFolderSettings.xml";
            // Creates an instance of XMLSerializer
            XmlSerializer deserializer = new XmlSerializer(typeof(List<CustomFolderSettings>));

            TextReader reader = new StreamReader(fileNameXML);
            object obj = deserializer.Deserialize(reader);

            // Close the TextReader object
            reader.Close();

            // Obtains a list of strongly typed CustomFolderSettings from XML Input data
            listFolders = obj as List<CustomFolderSettings>;
        }

        private dynamic GetDataArray(string sqlCommand, string passedValue, string getType)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\pfsdb.db;Version=3;"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add(new SQLiteParameter("@filterValue", passedValue));
                        conn.Open();
                        switch (getType)
                        {
                        case "lookup":
                            var lookupList = new List<LookUp>();
                            using (var reader = command.ExecuteReader())
                                while (reader.Read())
                                    lookupList.Add(new LookUp { Lookup_term = reader.GetString(0), Show_id = reader.GetInt32(1) });
                            conn.Close();
                            return lookupList.ToArray();
                        default:
                            var showList = new List<Show>();
                            using (var reader = command.ExecuteReader())
                                while (reader.Read())
                                {
                                    switch (getType)
                                    {
                                        case "tvshow":
                                            showList.Add(new Show { Name = reader.GetString(0), Drive_letter = reader.GetString(1) });
                                            break;
                                        case "anime":
                                            showList.Add(new Show { Name = reader.GetString(0), Drive_letter = reader.GetString(1), Season= reader.GetInt32(2), Episode_offset = reader.GetInt32(3) });
                                            break;
                                    }
                                }
                            conn.Close();
                            return showList.ToArray();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message, "FAILED");
                return null;
            }
        }

        /// <summary>
        /// Matches the file name to the database and return the destination information
        /// </summary>
        private string CheckFile(string executableFile, int contentType, string storageLocation)
        {
            var databaseArrayList = GetDataArray("Select lookup.lookup_term, lookup.show_id from lookup JOIN shows ON shows.id = lookup.show_id WHERE shows.anime=@filterValue", contentType.ToString(), "lookup");
            if (databaseArrayList != null)
                foreach (var field in databaseArrayList)
                {
                    if (executableFile.ToLower().Contains(field.Lookup_term.ToLower()))
                    {
                        int episodeNumber;
                        Regex r;
                        switch (contentType)
                        {
                            case 0:
                                databaseArrayList = GetDataArray("Select shows.name, shows.drive_letter FROM shows WHERE shows.id = @filterValue", field.Show_id.ToString(), "tvshow");

                                r = new Regex(@"[S][\d]+[E][\d]+", RegexOptions.IgnoreCase);
                                Match seasonNumberEpisodeNumber = r.Match(executableFile);
                                return SortFile(executableFile, databaseArrayList[0].Name, seasonNumberEpisodeNumber.Value.ToUpper(), databaseArrayList[0].Drive_letter, storageLocation);
                            case 1:
                                databaseArrayList = GetDataArray("Select shows.name, shows.drive_letter, season_info.season, season_info.episode_offset FROM shows INNER JOIN season_info ON season_info.show_id = shows.id WHERE shows.id = @filterValue", field.Show_id.ToString(), "anime");

                                r = new Regex(@"\d+(?=\s?\[?\d{3,4}p])", RegexOptions.IgnoreCase);
                                Match episodePos = r.Match(executableFile);
                                if (episodePos.Success)
                                {
                                    if (int.TryParse(episodePos.Value, out int failedPositioning))
                                        episodeNumber = int.Parse(episodePos.Value);
                                    else
                                        return "Error: Failed to convert episode number to string from " + executableFile;
                                }
                                else
                                    return "Error: Failed to find episode number from " + executableFile;
                                return (databaseArrayList[0].Episode_offset != null)
                                    ? (string)SortFile(executableFile, databaseArrayList[0].Name, "S" + databaseArrayList[0].Season.ToString().PadLeft(2, '0') + "E" + (episodeNumber - databaseArrayList[0].Episode_offset).ToString("D3"), databaseArrayList[0].Drive_letter, storageLocation)
                                    : (string)("Error: The episode offset is not correctly configured for " + databaseArrayList[0].Name + ".");
                            default:
                                break;
                        }
                    }
                }
            return "Error: Nothing was found in the database that matches: " + executableFile;
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
                    }
                    else
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
    }

    public class LookUp
    {
        public string Lookup_term { get; set; }
        public int Show_id { get; set; }
    }

    public class Show
    {
        public string Name { get; set; }
        public string Drive_letter { get; set; }
        public int Season { get; set; }
        public int Episode_offset { get; set; }
    }
}
