using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLet4You
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
           SearchProperty test = new SearchProperty();
            test.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchTenant searchTenant = new SearchTenant();
            searchTenant.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchLandlord searchLandlord = new SearchLandlord();   
            searchLandlord.Show();
        }
    }
}
