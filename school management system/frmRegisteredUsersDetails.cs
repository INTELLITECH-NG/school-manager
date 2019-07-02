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
    public partial class frmRegisteredUsersDetails : Form
    {
        Connectionstring cs = new Connectionstring();
        public frmRegisteredUsersDetails()
        {
            InitializeComponent();
        }
        private SqlConnection Connection
        {
            get
            {
                SqlConnection ConnectionToFetch = new SqlConnection(cs.DBcon);
                ConnectionToFetch.Open();
                return ConnectionToFetch;
            }
        }
        public DataView GetData()
        {
            dynamic SelectQry = "SELECT RTRIM(UserID),RTRIM(Password)[Password],RTRIM(Name)[Name],RTRIM(Contact_No)[Contact No.],RTRIM(Email)[Email],RTRIM(userType) as [User Type] ,RTRIM(Date_of_joining)[Date Of Joining] FROM user_registration Where UserType='"+usertype.Text+"'";
            DataSet SampleSource = new DataSet();
            DataView TableView = null;
            try
            {
                SqlCommand SampleCommand = new SqlCommand();
                dynamic SampleDataAdapter = new SqlDataAdapter();
                SampleCommand.CommandText = SelectQry;
                SampleCommand.Connection = Connection;
                SampleDataAdapter.SelectCommand = SampleCommand;
                SampleDataAdapter.Fill(SampleSource);
                TableView = SampleSource.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TableView;
        }
        private void frmRegisteredUsersDetails_Load(object sender, EventArgs e)
        {

        }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
            frmUserRegistrations frm = new frmUserRegistrations();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.UserID.Text = dr.Cells[0].Value.ToString();
            frm.TextBox1.Text = dr.Cells[0].Value.ToString();
            frm.txtPassword.Text= dr.Cells[1].Value.ToString();
            frm.txtName.Text = dr.Cells[2].Value.ToString();
            frm.txtContact_no.Text= dr.Cells[3].Value.ToString();
            frm.txtEmail_Address.Text = dr.Cells[4].Value.ToString();
            frm.cmbUsertype.Text = dr.Cells[5].Value.ToString();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.btnDelete.Enabled = true;
            frm.btnUpdate_record.Enabled = true;
            frm.btnRegister.Enabled = false;
            frm.UserID.Focus();
     
     }

        private void frmRegisteredUsersDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmUserRegistrations frm = new frmUserRegistrations();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
           
        }
    }
}
