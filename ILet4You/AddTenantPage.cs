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
            string[] nameSplit = Nametxt.Text.Split(' ');

            string addQuery = "INSERT INTO Tenant(T_FName, T_MName, T_LName, T_PhoneNo, T_Email, T_Notes, T_DBS)" +
            $"VALUES('{Nametxt.Text}', '{Emailtxt.Text}', '{Phonenumbertxt.Text}', {DOBtxt.Text}, '{RentDatetxt.Text}', '{RentAmounttxt.Text}')";

            AmendDatabase(addQuery);

            clearTextFields();
        }

        void AmendDatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=DBiLet4You.db;");
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(txtQuery, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            clearTextFields();
        }

        void clearTextFields()
        {
            Nametxt.Text = "";
            Emailtxt.Text = "";
            Phonenumbertxt.Text = "";
            DOBtxt.Text = "";
            RentDatetxt.Text = "";
            RentAmounttxt.Text = "";
        }
    }
}
