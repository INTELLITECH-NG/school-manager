﻿using System;
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
    public partial class frmBusholderRecords : Form
    {
       
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmBusholderRecords()
        {
            InitializeComponent();
        }
        private void AutocompleteCourse()
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
                CmbAmissionNo.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    CmbAmissionNo.Items.Add(drow[0].ToString());

                }
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

        private void AutocompleteSourcelocation()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Sourcelocation) FROM Student,BusHolders where Student.AdmissionNo=BusHolders.AdmissionNo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
          

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
        private void frmBusholderRecords_Load(object sender, EventArgs e)
        {
            AutocompleteCourse();
            AutocompleteScholarNo();
            AutocompleteStudentname();
            AutocompleteSourcelocation();
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsection.Items.Clear();
            cmbsection.Text = "";
            cmbsection.Enabled = true;

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
                    cmbsection.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             try
            {
                if (cmbclass.Text == "")
                {
                    MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbclass.Focus();
                    return;
                }
                if (cmbsection.Text == "")
                {
                    MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbsection.Focus();
                    return;
                }

              

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(SourceLocation)[Source Location], RTRIM(StartingDate)[Starting Date]  from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and StartingDate between @date1 and @date2 and Class= '" + cmbclass.Text + "'and Section='" + cmbsection.Text + "' order by StartingDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "StartingDate").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "StartingDate").Value = Date_to.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "BusHolders");
                myDA.Fill(myDataSet, "Student");

                dataGridView1.DataSource = myDataSet.Tables["BusHolders"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScholarNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(SourceLocation)[Source Location], RTRIM(StartingDate)[Starting Date]  from BusHolders,Student where Student.AdmissionNo = BusHolders.AdmissionNo and Student.AdmissionNo = '" + CmbAmissionNo.Text + "' order by Studentname", con);
               
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "BusHolders");
                myDA.Fill(myDataSet, "Student");

                dataGridView2.DataSource = myDataSet.Tables["BusHolders"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
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

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(SourceLocation)[Source Location], RTRIM(StartingDate)[Starting Date]  from BusHolders,Student where Student.AdmissionNo = BusHolders.AdmissionNo and Student.StudentName = '" + cmbStudentName.Text + "' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "BusHolders");
                myDA.Fill(myDataSet, "Student");

                dataGridView3.DataSource = myDataSet.Tables["BusHolders"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.cmbAdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
    
            frm.txtclass.Text = dr.Cells[2].Value.ToString();
            frm.txtsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbSourceLocation.Text= dr.Cells[4].Value.ToString();
            frm.dtpStartingDate.Text = dr.Cells[5].Value.ToString();
            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.button1.Enabled = true;
            
            frm.btnSave.Enabled = false;
         
            
        }

        private void frmBusholderRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(SourceLocation)[Source Location], RTRIM(StartingDate)[Starting Date]  from BusHolders,Student where Student.AdmissionNo = BusHolders.AdmissionNo and Student.StudentName Like '" + txtStudentName.Text + "%' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "BusHolders");
                myDA.Fill(myDataSet, "Student");

                dataGridView3.DataSource = myDataSet.Tables["BusHolders"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
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

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(SourceLocation)[Source Location], RTRIM(StartingDate)[Starting Date]  from BusHolders,Student where Student.AdmissionNo = BusHolders.AdmissionNo and Sourcelocation Like '" + txtSourceLocation.Text + "%' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "BusHolders");
                myDA.Fill(myDataSet, "Student");

                dataGridView5.DataSource = myDataSet.Tables["BusHolders"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dr = dataGridView2.SelectedRows[0];
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.cmbAdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
    
            frm.txtclass.Text = dr.Cells[2].Value.ToString();
            frm.txtsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbSourceLocation.Text= dr.Cells[4].Value.ToString();
            frm.dtpStartingDate.Text = dr.Cells[5].Value.ToString();
            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            
            frm.btnSave.Enabled = false;
         
            
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dr = dataGridView3.SelectedRows[0];
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.cmbAdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
    
            frm.txtclass.Text = dr.Cells[2].Value.ToString();
            frm.txtsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbSourceLocation.Text= dr.Cells[4].Value.ToString();
            frm.dtpStartingDate.Text = dr.Cells[5].Value.ToString();
            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.button1.Enabled = true;
            
            frm.btnSave.Enabled = false;
         
            
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dr = dataGridView4.SelectedRows[0];
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.cmbAdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
    
            frm.txtclass.Text = dr.Cells[2].Value.ToString();
            frm.txtsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbSourceLocation.Text= dr.Cells[4].Value.ToString();
            frm.dtpStartingDate.Text = dr.Cells[5].Value.ToString();
            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.button1.Enabled = true;
            frm.btnSave.Enabled = false;
         
            
        }

        private void dataGridView5_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DataGridViewRow dr = dataGridView5.SelectedRows[0];
            this.Hide();
            frmBusHolders frm = new frmBusHolders();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.cmbAdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
    
            frm.txtclass.Text = dr.Cells[2].Value.ToString();
            frm.txtsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbSourceLocation.Text= dr.Cells[4].Value.ToString();
            frm.dtpStartingDate.Text = dr.Cells[5].Value.ToString();
            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.button1.Enabled = true;
            frm.btnSave.Enabled = false;
         
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
             con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(SourceLocation)[Source Location], RTRIM(StartingDate)[Starting Date]  from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and StartingDate  between @date1 and @date2  order by StartingDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "StartingDate").Value = dateTimePicker1.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "StartingDate").Value = dateTimePicker2.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "BusHolders");
                myDA.Fill(myDataSet, "Student");

                dataGridView4.DataSource = myDataSet.Tables["BusHolders"].DefaultView;
                dataGridView4.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView4_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (dataGridView4.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    dataGridView4.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
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

        private void button11_Click(object sender, EventArgs e)
        {
            txtSourceLocation.Text = "";
            cmbSourceLocation.Text = "";
            dataGridView5.DataSource = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = System.DateTime.Today.ToString();
            dateTimePicker2.Text = System.DateTime.Today.ToString();
            dataGridView4.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = "";
            cmbStudentName.Text = "";

            dataGridView3.DataSource = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CmbAmissionNo.Text = "";

            dataGridView2.DataSource = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbclass.Text = "";
            cmbsection.Text = "";
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView1.DataSource = null;
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView4.DataSource == null)
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

                rowsTotal = dataGridView4.RowCount - 1;
                colsTotal = dataGridView4.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView4.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView4.Rows[I].Cells[j].Value;
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

        private void button10_Click(object sender, EventArgs e)
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
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        }
        }
        
       
