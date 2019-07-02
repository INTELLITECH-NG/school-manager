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
    public partial class frmStudentBookIssue : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;

        public frmStudentBookIssue()
        {
            InitializeComponent();
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
                    cmbadmissionno.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutocompleStaffID()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(staffID) from Employee ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbStaffID.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
         
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txtTransactionID.Text = "T-" + GetUniqueKey(8);
        }

        private void auto1()
        {
            txtTransactionID1.Text = "T-" + GetUniqueKey(8);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccessionNo.Text == "")
                {
                    MessageBox.Show("Please Select AccessionNo of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Focus();
                    return;
                }
                if (cmbadmissionno.Text == "")
                {
                    MessageBox.Show("Please Select AdmissionNo of Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Focus();
                    return;
                }
                if (txtBookTitle.Text == "")
                {
                    MessageBox.Show("Please Select Book title of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookTitle.Focus();
                    return;
                }
                if (txtStudentName.Text == "")
                {
                    MessageBox.Show("Please Select StudentName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStudentName.Focus();
                    return;
                }
                if (dtpDueDate.Value.Date < dtpIssueDate.Value.Date)
                {
                    MessageBox.Show("Due date can not be less than from  Issuedate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDueDate.Focus();
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb1 = "insert into StudentBookissue(TransactionID, IssueDate, DueDate, AccessionNo,AdmissionNo, Status) VALUES(@d1,@d2,@d3,@d4,@d5,@d6)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1",txtTransactionID.Text);
            
                cmd.Parameters.AddWithValue("@d4", cmbAccessionNo.Text);
                cmd.Parameters.AddWithValue("@d5",cmbadmissionno.Text );
                cmd.Parameters.AddWithValue("@d6",txtStatus.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                st1 = lblUser.Text;
                st2 = "book  is issued by Student'"+txtStudentName.Text+"'  having accessionNo='" + cmbAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmbadmissionno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT StudentName,class,Section FROM student WHERE AdmissionNo = '" +cmbadmissionno.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    txtStudentName.Text = rdr.GetString(0).Trim();


                    txtClass.Text = GetString(1).Trim();

                    txtsection.Text= GetString(2).Trim();

                 
                    txtStudentName.Focus();
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
        private void AutocompleAccessionNo()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(AccessionNo) from Book";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   cmbAccessionNo.Items.Add(rdr[2]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutocompleAccessionNo1()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select  RTRIM(AccessionNo) from Book";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbAccessionNo1.Items.Add(rdr[2]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmStudentBookIssue_Load(object sender, EventArgs e)
        {
            AutocompleAccessionNo();
            AutocompleScholarNo();
            AutocompleAccessionNo1();
            AutocompleStaffID();
            dtpDueDate.Text = dtpIssueDate.Value.Date.AddDays(5).ToString();
            dtpDueDate1.Text = dtpIssueDate1.Value.Date.AddDays(5).ToString();
     
        }

        private void cmbAccessionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT BookTitle,Author,Subject,ISBN,Edition FROM Book WHERE AccessionNo = '" + cmbAccessionNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    txtBookTitle.Text= rdr.GetString(0).Trim();
                    txtsubject.Text = rdr.GetString(2).Trim();
                    txtISBN.Text= rdr.GetString(3).Trim();
                    txtEdition.Text= rdr.GetString(4).Trim();


                    txtStudentName.Focus();
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

        private void cmbAccessionNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT BookTitle,Author,Subject FROM Book WHERE AccessionNo = '" + cmbAccessionNo1.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    txtBookTitle1.Text = rdr.GetString(0).Trim();


                    txtAuthor1.Text = rdr.GetString(1).Trim();

                    txtsubject1.Text = rdr.GetString(2).Trim();
                    txtISBN1.Text = rdr.GetString(3).Trim();
                    txtEdition1.Text = rdr.GetString(4).Trim();


                    cmbAccessionNo1.Focus();
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

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT StaffName FROM Employee WHERE StaffID = '" + cmbStaffID.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    txtStaffName.Text = rdr.GetString(0).Trim();
                    txtDepartment1.Text = rdr.GetString(1).Trim();

                   cmbAccessionNo1.Focus();
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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccessionNo1.Text == "")
                {
                    MessageBox.Show("Please Select AccessionNo of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID1.Focus();
                    return;
                }
                if (cmbStaffID.Text == "")
                {
                    MessageBox.Show("Please Select StaffID of Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbStaffID.Focus();
                    return;
                }
                if (txtBookTitle1.Text == "")
                {
                    MessageBox.Show("Please Select Book title of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookTitle1.Focus();
                    return;
                }
                if (txtStaffName.Text == "")
                {
                    MessageBox.Show("Please Select StaffName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStaffName.Focus();
                    return;
                }
                if (dtpDueDate1.Value.Date < dtpIssueDate1.Value.Date)
                {
                    MessageBox.Show("Due date can not be less than from  Issuedate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDueDate1.Focus();
                    return;
                }
                auto1();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Bookissuestaff(TransactionID, IssueDate, DueDate, AccessionNo,StaffID, Status) VALUES(@d1,@d3,@d4,@d5,@d6)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtTransactionID1.Text);
                cmd.Parameters.AddWithValue("@d2", dtpIssueDate.Text);
                cmd.Parameters.AddWithValue("@d3", dtpDueDate.Text);
              
                cmd.Parameters.AddWithValue("@d6", txtStatus.Text);
                cmd.ExecuteNonQuery();
                st1 = lblUser.Text;
                st2 = "book  is issued By Staff'"+txtStaffName.Text+"' having accessionNo='" + cmbAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;


                con.Close();
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDueDate.Text = dtpIssueDate.Value.Date.AddDays(5).ToString();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookIssueRecord frm = new  frmBookIssueRecord();
            frm.lblUser.Text=lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Set1.Text = "Book issue";
            frm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookIssueRecordStaff frm1 = new frmBookIssueRecordStaff();
            frm1.lblUser.Text = lblUser.Text;
            frm1.lblUserType.Text = lblUserType.Text;
            frm1.SET.Text = "Book Issues";
            frm1.Show();
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (cmbAccessionNo.Text == "")
                {
                    MessageBox.Show("Please Select AccessionNo of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Focus();
                    return;
                }
                if (cmbadmissionno.Text == "")
                {
                    MessageBox.Show("Please Select AdmissionNo of Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID.Focus();
                    return;
                }
                if (txtBookTitle.Text == "")
                {
                    MessageBox.Show("Please Select Book title of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookTitle.Focus();
                    return;
                }
                if (txtStudentName.Text == "")
                {
                    MessageBox.Show("Please Select StudentName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStudentName.Focus();
                    return;
                }
                if (dtpDueDate.Value.Date < dtpIssueDate.Value.Date)
                {
                    MessageBox.Show("Due date can not be less than from  Issuedate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDueDate.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "Update StudentBookIssue IssueDate=@d1, DueDate=@d2, AccessionNo=@d3,AdmissionNo=@d4, Status=@d5 where TransactionID='" + txtTransactionID.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1",dtpIssueDate.Text);
              
                cmd.Parameters.AddWithValue("@d4", cmbadmissionno.Text);
                cmd.Parameters.AddWithValue("@d5", txtStatus.Text);
     
                cmd.ExecuteReader();
                con.Close();
                st1 = lblUser.Text;
                st2 = " issued book by Student'"+txtStudentName.Text+"'is Updated having accessionNo='" + cmbAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully updated", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
             try
            {
                if (cmbAccessionNo1.Text == "")
                {
                    MessageBox.Show("Please Select AccessionNo of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransactionID1.Focus();
                    return;
                }
                if (cmbStaffID.Text == "")
                {
                    MessageBox.Show("Please Select StaffID of Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbStaffID.Focus();
                    return;
                }
                if (txtBookTitle1.Text == "")
                {
                    MessageBox.Show("Please Select Book title of Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookTitle1.Focus();
                    return;
                }
                if (txtStaffName.Text == "")
                {
                    MessageBox.Show("Please Select StaffName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStaffName.Focus();
                    return;
                }
                if (dtpDueDate1.Value.Date < dtpIssueDate1.Value.Date)
                {
                    MessageBox.Show("Due date can not be less than from  Issuedate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDueDate1.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "Update BookIssueStaff Set IssueDate=@d1, DueDate=@d2, AccessionNo=@d3,StaffID=@d4, Status=@d5 where TransactionID='" + txtTransactionID1.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", dtpIssueDate1.Text);
                cmd.Parameters.AddWithValue("@d2", dtpDueDate1.Text);
                cmd.Parameters.AddWithValue("@d3", cmbAccessionNo1.Text);
                cmd.Parameters.AddWithValue("@d4", cmbStaffID.Text);
                cmd.Parameters.AddWithValue("@d5", txtStatus.Text);

                cmd.ExecuteReader();
                con.Close();
                st1 = lblUser.Text;
                st2 = " issued book of Staff'"+txtStaffName.Text+"' is Updated  having accessionNo='" + cmbAccessionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully updated", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpIssueDate1_ValueChanged(object sender, EventArgs e)
        {
            dtpDueDate1.Text = dtpIssueDate1.Value.Date.AddDays(5).ToString();
        }

        private void Reset()
        {
            cmbAccessionNo.Text = "";
            txtsection.Text = "";
            txtAuthor.Text = "";
            txtBookTitle.Text= "";
            txtClass.Text = "";
            txtBookTitle.Text = "";
            txtEdition.Text = "";
            txtISBN.Text = "";
            txtStatus.Text = "";
            txtStudentName.Text = "";
            txtsubject.Text = "";
            txtTransactionID.Text = "";
            cmbadmissionno.Text = "";
            dtpDueDate.Text = "";
            dtpIssueDate.Text = "";
            
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
                string ct = "select TransactionID from BookReturnStudent where TransactionID=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "TransactionID"));


                cmd.Parameters["@find"].Value =txtTransactionID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already use in BooK Return Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from studentBookissue where TransactionID='" +txtTransactionID.Text+ "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = " issued book by Staff'"+txtStaffName.Text+"' is Deleted  having accessionNo='" + cmbAccessionNo.Text + "'";
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
            
            txtsection.Text = "";
            txtAuthor1.Text = "";
            cmbAccessionNo1.Text = "";
            cmbStaffID.Text = "";
            txtBookTitle1.Text = "";
            txtEdition1.Text = "";
            txtISBN1.Text = "";
            txtStatus1.Text = "";
            txtDepartment1.Text = "";
            txtStaffName.Text="";
            txtTransactionID1.Text = "";
       
            dtpDueDate1.Text = "";
            dtpIssueDate1.Text = "";

            
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
                string ct = "select TransactionID from BookReturnStaff where TransactionID=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "TransactionID"));


                cmd.Parameters["@find"].Value =txtTransactionID1.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already use in BooK Return Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete Bookissuestaff where TransactionID='" +txtTransactionID1.Text+ "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = " issued book  by Student'"+txtStudentName.Text+"' is Deleted  having accessionNo='" + cmbAccessionNo.Text + "'";
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

        private void frmStudentBookIssue_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
        }

    }

