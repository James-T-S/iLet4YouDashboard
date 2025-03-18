using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLet4You
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            loadshortcuts();
            showshortcuts();
        }


///BY JAMES SHIPMAN


        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string addQuery = @"INSERT INTO PROPERTY (P_Address, P_Postcode, P_EPCRating, P_EPCExpiry, P_EICRExpiry, P_GasCertExpiry, P_Rent, P_RentDate, P_IsVacant, P_Notes, LandlordID) " +
                            @"VALUES(@P_Address, @P_Postcode, @P_EPCRating, @P_EPCExpiry, @P_EICRExpiry, @P_GasCertExpiry, @P_Rent, @P_RentDate, @P_IsVacant, @P_Notes, @LandlordID)";

                        using (SQLiteCommand cmd = new SQLiteCommand(addQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@P_Address", Addresstxt.Text);
                            cmd.Parameters.AddWithValue("@P_Postcode", Postcodetxt.Text);
                            cmd.Parameters.AddWithValue("@P_EPCRating", EPCRatingtxt.Text);
                            cmd.Parameters.AddWithValue("@P_EPCExpiry", EPCExpirytxt.Text);
                            cmd.Parameters.AddWithValue("@P_EICRExpiry", EICRtxt.Text);
                            cmd.Parameters.AddWithValue("@P_GasCertExpiry", GasCertExpirytxt.Text);
                            cmd.Parameters.AddWithValue("@P_Rent", Convert.ToDecimal(RentAmttxt.Text));
                            cmd.Parameters.AddWithValue("@P_RentDate", RentDatetxt.Text);
                            cmd.Parameters.AddWithValue("@P_IsVacant", Vacantchb.Checked);
                            cmd.Parameters.AddWithValue("@P_Notes", Notestxt.Text);
                            cmd.Parameters.AddWithValue("@LandlordID", Landlordtxt.Text);

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
            Addresstxt.Text = "";
            Postcodetxt.Text = "";
            EPCRatingtxt.Text = "";
            EPCExpirytxt.Text = "";
            EICRtxt.Text = "";
            GasCertExpirytxt.Text = "";
            RentAmttxt.Text = "";
            RentDatetxt.Text = "";
            Vacantchb.Checked = false;
            Notestxt.Text = "";
            Landlordtxt.Text = "";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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


            clearTextFields2();
        }
        void clearTextFields2()
        {
            Nametxt.Text = "";
            Emailtxt.Text = "";
            PhoneNotxt.Text = "";
            DOBtxt.Text = "";
            DBStxt.Text = "";
            Notestxt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
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


            clearTextFields3();
        }

        void clearTextFields3()
        {
            Nametxt.Text = "";
            Addresstxt.Text = "";
            PhoneNotxt.Text = "";
            Emailtxt.Text = "";
            Notestxt.Text = "";
        }


        List<string> shortcuts = new List<string>();
        private const string savefilename = "shortcuts.dat";

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var path = shortcuts[listBox1.SelectedIndex];
                try
                {
                    if (File.Exists(path))
                    {
                        Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("Cant Find File");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "All Files|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!shortcuts.Contains(fileDialog.FileName))
                    {
                        shortcuts.Add(fileDialog.FileName);
                        savehortcuts();
                        showshortcuts();

                    }
                }
            }
        }


        private void showshortcuts()
        {
            listBox1.Items.Clear();
            foreach (var path in shortcuts)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(path));
            }
        }

        private void savehortcuts()
        {
            File.WriteAllLines(savefilename, shortcuts);

        }

        private void loadshortcuts()
        {
            if (File.Exists(savefilename))
            {
                shortcuts = new List<string>(File.ReadAllLines(savefilename));
            }
        }
    }
}
