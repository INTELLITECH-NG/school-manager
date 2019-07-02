using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace school_management_system
{
    public partial class frmBusHolderReport : Form
    {
      
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
     
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        SqlDataReader rdr = null;
        public frmBusHolderReport()
        {
            InitializeComponent();
        }
        private void AutocompleteSourcelocation()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Sourcelocation) FROM BusHolders", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];

                cmbSourceLocation.Items.Clear();
                foreach (DataRow drow in dtable.Rows)
                {
                    cmbSourceLocation.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AutocompleteScholarNo()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(AdmissionNo) FROM BusHolders", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                AdmissionNo.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    AdmissionNo.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AutocompleteClass()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Class) FROM Student,BusHolders where Student.AdmissionNo=BusHolders.AdmissionNo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbclass.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbclass.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmBusHolderReport_Load(object sender, EventArgs e)
        {
            AutocompleteStudentname();
            AutocompleteClass();
            AutocompleteScholarNo();
            AutocompleteSourcelocation();
        }

        private void AdmissionNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and Student.AdmissionNo= '" + AdmissionNo.Text + "' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer2.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void frmBusHolderReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text =lblUserType.Text;
            frm.User.Text = lblUser.Text ;
            frm.Show();
        }

        private void cmbSourceLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select distinct BusHolders.AdmissionNo, BusHolders.SourceLocation, BusHolders.StartingDate, Student.AdmissionNo AS Expr1, Student.EnrollmentNo, Student.StudentName, Student.FatherName, Student.MotherName,Student.FatherCN, Student.PermanentAddress, Student.TemporaryAddress, Student.ContactNo, Student.EmailID, Student.DOB, Student.Gender, Student.AdmissionDate, Student.Session, Student.Caste,Student.Religion, Student.Status, Student.Nationality, Student.Class, Student.Section, Student.SchoolID FROM BusHolders INNER JOIN Student ON BusHolders.AdmissionNo = Student.AdmissionNo where SourceLocation= '" + cmbSourceLocation.Text + "' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer5.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new  ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select distinct BusHolders.AdmissionNo, BusHolders.SourceLocation, BusHolders.StartingDate, Student.AdmissionNo AS Expr1, Student.EnrollmentNo, Student.StudentName, Student.FatherName, Student.MotherName,Student.FatherCN, Student.PermanentAddress, Student.TemporaryAddress, Student.ContactNo, Student.EmailID, Student.DOB, Student.Gender, Student.AdmissionDate, Student.Session, Student.Caste,Student.Religion, Student.Status, Student.Nationality, Student.Class, Student.Section, Student.SchoolID FROM BusHolders INNER JOIN Student ON BusHolders.AdmissionNo = Student.AdmissionNo where StartingDate  between @date1 and @date2 order by Studentname ";
                MyCommand.Parameters.Add("@date1", SqlDbType.DateTime, 30, "StartingDate").Value = dateTimePicker1.Value.Date;
                MyCommand.Parameters.Add("@date2", SqlDbType.DateTime, 30, "StartingDate").Value = dateTimePicker2.Value.Date;

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer4.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            txtSourceLocation.Text = "";
            cmbSourceLocation.Text = "";
            crystalReportViewer5.ReportSource = null;
            crystalReportViewer4.ReportSource = null;
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.ToString();
            cmbStudentName.Text = "";
            txtStudentName.Text = "";
            crystalReportViewer3.ReportSource = null;
            AdmissionNo.Text = "";
            crystalReportViewer2.ReportSource = null;
            cmbclass.Text = "";
            cmbSection.Text = "";
           
            crystalReportViewer1.ReportSource = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdmissionNo.Text = "";
            crystalReportViewer2.ReportSource = null;
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            cmbSection.Text = "";
            cmbSection.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(Section) from Student where class= '" + cmbclass.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSection.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutocompleteStudentname()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Studentname) FROM Student,BusHolders where Student.AdmissionNo=BusHolders.AdmissionNo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbStudentName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbStudentName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and Student.Studentname= '" + cmbStudentName.Text + "' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer3.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new  RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and Student.Studentname Like '" + txtStudentName.Text + "%' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer3.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSourceLocation_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and SourceLocation Like '" + txtSourceLocation.Text + "%' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer5.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbclass.Text == "")
                {
                    MessageBox.Show("Please select class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbclass.Focus();
                    return;
                }
                if (cmbSection.Text == "")
                {
                    MessageBox.Show("Please select Section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSection.Focus();
                    return;
                }
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptBusHoders rpt = new RptBusHoders();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and StartingDate between @date1 and @date2 and Class= '" + cmbclass.Text + "'and Section='" + cmbSection.Text + "' order by Studentname ";
                MyCommand.Parameters.Add("@date1", SqlDbType.DateTime, 30, "StartingDate").Value = Date_from.Value.Date;
                MyCommand.Parameters.Add("@date2", SqlDbType.DateTime, 30, "StartingDate").Value = Date_to.Value.Date;

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer1.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbclass.Text = "";
            cmbSection.Text = "";
            cmbSection.Enabled = false;
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            crystalReportViewer1.ReportSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbStudentName.Text = "";
            txtStudentName.Text = "";
            crystalReportViewer3.ReportSource = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            crystalReportViewer4.ReportSource = null;
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.ToString();
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtSourceLocation.Text = "";
            cmbSourceLocation.Text = "";
            crystalReportViewer5.ReportSource = null;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
