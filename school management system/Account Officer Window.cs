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
    public partial class Account_Officer_Window : Form
    {
        public Account_Officer_Window()
        {
            InitializeComponent();
        }

       

        private void classFeePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClassFeePaymentcs frm = new frmClassFeePaymentcs();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void buaFeePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmBusFeePayment frm = new FrmBusFeePayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void hostelFeePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHostelFeePayment frm = new FrmHostelFeePayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void scholarshipFeePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScholarshippayment frm = new frmScholarshippayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void salaryPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmployeepayment frm = new frmEmployeepayment();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }

        private void Account_Officer_Window_Load(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
            timer1.Start();
        }
    }
}
