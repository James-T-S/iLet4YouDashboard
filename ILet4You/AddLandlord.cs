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
            string addQuery = "";
            string[] nameSplit = Nametxt.Text.Split(' ');

            if (nameSplit.Length == 2)
            {
                addQuery = "INSERT INTO Landlord(L_FName, L_LName, L_Address, L_PhoneNo, L_Email, L_Notes)" +
                $"VALUES('{nameSplit[0]}', '{nameSplit[1]}', '{Addresstxt.Text}', '{PhoneNotxt.Text}', '{Emailtxt.Text}', '{Notestxt.Text}')";
            }
            else if (nameSplit.Length == 3)
            {
                addQuery = "INSERT INTO Landlord(L_FName, L_MName, L_LName, L_Address, L_PhoneNo, L_Email, L_Notes)" +
                $"VALUES('{nameSplit[0]}', '{nameSplit[1]}', '{nameSplit[2]}', '{Addresstxt.Text}', '{PhoneNotxt.Text}', '{Emailtxt.Text}', '{Notestxt.Text}')";
            }


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
