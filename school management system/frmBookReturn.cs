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
    public partial class frmBookReturn : Form
    {
       
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
         clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmBookReturn()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookIssueRecord frm = new frmBookIssueRecord();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Set10.Text = "Book Return";
            frm.Show();
        }
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
            txtReturnID.Text = "R-" + GetUniqueKey(4);
        }
        private void auto1()
        {
            txtReturnID1.Text = "R-" + GetUniqueKey(4);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransactionID.Text == "")
                {
                    MessageBox.Show("Please Retrive TransactionID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Focus();
                    return;
                }
                if (dtpReturnDate.Value.Date < dtpDueDate.Value.Date)
                {
                    MessageBox.Show("Return date can not be less than due date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpReturnDate.Focus();
                    return;
                }

                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select TransactionID  from BookReturnStudent where TransactionID='" +txtTransactionID.Text+ "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Book Returned Already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Text = "";
                    Reset();
                    txtTransactionID.Focus();
                    
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "insert into BookreturnStudent(ReturnID, TransactionID, ReturnDate, Fine) VALUES(@d1,@d2,@d3,@d4)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtReturnID.Text);
                cmd.Parameters.AddWithValue("@d2", txtTransactionID.Text);
                cmd.Parameters.AddWithValue("@d3", dtpReturnDate.Text);
                cmd.Parameters.AddWithValue("@d4", txtFine.Text);

                cmd.ExecuteNonQuery();
                st1 = lblUser.Text;
                st2 = "book  is Returned by Student'"+txtStudentName.Text+"' having accessionNo='" + txtAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully Returned", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                con.Close();
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransactionID1.Text == "")
                {
                    MessageBox.Show("Please Retrive TransactionID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID1.Focus();
                    return;
                }
                if (dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date)
                {
                    MessageBox.Show("Return date can not be less than due date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpReturnDate1.Focus();
                    return;
                }
                auto1();
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct1 = "select TransactionID  from BookReturnStaff where TransactionID='" + txtTransactionID1.Text + "'";

                cmd = new SqlCommand(ct2);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Book Returned Already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID1.Text = "";
                    Reset1();
                    txtTransactionID1.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "insert into BookreturnStaff(ReturnID, TransactionID, ReturnDate, Fine) VALUES(@d1,@d2,@d3,@d4)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtReturnID1.Text);
                cmd.Parameters.AddWithValue("@d2", txtTransactionID1.Text);
                cmd.Parameters.AddWithValue("@d3", dtpReturnDate1.Text);
                cmd.Parameters.AddWithValue("@d4", txtFine1.Text);
                cmd.ExecuteNonQuery();
                st1 = lblUser.Text;
                st2 = " book  is Returned by Staff'"+txtStaffName.Text+"' having accessionNo='" + txtAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully Returned", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBookReturn_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookIssueRecordStaff frm = new frmBookIssueRecordStaff();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Set10.Text = "Book Return";
            frm.Show();
            
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            int st;
            st = dtpReturnDate.Value.Date.Subtract(dtpDueDate.Value.Date).Days;
            if (st >= 0)
            {
                txtFine.Text=(5 *st).ToString();
            }

        }

        private void dtpReturnDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpReturnDate.Value.Date < dtpDueDate.Value.Date)
            {
                MessageBox.Show("Return Date must be greater than issue date", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpReturnDate.Focus();
            }
        }
          private void Reset()
        {
            
            txtAccessionNo.Text = "";
            txtAuthor.Text = "";
            txtBookTitle.Text= "";
            txtClass.Text = "";
            txtSection.Text = "";
            txtBookTitle.Text = "";
            txtEdition.Text = "";
            txtISBN.Text = "";
            txtSubject.Text = "";
            txtStudentName.Text = "";
           
            txtTransactionID.Text = "";
            AdmissionNo.Text = "";
            dtpDueDate.Text = "";
            dtpIssueDate.Text = "";
            dtpReturnDate.Text = "";
            
            
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
                  string cq1 = "delete from BookReturnStudent where TransactionID='" + txtTransactionID.Text + "'";
                  cmd = new SqlCommand(cq1);
                  cmd.Connection = con;
                  RowsAffected = cmd.ExecuteNonQuery();
                  con.Close();

                  if (RowsAffected > 0)
                  {
                      st1 = lblUser.Text;
                      st2 = "Returned book by Student'"+txtStudentName.Text+"'is Deleted  having accessionNo='" + txtAccessionNo.Text + "'";
                      cf.LogFunc(st1, System.DateTime.Now, st2);
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
                  //GetData(); 
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

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            delete_records1();
        }

        private void Reset1()
        {

            txtAccessionNo1.Text = "";
            txtAuthor1.Text = "";
            txtBookTitle1.Text = "";
            txtDepartment1.Text= "";
            txtStaffID.Text = "";
            txtEdition1.Text = "";
            txtISBN1.Text = "";
            txtSubject.Text = "";
            txtStaffName.Text = "";
            txtTransactionID1.Text = "";
            txtsubject1.Text = "";
            dtpDueDate1.Text = "";
            dtpIssueDate1.Text = "";
            dtpReturnDate1.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }
        private void delete_records1()
          {

              try
              {

                  int RowsAffected = 0;

                  con = new SqlConnection(cs.DBcon);
                  con.Open();
                  string cq1 = "delete from BookReturnStaff where TransactionID='" + txtTransactionID1.Text + "'";
                  cmd = new SqlCommand(cq1);
                  cmd.Connection = con;
                  RowsAffected = cmd.ExecuteNonQuery();
                  con.Close();

                  if (RowsAffected > 0)
                  {
                      st1 = lblUser.Text;
                      st2 = "Returned book by Staff'"+txtStaffName.Text+"'  is Deleted  having accessionNo='" + txtAccessionNo.Text + "'";
                      cf.LogFunc(st1, System.DateTime.Now, st2);
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
                  //GetData(); 
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookReturn_Student_ frm = new frmBookReturn_Student_();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransactionID1.Text == "")
                {
                    MessageBox.Show("Please Retrive TransactionID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID1.Focus();
                    return;
                }
                if (dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date)
                {
                    MessageBox.Show("Return date can not be less than due date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpReturnDate1.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "Update BookReturnStaff  Set TransactionID=@d2, ReturnDate=@d3, Fine=@d4 where ReturnID='" + txtReturnID1.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d2", txtTransactionID1.Text);
               cmd.ExecuteReader();
                st1 = lblUser.Text;
                st2 = " Returned  book by staff'"+txtStaffName.Text+"'is Updated having accessionNo='" + txtAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully updated", "BookReturnStaff", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTransactionID.Text == "")
                {
                    MessageBox.Show("Please Retrive TransactionID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Focus();
                    return;
                }
                if (dtpReturnDate.Value.Date < dtpDueDate.Value.Date)
                {
                    MessageBox.Show("Return date can not be less than due date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpReturnDate.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "Update BookReturnStudent  Set TransactionID=@d2, ReturnDate=@d3, Fine=@d4 where ReturnID='" +txtReturnID + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d2",txtTransactionID.Text);
                cmd.Parameters.AddWithValue("@d3",dtpReturnDate.Text);
                cmd.Parameters.AddWithValue("@d4",txtFine.Text);
                cmd.ExecuteReader();
                st1 = lblUser.Text;
                st2 = "Returned book by student is Updated having accessionNo='" + txtAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
               MessageBox.Show("Successfully updated", "BookReturnStudent", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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

        private void dtpReturnDate1_ValueChanged(object sender, EventArgs e)
        {
            int st;
            st = dtpReturnDate1.Value.Date.Subtract(dtpDueDate1.Value.Date).Days;
            if (st >= 0)
            {
                txtFine1.Text = (5 * st).ToString();
            }
        }

        private void dtpReturnDate1_Validating(object sender, CancelEventArgs e)
        {
            if (dtpReturnDate1.Value.Date < dtpDueDate1.Value.Date)
            {
                MessageBox.Show("Return Date must be greater than issue date", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpReturnDate1.Focus();
            }
        }

        private void dtpIssueDate1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmBookReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void btnNewRecord1_Click(object sender, EventArgs e)
        {
            Reset1();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
