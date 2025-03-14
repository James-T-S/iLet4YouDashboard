using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace iLet4You
{
    public partial class SearchTenant : Form
    {
        public SearchTenant()
        {
            InitializeComponent();
        }
        ///removes all white space basscily so if we write mohammed hakeem suleman after the white space will ignore
        DataTable searchresults = new DataTable();
       
        int currentindex = -1; //index starts at 0 on sql so when you press the button will go up one so = 0 which really = 1
        string lastsearch = "";
        private void SearchTenant_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            string search = SearchBartxt.Text.Trim();
            if (string.IsNullOrEmpty(search) )
            {
                MessageBox.Show("Please fill in search bar");
            }

            ///if its not blank then will start searching 
            if(search !=lastsearch)
            {
                currentindex = -1;
                lastsearch = search;
                searchresults.Clear();

                try
                {
                    using(SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
                    {
                        connection.Open();
                        ///LIKE FOR MATCHING LETTER OF STRING PERFECT FOR SEARCH
                        string query = @"SELECT * FROM TENANT WHERE T_FNAME LIKE @search OR T_MNAME LIKE @search OR T_LNAME LIKE @search";
                        using(SQLiteCommand command = new SQLiteCommand(query,connection))
                        {
                            command.Parameters.AddWithValue("@search", $"%{search}%");
                            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                            da.Fill(searchresults);
                        }
                    }

                    if(searchresults.Rows.Count == 0)
                    {
                        MessageBox.Show("No tenant found with that Name!");
                        return;
                    }
                    currentindex = 0;
                    Displaysearch();


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clearfields();
                }
            }
            else
            {
                if(searchresults.Rows.Count == 0)
                {
                    return;
                }
                currentindex = (currentindex + 1) % searchresults.Rows.Count;
                Displaysearch();
            }

        }

        private void Displaysearch()
        {
            if(currentindex >= 0 && currentindex < searchresults.Rows.Count )
            {
                DataRow row = searchresults.Rows[currentindex];
                TenantFnametxt.Text = row["T_FNAME"].ToString();
                TenantMnametxt.Text = row["T_MNAME"].ToString();
                TenantLnametxt.Text = row["T_LNAME"].ToString();
                TenantPhonenumbertxt.Text = row["T_PHONENO"].ToString();
                TenantEmailtxt.Text = row["T_EMAIL"].ToString();
                DBStxt.Text = row["T_DBS"].ToString();
            }
        }

        private void clearfields()
        {
            TenantFnametxt.Text = "";
            TenantMnametxt.Text = "";
            TenantLnametxt.Text = "";
            TenantPhonenumbertxt.Text = "";
            TenantEmailtxt.Text = "";
            DBStxt.Text = "";
        }



        private void Clearbutton_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void NotesUpdate_Click(object sender, EventArgs e)
        {

            if(TenantFnametxt == null ||  TenantMnametxt == null || TenantLnametxt == null || TenantPhonenumbertxt == null || TenantEmailtxt == null || DBStxt == null)
            {
                MessageBox.Show("Nothing to edit :)");
                return;
            }

            if(currentindex >= 0 &&  searchresults.Rows.Count == 0 )
            {
                MessageBox.Show("No Tenant Selected to Updated");
                return;
            }

            int TenantID;
            try
            {
              TenantID=Convert.ToInt32(searchresults.Rows[currentindex]["TENANTID"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




            string updateFname = TenantFnametxt.Text;
            string updateMname = TenantMnametxt.Text;
            string updateLname = TenantLnametxt.Text;
            string updatenumber = TenantPhonenumbertxt.Text;
            string updatemail = TenantEmailtxt.Text;
            string updatedbs = DBStxt.Text;


            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                connection.Open();
                string Updatequery = @"UPDATE TENANT SET T_FNAME = @FName, T_MNAME =@MName, T_LNAME =@LName, T_PHONENO =@Phone, T_EMAIL =@Email, T_DBS = @DBS WHERE TENANTID = @TenantID";

                using(SQLiteCommand command =new SQLiteCommand(Updatequery,connection))
                {
                    command.Parameters.AddWithValue("@FName",updateFname);
                    command.Parameters.AddWithValue("@MName", updateMname);
                    command.Parameters.AddWithValue("@LName", updateLname);
                    command.Parameters.AddWithValue("@Phone", updatenumber);
                    command.Parameters.AddWithValue("@Email", updatemail);
                    command.Parameters.AddWithValue("@DBS", updatedbs);
                    command.Parameters.AddWithValue("@TenantID", TenantID);

                    int rowaffected = command.ExecuteNonQuery();

                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Updated succesfully");
                        searchresults.Rows[currentindex]["T_FNAME"] = updateFname;
                        searchresults.Rows[currentindex]["T_MNAME"] = updateMname;
                        searchresults.Rows[currentindex]["T_LNAME"] = updateLname;
                        searchresults.Rows[currentindex]["T_PHONENO"] = updatenumber;
                        searchresults.Rows[currentindex]["T_EMAIL"] = updatemail;
                        searchresults.Rows[currentindex]["T_DBS"] = updatedbs;

                    }
                    else
                    {
                        MessageBox.Show("Error Nothing Was Updated");
                    }
                }
            }
        }

        private void Notesbutton_Click(object sender, EventArgs e)
        {
            if(currentindex == -1 || searchresults.Rows.Count == 0)
            {
                MessageBox.Show("Please select a tenant first");
                return;
            }
            int TenantID = Convert.ToInt32(searchresults.Rows[currentindex]["TENANTID"]);
            TenantNote note = new TenantNote(TenantID);
            note.Show();

        }
    }
}
