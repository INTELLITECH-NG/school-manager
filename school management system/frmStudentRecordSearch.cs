using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace school_management_system
{
    public partial class frmStudentRecordSearch : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmStudentRecordSearch()
        {
            InitializeComponent();
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
        private void frmStudentRecordSearch_Load(object sender, EventArgs e)
        {
            FillSession();
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

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [SchoolName], RTRIM(AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(StudentName) as [Student Name], RTRIM(FatherName) as [Father's Name], RTRIM(MotherName) as [Mother's Name], RTRIM(FatherCN) as [Father's Contact No.],RTRIM(PermanentAddress) as [Permanent Address], RTRIM(TemporaryAddress) as [Temporary Address], RTRIM(Student.ContactNo) as [Contact No.], RTRIM(EmailID) as [Email ID],CONVERT(DateTime,DOB,105) as [DOB],RTRIM(Gender) as [Gender],CONVERT(DateTime,AdmissionDate,105) as [Admission Date],RTRIM(Session) as [Session], RTRIM(Caste) as [Category], RTRIM(Religion) as [Religion],RTRIM(Student.Class) as [Class],RTRIM(Student.Section) as [Section], RTRIM(Status) as [Status],RTRIM(Nationality) as [Nationality],Photo from Student,School where School.ID=Student.SchoolID and  Section= '" + cmbSection.Text + "' and Class='" + cmbClass.Text + "' and Session='" + cmbSession.Text + "' order by StudentName", con);
     
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Student");

                DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;

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
                cmd = new SqlCommand("SELECT RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [SchoolName], RTRIM(AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(StudentName) as [Student Name], RTRIM(FatherName) as [Father's Name], RTRIM(MotherName) as [Mother's Name], RTRIM(FatherCN) as [Father's Contact No.],RTRIM(PermanentAddress) as [Permanent Address], RTRIM(TemporaryAddress) as [Temporary Address], RTRIM(Student.ContactNo) as [Contact No.], RTRIM(EmailID) as [Email ID],CONVERT(DateTime,DOB,105) as [DOB],RTRIM(Gender) as [Gender],CONVERT(DateTime,AdmissionDate,105) as [Admission Date],RTRIM(Session) as [Session], RTRIM(Caste) as [Category], RTRIM(Religion) as [Religion],RTRIM(Student.Class) as [Class],RTRIM(Student.Section) as [Section], RTRIM(Status) as [Status],RTRIM(Nationality) as [Nationality],Photo from Student,School where School.ID=Student.SchoolID and StudentName like '" + txtStudentName.Text + "%' order by StudentName", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Student");

                DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (label4.Text == "Student Record")
                {
                    DataGridViewRow dr = DataGridView1.SelectedRows[0];
                    this.Hide();
                    frmClassFeePaymentcs frm = new  frmClassFeePaymentcs();
                    frm.Show();
                     frm.txtAdmissionNo.Text = dr.Cells[2].Value.ToString();
                  frm.txtEnrollmentNo.Text = dr.Cells[3].Value.ToString();
                  frm.txtSession.Text = dr.Cells[15].Value.ToString();
                  frm.txtStudentName.Text = dr.Cells[4].Value.ToString();
                  frm.txtClass.Text = dr.Cells[18].Value.ToString();
                  frm.txtSection.Text = dr.Cells[19].Value.ToString();
                  frm.txtSchoolName.Text = dr.Cells[1].Value.ToString();
                  frm.lblUser.Text = lblUser.Text;
                  frm.lblUserType.Text = lblUserType.Text;
                  frm.cmbMonth.Enabled = true;
                  frm.DataGridView1.Enabled = true;
                  frm.groupBox5.Enabled = true;
                  frm.groupBox4.Enabled = true;
                  frm.GetData();
       
                    frm.btnDelete.Enabled = false;
                    frm.btnUpdate_record.Enabled = false;

                    frm.btnSave.Enabled = true;
                    label4.Text = "";          
            }
              else
                {
                     DataGridViewRow dr = DataGridView1.SelectedRows[0];
                this.Hide();
                Frm_student frm = new Frm_student();
                frm.Show();
                frm.txtSchoolID.Text = dr.Cells[0].Value.ToString();
                frm.cmbSchoolName.Text = dr.Cells[1].Value.ToString();
                frm.txtAdmissionNo.Text = dr.Cells[2].Value.ToString();
                frm.txtEnrollmentNo.Text = dr.Cells[3].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[4].Value.ToString();
                frm.txtFathername.Text = dr.Cells[5].Value.ToString();
                frm.txtMotherName.Text = dr.Cells[6].Value.ToString();
                frm.txtFatherContactNo.Text = dr.Cells[7].Value.ToString();
                frm.txtPermanentAddress.Text = dr.Cells[8].Value.ToString();
                frm.txtTemrorayAddress.Text = dr.Cells[9].Value.ToString();
                frm.txtContactNo.Text = dr.Cells[10].Value.ToString();
                frm.txtEmailID.Text = dr.Cells[11].Value.ToString();
                frm.dtpDOB.Text = dr.Cells[12].Value.ToString();
                frm.txtGender.Text = dr.Cells[13].Value.ToString();
                frm.dtpAdmissionDate.Text = dr.Cells[14].Value.ToString();
                frm.txtSession.Text = dr.Cells[15].Value.ToString();
                frm.cmbCategory.Text = dr.Cells[16].Value.ToString();
                frm.cmbReligion.Text = dr.Cells[17].Value.ToString();
                frm.cmbStatus.Text = dr.Cells[20].Value.ToString();
                frm.txtNationality.Text = dr.Cells[21].Value.ToString();
              frm.cmbClass.Text = dr.Cells[18].Value.ToString();
               frm.CmbSection.Text = dr.Cells[19].Value.ToString();
               byte[] data = (byte[])dr.Cells[22].Value;   
                MemoryStream ms = new MemoryStream(data);
                frm.Picture.Image = Image.FromStream(ms);
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnSave.Enabled = false;
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;         
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbClass.Text = "";
            txtStudentName.Text = "";
            cmbSection.Text = "";
            cmbSession.Text = "";
            DataGridView1.DataSource = "";
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(SchoolID) as [School ID],RTRIM(SchoolName) as [SchoolName], RTRIM(AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(StudentName) as [Student Name], RTRIM(FatherName) as [Father's Name], RTRIM(MotherName) as [Mother's Name], RTRIM(FatherCN) as [Father's Contact No.],RTRIM(PermanentAddress) as [Permanent Address], RTRIM(TemporaryAddress) as [Temporary Address], RTRIM(Student.ContactNo) as [Contact No.], RTRIM(EmailID) as [Email ID],CONVERT(DateTime,DOB,105) as [DOB],RTRIM(Gender) as [Gender],CONVERT(DateTime,AdmissionDate,105) as [Admission Date],RTRIM(Session) as [Session], RTRIM(Caste) as [Category], RTRIM(Religion) as [Religion],RTRIM(Student.Class) as [Class],RTRIM(Student.Section) as [Section], RTRIM(Status) as [Status],RTRIM(Nationality) as [Nationality],Photo from Student,School where School.ID=Student.SchoolID and admissionDate Between @date1 and @Date2  order by StudentName", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "AdmissionDateDate").Value = dtpDateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "AdmissionDateDate").Value = dtpDateTo.Value.Date;
                
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Student");

                DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void frmStudentRecordSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (label4.Text == "Student Record")
            {
                this.Hide();
                frmClassFeePaymentcs frm = new frmClassFeePaymentcs();
                frm.lblUserType.Text = lblUserType.Text;
                frm.lblUser.Text = lblUser.Text;
                frm.Show();
            }
            else
            {
                this.Hide();
                Frm_student frm = new Frm_student();
                frm.lblUserType.Text = lblUserType.Text;
                frm.lblUser.Text = lblUser.Text;
                frm.Show();
            }
        }
    }
}

