using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace PlexFileSorterGUI
{
    public partial class LookupGUI : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public LookupGUI(string showID)
        {
            InitializeComponent();
            showIDTextBox.Text = showID;
            bindingSource1.DataSource = GetData("SELECT lookup.id, lookup.lookup_term FROM lookup WHERE lookup.show_id=@showID", showID);
            lookupDataGridView.DataSource = bindingSource1;
        }

        public DataTable GetData(string sqlCommand, string showID)
        {
            DataTable table = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Plex File Sorter") + @"\pfsdb.db;Version=3;"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add(new SQLiteParameter("@showID", showID));
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                        adapter.SelectCommand = command;
                        table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        adapter.Fill(table);
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

        private void LookupAdd_Click(object sender, EventArgs e)
        {
            if (SetData("INSERT INTO lookup(show_id, lookup_term) VALUES(@show_id, @lookup_term);", new String[2, 2] { { "@show_id", showIDTextBox.Text }, { "@lookup_term", lookupTextBox.Text.ToLower() } }))
            {
                bindingSource1.DataSource = GetData("SELECT * FROM lookup WHERE lookup.show_id=@showID;", showIDTextBox.Text);
                lookupDataGridView.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("Failed to add " + lookupTextBox.Text + ".", "ERROR");
            }
        }

        private void LookupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 1: //Update
                        if (SetData("UPDATE lookup SET lookup_term=@term WHERE id=@termID;", new String[2, 2] { { "@term", senderGrid[0, e.RowIndex].Value.ToString() }, { "@termID", senderGrid[3, e.RowIndex].Value.ToString() } }))
                        {
                            MessageBox.Show("Updated " + senderGrid[0, e.RowIndex].Value + ".", "SUCCESS");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update " + senderGrid[0, e.RowIndex].Value + ".", "ERROR");
                        }
                        break;
                    case 2: //Delete
                        if (SetData("DELETE FROM lookup WHERE lookup.id=@termID;", new String[1, 2] { { "@termID", senderGrid[3, e.RowIndex].Value.ToString() } }))
                        {
                            senderGrid.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete " + senderGrid[0, e.RowIndex].Value + ".", "ERROR");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
