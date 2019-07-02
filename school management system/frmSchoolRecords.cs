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
    public partial class frmSchoolRecords : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmSchoolRecords()
        {
            InitializeComponent();
        }

        private void frmSchoolRecords_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT  ID,rtrim(schoolName) [School Name],rtrim(address) [Address],rtrim(contactNo) [Contact],rtrim(Fax) [Fax] ,rtrim(Email) [Email],rtrim(website) [Website] from School order by SchoolName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Hide();
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
               frmSchoolinfo frm = new frmSchoolinfo();
                frm.Show();
               frm.txtID.Text = dr.Cells[0].Value.ToString();
                frm.txtSchoolName.Text = dr.Cells[1].Value.ToString();
                frm.txtAddress.Text = dr.Cells[2].Value.ToString();
                frm.txtContactNo.Text = dr.Cells[3].Value.ToString();
                frm.txtFax.Text = dr.Cells[4].Value.ToString();
                frm.txtEmailID.Text = dr.Cells[5].Value.ToString();
                frm.txtWebsite.Text = dr.Cells[6].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnUpdate_record.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.btnDelete.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSchoolRecords_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
             frmSchoolinfo frm = new frmSchoolinfo();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                string strRowNumber = (e.RowIndex + 1).ToString();
                SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
                if (DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
                {
                    DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
                }
                Brush b = SystemBrushes.ControlText;
                e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            }
        }
    }
}
