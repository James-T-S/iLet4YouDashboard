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
            string addQuery = "INSERT INTO Property(P_Address, P_Postcode, P_EPCRating, P_EPCExpiry, P_EICRExpiry," +
            " P_GasCertExpiry, P_Rent, P_RentDate, P_IsVacant, P_Notes) " +
            $"VALUES('{Addresstxt.Text}', '{Postcodetxt.Text}', '{EPCRatingtxt.Text}', '{EPCExpirytxt.Text}', '{EICRtxt.Text}'," +
            $" '{GasCertExpirytxt.Text}', {RentAmttxt.Text}, '{RentDatetxt.Text}', {Vacantchb.Checked}, '{Notestxt.Text}')";

            AmendDatabase(addQuery);

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
        }

    }
}
