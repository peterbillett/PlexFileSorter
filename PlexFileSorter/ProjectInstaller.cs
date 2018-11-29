using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PlexFileSorter
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            new System.IO.FileInfo(@"C:/Plex File Sorter/").Directory.Create();
            foreach (var file in Directory.GetFiles(System.IO.Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "/Plex File Sorter"))
                File.Copy(file, Path.Combine("C:/Plex File Sorter/", Path.GetFileName(file)), true);
        }
    }
}
