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
            string addQuery = "";
            string[] nameSplit = Nametxt.Text.Split(' ');

            if (nameSplit.Length == 2)
            {
                addQuery = "INSERT INTO Tenant(T_FName, T_LName, T_PhoneNo, T_Email, T_Notes, T_DBS)" +
                $"VALUES('{nameSplit[0]}', '{nameSplit[1]}', '{Phonenumbertxt.Text}', '{Emailtxt.Text}', '{Notestxt.Text}', '{DBStxt.Text}')";
            }
            else if (nameSplit.Length == 3)
            {
                addQuery = "INSERT INTO Tenant(T_FName, T_MName, T_LNane, T_PhoneNo, T_Email, T_Notes, T_DBS) " +
                $"VALUES('{nameSplit[0]}', '{nameSplit[1]}', '{nameSplit[2]}', '{Phonenumbertxt.Text}', '{Emailtxt.Text}', '{Notestxt.Text}', '{DBStxt.Text}')";
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
            Emailtxt.Text = "";
            Phonenumbertxt.Text = "";
            DOBtxt.Text = "";
            DBStxt.Text = "";
            Notestxt.Text = "";
        }
    }
}
