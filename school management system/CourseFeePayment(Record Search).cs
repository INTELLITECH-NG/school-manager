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
    public partial class CourseFeePayment_Record_Search_ : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
 
        public void GetData()         {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
               
                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(Student.StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(student.Class) as [Class], RTRIM(Student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(varchar(30),sysDatetime(),106) as [Payment Date],RTRIM(PaymentDue) as [Current Due],rtrim(orders) [Transactions order] from Student,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo order by orders, PaymentDate", con);
                
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
        public CourseFeePayment_Record_Search_()
        {
            InitializeComponent();
        }
        public void FillSession()    
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "SELECT distinct RTRIM(Session) from courseFeePayment,Student where coursefeepayment.admissionno=student.admissionno";   
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
        public void FillAdmissionNo()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "SELECT distinct RTRIM(AdmissionNo) FROM CourseFeePayment";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CmbAdmissionNo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CourseFeePayment_Record_Search__Load(object sender, EventArgs e)
        {
            FillSession();
            FillAdmissionNo();
            GetData();
        
        
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "SELECT distinct class FROM CourseFeePayment Where courseFeePayment.admissionNo=student.admissionNo and session='" + cmbSession.Text + "'";

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


                string ct = "SELECT distinct RTRIM(Section) FROM CourseFeePayment Where courseFeePayment.admissionNo = student.admissionNo and session='" + cmbSession.Text + "' and Class='" + cmbClass.Text + "'  ";

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
                cmd = new SqlCommand("select RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(Student.StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(student.Class) as [Class], RTRIM(Student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(varchar(30),sysDatetime(),106) as [Payment Date],RTRIM(PaymentDue) as [Current Due],rtrim(orders) [Transactions Order] from Student,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo and Section= '" + cmbSection.Text + "'and Class='" + cmbClass.Text + "' and Session='" + cmbSession.Text + "' order by orders, PaymentDate", con);
      
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
                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(Student.Class) as [Class], RTRIM(student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(varchar(30),sysDatetime(),106) as [Payment Date],RTRIM(PaymentDue) as [Current Due],rtrim(orders) [Transactions Order] from Student ,School,CourseFeePayment where  School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo and studentname like '" + txtStudentName.Text + "%' order by Orders,PaymentDate", con);

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
                cmd = new SqlCommand("SELECT RTRIM(CourseFeePayment.ID) as [Fee Payment ID],RTRIM(Student.AdmissionNo) as [Admission No.], RTRIM(EnrollmentNo) as [Enrollment No.], RTRIM(Student.StudentName) as [Student Name], RTRIM(SchoolName) as [School Name], RTRIM(student.Class) as [Class], RTRIM(Student.Section) as [Section],RTRIM(Session) as [Session],RTRIM(Year) as [Year], RTRIM(CourseFeePayment.Fee) as [Fee],RTRIM(PreviousDue) as [Previous Due],RTRIM(Fine) as [Fine],RTRIM(GrandTotal) as [GrandTotal],RTRIM(TotalPaid) as [Total Paid], RTRIM(ModeOfPayment) as [Payment Mode], RTRIM(PaymentModeDetails) as [Payment Mode Details] ,CONVERT(varchar(30),sysDatetime(),106) as [Payment Date],RTRIM(PaymentDue) as [Current Due],rtrim(orders) [Transactions Order] from Student,School,CourseFeePayment where School.ID=Student.SchoolID and CourseFeePayment.AdmissionNo=Student.AdmissionNo and PaymentDate between @date1 and @date2 order by orders, PaymentDate", con);
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

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                this.Hide();
                frmClassFeePaymentcs frm = new frmClassFeePaymentcs();
                frm.Show();

           
                frm.txtFee.Text = dr.Cells[1].Value.ToString();
                frm.txtPreviousDue.Text = dr.Cells[10].Value.ToString();
                frm.txtFine.Text = dr.Cells[11].Value.ToString();
                frm.txtGrandTotal.Text = dr.Cells[12].Value.ToString();
                frm.txtTotalPaid.Text = dr.Cells[13].Value.ToString();
                frm.cmbPaymentMode.Text = dr.Cells[14].Value.ToString();
                frm.txtPaymentModeDetails.Text = dr.Cells[15].Value.ToString();
                frm.dtpPaymentDate.Text = dr.Cells[16].Value.ToString();
                frm.txtCurrentDue.Text = dr.Cells[17].Value.ToString();
               frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;
                frm.btnSave.Enabled = false;
               // frm.dataGridView2.Visibl = true;
                frm.DataGridView1.Visible = true;
                frm.btnAdd.Enabled = false;
              
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ID) as [Fee ID],RTRIM(Feename) as [Fee Name],RTRIM(CourseFeePayment_Join.Fee) as [Fee],RTRIM(Month) as [Month] from CourseFeePayment,CourseFeePayment_Join,Fee where CourseFeePayment.ID=CourseFeePayment_Join.PaymentID and Fee.ID=CourseFeePayment_Join.FeeID and CourseFeePayment.ID='" + dr.Cells[0].Value + "' order by Month",con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
             
                frm.DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    frm.DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
              
                con.Close();
                //frm.Calculate2();
                //frm.Calculate1();
              
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

        private void CourseFeePayment_Record_Search__FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
           frmClassFeePaymentcs frm = new frmClassFeePaymentcs();
           frm.lblUserType.Text = lblUserType.Text;
           frm.lblUser.Text = lblUser.Text;
           frm.Show();
        }

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
    }
}
