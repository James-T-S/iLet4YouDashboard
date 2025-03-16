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
    public partial class AddTenantPage : Form
    {
        public AddTenantPage()
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

                        string addQuery = @"INSERT INTO TENANT (T_Fname, T_MName, T_LName, T_PhoneNo, T_Email, T_Notes, T_DBS) " +
                            @"VALUES(@T_Fname, @T_MName, @T_LName, @T_PhoneNo, @T_Email, @T_Notes, @T_DBS)";


                        using (SQLiteCommand cmd = new SQLiteCommand(addQuery, conn))
                        {
                            if (nameSplit.Length == 2)
                            {
                                cmd.Parameters.AddWithValue("@T_Fname", nameSplit[0]);
                                cmd.Parameters.AddWithValue("@T_MName", null);
                                cmd.Parameters.AddWithValue("@T_LName", nameSplit[1]);
                                cmd.Parameters.AddWithValue("@T_Email", Emailtxt.Text);
                                cmd.Parameters.AddWithValue("@T_PhoneNo", PhoneNotxt.Text);
                                cmd.Parameters.AddWithValue("@T_Notes", Notestxt.Text);
                                cmd.Parameters.AddWithValue("@T_DBS", DBStxt.Text);
                            }                                 
                            else if (nameSplit.Length == 3)   
                            {                                 
                                cmd.Parameters.AddWithValue("@T_Fname", nameSplit[0]);
                                cmd.Parameters.AddWithValue("@T_MName", nameSplit[1]);
                                cmd.Parameters.AddWithValue("@T_LName", nameSplit[2]);
                                cmd.Parameters.AddWithValue("@T_Email", Emailtxt.Text);
                                cmd.Parameters.AddWithValue("@T_PhoneNo", PhoneNotxt.Text);
                                cmd.Parameters.AddWithValue("@T_Notes", Notestxt.Text);
                                cmd.Parameters.AddWithValue("@T_DBS", DBStxt.Text);
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
            Emailtxt.Text = "";
            PhoneNotxt.Text = "";
            DOBtxt.Text = "";
            DBStxt.Text = "";
            Notestxt.Text = "";
        }
    }
}
