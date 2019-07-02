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
    public partial class frmSchoolinfo : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;

        public frmSchoolinfo()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (txtSchoolName.Text== "")
                {
                    MessageBox.Show("Please Enter SchoolName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSchoolName.Focus();
                    return;
                }
                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please enter ContactNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactNo.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

              
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into school(SchoolName,Address,ContactNo,Email,Fax,Website) VALUES ('" + txtSchoolName.Text + "','" + txtAddress.Text + "','" + txtContactNo.Text + "','" + txtEmailID.Text + "','" + txtFax.Text + "','" + txtWebsite.Text + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                //GetData();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added the New School '" +txtSchoolName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSchoolinfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {


                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "update School set SchoolName='" + txtSchoolName.Text + "',Address='" + txtAddress.Text + "',ContactNo='" + txtContactNo.Text + "',Email='" + txtEmailID.Text + "',Fax='" + txtFax.Text + "',Website='" + txtWebsite.Text + "' where  ID='" + txtID.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                //GetData();
                MessageBox.Show("Successfully updated", "School Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the  School '" +txtSchoolName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate_record.Enabled = false;


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

        private void frmSchoolinfo_Load(object sender, EventArgs e)
        {
            //GetData();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void Reset()
        {

            txtSchoolName.Text = "";
            txtEmailID.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtID.Text= "";
            txtWebsite.Text = "";
            txtFax.Text = "";

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int RowsAffected = 0;

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cm5 = "select SchoolID from Student where SchoolID=@find";


                cmd = new SqlCommand(cm5);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.Int, 10, "SchoolID"));


                cmd.Parameters["@find"].Value = txtID.Text;


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
                string cq1 = "delete from School where ID = '" + txtID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the School'" + txtSchoolName.Text + "'";
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
                //GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchoolRecords frm = new frmSchoolRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }
    }
}
