using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace school_management_system
{
    public partial class FrmSupplier : Form
    {

   
        DataTable dtable = new DataTable();
        SqlConnection con = null;
   
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
       public string S1, S2, S3;
       public static string GetUniqueKey(int maxSize)
       {
           char[] chars = new char[62];
           chars =
           "123456789".ToCharArray();
           byte[] data = new byte[1];
           RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
           crypto.GetNonZeroBytes(data);
           data = new byte[maxSize];
           crypto.GetNonZeroBytes(data);
           StringBuilder result = new StringBuilder(maxSize);
           foreach (byte b in data)
           {
               result.Append(chars[b % (chars.Length)]);
           }
           return result.ToString();
       }
       private void auto()
       {
           ID.Text = "S-" + GetUniqueKey(4);
       }
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
           
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text=="")
                {
                    MessageBox.Show("Please Enter Supplier name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierName.Focus();
                    return;
                }
                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please Enter ContactNo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactNo.Focus();
                    return;
                }
                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                } 
                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Supplier(ID,SupplierName, Address, ContactNo, EmailID) VALUES (@d1,@d2,@d6,@d7,@d8)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@d1",ID.Text);
                cmd.Parameters.AddWithValue("@d2",txtSupplierName.Text);
             
                cmd.Parameters.AddWithValue("@d6",txtAddress.Text);
                cmd.Parameters.AddWithValue("@d7",txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d8",txtEmail.Text);

                cmd.ExecuteReader();
            
                con.Close();
               // GetData();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added the New Supplier '" + txtSupplierName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FrmSupplier_FormClosing(object sender, FormClosingEventArgs e)
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
                string cb = "update Supplier set SupplierName='" + txtSupplierName.Text + "',Address='" + txtAddress.Text + "',ContactNo='" + txtContactNo.Text + "',EmailID='" + txtEmail.Text + "' where  ID='" + ID.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                 cmd.ExecuteReader();
                 //GetData();
                MessageBox.Show("Successfully updated", "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the Supplier'" +txtSupplierName.Text + "'";
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
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Supplier where ID = '" + ID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the New Supplier '" +txtSupplierName.Text + "'";
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
              //  GetData(); 
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
        private void Reset()
        {
      
            txtSupplierName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            ID.Text = "";
            
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }

       
        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBookSuppliers frm = new FrmBookSuppliers();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }
           
            
        }
    }

