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
    public partial class FrmHostel_info : Form
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
        public FrmHostel_info()
        {
            InitializeComponent();
        }

        private void FrmHostel_info_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
               try
            {
                if (txtHostelName.Text == "")
                {
                    MessageBox.Show("Please enter hostel name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHostelName.Focus();
                    return;
                }
                if (txtHostelFees.Text == "")
                {
                    MessageBox.Show("Please enter hostel fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHostelFees.Focus();
                    return;
                }
                if (txtPhoneNo.Text == "")
                {
                    MessageBox.Show("Please enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNo.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select HostelName from HostelInfo where HostelName='" +txtHostelName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Hostel Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHostelName.Text = "";
                    txtHostelName.Focus();
                   


                   if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Hostelinfo(HostelName,Hostel_Address,Hostel_Phone,ManagedBy,Hostel_ContactNo,HostelFees) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtHostelName.Text);
                cmd.Parameters.AddWithValue("@d2", txtAddress.Text);
                cmd.Parameters.AddWithValue("@d3", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@d4", txtManagedBy.Text);
                cmd.Parameters.AddWithValue("@d5", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d6",txtHostelFees.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                // GetData();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "added the New Hostel '" + txtHostelName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            txtHostelFees.Text = "";
            txtID.Text = "";
            txtHostelName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            txtManagedBy.Text = "";
            txtPhoneNo.Text = "";
           btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled= false;
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cm5 = "select HostelName from Hosteler where HostelName=@find";
               cmd = new SqlCommand(cm5);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 150, "HostelName"));
                cmd.Parameters["@find"].Value = txtHostelName.Text;
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
                string cq1 = "delete from Hostelinfo where ID='" +txtID.Text+ "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the Hostel '" + txtHostelName.Text + "'";
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

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "update Hostelinfo set Hostelname=@d2,Hostel_address=@d3,Hostel_Phone=@d4,ManagedBy=@d5,Hostel_ContactNo=@d6,HostelFees=@d7 where ID=@d1";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d2", txtHostelName.Text);
                cmd.Parameters.AddWithValue("@d1", txtID.Text);
                cmd.Parameters.AddWithValue("@d3", txtAddress.Text);
                cmd.Parameters.AddWithValue("@d4", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@d5", txtManagedBy.Text);
                cmd.Parameters.AddWithValue("@d6", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d7", txtHostelFees.Text);
                 cmd.ExecuteReader();
                MessageBox.Show("Successfully updated", "Hostel Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Deleted the Hostel '" + txtHostelName.Text + "'";
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHostelinfoRecord frm = new FrmHostelinfoRecord();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
            frm.GetData();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            txtHostelFees.Text = "";
            txtID.Text = "";
            txtHostelName.Text = "";
            txtContactNo.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
            txtManagedBy.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;

        }

        private void FrmHostel_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
            
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
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
        }
        }
    

