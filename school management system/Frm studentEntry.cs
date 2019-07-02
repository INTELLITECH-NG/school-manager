using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace school_management_system
{
    public partial class Frm_student : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public Frm_student()
        {
            InitializeComponent();
        }

        private void auto()
        {
            txtAdmissionNo.Text = "A-" + GetUniqueKey(6);
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
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


        private void Frm_student_Load(object sender, EventArgs e)
        {
            FillClass();
            AutocompleSchool();
    

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
              
                if (txtGender.Text == "")
                {
                    MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGender.Focus();
                    return;
                }
                if (cmbCategory.Text == "")
                {
                    MessageBox.Show("Please select Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCategory.Focus();
                    return;
                }
                if (txtFathername.Text == "")
                {
                    MessageBox.Show("Please enter father's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFathername.Focus();
                    return;
                }
                if (txtSession.Text == "")
                {
                    MessageBox.Show("Please enter session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSession.Focus();
                    return;
                }
                if (dtpDOB.Text == "")
                {
                    MessageBox.Show("Please enter dob", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDOB.Focus();
                    return;
                }

                if (txtMotherName.Text == "")
                {
                    MessageBox.Show("Please enter mother's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMotherName.Focus();
                    return;
                }

                if (cmbReligion.Text == "")
                {
                    MessageBox.Show("Please select religion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbReligion.Focus();
                    return;
                }
                if (txtPermanentAddress.Text == "")
                {
                    MessageBox.Show("Please select address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPermanentAddress.Focus();
                    return;
                }
               
                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactNo.Focus();
                    return;
                }
                if (txtEmailID.Text == "")
                {
                    MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailID.Focus();
                    return;
                }
                if (cmbClass.Text == "")
                {
                    MessageBox.Show("Please select class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClass.Focus();
                    return;
                }
                if (CmbSection.Text == "")
                {
                    MessageBox.Show("Please select Section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CmbSection.Focus();
                    return;
                }

                if (cmbSchoolName.Text == "")
                {
                    MessageBox.Show("Please select SchoolName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSchoolName.Focus();
                    return;
                }
               
                if (txtNationality.Text == "")
                {
                    MessageBox.Show("Please enter nationality", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNationality.Focus();
                    return;
                }
                auto();

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Student(AdmissionNo, EnrollmentNo, StudentName, FatherName, MotherName, FatherCN, PermanentAddress, TemporaryAddress, ContactNo, EmailID, DOB, Gender, AdmissionDate, Session, Caste, Religion, Class,Photo, Status,Nationality,Section,SchoolID) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22)";  //id  li

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text);
                cmd.Parameters.AddWithValue("@d2", txtEnrollmentNo.Text);
                cmd.Parameters.AddWithValue("@d3", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@d4", txtFathername.Text);
                cmd.Parameters.AddWithValue("@d5", txtMotherName.Text);
                cmd.Parameters.AddWithValue("@d6", txtFatherContactNo.Text);
                cmd.Parameters.AddWithValue("@d7", txtPermanentAddress.Text);
                cmd.Parameters.AddWithValue("@d8", txtTemrorayAddress.Text);
                cmd.Parameters.AddWithValue("@d9", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d10", txtEmailID.Text);
                cmd.Parameters.AddWithValue("@d11", dtpDOB.Text);
                cmd.Parameters.AddWithValue("@d12", txtGender.Text);
                cmd.Parameters.AddWithValue("@d13", dtpAdmissionDate.Text);
                cmd.Parameters.AddWithValue("@d14", txtSession.Text);
                cmd.Parameters.AddWithValue("@d15", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@d16", cmbReligion.Text);
                cmd.Parameters.AddWithValue("@d17", cmbClass.Text);
                cmd.Parameters.AddWithValue("@d19", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@d20", txtNationality.Text);
                cmd.Parameters.AddWithValue("@d21", CmbSection.Text);
                cmd.Parameters.AddWithValue("@d22", txtSchoolID.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(Picture.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d18", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteReader();
                con.Close();
                st1 = lblUser.Text;
                st2 = "added the new student '" + txtStudentName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully saved", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                btnSave.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Browse_Click(object sender, EventArgs e)
        {

            try
            {
                var _with1 = OpenFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;
                //Reset the file name
                OpenFileDialog1.FileName = "";

                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Picture.Image = Image.FromFile(OpenFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "Update Student Set EnrollmentNo=@d2, StudentName=@d3, FatherName=@d4, MotherName=@d5, FatherCN=@d6, PermanentAddress=@d7, TemporaryAddress=@d8, ContactNo=@d9, EmailID=@d10, DOB=@d11, Gender=@d12, AdmissionDate=@d13, Session=@d14, Caste=@d15, Religion=@d16, Class=@d17,Photo=@d18, Status=@d19,Nationality=@d20,Section=@d21,SchoolID=@d22 where AdmissionNo=@d1";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text);
                cmd.Parameters.AddWithValue("@d2", txtEnrollmentNo.Text);
                cmd.Parameters.AddWithValue("@d3", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@d4", txtFathername.Text);
                cmd.Parameters.AddWithValue("@d5", txtMotherName.Text);
                cmd.Parameters.AddWithValue("@d6", txtFatherContactNo.Text);
                cmd.Parameters.AddWithValue("@d7", txtPermanentAddress.Text);
                cmd.Parameters.AddWithValue("@d8", txtTemrorayAddress.Text);
                cmd.Parameters.AddWithValue("@d9", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d10", txtEmailID.Text);
                cmd.Parameters.AddWithValue("@d11", dtpDOB.Text);
                cmd.Parameters.AddWithValue("@d12", txtGender.Text);
                cmd.Parameters.AddWithValue("@d13", dtpAdmissionDate.Text);
                cmd.Parameters.AddWithValue("@d14", txtSession.Text);
                cmd.Parameters.AddWithValue("@d15", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@d16", cmbReligion.Text);
                cmd.Parameters.AddWithValue("@d17", cmbClass.Text);
                cmd.Parameters.AddWithValue("@d19", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@d20", txtNationality.Text);
                cmd.Parameters.AddWithValue("@d21", CmbSection.Text);
                cmd.Parameters.AddWithValue("@d22", txtSchoolID.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(Picture.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d18", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteReader();
               
                MessageBox.Show("Successfully updated", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
                st1 = lblUser.Text;
                st2 = "Updated the Student '" +txtStudentName.Text + "' having admissionNo '" + txtAdmissionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2); 
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FillClass()    
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct1 = "SELECT distinct RTRIM(ClassName) FROM Class";  
                cmd = new SqlCommand(ct1);
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

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentRecordSearch frm = new  frmStudentRecordSearch();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();

        }


       
        private void Reset()
        {

            txtAdmissionNo.Text = "";
            cmbSchoolName.SelectedIndex=-1;
   
            txtContactNo.Text = "";
            txtContactNo.Text = "";
            txtEmailID.Text = "";
            txtEnrollmentNo.Text = "";
            txtFatherContactNo.Text = "";
            txtFathername.Text = "";
            txtMotherName.Text = "";
            txtNationality.Text = "";
            txtPermanentAddress.Text = "";
            dtpAdmissionDate.Text = System.DateTime.Now.ToString();
  
            txtSession.Text = "";
            txtStudentName.Text = "";
            txtTemrorayAddress.Text = "";
            cmbCategory.Text = "";
            cmbClass.Text= "";
            cmbReligion.Text = "";
            CmbSection.Text = "";
            cmbStatus.Text = "";
            txtGender.Text = "";
            dtpDOB.Text = System.DateTime.Now.ToString();
            
            cmbSchoolName.Text = "";
            Picture.Image = Properties.Resources.photo;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }
        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);

                con.Open();
                string cm = "select AdmissionNo from BusHolders where AdmissionNo=@find";


                cmd = new SqlCommand(cm);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));


                cmd.Parameters["@find"].Value =txtAdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                    
                string cm1 = "select AdmissionNo from hostler where AdmissionNo=@find";


                cmd = new SqlCommand(cm1);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));


                cmd.Parameters["@find"].Value =txtAdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                string cm2 = "select AdmissionNo from busfeepayment where AdmissionNo=@find";


                cmd = new SqlCommand(cm2);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));


                cmd.Parameters["@find"].Value = txtAdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                string cm3 = "select AdmissionNo from hostelfeepayment where AdmissionNo=@find";


                cmd = new SqlCommand(cm3);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));


                cmd.Parameters["@find"].Value = txtAdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                string cm4 = "select AdmissionNo from coursefeepayment where AdmissionNo=@find";


                cmd = new SqlCommand(cm4);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));


                cmd.Parameters["@find"].Value = txtAdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                string cm5 = "select AdmissionNo from StudentBookissue where AdmissionNo=@find";


                cmd = new SqlCommand(cm5);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));


                cmd.Parameters["@find"].Value = txtAdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

          
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from student where AdmissionNo='" + txtAdmissionNo.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deleted the Student '" +txtStudentName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
               // GetData(); 


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records();
        }
        public void AutocompleCourse()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(ClassName) from class ";

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
        public void AutocompleSchool()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(SchoolName) from School ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSchoolName.Items.Add(rdr[0]);
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

            CmbSection.Items.Clear();
            CmbSection.Text = "";
            CmbSection.Enabled = true;
            CmbSection.Focus();

            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(Section) from  class  where ClassName = '" + cmbClass.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CmbSection.Items.Add(rdr[0]);
              }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cmbSchoolName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "SELECT ID FROM School where SchoolName='"+cmbSchoolName.Text+"' ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
              
                   txtSchoolID.Text = rdr.GetInt32(0).ToString();


                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_student_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void txtFatherContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

       
        }
    }

    


      

