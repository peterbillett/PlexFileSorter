using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace PlexFileSorterGUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = GetData("SELECT shows.id, shows.name, shows.drive_letter, season_info.season, season_info.episode_offset FROM shows INNER JOIN season_info ON season_info.show_id = shows.id WHERE shows.anime = 1 ORDER BY shows.name");
            AnimeDataView.DataSource = bindingSource1;

            bindingSource2.DataSource = GetData("SELECT shows.id, shows.name, shows.drive_letter FROM shows WHERE shows.anime = 0 ORDER BY shows.name");
            TVShowDataView.DataSource = bindingSource2;
        }

        private static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\pfsdb.db;Version=3;"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.Text;
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                        adapter.SelectCommand = command;
                        table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        adapter.Fill(table);
                        conn.Close();
                        return table;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message, "FAILED");
                return table;
            }
        }

        private bool SetData(string sqlCommand, String[,] parameterArray)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\pfsdb.db;Version=3;"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, conn))
                    {
                        conn.Open();
                        for (int i = 0; i < parameterArray.GetLength(0); i++)
                            command.Parameters.Add(new SQLiteParameter(parameterArray[i, 0], parameterArray[i, 1]));
                        command.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message, "FAILED");
                return false;
            }
        }

        private void AnimeDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 0: //Search Terms
                        new LookupGUI(senderGrid[7, e.RowIndex].Value.ToString()).ShowDialog();
                        break;
                    case 5: //Update
                        if (SetData("UPDATE shows SET name=@name, drive_letter=@drive_letter WHERE id=@showID", new String[3, 2] { { "@name", senderGrid[1, e.RowIndex].Value.ToString() }, { "@drive_letter", senderGrid[4, e.RowIndex].Value.ToString() }, { "@showID", senderGrid[7, e.RowIndex].Value.ToString() } }))
                            MessageBox.Show("Updated " + senderGrid[1, e.RowIndex].Value + ".", "SUCCESS");
                        else
                            MessageBox.Show("Failed to update " + senderGrid[1, e.RowIndex].Value + ".", "FAILED");
                        break;
                    case 6: //Delete
                        if (SetData("DELETE FROM shows WHERE shows.id=@showID", new String[1, 2] { { "@showID", senderGrid[7, e.RowIndex].Value.ToString() } }))
                            senderGrid.Rows.RemoveAt(e.RowIndex);
                        else
                            MessageBox.Show("Failed to delete " + senderGrid[1, e.RowIndex].Value + ".", "FAILED");
                        break;
                    default:
                        break;
                }
            }
        }

        private void TVShowDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 0: //Search Terms
                        new LookupGUI(senderGrid[5, e.RowIndex].Value.ToString()).ShowDialog();
                        break;
                    case 3: //Update
                        if (SetData("UPDATE shows SET name=@name, drive_letter=@drive_letter WHERE id=@showID", new String[3, 2] { { "@name", senderGrid[1, e.RowIndex].Value.ToString() }, { "@drive_letter", senderGrid[2, e.RowIndex].Value.ToString() }, { "@showID", senderGrid[5, e.RowIndex].Value.ToString() } }))
                            MessageBox.Show("Updated " + senderGrid[1, e.RowIndex].Value + ".", "SUCCESS");
                        break;
                    case 4: //Delete
                        if (SetData("DELETE FROM shows WHERE shows.id=@showID", new String[1, 2] { { "@showID", senderGrid[5, e.RowIndex].Value.ToString() } }))
                            senderGrid.Rows.RemoveAt(e.RowIndex);
                        break;
                    default:
                        break;
                }
            }
        }

        private void AddAnimeButton_Click(object sender, EventArgs e)
        {
            new NewShowGUI(1).ShowDialog();
            bindingSource1.DataSource = GetData("SELECT shows.id, shows.name, shows.drive_letter, season_info.season, season_info.episode_offset FROM shows INNER JOIN season_info ON season_info.show_id = shows.id WHERE anime = 1 ORDER BY shows.name");
            AnimeDataView.DataSource = bindingSource1;
        }

        private void AddTVShowButton_Click(object sender, EventArgs e)
        {
            new NewShowGUI(0).ShowDialog();
            bindingSource2.DataSource = GetData("SELECT shows.id, shows.name, shows.drive_letter FROM shows WHERE anime = 0 ORDER BY shows.name");
            TVShowDataView.DataSource = bindingSource2;
        }

        private void folderSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FolderSettings().ShowDialog();
        }

        private void autoModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
