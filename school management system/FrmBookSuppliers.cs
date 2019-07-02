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
    public partial class FrmBookSuppliers : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public FrmBookSuppliers()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(supplierName) [Supplier Name],rtrim(address) [Address],rtrim(contactNo) [Contact No],rtrim(EmailID) [Email ID],ID  from Supplier order by SupplierName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmBookSuppliers_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                this.Hide();
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                FrmSupplier frm = new FrmSupplier();
                frm.Show();
                frm.txtSupplierName.Text = dr.Cells[0].Value.ToString();
                frm.txtAddress.Text = dr.Cells[1].Value.ToString();
                frm.txtContactNo.Text = dr.Cells[2].Value.ToString();
                frm.txtEmail.Text = dr.Cells[3].Value.ToString();
                frm.ID.Text = dr.Cells[4].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
               frm. btnUpdate_record.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.btnDelete.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBookSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmSupplier frm = new FrmSupplier();
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
