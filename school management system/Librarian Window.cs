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
    public partial class Librarian_Window : Form
    {
        public Librarian_Window()
        {
            InitializeComponent();
        }

        private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmStudentBookIssue frm = new frmStudentBookIssue();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookReturn frm = new frmBookReturn();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
            timer1.Start();
        }
    }
}
