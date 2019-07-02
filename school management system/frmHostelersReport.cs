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
    public partial class frmHostelersReport : Form
    {
        
        DataTable dtable = new DataTable();
   
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
  
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;

        public frmHostelersReport()
        {
            InitializeComponent();
        }
        private void AutocompleteStudentname()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Studentname) FROM Student,Hosteler where Student.AdmissionNo=Hosteler.AdmissionNo", CN);
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
        private void AutocompleteScholarNo()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(AdmissionNo) FROM Hosteler", CN);
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
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Class) FROM Student,Hosteler where Student.AdmissionNo=Hosteler.AdmissionNo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbClass.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbClass.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmHostelersReport_Load(object sender, EventArgs e)
        {
            AutocompleteClass();
            AutocompleteScholarNo();
            AutocompleteHostelname();
            AutocompleteStudentname();
        }
        private void AutocompleteHostelname()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(hostelname) FROM Hosteler ", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbHostelName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbHostelName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void AdmissionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                 RptHostelers rpt = new  RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and Student.AdmissionNo= '" +AdmissionNo.Text + "' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer2.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbHostelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptHostelers rpt = new RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and hostelname= '" + cmbHostelName.Text + "' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer5.ReportSource = rpt;


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
                RptHostelers rpt = new RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and Student.Studentname Like '" + txtStudentName.Text + "%' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer3.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptHostelers rpt = new RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and Student.Studentname= '" + cmbStudentName.Text + "' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer3.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbSection.Items.Clear();
            cmbSection.Text = "";
            cmbSection.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(Section) from Student where class= '" +cmbClass.Text + "'";

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClass.Text == "")
                {
                    MessageBox.Show("Please select class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClass.Focus();
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
                RptHostelers rpt = new RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and  JoiningDate between @date1 and @date2 and Class= '" + cmbClass.Text + "'and Section='" + cmbSection.Text + "' order by Studentname ";
                MyCommand.Parameters.Add("@date1", SqlDbType.DateTime, 30, "JoiningDate").Value = Date_from.Value.Date;
                MyCommand.Parameters.Add("@date2", SqlDbType.DateTime, 30, "JoiningDate").Value = Date_to.Value.Date;

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer1.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptHostelers rpt = new RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and JoiningDate between @date1 and @date2 order by Studentname ";
                MyCommand.Parameters.Add("@date1", SqlDbType.DateTime, 30, "JoiningDate").Value = dateTimePicker1.Value.Date;
                MyCommand.Parameters.Add("@date2", SqlDbType.DateTime, 30, "JoiningDate").Value = dateTimePicker2.Value.Date;

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer4.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHostelName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptHostelers rpt = new RptHostelers();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and hostelname Like '" + txtHostelName.Text + "%' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Hosteler");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                crystalReportViewer5.ReportSource = rpt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHostelersReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtHostelName.Text = "";
            cmbHostelName.Text = "";
            crystalReportViewer5.ReportSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbStudentName.Text = "";
            txtStudentName.Text = "";
            crystalReportViewer3.ReportSource = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdmissionNo.Text = "";
            crystalReportViewer2.ReportSource = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.ReportSource = null;
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            txtHostelName.Text = "";
            cmbHostelName.Text = "";
            crystalReportViewer5.ReportSource = null;
            crystalReportViewer4.ReportSource = null;
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.ToString();
            cmbStudentName.Text = "";
            txtStudentName.Text = "";
            crystalReportViewer3.ReportSource = null;
            AdmissionNo.Text = "";
            crystalReportViewer2.ReportSource = null;
            cmbClass.Text = "";
            cmbSection.Text = "";
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            crystalReportViewer1.ReportSource = null;
            cmbSection.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cmbClass.Text = "";
           cmbSection.Text = "";
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            crystalReportViewer1.ReportSource = null;
            cmbSection.Enabled = false;
        }

       
    }
}
