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
    public partial class frm_Main_Menu : Form
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
        public frm_Main_Menu()
        {
            InitializeComponent();
        }

         private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

         private void classToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmclass frm = new Frmclass();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSections frm = new FrmSections();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void eventToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEvents frm = new frmEvents();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void hostelEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHostel_info frm = new FrmHostel_info();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void registrationToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmUserRegistrations frm = new frmUserRegistrations();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void loginDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
       
            frmLoginDetails frm = new frmLoginDetails();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void profileEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_student frm = new Frm_student();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
  }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookEntry frm = new frmBookEntry(); //(book entry ka lable User Type and User call kiye)
            frm.lblUserType.Text = UserType.Text; //Main menu k User Type or User Set kiye
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void hostelersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmhosteler frm = new Frmhosteler();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void feeEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClassFeesEntry frm = new frmClassFeesEntry();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void profileEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee frm = new frmEmployee();
            frm.lblUser.Text = UserType.Text;
            frm.lblUserType.Text = User.Text;
            frm.Show();
        }

        private void employeeSalaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeepayment frm = new frmEmployeepayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClassFeePaymentcs frm = new frmClassFeePaymentcs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusFeePayment frm = new FrmBusFeePayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void busCardHoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void eventToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSupplier frm = new FrmSupplier();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void logsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            frmlogs frm = new frmlogs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void bookIssueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentBookIssue frm = new frmStudentBookIssue();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookReturn frm = new frmBookReturn();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void scholarshipEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarship frm = new frmScholarship();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void transportationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrasportation frm = new frmTrasportation();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void hostelFeePaymentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHostelFeePayment frm = new FrmHostelFeePayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeRecordss1 frm = new frmEmployeeRecordss1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void scholarshipPaymentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmscholarshippaymentRecord1 frm = new frmscholarshippaymentRecord1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void scholarshipPaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshippayment frm = new frmScholarshippayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudentrecordsearch1 frm = new frmstudentrecordsearch1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void BookstoolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookentryRecords1 frm = new frmBookentryRecords1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void eventRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEventrecords1cs frm = new frmEventrecords1cs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void busHoldersToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHolderRecord1 frm = new frmBusHolderRecord1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void hostelersToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelerRecords1 frm = new frmHostelerRecords1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            st1 = User.Text;
            st2 = "Successfully logged out";
            cf.LogFunc(st1, System.DateTime.Now, st2);
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }

        private void bookIssueStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmBookissueRecordstudent1 frm = new frmBookissueRecordstudent1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void databaseRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
               
               if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    timer1.Enabled = true;
                    SqlConnection.ClearAllPools();
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.Path + "\\ERPS_db.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_db.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_db.mdf] SET Multi_User ";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    st1 = User.Text;
                    st2 = "Successfully restore the database";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void databaseBackupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                if ((!System.IO.Directory.Exists("C:\\DBBackup")))
                {
                    System.IO.Directory.CreateDirectory("C:\\DBBackup");
                }
                string destdir = "C:\\DBBackup\\ERPS_DB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_DB.mdf] to disk='" + destdir + "'with init,stats=10";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                st1 = User.Text;
                st2 = "Successfully backup the database";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            FrmFee frm = new FrmFee();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void bookReturnToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmBookReturnRecord_Staff_1 frm = new frmBookReturnRecord_Staff_1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void bookIssueStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmBookissueRecordstaff1 frm = new frmBookissueRecordstaff1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void bookReturnStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookReturn_Student_1 frm = new BookReturn_Student_1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusFeePaymentRecord1 frm = new frmBusFeePaymentRecord1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeePaymentRecord1 frm = new frmEmployeePaymentRecord1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void calculatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void taskManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void wordpadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void claToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourseFeePaymentRecord1 frm = new frmCourseFeePaymentRecord1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void hostelFeePaymentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelfeepayRecord1 frm = new frmHostelfeepayRecord1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

     

       

       
        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            st1 = User.Text;
            st2 = "Successfully logged out";
            cf.LogFunc(st1, System.DateTime.Now, st2);
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // toolStripStatusLabel4.Text = System.DateTime.Now.ToString();
            Time.Text = DateTime.Now.ToString();
            timer2.Start();
        }

       

        private void logsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogs frm = new frmlogs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
       
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserRegistrations frm = new frmUserRegistrations();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void studentToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_student frm = new Frm_student();
             frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        
        }

        private void employeeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee frm = new frmEmployee();
            frm.lblUser.Text = UserType.Text;
            frm.lblUserType.Text = User.Text;
            frm.Show();
        }

        private void salaryPaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeepayment frm = new frmEmployeepayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void feePaymentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClassFeePaymentcs frm = new frmClassFeePaymentcs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void hostelFeePaymentToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHostelFeePayment frm = new FrmHostelFeePayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void scholarshipPaymentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshippayment frm = new frmScholarshippayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void databaseBackupToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                if ((!System.IO.Directory.Exists("C:\\DBBackup")))
                {
                    System.IO.Directory.CreateDirectory("C:\\DBBackup");
                }
                string destdir = "C:\\DBBackup\\ERPS_DB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_DB.mdf] to disk='" + destdir + "'with init,stats=10";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                st1 = User.Text;
                st2 = "Successfully backup the database";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void databaseRecoveryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    timer1.Enabled = true;
                    SqlConnection.ClearAllPools();
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_db.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_db.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\ERPS_db.mdf] SET Multi_User ";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    st1 = User.Text;
                    st2 = "Successfully restore the database";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logsToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            frmlogs frm = new frmlogs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            st1 = User.Text;
            st2 = "Successfully logged out";
            cf.LogFunc(st1, System.DateTime.Now, st2);
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }

        private void frm_Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void busHoldersToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHolderReport frm = new frmBusHolderReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void hostelersToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelersReport frm = new frmHostelersReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void classFeePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClassFeePaymentsReport frm = new frmClassFeePaymentsReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void hostelFeePaymentToolStripMenuItem6_Click(object sender, EventArgs e)
        {
        }

        private void scholarshipPaymentToolStripMenuItem5_Click(object sender, EventArgs e)
        {
        }

        private void salaryPaymentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalaryPaymentreport1 frm = new frmSalaryPaymentreport1();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void busFeePaymentToolStripMenuItem6_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void busFeePaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmBusFeePaymentsReport frm = new frmBusFeePaymentsReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelFeePaymentsReport frm = new  frmHostelFeePaymentsReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void SchooltoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchoolinfo frm = new frmSchoolinfo();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshipPaymentsReport frm = new frmScholarshipPaymentsReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
         

        }

        private void busFeePaymentToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusFeePayment frm = new FrmBusFeePayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Contact_Me frm = new Contact_Me();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
         
            Contact_Me frm = new Contact_Me();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void profileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void subjectEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubectEntry frm = new frmSubectEntry();
            frm.lblUserType.Text = UserType.Text; //Main menu k User Type or User Set kiye
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void marksEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMarksEntry frm = new frmMarksEntry();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void studentMarksReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMarksReport frm = new frmMarksReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void subjectRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubjectRecords1 frm = new frmSubjectRecords1();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void marksRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMarksRecord2 frm = new frmMarksRecord2();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void examsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExamEntry frm = new  frmExamEntry();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmstudentReport frm = new frmstudentReport();
           frm.lblUser.Text = User.Text;
           frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeReport frm = new frmEmployeeReport();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void masterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_Main_Menu_Load_1(object sender, EventArgs e)
        {

        }

      

        }
        }
    
        
    

