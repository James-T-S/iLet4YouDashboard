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
    public partial class SearchLandlord : Form
    {
        public SearchLandlord()
        {
            InitializeComponent();
        }

        private void SearchLandlord_Load(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        int currentindex = -1;
        string lastsearch = "";

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string search = Nametxt.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please fill in search bar");
            }

            ///if its not blank then will start searching 
            if (search != lastsearch)
            {
                currentindex = -1;
                lastsearch = search;
                dt.Clear();

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
                    {
                        connection.Open();
                        string query = @"SELECT * FROM LANDLORD WHERE L_FNAME LIKE @search OR L_MNAME LIKE @search OR L_LNAME LIKE @search";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@search", $"%{search}%");
                            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                            da.Fill(dt);
                        }

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No tenant found with that Name!");
                            return;
                        }
                        currentindex = 0;
                        Displaysearch();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                currentindex = (currentindex + 1) % dt.Rows.Count;
                Displaysearch();


            }
        }


        private void Displaysearch()
        {
            if (currentindex >= 0 && currentindex < dt.Rows.Count)
            {
                DataRow row = dt.Rows[currentindex];
                LFnametxt.Text = row["L_FNAME"].ToString();
                LMnametxt.Text = row["L_MNAME"].ToString();
                LLnametxt.Text = row["L_LNAME"].ToString();
                LaddressTxt.Text = row["L_ADDRESS"].ToString();
                LPhonenumbertxt.Text = row["L_PHONENO"].ToString();
                LEmailtxt.Text = row["L_EMAIL"].ToString();

            }
        }



        private void clearfields()
        {
            LFnametxt.Text = "";
            LMnametxt.Text = "";
            LLnametxt.Text = "";
            LPhonenumbertxt.Text = "";
            LEmailtxt.Text = "";
            LaddressTxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (currentindex >= 0 && dt.Rows.Count == 0)
            {
                MessageBox.Show("No Tenant Selected to Updated");
                return;
            }

            int Landlordid;
            try
            {
                Landlordid = Convert.ToInt32(dt.Rows[currentindex]["LANDLORDID"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




            string updateFname = LFnametxt.Text;
            string updateMname = LMnametxt.Text;
            string updateLname = LLnametxt.Text;
            string updatenumber = LPhonenumbertxt.Text;
            string updatemail = LEmailtxt.Text;
            string updateaddress = LaddressTxt.Text;


            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                connection.Open();
                string Updatequery = @"UPDATE LANDLORD SET L_FNAME = @FName, L_MNAME =@MName, L_LNAME =@LName, L_PHONENO =@Phone, L_EMAIL =@Email, L_ADDRESS = @Address WHERE LANDLORDID = @LandlordID";

                using (SQLiteCommand command = new SQLiteCommand(Updatequery, connection))
                {
                    command.Parameters.AddWithValue("@FName", updateFname);
                    command.Parameters.AddWithValue("@MName", updateMname);
                    command.Parameters.AddWithValue("@LName", updateLname);
                    command.Parameters.AddWithValue("@Phone", updatenumber);
                    command.Parameters.AddWithValue("@Email", updatemail);
                    command.Parameters.AddWithValue("@Address", updateaddress);
                    command.Parameters.AddWithValue("@LandlordID", Landlordid);

                    int rowaffected = command.ExecuteNonQuery();

                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Updated succesfully");
                        dt.Rows[currentindex]["L_FNAME"] = updateFname;
                        dt.Rows[currentindex]["L_MNAME"] = updateMname;
                        dt.Rows[currentindex]["L_LNAME"] = updateLname;
                        dt.Rows[currentindex]["L_PHONENO"] = updatenumber;
                        dt.Rows[currentindex]["L_EMAIL"] = updatemail;
                        dt.Rows[currentindex]["L_ADDRESS"] = updateaddress;

                    }
                    else
                    {
                        MessageBox.Show("Error Nothing Was Updated");
                    }
                }
            }
        }

        private void Notes_Click(object sender, EventArgs e)
        {
            if (currentindex == -1 || dt.Rows.Count == 0)
            {
                MessageBox.Show("Please select a tenant first");
                return;
            }
            int LandLordID = Convert.ToInt32(dt.Rows[currentindex]["LANDLORDID"]);
            LandlordNotes note = new LandlordNotes(LandLordID);
            note.Show();

        }
    }
}
