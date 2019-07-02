using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace school_management_system
{
    public partial class frmScholarship : Form
    {

        DataTable dt = new DataTable();
       Connectionstring cs = new Connectionstring();
       clsFunc cf = new clsFunc();
       string st1;
       string st2;
        public frmScholarship()
        {
            InitializeComponent();
        }

        private void frmScholarship_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT ScholarShipname FROM Scholarship", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Scholarship");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["Scholarshipname"].ToString());

                }
                ScholarshipName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ScholarshipName.AutoCompleteCustomSource = col;
                ScholarshipName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         

        private void Reset()
        {
            ScholarshipID.Text = "";
            ScholarshipName.Text = "";
            Description.Text = "";
            Amount.Text = "";
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
            ScholarshipName.Focus();
        }

        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);

                con.Open();
                string ct = "select ScholarshipID from ScholarShipPayment where ScholarshipID=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarshipID"));


                cmd.Parameters["@find"].Value = ScholarshipID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);

                con.Open();


                string cq = "delete from Scholarship where ScholarshipID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "ScholarshipID"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(ScholarshipID.Text);
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ScholarshipName.Text == "")
            {
                MessageBox.Show("Please enter scholarship name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScholarshipName.Focus();
                return;
            }
            if (Amount.Text == "")
            {
                MessageBox.Show("Please enter amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Amount.Focus();
                return;
            }

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Scholarship(Scholarshipname,Description,amount) VALUES (@d2,@d3,@d4)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;



                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Scholarshipname"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.VarChar, 200, "Description"));
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "Amount"));


                cmd.Parameters["@d2"].Value = ScholarshipName.Text.Trim();
                cmd.Parameters["@d3"].Value = Description.Text.Trim();
                cmd.Parameters["@d4"].Value = Amount.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Scholarship Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added new Scholarship'" +ScholarshipName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBcon);
            con.Open();

            string cb = "update Scholarship set Scholarshipname=@d2,Description=@d3,amount=@d4 where ScholarshipID=@d1";

            cmd = new SqlCommand(cb);

            cmd.Connection = con;

            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "Scholarshipid"));

            cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Scholarshipname"));

            cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 50, "Description"));
            cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 50, "Amount"));

            cmd.Parameters["@d1"].Value = Convert.ToInt32(ScholarshipID.Text);
            cmd.Parameters["@d2"].Value = ScholarshipName.Text.Trim();
            cmd.Parameters["@d3"].Value = Description.Text.Trim();
            cmd.Parameters["@d4"].Value = Amount.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            st1 = lblUser.Text;
            st2 = "Updated the Scholarship'" + ScholarshipName.Text + "'";
            cf.LogFunc(st1, System.DateTime.Now, st2);
            Update_record.Enabled = false;
            Autocomplete();
            con.Close();
        }

        private void GetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshipRecord frm = new frmScholarshipRecord();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmScholarship_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);

                con.Open();
                string cm5 = "select ScholarshipID from scholarshippayment where ScholarshipID=@find";
                cmd = new SqlCommand(cm5);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.Int, 10, "ScholarshipID"));


                cmd.Parameters["@find"].Value =ScholarshipID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Scholarship where ScholarShipID='" +ScholarshipID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Delete the Scholarship '" +ScholarshipName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
