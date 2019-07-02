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
    public partial class frmCourseFeePaymentRecord1 : Form
    {
       
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmCourseFeePaymentRecord1()
        {
            InitializeComponent();
        }
        public void GetData()  //is getdata function ko form ke load event par call kar lena
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();

                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(Student.StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(student.Class) as [Class], RTRIM(Student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(DateTime,PaymentDate,105) as [Payment Date],RTRIM(PaymentDue) as [Current Due] from Student,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo order by StudentName", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Student");
                DataGridView1.DataSource = myDataSet.Tables["student"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FillSession()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "SELECT distinct RTRIM(student.Session) FROM Student";
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

        private void frmCourseFeePaymentRecord1_Load(object sender, EventArgs e)
        {
            FillSession();
            GetData();
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(Student.StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(student.Class) as [Class], RTRIM(Student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(DateTime,PaymentDate,105) as [Payment Date],RTRIM(PaymentDue) as [Balance] from Student,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo and Section= '" + cmbSection.Text + "'and Class='" + cmbClass.Text + "' and Session='" + cmbSession.Text + "' order by student.StudentName", con);

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
                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(Student.Class) as [Class], RTRIM(student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(DateTime,PaymentDate,105) as [Payment Date],RTRIM(PaymentDue) as [Balance] from Student ,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo and studentname like '" + txtStudentName.Text + "%' order by StudentName", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "School");
                myDA.Fill(myDataSet, "coursefeepayment");

                DataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;

                DataGridView1.DataSource = myDataSet.Tables["School"].DefaultView;

                DataGridView1.DataSource = myDataSet.Tables["CourseFeepayment"].DefaultView;

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
                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(Student.StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(student.Class) as [Class], RTRIM(Student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(DateTime,PaymentDate,105) as [Payment Date],RTRIM(PaymentDue) as [Balance] from Student,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo  and PaymentDate between @date1 and @date2 order by student.StudentName", con);
                cmd.Parameter.Add("@date1", SqlDbType.DateTime, 30, "StartingDate").Value = dtpDateFrom.Value.Date;
                cmd.Parameter.Add("@date2", SqlDbType.DateTime, 30, "StartingDate").Value = dtpDateTo.Value.Date;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbClass.Text = "";
            txtStudentName.Text = "";
            cmbSection.Text = "";
            cmbSession.Text = "";
            DataGridView1.DataSource = "";
            GetData();
        }

        private void frmCourseFeePaymentRecord1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.ShowDialog();
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (DataGridView1.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = DataGridView1.RowCount - 1;
                colsTotal = DataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = DataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = DataGridView1.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }
    }
}
