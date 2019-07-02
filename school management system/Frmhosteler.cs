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
    public partial class Frmhosteler : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        Connectionstring cs = new Connectionstring();

        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public Frmhosteler()
        {
            InitializeComponent();
        }

        private void Frmhosteler_Load(object sender, EventArgs e)
        {
            AutocompleScholarNo();
            hostelName();
        }

        private void hostelName()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(hostelName) from Hostelinfo ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbHostelName.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutocompleScholarNo()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(AdmissionNo) from student ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    AdmissionNo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (AdmissionNo.Text == "")
                {
                    MessageBox.Show("Please select AdmissionNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdmissionNo.Focus();
                    return;
                }
                if (cmbHostelName.Text == "")
                {
                    MessageBox.Show("Please select hostel name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbHostelName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select AdmissionNo from Hosteler where AdmissionNo='" + AdmissionNo.Text +"'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbHostelName.Text = "";
                    cmbsection.Text = "";
                    txtClass.Text = "";
                    StudentName.Text = "";
                    cmbHostelName.Focus();

                  if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Hosteler(AdmissionNo,HostelName,joiningDate) VALUES (@d1,@d2,@d3)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1",AdmissionNo.Text);
                cmd.Parameters.AddWithValue("@d2",cmbHostelName.Text);
                cmd.Parameters.AddWithValue("@d3",dtpJoiningDate.Text);
               
                cmd.ExecuteNonQuery();
                con.Close();
       
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added the New Hosteler '" +StudentName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdmissionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT StudentName,class,Section FROM student WHERE AdmissionNo = '" + AdmissionNo.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    StudentName.Text = rdr.GetString(0).Trim();


                    txtClass.Text = rdr.GetString(1).Trim();

                    cmbsection.Text = rdr.GetString(2).Trim();
                    cmbHostelName.Focus();
                }


                if ((rdr != null))
                {
                    rdr.Close();
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

        private void Reset()
        {
            AdmissionNo.Text = "";
            txtClass.Text = "";
            cmbHostelName.Text = "";
             cmbsection.Text = "";
            dtpJoiningDate.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Hosteler where AdmissionNO='" + AdmissionNo.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Delete the Hosteler '" + StudentName.Text + "'";
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
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelerRecords frm = new frmHostelerRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
    
            frm.Show();
            
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

       

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "update Hosteler set HostelName=@d3,joiningDate=@d4 where AdmissionNo='"+AdmissionNo.Text+"'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
             
                cmd.Parameters.AddWithValue("@d3", cmbHostelName.Text);
                cmd.Parameters.AddWithValue("@d4", dtpJoiningDate.Text);
               
                cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Hostel Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Update the Hosteler '" +StudentName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate_record.Enabled = false;
                FrmHostelinfoRecord frm = new FrmHostelinfoRecord();
                frm.GetData();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        }

    
        }

    

      
