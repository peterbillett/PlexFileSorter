﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace PlexFileSorter
{
    /// <summary>
    /// This class defines an individual type of file and its associated folder to be monitored by the File System Watcher
    /// </summary>
    public class CustomFolderSettings
    {
        /// <summary>Custom Folder/File setting identifer</summary>
        [XmlAttribute]
        public string FolderID { get; set; }

        /// <summary>Description of the type of files and folder location - Just for documentation purpose</summary>
        [XmlElement]
        public string FolderDescription { get; set; }

        /// <summary>Filter to select the type of files to be monitored. (Examples: *.shp, *.*, Project00*.zip)</summary>
        [XmlElement]
        public string FolderFilter { get; set; }

        /// <summary>Full path to be monitored (i.e.: D:\files\projects\shapes\ )</summary>
        [XmlElement]
        public string FolderPath { get; set; }

        /// <summary>If TRUE: the folder and its subfolders will be monitored</summary>
        [XmlElement]
        public bool FolderIncludeSub { get; set; }

        /// <summary>Folder datbase file</summary>
        [XmlElement]
        public string Database { get; set; }

        /// <summary>Database file content type</summary>
        [XmlElement]
        public string ContentType { get; set; }

        /// <summary>Where to save files found with watcher</summary>
        [XmlElement]
        public string StorageLocation { get; set; }

        /// <summary>Default constructor of the class</summary>        
        public CustomFolderSettings()
        {

        }
    }
}
