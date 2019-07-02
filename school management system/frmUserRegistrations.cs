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

namespace school_management_system
{
    public partial class frmUserRegistrations : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
  
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        string st1;
        string st2;
        clsFunc cf = new clsFunc();
        public frmUserRegistrations()
        {
            InitializeComponent();
        }
        private void Autocomplete()
        {

            con = new SqlConnection(cs.DBcon);
            con.Open();


            SqlCommand cmd = new SqlCommand("SELECT userID FROM user_registration", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "user_registration");


            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["UserID"].ToString());

            }
            UserID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            UserID.AutoCompleteCustomSource = col;
            UserID.AutoCompleteMode = AutoCompleteMode.Suggest;

            con.Close();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "")
            {
                MessageBox.Show("Please enter userID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserID.Focus();
                return;
            }
            if (cmbUsertype.Text == "")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserID.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtContact_no.Text == "")
            {
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact_no.Focus();
                return;
            }
            if (txtEmail_Address.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail_Address.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select userID from user_registration where userID=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 150, "userID"));
                cmd.Parameters["@find"].Value = UserID.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("UserID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserID.Text = "";
                    UserID.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();
                
                string cb = "insert into user_registration(UserID,password,contact_no,email,name,date_of_joining,usertype) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)";

            
                 cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", UserID.Text);
                cmd.Parameters.AddWithValue("@d7", cmbUsertype.Text);
                cmd.Parameters.AddWithValue("@d2", txtPassword.Text);
                cmd.Parameters.AddWithValue("@d5", txtName.Text);
                cmd.Parameters.AddWithValue("@d3", txtContact_no.Text);
                cmd.Parameters.AddWithValue("@d4", txtEmail_Address.Text);
                cmd.Parameters.AddWithValue("@d6", System.DateTime.Now);
                cmd.ExecuteReader();
                con.Close();
                st1 = lblUser.Text;
                st2 = "added the new user having user id'" + UserID.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
         
                btnRegister.Enabled = false;
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void delete_records()
        {

            try
            {
                if (UserID.Text == "admin")
                {
                    MessageBox.Show("Admin Account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq = "delete from User_Registration where UserID='" + UserID.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = " Registered User is Deleted in User Registration";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Autocomplete();
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                frmRegisteredUsersDetails frm1 =new frmRegisteredUsersDetails();
                    frm1.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    delete_records();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void Reset()
        {
            UserID.Text = "";
            txtPassword.Text = "";
            txtContact_no.Text = "";
            txtName.Text = "";
            txtEmail_Address.Text = "";
            btnRegister.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            cmbUsertype.Text = "";
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
        Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUserRegistrations_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
             try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "update user_registration set UserID=@d1 , password=@d2,contact_no=@d3,email=@d4,name=@d5,usertype=@d7 where userid=@d8";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", UserID.Text);
                cmd.Parameters.AddWithValue("@d7", cmbUsertype.Text);
                cmd.Parameters.AddWithValue("@d2", txtPassword.Text);
                cmd.Parameters.AddWithValue("@d5", txtName.Text);
                cmd.Parameters.AddWithValue("@d3", txtContact_no.Text);
                cmd.Parameters.AddWithValue("@d4", txtEmail_Address.Text);
                cmd.Parameters.AddWithValue("@d8", TextBox1.Text);
                cmd.ExecuteReader();
                con.Close();
                frmRegisteredUsersDetails frm = new frmRegisteredUsersDetails();
                frm.GetData();
                MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = " Registered User is Updated in User Registration";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                Autocomplete();
                btnRegister.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
             try
            {
                if (UserID.Text == "")
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserID.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select username from user_registration where userID=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 150, "userid"));
                cmd.Parameters["@find"].Value = UserID.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("UserID not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!rdr.Read())
                {
                    MessageBox.Show("UserID available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserID.Focus();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }

               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Address_Validating(object sender, CancelEventArgs e)
        {
              System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail_Address.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail_Address.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail_Address.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
             System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9_]");
            if (UserID.Text.Length > 0)
            {
                if (!rEMail.IsMatch(UserID.Text))
                {
                    MessageBox.Show("only letters,numbers and underscore is allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserID.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
             btnDelete.Enabled = true;
            btnUpdate_record.Enabled = true;
            try
            {
                UserID.Text = UserID.Text.TrimEnd();
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM user_registration WHERE userID = '" + UserID.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    txtPassword.Text = (rdr.GetString(1).Trim());
                    txtName.Text = (rdr.GetString(2).Trim());
                    txtContact_no.Text = (rdr.GetString(3).Trim());
                    txtEmail_Address.Text = (rdr.GetString(4).Trim());
                    cmbUsertype.Text = (rdr.GetString(6).Trim());


                }

                if ((rdr != null))
                {
                    rdr.Close();
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisteredUsersDetails frm =new  frmRegisteredUsersDetails();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
      
            frm.Show();
        }

        private void frmUserRegistrations_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }
        }
    }

