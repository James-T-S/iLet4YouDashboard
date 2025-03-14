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
    public partial class SearchProperty : Form
    {
        public SearchProperty()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int currentindex = -1;
        string lastsearch = "";


        private void SearchProperty_Load(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string search = SEARCHTXT.Text.Trim();
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
                        string query = @"SELECT * FROM PROPERTY WHERE P_ADDRESS LIKE @search OR P_POSTCODE LIKE @search";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@search", $"%{search}%");
                            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                            da.Fill(dt);
                        }

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No Property found with this address!");
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
                 Addresstxt.Text = row["P_ADDRESS"].ToString();
                Postcodetxt.Text = row["P_POSTCODE"].ToString();
                EPCRatingtxt.Text = row["P_EPCRATING"].ToString();
                EPCEXPIRYTXT.Text = row["P_EPCEXPIRY"].ToString();
                GASCERTEXPIRY.Text = row["P_GASCERTEXPIRY"].ToString();
                RENTTXT.Text = row["P_RENT"].ToString();
                RENTDUETXT.Text = row["P_RENTDATE"].ToString();
                ISVACENTTXT.Text = row["P_ISVACANT"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addresstxt.Text = "";
            Postcodetxt.Text = "";
            EPCRatingtxt.Text = "";
            EPCEXPIRYTXT.Text = "";
            GASCERTEXPIRY.Text = "";
            RENTTXT.Text = "";
            RENTDUETXT.Text = "";
            ISVACENTTXT.Text = "";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (currentindex >= 0 && dt.Rows.Count == 0)
            {
                MessageBox.Show("No Property can be Updated");
                return;
            }

            int PropertyID;
            try
            {
                PropertyID = Convert.ToInt32(dt.Rows[currentindex]["PROPERTYID"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




            string updateAddress = Addresstxt.Text;
            string updatePostcode = Postcodetxt.Text;
            string updateEPCRATING = EPCRatingtxt.Text;
            string updateEPCEXPIRY = EPCEXPIRYTXT.Text;
            string updateGASCERTEXPIRY = GASCERTEXPIRY.Text;
            string updateRENT = RENTTXT.Text;
            string updateRENTDATE = RENTDUETXT.Text;
            string updateISVACENT = ISVACENTTXT.Text;
            string updateEICRexpiry = EICREXPIRYTXT.Text;


            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
            {
                connection.Open();
                string Updatequery = @"UPDATE PROPERTY SET P_ADDRESS = @Address, P_POSTCODE =@Postcode, P_EPCRATING =@Epcrating, P_EPCEXPIRY =@Epcexpiry, P_EICREXPIRY =@Eicrexpiry, P_GASCERTEXPIRY =@Gascertexpiry, P_RENT = @Rent, P_RENTDATE =@Rentdate, P_ISVACANT =@Isvacant WHERE PROPERTYID = @PropertyID";

                using (SQLiteCommand command = new SQLiteCommand(Updatequery, connection))
                {
                   
                    command.Parameters.AddWithValue("@Address", updateAddress);
                    command.Parameters.AddWithValue("@Postcode", updatePostcode);
                    command.Parameters.AddWithValue("@Epcrating", updateEPCRATING);
                    command.Parameters.AddWithValue("@Epcexpiry", updateEPCEXPIRY);
                    command.Parameters.AddWithValue("@Gascertexpiry", updateGASCERTEXPIRY);
                    command.Parameters.AddWithValue("@Rent", Convert.ToDouble(updateRENT));
                    command.Parameters.AddWithValue("@Rentdate", updateRENTDATE);
                    command.Parameters.AddWithValue("@Isvacant", Convert.ToInt32(updateISVACENT));
                    command.Parameters.AddWithValue("@E'7icrexpiry", updateEICRexpiry);
                    command.Parameters.AddWithValue("@PropertyID", PropertyID);


                    int rowaffected = command.ExecuteNonQuery();

                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Updated succesfully");
                        dt.Rows[currentindex]["P_ADDRESS"] = updateAddress;
                        dt.Rows[currentindex]["P_POSTCODE"] = updatePostcode;
                        dt.Rows[currentindex]["P_EPCRATING"] = updateEPCRATING;
                        dt.Rows[currentindex]["P_EPCEXPIRY"] = updateEPCEXPIRY;
                        dt.Rows[currentindex]["P_GASCERTEXPIRY"] = updateGASCERTEXPIRY;
                        dt.Rows[currentindex]["P_RENT"] = updateRENT;
                        dt.Rows[currentindex]["P_RENTDATE"] = updateRENTDATE;
                        dt.Rows[currentindex]["P_ISVACANT"] = updateISVACENT;
                        dt.Rows[currentindex]["P_EICREXPIRY"] = updateEICRexpiry;

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
            int PropertyID = Convert.ToInt32(dt.Rows[currentindex]["PROPERTYID"]);
            TenantNote note = new TenantNote(PropertyID);
            note.Show();

        }
    }
}
