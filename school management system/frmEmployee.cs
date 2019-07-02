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
using System.Security.Cryptography;

namespace school_management_system
{
    public partial class frmEmployee : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       Connectionstring cs = new Connectionstring();
       clsFunc cf = new clsFunc();
       string st1;
       string st2;
        public frmEmployee()
        {
            InitializeComponent();
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txtStaffID.Text = "E-" + GetUniqueKey(6);
        }
        private void Autocompletedepartment()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(DepartmentName) from Department ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtDepartment.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Autocompletedepartment();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaffName.Text == "")
                {
                    MessageBox.Show("Please enter staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStaffName.Focus();
                    return;
                }
                if (cmbGender.Text == "")
                {
                    MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbGender.Focus();
                    return;
                }
                if (DOB.Text == "")
                {
                    MessageBox.Show("Please enter DOB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOB.Focus();
                    return;
                }
                if (txtFatherName.Text == "")
                {
                    MessageBox.Show("Please enter father's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFatherName.Focus();
                    return;
                }
                if (txtPAddress.Text == "")
                {
                    MessageBox.Show("Please enter permanent address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPAddress.Focus();
                    return;
                }
                if (txtTAddress.Text == "")
                {
                    MessageBox.Show("Please enter temporary address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTAddress.Focus();
                    return;
                }
                if (txtPhoneNo.Text == "")
                {
                    MessageBox.Show("Please enter phone no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNo.Focus();
                    return;
                }
                if (txtMobileNo.Text == "")
                {
                    MessageBox.Show("Please enter mobile no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobileNo.Focus();
                    return;
                }

                if (txtDepartment.Text == "")
                {
                    MessageBox.Show("Please select department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepartment.Focus();
                    return;
                }
                if (txtQualifications.Text == "")
                {
                    MessageBox.Show("Please enter qualifications", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQualifications.Focus();
                    return;
                }
                if (txtYOP.Text == "")
                {
                    MessageBox.Show("Please enter year of experience", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYOP.Focus();
                    return;
                }
                if (txtDesignation.Text == "")
                {
                    MessageBox.Show("Please enter staff designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesignation.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                if (txtBasicSalary.Text == "")
                {
                    MessageBox.Show("Please enter basic salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBasicSalary.Focus();
                    return;
                }

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Please browse & select photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Browse.Focus();
                    return;
                }


                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Employee(Staffid,staffname,department,gender,fathername,permanentaddress,temporaryaddress,phoneno,mobileno,dateofjoining,qualification,yearofexperience,designation,email,Basicsalary,picture,DOB,status,mothername) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19)";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "Staffid"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Staffname"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.VarChar, 100, "department"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "gender"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "fathername"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.VarChar, 100, "permanentaddress"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 100, "temporaryaddress"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 10, "Phoneno"));

                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.NChar, 15, "status"));

                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.NChar, 30, "mothername"));

                cmd.Parameters["@d1"].Value = txtStaffID.Text;
                cmd.Parameters["@d2"].Value = txtStaffName.Text;
                cmd.Parameters["@d3"].Value = txtDepartment.Text;
                cmd.Parameters["@d4"].Value = cmbGender.Text;
                cmd.Parameters["@d5"].Value = txtFatherName.Text;
                cmd.Parameters["@d6"].Value = txtPAddress.Text;
         
                cmd.Parameters["@d18"].Value = cmbstatus.Text;
                cmd.Parameters["@d19"].Value = txtmotherName.Text;
                
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);

              
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d16", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added the New Staff'" +txtStaffName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);

                btnSave.Enabled = false;
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var _with1 = openFileDialog1;

            _with1.Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.ico");
            _with1.FilterIndex = 4;

            //Clear the file name
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void clear()
        {
            txtBasicSalary.Text = "";
            txtDepartment.Text = "";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            cmbGender.Text = "";
            txtFatherName.Text = "";
            txtMobileNo.Text = "";
            txtPAddress.Text = "";
            txtPhoneNo.Text = "";
            txtQualifications.Text = "";
            txtmotherName.Text = "";
            cmbstatus.SelectedIndex = -1;
            txtStaffName.Text = "";
            txtTAddress.Text = "";
            txtYOP.Text = "";
            DOB.Text = "";
            txtStaffID.Text = "";
            dtpDateOfJoining.Text = System.DateTime.Today.ToString();
            pictureBox1.Image = Properties.Resources.photo;
      
            btnSave.Enabled = true;
            Delete.Enabled = false;
            btnupdate.Enabled = false;
           
        }
        private void Delete_Click(object sender, EventArgs e)
        {
          try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cm = "select StaffID from EmployeePayment where StaffID=@find";
                cmd = new SqlCommand(cm);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "StaffID"));


                cmd.Parameters["@find"].Value = txtStaffID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cm1 = "select StaffID from Bookissuestaff where StaffID=@find";
                cmd = new SqlCommand(cm1);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "StaffID"));


                cmd.Parameters["@find"].Value = txtStaffID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq = "delete from Employee where StaffID=@DELETE1;";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 15, "StaffID"));
                cmd.Parameters["@DELETE1"].Value = txtStaffID.Text;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the Employee'" + txtStaffName.Text + "' having StaffID='"+txtStaffID.Text+"'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    clear();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    clear();

                }

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Update_record_Click(object sender, EventArgs e)
        {
            try
            {
            con = new SqlConnection(cs.DBcon);
            con.Open();

            string cb = "update Employee set staffname=@d2,department=@d3,gender=@d4,fathername=@d5,permanentaddress=@d6,temporaryaddress=@d7,phoneno=@d8,mobileno=@d9,dateofjoining=@d10,qualification=@d11,yearofexperience=@d12,designation=@d13,email=@d14,Basicsalary=@d15,picture=@d16,DOB=@d17,mothername=@d19,status=@d18 where staffid=@d1";

            cmd = new SqlCommand(cb);
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "Staffid"));

             cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.VarChar, 100, "permanentaddress"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 100, "temporaryaddress"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 10, "Phoneno"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "mobileno"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 30, "dateofjoining"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 70, "qualiication"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.NChar, 50, "yearofexperience"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.VarChar, 100, "designation"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.NChar, 30, "email"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.Int, 10, "basicsalary"));

                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.NChar, 20, "DOB"));
                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.NChar, 15, "status"));

                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.NChar, 30, "mothername"));

                cmd.Parameters["@d1"].Value = txtStaffID.Text;
                cmd.Parameters["@d2"].Value = txtStaffName.Text;
            
                cmd.Parameters["@d8"].Value = txtPhoneNo.Text;
                cmd.Parameters["@d9"].Value = txtMobileNo.Text;
                cmd.Parameters["@d10"].Value = dtpDateOfJoining.Text;
                cmd.Parameters["@d11"].Value = txtQualifications.Text;
                cmd.Parameters["@d12"].Value = txtYOP.Text;
                cmd.Parameters["@d13"].Value = txtDesignation.Text;
                cmd.Parameters["@d14"].Value = txtEmail.Text;
                cmd.Parameters["@d15"].Value = Convert.ToInt32(txtBasicSalary.Text);
                cmd.Parameters["@d17"].Value = DOB.Text;
                cmd.Parameters["@d18"].Value = cmbstatus.Text;
                cmd.Parameters["@d19"].Value = txtmotherName.Text;
                
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d16", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                  con.Close();

                MessageBox.Show("Successfully Updated", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the Staff'" +txtStaffName.Text + "' having StaffID '"+txtStaffID.Text+"'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnupdate.Enabled = false;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }


        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            clear();
        }

      
    }
}
