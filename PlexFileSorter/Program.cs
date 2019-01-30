using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlexFileSorterGUI
{
    static class Program
    {
        public static bool LaunchedViaStartup { get; set; }
        public static BackgroundProcess backgroundProcess;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Program.LaunchedViaStartup = args != null && args.Any(arg => arg.Equals("startup", StringComparison.CurrentCultureIgnoreCase));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            backgroundProcess = new BackgroundProcess();
            if (backgroundProcess.alldisabled)
                backgroundProcess.Load += openSettings;
            if (!Program.LaunchedViaStartup)
            {
                backgroundProcess.Load += openMainGUI;
                Application.Run(backgroundProcess);
            } else
            {
                Application.Run(backgroundProcess);
            }
        }

        static void openSettings(object sender, EventArgs e)
        {
            backgroundProcess.Load -= openSettings;
            MessageBox.Show("Setup download directories and file destination paths.");
            new FolderSettings().ShowDialog();
        }

        static void openMainGUI(object sender, EventArgs e)
        {
            backgroundProcess.Load -= openMainGUI;
            new MainGUI().ShowDialog();
        }
    }
}
