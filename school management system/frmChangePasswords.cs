using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace school_management_system
{
    public partial class frmChangePasswords : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        Connectionstring cs = new Connectionstring();
        public frmChangePasswords()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = 0;
                if ((txtUserID.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter UserID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Focus();
                    return;
                }
                if ((txtOldPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.Focus();
                    return;
                }
                if ((txtNewPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                    return;
                }
                if ((txtConfirmPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please confirm new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Focus();
                    return;
                }
                if ((txtNewPassword.TextLength < 5))
                {
                    MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }
                else if ((txtNewPassword.Text != txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtOldPassword.Focus();
                    return;
                }
                else if ((txtOldPassword.Text == txtNewPassword.Text))
                {
                    MessageBox.Show("Password is same..Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string co = "Update User_Registration set Password = '" + txtNewPassword.Text + "'where UserID='" +txtUserID.Text + "' and Password = '" + txtOldPassword.Text + "'";

                cmd = new SqlCommand(co);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if ((RowsAffected > 0))
                {
                    MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    txtUserID.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    frmLogin LoginForm1 = new frmLogin();
                    LoginForm1.Show();
                    LoginForm1.cmbUsertype.Text = "";
                    LoginForm1.UserID.Text = "";
                    LoginForm1.Password.Text = "";
                    LoginForm1.ProgressBar1.Visible = false;
                    LoginForm1.cmbUsertype.Focus();
                }
                else
                {
                    MessageBox.Show("invalid userID or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtUserID.Focus();
                }
                if ((con.State == ConnectionState.Open))
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

        private void frmChangePasswords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.cmbUsertype.Text = "";
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.cmbUsertype.Focus();
            frm.Show();
        }
    }
}
