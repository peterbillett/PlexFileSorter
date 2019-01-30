using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace PlexFileSorterGUI
{
    public partial class NewShowGUI : Form
    {
        public NewShowGUI(int anime)
        {
            InitializeComponent();
            if (anime == 1)
            {
                newSeasonTextBox.Visible = true;
                newEpisodeOffsetTextBox.Visible = true;
                seasonLabel.Visible = true;
                episodeOffsetLabel.Visible = true;
                showType.Text = "1";
            } else
            {
                newSeasonTextBox.Visible = false;
                newEpisodeOffsetTextBox.Visible = false;
                seasonLabel.Visible = false;
                episodeOffsetLabel.Visible = false;
                showType.Text = "0";
            }
            string temp = GetData("SELECT shows.drive_letter FROM shows WHERE shows.anime=@anime ORDER BY shows.id DESC", anime);
            if (temp != "")
                newStorageDriveTextBox.Text = temp;
        }

        private static string GetData(string sqlCommand, int anime)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\pfsdb.db;Version=3;"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add(new SQLiteParameter("@anime", anime));
                        conn.Open();
                        string temp = command.ExecuteScalar().ToString();
                        conn.Close();
                        return temp;
                    }
                }
            }
            catch (Exception)
            {
                return "C";
            }
        }

        private void NewShowGUI_Load(object sender, EventArgs e)
        {

        }

        private int SetData(String[] sqlCommand)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\pfsdb.db;Version=3;"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        int rowID=0;
                        using (var tr = conn.BeginTransaction())
                        {
                            for (int y = 0; y < sqlCommand.Count(); y++)
                            {
                                command.CommandText = sqlCommand[y];
                                command.ExecuteNonQuery();
                                if (y == 0)
                                    rowID = (int)conn.LastInsertRowId;
                            }
                            tr.Commit();

                            return rowID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message, "FAILED");
                return 0;
            }
        }

        private bool checkConstraints(string type)
        {
            if (newNameTextBox.Text != "" && newStorageDriveTextBox.Text != "")
                if (char.IsLetter(newStorageDriveTextBox.Text[0]))
                    if (type == "1")
                        if (newEpisodeOffsetTextBox.Text != "" && newSeasonTextBox.Text != "")
                            if (int.TryParse(newEpisodeOffsetTextBox.Text, out int temp))
                                if (int.TryParse(newSeasonTextBox.Text, out temp))
                                    return true;
                                else
                                    MessageBox.Show("Please only enter numbers in the season textbox.");
                            else
                                MessageBox.Show("Please only enter numbers in the episode offset textbox (Default 0).");
                        else
                            MessageBox.Show("All fields must be entered.");
                    else
                        return true;
                else
                    MessageBox.Show("Storage drive must be a letter");
            else
                MessageBox.Show("All fields must be entered.");
            return false;
        }

        private void SubmitNewShowButton_Click(object sender, EventArgs e)
        {
            if (checkConstraints(showType.Text))
                {
                //    int lastInsertedId = -1;
                //    if (showType.Text == "1")
                //        lastInsertedId = SetData(new string[2] { "INSERT INTO shows(name, drive_letter, anime) VALUES('" + newNameTextBox.Text + "', '" + newStorageDriveTextBox.Text + "', 1);", "INSERT INTO season_info(show_id, season, episode_offset) VALUES(last_insert_rowid(), " + newSeasonTextBox.Text + ", " + newEpisodeOffsetTextBox.Text + ");" });
                //    else if (showType.Text == "0")
                //        lastInsertedId = SetData(new string[1] { "INSERT INTO shows(name, drive_letter, anime) VALUES('"+newNameTextBox.Text+"', '"+newStorageDriveTextBox.Text+"', 0);" });

                int lastInsertedId = showType.Text == "1" //anime
                    ? SetData(new string[2] { "INSERT INTO shows(name, drive_letter, anime) VALUES('" + newNameTextBox.Text + "', '" + newStorageDriveTextBox.Text + "', 1);", "INSERT INTO season_info(show_id, season, episode_offset) VALUES(last_insert_rowid(), " + newSeasonTextBox.Text + ", " + newEpisodeOffsetTextBox.Text + ");" })
                    : SetData(new string[1] { "INSERT INTO shows(name, drive_letter, anime) VALUES('" + newNameTextBox.Text + "', '" + newStorageDriveTextBox.Text + "', 0);" });
                InsertDefaultLookup(lastInsertedId);
            }
        }

        private void InsertDefaultLookup(int lastInsertedId)
        {
            if (lastInsertedId > 0)
            {
                SetData(new string[1] { "INSERT INTO lookup(show_id, lookup_term) VALUES(" + lastInsertedId + ", '" + newNameTextBox.Text.ToLower() + (newNameTextBox.Text.Contains(" ") ? ("'), (" + lastInsertedId + ", '" + newNameTextBox.Text.ToLower().Replace(" ", ".") + "');") : "');") });
                this.Close();
                new LookupGUI(lastInsertedId.ToString()).ShowDialog();
            }
            else
                MessageBox.Show("Failed to add " + newNameTextBox.Text + ".", "ERROR");
        }
    }
}
