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
    public partial class frmBookReturn_Student_ : Form
    {
      
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmBookReturn_Student_()
        {
            InitializeComponent();
        }

        private void AutocompleteStudent()
        {

            try
            {


                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Student.studentname) FROM Student,StudentBookIssue,BookReturnStudent where Student.AdmissionNo=StudentBookIssue.AdmissionNo and StudentBookIssue.TransactionID=BookReturnstudent.TransactionID", CN);
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
        private void AutocompleteAdmissionNo()
        {

            try
            {


                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(StudentBookIssue.AdmissionNo) FROM Student,StudentBookIssue,BookReturnStudent where Student.AdmissionNO=StudentBookIssue.AdmissionNo", CN);
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
        private void frmBookReturn_Student__Load(object sender, EventArgs e)
        {
            AutocompleteStudent();
            AutocompleteAdmissionNo();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ReturnID) as [Return ID],convert(Datetime,ReturnDate,103) as [Return Date],RTRIM(Fine) as [Fine], RTRIM(StudentBookIssue.TransactionID) as [Transaction ID], convert(Datetime,IssueDate,103) as [Issue Date],convert(datetime,DueDate,103) as [Due Date], RTRIM(Book.AccessionNo) as [Accession No],RTRIM(BookTitle) as [Book Title],RTRIM(Author) as [Author],RTRIM(Subject) as [Subject],RTRIM(ISBN) as [ISBN],RTRIM(Edition) as [Edition],RTRIM(Student.AdmissionNo) as [AdmissionNo],RTRIM(Student.StudentName) as [Student Name],RTRIM(Student.Class) as [Class],RTRIM(student.Section) as [Section] from Book,StudentBookIssue,Student,BookReturnStudent where Book.AccessionNo=StudentBookIssue.AccessionNo and StudentBookIssue.AdmissionNo=Student.AdmissionNo  and StudentBookIssue.TransactionID=BookReturnStudent.TransactionID and ReturnDate Between @date1 and @date2 and Student.Studentname='"+cmbStudentName.Text+"' order by IssueDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "ReturnDate").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "ReturnDate").Value = Date_to.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "BookReturnStudent");
                myDA.Fill(myDataSet, "StudentBookissue");

                dataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["BookReturnstudent"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["StudentBookIssue"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void StaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = cmd = new SqlCommand("SELECT RTRIM(ReturnID) as [Return ID],convert(Datetime,ReturnDate,103) as [Return Date],RTRIM(Fine) as [Fine], RTRIM(StudentBookIssue.TransactionID) as [Transaction ID], convert(Datetime,IssueDate,103) as [Issue Date],convert(datetime,DueDate,103) as [Due Date], RTRIM(Book.AccessionNo) as [Accession No],RTRIM(BookTitle) as [Book Title],RTRIM(Author) as [Author],RTRIM(Subject) as [Subject],RTRIM(ISBN) as [ISBN],RTRIM(Edition) as [Edition],RTRIM(Student.AdmissionNo) as [AdmissionNo],RTRIM(Student.StudentName) as [Student Name],RTRIM(Student.Class) as [Class],RTRIM(student.Section) as [Section] from Book,StudentBookIssue,Student,BookReturnStudent where Book.AccessionNo=StudentBookIssue.AccessionNo and StudentBookIssue.AdmissionNo=Student.AdmissionNo  and StudentBookIssue.TransactionID=BookReturnStudent.TransactionID  and Student.AdmissionNo='" + AdmissionNo.Text + "' order by IssueDate", con);
                

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "BookReturnStudent");
                myDA.Fill(myDataSet, "StudentBookissue");

                dataGridView2.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["BookReturnstudent"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["StudentBookIssue"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ReturnID) as [Return ID],convert(Datetime,ReturnDate,103) as [Return Date],RTRIM(Fine) as [Fine], RTRIM(StudentBookIssue.TransactionID) as [Transaction ID], convert(Datetime,IssueDate,103) as [Issue Date],convert(datetime,DueDate,103) as [Due Date], RTRIM(Book.AccessionNo) as [Accession No],RTRIM(BookTitle) as [Book Title],RTRIM(Author) as [Author],RTRIM(Subject) as [Subject],RTRIM(ISBN) as [ISBN],RTRIM(Edition) as [Edition],RTRIM(Student.AdmissionNo) as [AdmissionNo],RTRIM(Student.StudentName) as [Student Name],RTRIM(Student.Class) as [Class],RTRIM(student.Section) as [Section] from Book,StudentBookIssue,Student,BookReturnStudent where Book.AccessionNo=StudentBookIssue.AccessionNo and StudentBookIssue.AdmissionNo=Student.AdmissionNo  and StudentBookIssue.TransactionID=BookReturnStudent.TransactionID and ReturnDate Between @date1 and @date2  order by Studentname", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "ReturnDate").Value = PaymentDateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "ReturnDate").Value = PaymentDateTo.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "BookReturnStudent");
                myDA.Fill(myDataSet, "StudentBookissue");

                dataGridView3.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["BookReturnstudent"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["StudentBookIssue"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmBookReturn frm = new frmBookReturn();
                frm.Show();
                frm.txtReturnID.Text = dr.Cells[0].Value.ToString();
                frm.txtTransactionID.Text = dr.Cells[3].Value.ToString();
                frm.dtpIssueDate.Text = dr.Cells[4].Value.ToString();

                frm.dtpDueDate.Text = dr.Cells[5].Value.ToString();
                frm.txtFine.Text = dr.Cells[2].Value.ToString();
                frm.dtpReturnDate.Text = dr.Cells[1].Value.ToString();
                frm.txtAccessionNo.Text = dr.Cells[6].Value.ToString();
                frm.txtBookTitle.Text = dr.Cells[7].Value.ToString();
                frm.txtAuthor.Text = dr.Cells[5].Value.ToString();
                frm.txtSubject.Text = dr.Cells[8].Value.ToString();
                frm.txtISBN.Text = dr.Cells[9].Value.ToString();

                frm.txtEdition.Text = dr.Cells[10].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[12].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[11].Value.ToString();
                frm.txtClass.Text = dr.Cells[13].Value.ToString();
                frm.txtSection.Text = dr.Cells[14].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;

                frm.btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBookReturn_Student__FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmBookReturn frm = new frmBookReturn();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ReturnID) as [Return ID],convert(Datetime,ReturnDate,103) as [Return Date],RTRIM(Fine) as [Fine], RTRIM(StudentBookIssue.TransactionID) as [Transaction ID], convert(Datetime,IssueDate,103) as [Issue Date],convert(datetime,DueDate,103) as [Due Date], RTRIM(Book.AccessionNo) as [Accession No],RTRIM(BookTitle) as [Book Title],RTRIM(Author) as [Author],RTRIM(Subject) as [Subject],RTRIM(ISBN) as [ISBN],RTRIM(Edition) as [Edition],RTRIM(Student.AdmissionNo) as [AdmissionNo],RTRIM(Student.StudentName) as [Student Name],RTRIM(Student.Class) as [Class],RTRIM(student.Section) as [Section] from Book,StudentBookIssue,Student,BookReturnStudent where Book.AccessionNo=StudentBookIssue.AccessionNo and StudentBookIssue.AdmissionNo=Student.AdmissionNo  and StudentBookIssue.TransactionID=BookReturnStudent.TransactionID and ReturnDate Between @date1 and @date2 and fine>0 order by IssueDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "ReturnDate").Value = dateTimePicker1.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "ReturnDate").Value = dateTimePicker2.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "BookReturnStudent");
                myDA.Fill(myDataSet, "StudentBookissue");

                dataGridView5.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["BookReturnstudent"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["StudentBookIssue"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView2.SelectedRows[0];
                this.Hide();
                frmBookReturn frm = new frmBookReturn();
                frm.Show();
                frm.txtReturnID.Text = dr.Cells[0].Value.ToString();
                frm.txtTransactionID.Text = dr.Cells[3].Value.ToString();
                frm.dtpIssueDate.Text = dr.Cells[4].Value.ToString();

                frm.dtpDueDate.Text = dr.Cells[5].Value.ToString();
                frm.txtFine.Text = dr.Cells[2].Value.ToString();
                frm.dtpReturnDate.Text = dr.Cells[1].Value.ToString();
                frm.txtAccessionNo.Text = dr.Cells[6].Value.ToString();
                frm.txtBookTitle.Text = dr.Cells[7].Value.ToString();
                frm.txtAuthor.Text = dr.Cells[5].Value.ToString();
                frm.txtSubject.Text = dr.Cells[8].Value.ToString();
                frm.txtISBN.Text = dr.Cells[9].Value.ToString();

                frm.txtEdition.Text = dr.Cells[10].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[12].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[11].Value.ToString();
                frm.txtClass.Text = dr.Cells[13].Value.ToString();
                frm.txtSection.Text = dr.Cells[14].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;

                frm.btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView3.SelectedRows[0];
                this.Hide();
                frmBookReturn frm = new frmBookReturn();
                frm.Show();
                frm.txtReturnID.Text = dr.Cells[0].Value.ToString();
                frm.txtTransactionID.Text = dr.Cells[3].Value.ToString();
                frm.dtpIssueDate.Text = dr.Cells[4].Value.ToString();

                frm.dtpDueDate.Text = dr.Cells[5].Value.ToString();
                frm.txtFine.Text = dr.Cells[2].Value.ToString();
                frm.dtpReturnDate.Text = dr.Cells[1].Value.ToString();
                frm.txtAccessionNo.Text = dr.Cells[6].Value.ToString();
                frm.txtBookTitle.Text = dr.Cells[7].Value.ToString();
                frm.txtAuthor.Text = dr.Cells[5].Value.ToString();
                frm.txtSubject.Text = dr.Cells[8].Value.ToString();
                frm.txtISBN.Text = dr.Cells[9].Value.ToString();

                frm.txtEdition.Text = dr.Cells[10].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[12].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[11].Value.ToString();
                frm.txtClass.Text = dr.Cells[13].Value.ToString();
                frm.txtSection.Text = dr.Cells[14].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;

                frm.btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView5_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView5.SelectedRows[0];
                this.Hide();
                frmBookReturn frm = new frmBookReturn();
                frm.Show();
                frm.txtReturnID.Text = dr.Cells[0].Value.ToString();
                frm.txtTransactionID.Text = dr.Cells[3].Value.ToString();
                frm.dtpIssueDate.Text = dr.Cells[4].Value.ToString();

                frm.dtpDueDate.Text = dr.Cells[5].Value.ToString();
                frm.txtFine.Text = dr.Cells[2].Value.ToString();
                frm.dtpReturnDate.Text = dr.Cells[1].Value.ToString();
                frm.txtAccessionNo.Text = dr.Cells[6].Value.ToString();
                frm.txtBookTitle.Text = dr.Cells[7].Value.ToString();
                frm.txtAuthor.Text = dr.Cells[5].Value.ToString();
                frm.txtSubject.Text = dr.Cells[8].Value.ToString();
                frm.txtISBN.Text = dr.Cells[9].Value.ToString();

                frm.txtEdition.Text = dr.Cells[10].Value.ToString();
                frm.txtStudentName.Text = dr.Cells[12].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[11].Value.ToString();
                frm.txtClass.Text = dr.Cells[13].Value.ToString();
                frm.txtSection.Text = dr.Cells[14].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;

                frm.btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (dataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    dataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (dataGridView5.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    dataGridView5.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Date_from.Text= System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView1.DataSource = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdmissionNo.Text = "";
            dataGridView2.DataSource = null;
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            PaymentDateFrom.Text = System.DateTime.Today.ToString();
            PaymentDateTo.Text= System.DateTime.Today.ToString();
            dataGridView3.DataSource = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = System.DateTime.Today.ToString();
            dateTimePicker2.Text = System.DateTime.Today.ToString();
            dataGridView5.DataSource = null;
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
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

                rowsTotal = dataGridView1.RowCount - 1;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView5.DataSource == null)
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

                rowsTotal = dataGridView5.RowCount - 1;
                colsTotal = dataGridView5.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView3.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView5.Rows[I].Cells[j].Value;
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null)
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

                rowsTotal = dataGridView2.RowCount - 1;
                colsTotal = dataGridView2.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView2.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView2.Rows[I].Cells[j].Value;
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

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.DataSource == null)
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

                rowsTotal = dataGridView3.RowCount - 1;
                colsTotal = dataGridView3.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView3.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView3.Rows[I].Cells[j].Value;
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
