using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace school_management_system
{
    public partial class frmEmployeePaymentReceipt : Form
    {
        public frmEmployeePaymentReceipt()
        {
            InitializeComponent();
        }

        private void frmEmployeePaymentReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void frmEmployeePaymentReceipt_Load(object sender, EventArgs e)
        {

        }
    }
}
