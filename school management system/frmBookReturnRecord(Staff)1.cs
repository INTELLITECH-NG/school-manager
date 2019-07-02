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
    public partial class frmBookReturnRecord_Staff_1 : Form
    {
        
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmBookReturnRecord_Staff_1()
        {
            InitializeComponent();
        }
        private void AutocompleteStaff()
        {

            try
            {


                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Staffname) FROM Employee,BookIssueStaff,BookReturnStaff where Employee.StaffID=BookIssueStaff.StaffID and BookIssueStaff.TransactionID=BookReturnstaff.TransactionID", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                CmbStaffName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    CmbStaffName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AutocompleteStaffID()
        {

            try
            {


                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(BookissueStaff.StaffID) FROM Employee,BookIssueStaff,BookReturnStaff where Employee.StaffID=BookIssueStaff.StaffID and BookIssueStaff.TransactionID=BookReturnstaff.TransactionID", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                StaffID.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    StaffID.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBookReturnRecord_Staff_1_Load(object sender, EventArgs e)
        {
            AutocompleteStaff();
            AutocompleteStaffID();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbStaffName.Text == "")
                {
                    MessageBox.Show("Please select StaffName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CmbStaffName.Focus();
                    return;
                }
               
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT rtrim(ReturnID) as [Return ID],(ReturnDate) as [Return Date],rtrim(Fine) [Fine],rtrim(BookIssueStaff.TransactionID) as [Transaction ID],(IssueDate) as [Issue Date],(DueDate) as [Due Date],rtrim(Book.AccessionNo) as [Accession No],rtrim (BookTitle) as [Book Title],rtrim(Author) as [Author],rtrim(Subject) [Subject],rtrim(ISBN) [ISBN],rtrim(Edition) as [Edition],rtrim(Employee.StaffID) as [Staff ID],rtrim(StaffName) as [Staff Name],rtrim(Employee.Department) [Department] from Book,BookIssueStaff,Employee,BookReturnStaff where Book.AccessionNo=BookIssueStaff.AccessionNo and BookIssueStaff.StaffID=Employee.StaffID  and BookIssueStaff.TransactionID=BookReturnStaff.TransactionID and ReturnDate Between @date1 and @date2 order by IssueDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "ReturnDate").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "ReturnDate").Value = Date_to.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Employee");
                myDA.Fill(myDataSet, "BookReturnstaff");

                dataGridView1.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["Employee"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["BookReturnstaff"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT rtrim(ReturnID) as [Return ID],(ReturnDate) as [Return Date],rtrim(Fine) [Fine],rtrim(BookIssueStaff.TransactionID) as [Transaction ID],(IssueDate) as [Issue Date],(DueDate) as [Due Date],rtrim(Book.AccessionNo) as [Accession No],rtrim (BookTitle) as [Book Title],rtrim(Author) as  [Author],rtrim(Subject) [Subject],rtrim(ISBN) [ISBN],rtrim(Edition) as [Edition],rtrim(Employee.StaffID) as [Staff ID],rtrim(StaffName) as [Staff Name],rtrim(Employee.Department) [Department] from Book,BookIssueStaff,Employee,BookReturnStaff where Book.AccessionNo=BookIssueStaff.AccessionNo and BookIssueStaff.StaffID=Employee.StaffID  and BookIssueStaff.TransactionID=BookReturnStaff.TransactionID and Fine>0 and ReturnDate Between @date1 and @date2 order by IssueDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "ReturnDate").Value = dateTimePicker1.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "ReturnDate").Value = dateTimePicker2.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Employee");
                myDA.Fill(myDataSet, "BookReturnstaff");

                dataGridView5.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["Employee"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["BookReturnstaff"].DefaultView;

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
                cmd = new SqlCommand("SELECT rtrim(ReturnID) as [Return ID],(ReturnDate) as [Return Date],rtrim(Fine) [Fine],rtrim(BookIssueStaff.TransactionID) as [Transaction ID],(IssueDate) as [Issue Date],(DueDate) as [Due Date],rtrim(Book.AccessionNo) as [Accession No],rtrim (BookTitle) as [Book Title],rtrim(Author) as [Author],rtrim(Subject) [Subject],rtrim(ISBN) [ISBN],rtrim(Edition) as [Edition],rtrim(Employee.StaffID) as [Staff ID],rtrim(StaffName) as [Staff Name],rtrim(Employee.Department) [Department] from Book,BookIssueStaff,Employee,BookReturnStaff where Book.AccessionNo=BookIssueStaff.AccessionNo and BookIssueStaff.StaffID=Employee.StaffID  and BookIssueStaff.TransactionID=BookReturnStaff.TransactionID and ReturnDate Between @date1 and @date2 order by IssueDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "ReturnDate").Value = PaymentDateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "ReturnDate").Value = PaymentDateTo.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Employee");
                myDA.Fill(myDataSet, "BookReturnstaff");

                dataGridView3.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Employee"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["BookReturnstaff"].DefaultView;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("SELECT rtrim(ReturnID) as [Return ID], (ReturnDate) as [Return Date],rtrim(Fine) [Fine],rtrim(BookIssueStaff.TransactionID) as [Transaction ID],(IssueDate) as [Issue Date],(DueDate) as [Due Date],rtrim(Book.AccessionNo) as [Accession No],rtrim (BookTitle) as [Book Title],rtrim(Author) as [Author],rtrim(Subject) [Subject],rtrim(ISBN) [ISBN],rtrim(Edition) as [Edition],rtrim(Employee.StaffID) as [Staff ID],rtrim(StaffName) as [Staff Name],rtrim(Employee.Department) [Department] from Book,BookIssueStaff,Employee,BookReturnStaff where Book.AccessionNo=BookIssueStaff.AccessionNo and BookIssueStaff.StaffID=Employee.StaffID  and BookIssueStaff.TransactionID=BookReturnStaff.TransactionID and  BookIssuestaff.staffID='" + StaffID.Text + "'  order by IssueDate", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Book");
                myDA.Fill(myDataSet, "Employee");
                myDA.Fill(myDataSet, "BookReturnstaff");
                myDA.Fill(myDataSet, "Bookissuestaff");
                dataGridView2.DataSource = myDataSet.Tables["Book"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["Employee"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["BookReturnstaff"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["Bookissuestaff"].DefaultView;

                con.Close();
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

        private void frmBookReturnRecord_Staff_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StaffID.Text = "";
            dataGridView2.DataSource = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView1.DataSource = null;
            CmbStaffName.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PaymentDateFrom.Text = System.DateTime.Today.ToString();
            PaymentDateTo.Text = System.DateTime.Today.ToString();
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
                    _with1.Cells[1, iC + 1].Value = dataGridView5.Columns[iC].HeaderText;
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
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
