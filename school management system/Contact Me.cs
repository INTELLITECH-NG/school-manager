using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class Contact_Me : Form
    {
        public Contact_Me()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string webAddress = "https://www.facebook.com/vaibhav.patidar.524";

                System.Diagnostics.Process.Start(webAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Contact_Me_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.ShowDialog();*/
        }

        private void Contact_Me_Load(object sender, EventArgs e)
        {

        }
    }
}
