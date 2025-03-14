using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLet4You
{
    public partial class PropertyNotes : Form
    {
        int propertyid;
        public PropertyNotes(int PropertyID)
        {
            InitializeComponent();
            propertyid = PropertyID;
            loadnotes();
            
        }

        private void loadnotes()
        {
            string notes = "";
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                connection.Open();
                string query = "SELECT P_NOTES FROM PROPERTY WHERE PROPERTYID = @PropertyID";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PropertyID", propertyid);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        notes = result.ToString();
                    }
                }
            }
            TenantTextBox.Text = notes;
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string notes = EnterText.Text.Trim();
            if (string.IsNullOrEmpty(notes))
            {
                MessageBox.Show("PLEASE FILL IN TEXTBOX");
                return;
            }

            string currentnotes = "";
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                connection.Open();
                string query3 = "SELECT P_NOTES FROM PROPERTY WHERE PROPERTYID = @PropertyID";
                using (SQLiteCommand command3 = new SQLiteCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@PropertyID", propertyid);
                    object result = command3.ExecuteScalar();
                    if (TenantTextBox.Text != null)
                    {
                        currentnotes = result.ToString();
                    }
                    else
                    {
                        currentnotes = "";
                    }
                }

            }


            string timendate = DateTime.Now.ToString("f");
            string updatetimendate;
            if (string.IsNullOrEmpty(timendate))
            {
                updatetimendate = $"{timendate}{notes}\n";
            }
            else
            {
                updatetimendate = $"{timendate}{notes}\n\n{currentnotes}";
            }

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                connection.Open();
                string updateq = "UPDATE PROPERTY SET P_NOTES = @Notes WHERE PROPERTYID = @PropertyID";

                using (SQLiteCommand command = new SQLiteCommand(updateq, connection))
                {
                    command.Parameters.AddWithValue("@Notes", updatetimendate);
                    command.Parameters.AddWithValue("@PropertyID", propertyid);
                    command.ExecuteNonQuery();
                }
            }
            loadnotes();
            EnterText.Clear();
            MessageBox.Show("UPDATED!");

        }
    }
}
