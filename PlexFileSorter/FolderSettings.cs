using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PlexFileSorterGUI
{
    public partial class FolderSettings : Form
    {
        private string fileNameXML = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\CustomFolderSettings.xml";
        private List<CustomFolderSettings> listFolders;

        public FolderSettings()
        {
            InitializeComponent();

            this.animeSaveLocationButton.Click += delegate { BrowseButton_Click(animeSaveLocation,3); };
            this.animeDownloadLocationButton.Click += delegate { BrowseButton_Click(animeDownloadLocation,0); };
            this.tvshowSaveLocationButtom.Click += delegate { BrowseButton_Click(tvshowSaveLocation,3); };
            this.tvshowDownloadLocationButton.Click += delegate { BrowseButton_Click(tvshowDownloadLocation,0); };
            this.updateAnime.Click += delegate { this.UpdateButton_Click(animeSaveLocation, animeDownloadLocation, animeCheckBox, 2); };
            this.updateTVShow.Click += delegate { this.UpdateButton_Click(tvshowSaveLocation, tvshowDownloadLocation, tvshowCheckBox, 1); };

            ToolTip toolTip1 = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 500,
                ShowAlways = true
            };
            toolTip1.SetToolTip(animeSaveLocation, "This is the path that files will be moved to. It does not include the drive letter as that is selected per series in the main database window.");
            toolTip1.SetToolTip(animeDownloadLocation, "This is the path that will be monitored for anime video files. Any anime video that is added that uses the standard anime torrent format will be found here.");
            toolTip1.SetToolTip(tvshowSaveLocation, "This is the path that files will be moved to. It does not include the drive letter as that is selected per series in the main database window.");
            toolTip1.SetToolTip(tvshowDownloadLocation, "This is the path that will be monitored for TV Show files. Any video that is added that includes the title and uses the S_E_ format for season and episode will be found here.");

            PopulateFields();
        }

        private void PopulateFields()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<CustomFolderSettings>));
            TextReader reader = new StreamReader(fileNameXML);
            object obj = deserializer.Deserialize(reader);
            reader.Close();
            listFolders = obj as List<CustomFolderSettings>;

            tvshowCheckBox.Checked = listFolders[0].Enabled;
            tvshowDownloadLocation.Text = listFolders[0].FolderPath != "" ? listFolders[0].FolderPath : "Folder to monitor for TV Show videos";
            tvshowSaveLocation.Text = listFolders[0].StorageLocation != "" ? listFolders[0].StorageLocation : "Path to move TV Show files to";
            animeCheckBox.Checked = listFolders[1].Enabled;
            animeDownloadLocation.Text = listFolders[1].FolderPath != "" ? listFolders[1].FolderPath : "Folder to monitor for Anime videos";
            animeSaveLocation.Text = listFolders[1].StorageLocation != "" ? listFolders[1].StorageLocation : "Path to move Anime files to"; 
        }

        private void BrowseButton_Click(TextBox textbox, int substring)
        {
            FolderBrowserDialog selectPath = new FolderBrowserDialog();
            selectPath.ShowDialog();
            if (selectPath.SelectedPath != "")
                textbox.Text = selectPath.SelectedPath.Substring(substring);
        }

        private void UpdateButton_Click(TextBox saveTextbox, TextBox downloadTextbox, CheckBox enabledCheckBox, int childNumber)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileNameXML);
            doc.SelectSingleNode("/ArrayOfCustomFolderSettings/CustomFolderSettings[" + childNumber + "]/Enabled").InnerText = enabledCheckBox.Enabled.ToString().ToLower();
            doc.SelectSingleNode("/ArrayOfCustomFolderSettings/CustomFolderSettings[" + childNumber + "]/FolderPath").InnerText = downloadTextbox.Text;
            doc.SelectSingleNode("/ArrayOfCustomFolderSettings/CustomFolderSettings[" + childNumber + "]/StorageLocation").InnerText = saveTextbox.Text;
            doc.Save(fileNameXML);
            BackgroundProcess testing = Program.backgroundProcess;
            Program.backgroundProcess.ResetFileSystemWatchers();
            MessageBox.Show("Updated.");
        }
    }
}
