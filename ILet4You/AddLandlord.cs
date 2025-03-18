using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLet4You
{
    public partial class AddLandlord : Form
    {
        public AddLandlord()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string[] nameSplit = Nametxt.Text.Split(' ');

                        string addQuery = @"INSERT INTO LANDLORD (L_Fname, L_MName, L_LName, L_Address, L_PhoneNo, L_Email, L_Notes) " +
                            @"VALUES(@L_Fname, @L_MName, @L_LName, @L_Address, @L_PhoneNo, @L_Email, @L_Notes)";


                        using (SQLiteCommand cmd = new SQLiteCommand(addQuery, conn))
                        {
                            if (nameSplit.Length == 2)
                            {
                                cmd.Parameters.AddWithValue("@L_Fname", nameSplit[0]);
                                cmd.Parameters.AddWithValue("@L_MName", null);
                                cmd.Parameters.AddWithValue("@L_LName", nameSplit[1]);
                                cmd.Parameters.AddWithValue("@L_Address", Addresstxt.Text);
                                cmd.Parameters.AddWithValue("@L_PhoneNo", PhoneNotxt.Text);
                                cmd.Parameters.AddWithValue("@L_Email", Emailtxt.Text);
                                cmd.Parameters.AddWithValue("@L_Notes", Notestxt.Text);
                            }
                            else if (nameSplit.Length == 3)
                            {
                                cmd.Parameters.AddWithValue("@L_Fname", nameSplit[0]);
                                cmd.Parameters.AddWithValue("@L_MName", nameSplit[1]);
                                cmd.Parameters.AddWithValue("@L_LName", nameSplit[2]);
                                cmd.Parameters.AddWithValue("@L_Address", Addresstxt.Text);
                                cmd.Parameters.AddWithValue("@L_PhoneNo", PhoneNotxt.Text);
                                cmd.Parameters.AddWithValue("@L_Email", Emailtxt.Text);
                                cmd.Parameters.AddWithValue("@L_Notes", Notestxt.Text);
                            }


                            cmd.ExecuteNonQuery();
                        }

                        string getLastInsertIdQuery = "SELECT last_insert_rowid()";
                        int propertyID;

                        using (SQLiteCommand getIdCmd = new SQLiteCommand(getLastInsertIdQuery, conn))
                        {
                            propertyID = Convert.ToInt32(getIdCmd.ExecuteScalar());
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


            clearTextFields();
        }


        void clearTextFields()
        {
            Nametxt.Text = "";
            Addresstxt.Text = "";
            PhoneNotxt.Text = "";
            Emailtxt.Text = "";
            Notestxt.Text = "";
        }

        private void AddLandlord_Load(object sender, EventArgs e)
        {

        }
    }
}
