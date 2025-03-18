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
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        DataTable dt3 = new DataTable();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        int currentlandlordindex = -1;
        int currenttenantindex = -1;
        int currentpropertyindex = -1;

        string lastlandlordsearch = "";
        string lasttenantsearch = "";
        string lastpropertysearch = "";

        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {

            string search = Nametxt.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please fill in search bar");
                return;
            }

            ///if its not blank then will start searching 
            if (search != lastlandlordsearch)
            {
                currentlandlordindex = -1;
                lastlandlordsearch = search;
                dt3.Clear();

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
                            da.Fill(dt3);
                        }

                        if (dt3.Rows.Count == 0)
                        {
                            MessageBox.Show("No LANDLORD found with that Name!");
                            return;
                        }
                        currentlandlordindex = 0;
                        Displaysearch1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (dt3.Rows.Count == 0)
                {
                    return;
                }
                currentlandlordindex = (currentlandlordindex + 1) % dt3.Rows.Count;
                Displaysearch1();


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
            if (currentlandlordindex < 0 && dt3.Rows.Count == 0)
            {
                MessageBox.Show("No LandLord Selected to Updated");
                return;
            }

            int Landlordid;
            try
            {
                Landlordid = Convert.ToInt32(dt3.Rows[currentlandlordindex]["LANDLORDID"]);

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
                        dt3.Rows[currentlandlordindex]["L_FNAME"] = updateFname;
                        dt3.Rows[currentlandlordindex]["L_MNAME"] = updateMname;
                        dt3.Rows[currentlandlordindex]["L_LNAME"] = updateLname;
                        dt3.Rows[currentlandlordindex]["L_PHONENO"] = updatenumber;
                        dt3.Rows[currentlandlordindex]["L_EMAIL"] = updatemail;
                        dt3.Rows[currentlandlordindex]["L_ADDRESS"] = updateaddress;

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
            if (currentlandlordindex == -1 || dt3.Rows.Count == 0)
            {
                MessageBox.Show("Please select a tenant first");
                return;
            }
            int LandLordID = Convert.ToInt32(dt3.Rows[currentlandlordindex]["LANDLORDID"]);
            LandlordNotes note = new LandlordNotes(LandLordID);
            note.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Displaysearch1()
        {
            if (currentlandlordindex >= 0 && currentlandlordindex < dt3.Rows.Count)
            {
                DataRow row = dt3.Rows[currentlandlordindex];
                LFnametxt.Text = row["L_FNAME"].ToString();
                LMnametxt.Text = row["L_MNAME"].ToString();
                LLnametxt.Text = row["L_LNAME"].ToString();
                LaddressTxt.Text = row["L_ADDRESS"].ToString();
                LPhonenumbertxt.Text = row["L_PHONENO"].ToString();
                LEmailtxt.Text = row["L_EMAIL"].ToString();

            }
        }
        private void Displaysearch2()
        {
            if (currentpropertyindex >= 0 && currentpropertyindex < dt.Rows.Count)
            {
                DataRow row = dt.Rows[currentpropertyindex];
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
        private void Displaysearch3()
        {
            if (currenttenantindex >= 0 && currenttenantindex < dt2.Rows.Count)
            {
                DataRow row = dt2.Rows[currenttenantindex];
                TenantFnametxt.Text = row["T_FNAME"].ToString();
                TenantMnametxt.Text = row["T_MNAME"].ToString();
                TenantLnametxt.Text = row["T_LNAME"].ToString();
                TenantPhonenumbertxt.Text = row["T_PHONENO"].ToString();
                TenantEmailtxt.Text = row["T_EMAIL"].ToString();
                DBStxt.Text = row["T_DBS"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search2 = SearchBartxt.Text.Trim();
            if (string.IsNullOrEmpty(search2))
            {
                MessageBox.Show("Please fill in search bar");
                return;
            }

            ///if its not blank then will start searching 
            if (search2 != lasttenantsearch)
            {
                currenttenantindex = -1;
                lasttenantsearch = search2;
                dt2.Clear();

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
                    {
                        connection.Open();
                        ///LIKE FOR MATCHING LETTER OF STRING PERFECT FOR SEARCH
                        string query = @"SELECT * FROM TENANT WHERE T_FNAME LIKE @search OR T_MNAME LIKE @search OR T_LNAME LIKE @search";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@search", $"%{search2}%");
                            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                            da.Fill(dt2);
                        }
                    }

                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("No tenant found with that Name!");
                        return;
                    }
                    currenttenantindex = 0;
                    Displaysearch3();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clearfields2();
                }
            }
            else
            {
                if (dt2.Rows.Count == 0)
                {
                    return;
                }
                currenttenantindex = (currenttenantindex + 1) % dt2.Rows.Count;
                Displaysearch3();
            }
        }

        private void Notesbutton_Click(object sender, EventArgs e)
        {

            if (currenttenantindex == -1 || dt2.Rows.Count == 0)
            {
                MessageBox.Show("Please select a tenant first");
                return;
            }
            int TenantID = Convert.ToInt32(dt2.Rows[currenttenantindex]["TENANTID"]);
            TenantNote note = new TenantNote(TenantID);
            note.Show();
        }

        private void NotesUpdate_Click(object sender, EventArgs e)
        {
            if (TenantFnametxt == null || TenantMnametxt == null || TenantLnametxt == null || TenantPhonenumbertxt == null || TenantEmailtxt == null || DBStxt == null)
            {
                MessageBox.Show("Nothing to edit :)");
                return;
            }

            if (currenttenantindex >= 0 && dt2.Rows.Count == 0)
            {
                MessageBox.Show("No Tenant Selected to Updated");
                return;
            }

            int TenantID;
            try
            {
                TenantID = Convert.ToInt32(dt2.Rows[currenttenantindex]["TENANTID"]);

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

                using (SQLiteCommand command = new SQLiteCommand(Updatequery, connection))
                {
                    command.Parameters.AddWithValue("@FName", updateFname);
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
                        dt2.Rows[currenttenantindex]["T_FNAME"] = updateFname;
                        dt2.Rows[currenttenantindex]["T_MNAME"] = updateMname;
                        dt2.Rows[currenttenantindex]["T_LNAME"] = updateLname;
                        dt2.Rows[currenttenantindex]["T_PHONENO"] = updatenumber;
                        dt2.Rows[currenttenantindex]["T_EMAIL"] = updatemail;
                        dt2.Rows[currenttenantindex]["T_DBS"] = updatedbs;

                    }
                    else
                    {
                        MessageBox.Show("Error Nothing Was Updated");
                    }
                }
            }
        }

        private void clearfields2()
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
            clearfields2();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string search3 = SEARCHTXT.Text.Trim();
            if (string.IsNullOrEmpty(search3))
            {
                MessageBox.Show("Please fill in search bar");
            }

            ///if its not blank then will start searching 
            if (search3 != lastpropertysearch)
            {
                currentpropertyindex = -1;
                lastpropertysearch = search3;
                dt.Clear();

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBiLet4You.db"))
                    {
                        connection.Open();
                        string query = @"SELECT * FROM PROPERTY WHERE P_ADDRESS LIKE @search OR P_POSTCODE LIKE @search";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@search", $"%{search3}%");
                            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                            da.Fill(dt);
                        }

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No Property found with this address!");
                            return;
                        }
                        currentpropertyindex = 0;
                        Displaysearch2();
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
                currentpropertyindex = (currentpropertyindex + 1) % dt.Rows.Count;
                Displaysearch2();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (currentpropertyindex == -1 || dt.Rows.Count == 0)
            {
                MessageBox.Show("Please select a property first");
                return;
            }
            int PropertyID = Convert.ToInt32(dt.Rows[currentpropertyindex]["PROPERTYID"]);
            PropertyNotescs note = new PropertyNotescs(PropertyID);
            note.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentpropertyindex >= 0 && dt.Rows.Count == 0)
            {
                MessageBox.Show("No Property can be Updated");
                return;
            }

            int PropertyID;
            try
            {
                PropertyID = Convert.ToInt32(dt.Rows[currentpropertyindex]["PROPERTYID"]);

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
                    command.Parameters.AddWithValue("@Eicrexpiry", updateEICRexpiry);
                    command.Parameters.AddWithValue("@PropertyID", PropertyID);


                    int rowaffected = command.ExecuteNonQuery();

                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Updated succesfully");
                        dt.Rows[currentpropertyindex]["P_ADDRESS"] = updateAddress;
                        dt.Rows[currentpropertyindex]["P_POSTCODE"] = updatePostcode;
                        dt.Rows[currentpropertyindex]["P_EPCRATING"] = updateEPCRATING;
                        dt.Rows[currentpropertyindex]["P_EPCEXPIRY"] = updateEPCEXPIRY;
                        dt.Rows[currentpropertyindex]["P_GASCERTEXPIRY"] = updateGASCERTEXPIRY;
                        dt.Rows[currentpropertyindex]["P_RENT"] = updateRENT;
                        dt.Rows[currentpropertyindex]["P_RENTDATE"] = updateRENTDATE;
                        dt.Rows[currentpropertyindex]["P_ISVACANT"] = updateISVACENT;
                        dt.Rows[currentpropertyindex]["P_EICREXPIRY"] = updateEICRexpiry;

                    }
                    else
                    {
                        MessageBox.Show("Error Nothing Was Updated");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (currentpropertyindex == -1 || dt.Rows.Count == 0)
            {
                MessageBox.Show("Please select a tenant first");
                return;
            }
            int PropertyID = Convert.ToInt32(dt.Rows[currentpropertyindex]["PROPERTYID"]);
            TenantNote note = new TenantNote(PropertyID);
            note.Show();
        }
    }
}
