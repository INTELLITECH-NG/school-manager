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
    public partial class frmHostelerRecords : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmHostelerRecords()
        {
            InitializeComponent();
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
        private void AutocompleteAdmissionNo()
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
        private void frmHostelerRecords_Load(object sender, EventArgs e)
        {
            AutocompleteClass();
            AutocompleteAdmissionNo();
            AutocompleteStudentname();
            AutocompleteHostelname();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClass.Text== "")
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
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and JoiningDate between @date1 and @date2 and Class= '" + cmbClass.Text + "'and Section='" + cmbSection.Text + "' order by JoiningDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "JoiningDate").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "JoiningDate").Value = Date_to.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView1.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;




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

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(section) from Student where class= '" +cmbClass.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                  cmbSection .Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdmissionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and Student.AdmissionNo = '" + AdmissionNo.Text + "' order by Studentname", con);
                
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView2.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
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
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo = Hosteler.AdmissionNo and Studentname = '" + cmbStudentName.Text + "' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView3.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
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


                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[Class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo=Hosteler.AdmissionNo and JoiningDate between @date1 and @date2 order by JoiningDate", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "JoiningDate").Value = dateTimePicker1.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "JoiningDate").Value = dateTimePicker2.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView4.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
                dataGridView4.DataSource = myDataSet.Tables["Student"].DefaultView;




                con.Close();
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

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo = Hosteler.AdmissionNo and HostelName = '" + cmbHostelName.Text + "' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView5.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["Student"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHostelerRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frmhosteler frm = new Frmhosteler();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void txtHostelName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo = Hosteler.AdmissionNo and HostelName  like '" + txtHostelName.Text + "%' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView5.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["Student"].DefaultView;
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

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select  RTrim(Student.AdmissionNo)[AdmissionNo],RTRIM(Studentname)[Student Name],RTRIM(Class)[class],RTRIM(Section)[Section],RTRIM(HostelName)[Hostel Name], RTRIM(JoiningDate)[Joining Date]  from Hosteler,Student where Student.AdmissionNo = Hosteler.AdmissionNo and StudentName  like '" + txtStudentName.Text + "%' order by Studentname", con);

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Hosteler");
                myDA.Fill(myDataSet, "Student");

                dataGridView5.DataSource = myDataSet.Tables["Hosteler"].DefaultView;
                dataGridView5.DataSource = myDataSet.Tables["Student"].DefaultView;
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
            Frmhosteler frm = new Frmhosteler();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.AdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
            frm.txtClass.Text = dr.Cells[2].Value.ToString();
            frm.cmbsection.Text= dr.Cells[3].Value.ToString();
            frm.cmbHostelName.Text = dr.Cells[4].Value.ToString();
            frm.dtpJoiningDate.Text = dr.Cells[5].Value.ToString();
           
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;
                frm.AdmissionNo.Focus();
                frm.lblUser.Text = lblUser.Text;
                frm.btnSave.Enabled = false;
           
            }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            this.Hide();
            Frmhosteler frm = new Frmhosteler();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.AdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
            frm.txtClass.Text = dr.Cells[2].Value.ToString();
            frm.cmbsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbHostelName.Text = dr.Cells[4].Value.ToString();
            frm.dtpJoiningDate.Text = dr.Cells[5].Value.ToString();

            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.AdmissionNo.Focus();
            frm.lblUser.Text = lblUser.Text;
            frm.btnSave.Enabled = false;
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView3.SelectedRows[0];
            this.Hide();
            Frmhosteler frm = new Frmhosteler();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.AdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
            frm.txtClass.Text = dr.Cells[2].Value.ToString();
            frm.cmbsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbHostelName.Text = dr.Cells[4].Value.ToString();
            frm.dtpJoiningDate.Text = dr.Cells[5].Value.ToString();

            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.AdmissionNo.Focus();
            frm.lblUser.Text = lblUser.Text;
            frm.btnSave.Enabled = false;
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView4.SelectedRows[0];
            this.Hide();
            Frmhosteler frm = new Frmhosteler();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.AdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
            frm.txtClass.Text = dr.Cells[2].Value.ToString();
            frm.cmbsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbHostelName.Text = dr.Cells[4].Value.ToString();
            frm.dtpJoiningDate.Text = dr.Cells[5].Value.ToString();

            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.AdmissionNo.Focus();
            frm.lblUser.Text = lblUser.Text;
            frm.btnSave.Enabled = false;
        }

        private void dataGridView5_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView5.SelectedRows[0];
            this.Hide();
            Frmhosteler frm = new Frmhosteler();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.AdmissionNo.Text = dr.Cells[0].Value.ToString();
            frm.StudentName.Text = dr.Cells[1].Value.ToString();
            frm.txtClass.Text = dr.Cells[2].Value.ToString();
            frm.cmbsection.Text = dr.Cells[3].Value.ToString();
            frm.cmbHostelName.Text = dr.Cells[4].Value.ToString();
            frm.dtpJoiningDate.Text = dr.Cells[5].Value.ToString();

            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.AdmissionNo.Focus();
            frm.lblUser.Text = lblUser.Text;
            frm.btnSave.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView1.DataSource = null;
            cmbClass.Text = "";
            cmbSection.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdmissionNo.Text = "";
            dataGridView2.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             txtStudentName.Text = "";
            cmbStudentName.Text = "";
            dataGridView3.DataSource = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = System.DateTime.Today.ToString();
            dateTimePicker2.Text = System.DateTime.Today.ToString();
            dataGridView4.DataSource = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtHostelName.Text = "";
            cmbHostelName.Text = "";
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

                rowsTotal = dataGridView1.RowCount;
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        }
        }
        
        
    

