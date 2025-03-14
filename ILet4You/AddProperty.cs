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
    public partial class AddProperty : Form
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //string addQuery = "INSERT INTO Property(P_Address, P_Postcode, P_EPCRating, P_EPCExpiry, P_EICRExpiry," +
             // " P_GasCertExpiry, P_Rent, P_RentDate, P_IsVacant, P_Notes, LandlordID) " +
                //$"VALUES('{Addresstxt.Text}', '{Postcodetxt.Text}', '{EPCRatingtxt.Text}', '{EPCExpirytxt.Text}', '{EICRtxt.Text}'," +
                //$" '{GasCertExpirytxt.Text}', {RentAmttxt.Text}, '{RentDatetxt.Text}', {Vacantchb.Checked}, '{Notestxt.Text}', '{Landlordtxt.Text}')";

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
                            cmd.Parameters.AddWithValue("@P_Rent", RentAmttxt.Text);
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

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            clearTextFields();
        }


        void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=DBiLet4You.db");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(txtQuery, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
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
    }
}
