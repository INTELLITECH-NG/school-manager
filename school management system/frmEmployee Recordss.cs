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
    public partial class frmEmployee_Recordss : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmEmployee_Recordss()
        {
            InitializeComponent();
        }
        private void AutocompleEmployee()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(StaffName) from Employee ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CmbEmployeeName.Items.Add(rdr[0]);
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

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select RTrim(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name], RTRIM(Department)[Department], RTRIM(Gender)[Gender],RTRIM(DOB)[DOB],RTRIM(status) [Status], RTRIM(FatherName)[Father's Name],RTRIM(motherName) [mother's Name], RTRIM(PermanentAddress)[Permanent Address],RTRIM(TemporaryAddress)[Temporary Address], RTRIM(PhoneNo)[Phone No.], RTRIM(MobileNo)[Mobile No.],RTRIM(DateOfJoining)[Date Of Joining],RTRIM(Qualification)[Qualifications],RTRIM(YearOfExperience)[Year Of  Experience], RTRIM(Designation)[Designation], RTRIM(Email)[Email], RTRIM(BasicSalary)[Basic Salary], (Picture)[Picture] from employee  where Dateofjoining between @date1 and @date2 order by Staffname", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "DateOfjoining").Value =Date_from. Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "DateOfjoining").Value = Date_to.Value.Date;


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Employee");

                dataGridView1.DataSource = myDataSet.Tables["Employee"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmployee_Recordss_Load(object sender, EventArgs e)
        {
            AutocompleEmployee();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmEmployee frm = new frmEmployee();
                // or simply use column name instead of index
                //dr.Cells["id"].Value.ToString();
                frm.Show();
                frm.txtStaffID.Text = dr.Cells[0].Value.ToString();
                frm.txtStaffName.Text = dr.Cells[1].Value.ToString();
                frm.txtDepartment.Text = dr.Cells[2].Value.ToString();
                frm.cmbGender.Text = dr.Cells[3].Value.ToString();
                frm.DOB.Text = dr.Cells[4].Value.ToString();
                frm.cmbstatus.Text = dr.Cells[5].Value.ToString();
                frm.txtFatherName.Text = dr.Cells[6].Value.ToString();
                frm.txtmotherName.Text = dr.Cells[7].Value.ToString();
                frm.txtPAddress.Text = dr.Cells[8].Value.ToString();
                frm.txtTAddress.Text = dr.Cells[9].Value.ToString();
                frm.txtPhoneNo.Text = dr.Cells[10].Value.ToString();
                frm.txtMobileNo.Text = dr.Cells[11].Value.ToString();
                frm.dtpDateOfJoining.Text = dr.Cells[12].Value.ToString();
                frm.txtQualifications.Text = dr.Cells[13].Value.ToString();
                frm.txtYOP.Text = dr.Cells[14].Value.ToString();
                frm.txtDesignation.Text = dr.Cells[15].Value.ToString();
                frm.txtEmail.Text = dr.Cells[16].Value.ToString();
                frm.txtBasicSalary.Text = dr.Cells[17].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                byte[] data = (byte[])dr.Cells[18].Value;
                MemoryStream ms = new MemoryStream(data);
              
                frm.pictureBox1.Image = Image.FromStream(ms);
               // frm.lblUser.Text = lblUser.Text;
                frm.Delete.Enabled = true;
                frm.btnupdate.Enabled = true;
                frm.btnSave.Enabled = false;
      
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
                cmd = new SqlCommand("select RTrim(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name], RTRIM(Department)[Department], RTRIM(Gender)[Gender],RTRIM(DOB)[DOB],RTRIM(status) [Status], RTRIM(FatherName)[Father's Name],RTRIM(motherName) [mother's Name], RTRIM(PermanentAddress)[Permanent Address],RTRIM(TemporaryAddress)[Temporary Address], RTRIM(PhoneNo)[Phone No.], RTRIM(MobileNo)[Mobile No.],RTRIM(DateOfJoining)[Date Of Joining],RTRIM(Qualification)[Qualifications],RTRIM(YearOfExperience)[Year Of  Experience], RTRIM(Designation)[Designation], RTRIM(Email)[Email], RTRIM(BasicSalary)[Basic Salary], (Picture)[Picture] from employee  Where StaffName='" + CmbEmployeeName.Text + "' order by Staffname", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Employee");

                dataGridView2.DataSource = myDataSet.Tables["Employee"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = new SqlCommand("select RTrim(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name], RTRIM(Department)[Department], RTRIM(Gender)[Gender],RTRIM(DOB)[DOB],RTRIM(status) [Status], RTRIM(FatherName)[Father's Name],RTRIM(motherName) [mother's Name], RTRIM(PermanentAddress)[Permanent Address],RTRIM(TemporaryAddress)[Temporary Address], RTRIM(PhoneNo)[Phone No.], RTRIM(MobileNo)[Mobile No.],RTRIM(DateOfJoining)[Date Of Joining],RTRIM(Qualification)[Qualifications],RTRIM(YearOfExperience)[Year Of  Experience], RTRIM(Designation)[Designation], RTRIM(Email)[Email], RTRIM(BasicSalary)[Basic Salary], (Picture)[Picture] from employee where StaffName like '" + txtEmployeeName.Text + "%'  order by Staffname", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Employee");

                dataGridView2.DataSource = myDataSet.Tables["Employee"].DefaultView;




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
                frmEmployee frm = new frmEmployee();
                // or simply use column name instead of index
                //dr.Cells["id"].Value.ToString();
                frm.Show();
                frm.txtStaffID.Text = dr.Cells[0].Value.ToString();
                frm.txtStaffName.Text = dr.Cells[1].Value.ToString();
                frm.txtDepartment.Text = dr.Cells[2].Value.ToString();
                frm.cmbGender.Text = dr.Cells[3].Value.ToString();
                frm.DOB.Text = dr.Cells[4].Value.ToString();
                frm.cmbstatus.Text = dr.Cells[5].Value.ToString();
                frm.txtFatherName.Text = dr.Cells[6].Value.ToString();
                frm.txtmotherName.Text = dr.Cells[7].Value.ToString();
                frm.txtPAddress.Text = dr.Cells[8].Value.ToString();
                frm.txtTAddress.Text = dr.Cells[9].Value.ToString();
                frm.txtPhoneNo.Text = dr.Cells[10].Value.ToString();
                frm.txtMobileNo.Text = dr.Cells[11].Value.ToString();
                frm.dtpDateOfJoining.Text = dr.Cells[12].Value.ToString();
                frm.txtQualifications.Text = dr.Cells[13].Value.ToString();
                frm.txtYOP.Text = dr.Cells[14].Value.ToString();
                frm.txtDesignation.Text = dr.Cells[15].Value.ToString();
                frm.txtEmail.Text = dr.Cells[16].Value.ToString();
                frm.txtBasicSalary.Text = dr.Cells[17].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                byte[] data = (byte[])dr.Cells[18].Value;
                MemoryStream ms = new MemoryStream(data);
                frm.pictureBox1.Image = Image.FromStream(ms);
        
                frm.Delete.Enabled = true;
                frm.btnupdate.Enabled = true;
                frm.btnSave.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmEmployee_Recordss_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmEmployee frm = new frmEmployee();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView1.DataSource = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CmbEmployeeName.Text = "";
            txtEmployeeName.Text = "";
           
            dataGridView2.DataSource = null;
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
