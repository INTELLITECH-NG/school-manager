using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace school_management_system
{
    public partial class frmstudentrecordsearch1 : Form
    {

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmstudentrecordsearch1()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                String sql = "SELECT RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(AdmissionNo),RTRIM(EnrollmentNo),RTRIM(StudentName),RTRIM(FatherName),RTRIM(MotherName),RTRIM(FatherCN),RTRIM(PermanentAddress),RTRIM(TemporaryAddress),RTRIM(Student.ContactNo),RTRIM(EmailID),CONVERT(Varchar(10),DOB,103),RTRIM(Gender),CONVERT(Varchar(10),AdmissionDate,103),RTRIM(Session),RTRIM(Caste),RTRIM(Religion),RTRIM(Student.Class),RTRIM(Student.Section),RTRIM(Status),RTRIM(Nationality),Photo from Student,School where School.ID=Student.SchoolID order by studentname,class";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FillSession()     //isko load event par call karna   or kisi dusre form par access kar rhe he to iski master entry wali primary key (id) ka textbox or lable same name ke ya lene honge
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "SELECT distinct RTRIM(student.Session) FROM Student";    //pk category id ko is form par hide karke le liya
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSession.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmstudentrecordsearch1_Load(object sender, EventArgs e)
        {
            FillSession();
            GetData();
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClass.Items.Clear();
            cmbClass.Text = "";
            cmbClass.Enabled = true;
            cmbClass.Focus();

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "SELECT distinct class FROM Student Where session='" + cmbSession.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbClass.Items.Add(rdr[0]);



                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbSection.Items.Clear();
            cmbSection.Text = "";
            cmbSection.Enabled = true;
            cmbSection.Focus();

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "SELECT distinct RTRIM(Section) FROM Student Where session='" + cmbSession.Text + "' and Class='" + cmbClass.Text + "'  ";

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

        private void Button1_Click(object sender, EventArgs e)
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
                try
                {
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    String sql = "SELECT RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(AdmissionNo),RTRIM(EnrollmentNo),RTRIM(StudentName),RTRIM(FatherName),RTRIM(MotherName),RTRIM(FatherCN),RTRIM(PermanentAddress),RTRIM(TemporaryAddress),RTRIM(Student.ContactNo),RTRIM(EmailID),CONVERT(Varchar(10),DOB,103),RTRIM(Gender),CONVERT(Varchar(10),AdmissionDate,103),RTRIM(Session),RTRIM(Caste),RTRIM(Religion),RTRIM(Student.Class),RTRIM(Student.Section),RTRIM(Status),RTRIM(Nationality),Photo from Student,School where School.ID=Student.SchoolID and Section= '" + cmbSection.Text + "' and Class='" + cmbClass.Text + "' and Session='" + cmbSession.Text + "' order by studentname,class";
                    cmd = new SqlCommand(sql, con);
                    rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataGridView1.Rows.Clear();
                    while (rdr.Read() == true)
                    {
                        DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22]);
                    }
                    con.Close();
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
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    String sql = "SELECT RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(AdmissionNo),RTRIM(EnrollmentNo),RTRIM(StudentName),RTRIM(FatherName),RTRIM(MotherName),RTRIM(FatherCN),RTRIM(PermanentAddress),RTRIM(TemporaryAddress),RTRIM(Student.ContactNo),RTRIM(EmailID),CONVERT(Varchar(10),DOB,103),RTRIM(Gender),CONVERT(Varchar(10),AdmissionDate,103),RTRIM(Session),RTRIM(Caste),RTRIM(Religion),RTRIM(Student.Class),RTRIM(Student.Section),RTRIM(Status),RTRIM(Nationality),Photo from Student,School where School.ID=Student.SchoolID and StudentName like '" + txtStudentName.Text + "%' order by studentname,class";
                    cmd = new SqlCommand(sql, con);
                    rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    DataGridView1.Rows.Clear();
                    while (rdr.Read() == true)
                    {
                        DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22]);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                String sql = "SELECT RTRIM(SchoolID),RTRIM(SchoolName),RTRIM(AdmissionNo),RTRIM(EnrollmentNo),RTRIM(StudentName),RTRIM(FatherName),RTRIM(MotherName),RTRIM(FatherCN),RTRIM(PermanentAddress),RTRIM(TemporaryAddress),RTRIM(Student.ContactNo),RTRIM(EmailID),CONVERT(Varchar(10),DOB,103),RTRIM(Gender),CONVERT(Varchar(10),AdmissionDate,103),RTRIM(Session),RTRIM(Caste),RTRIM(Religion),RTRIM(Student.Class),RTRIM(Student.Section),RTRIM(Status),RTRIM(Nationality),Photo from Student,School where School.ID=Student.SchoolID and admissionDate Between @date1 and @Date2 order by studentname,class";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "AdmissionDateDate").Value = dtpDateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "AdmissionDateDate").Value = dtpDateTo.Value.Date;

                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void frmstudentrecordsearch1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbClass.Text = "";
            txtStudentName.Text = "";
            cmbSection.Text = "";
            cmbSession.Text = "";
            GetData();
        }

       
        }
    }

