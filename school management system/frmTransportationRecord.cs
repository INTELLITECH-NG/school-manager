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
    public partial class frmTransportationRecord : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
  
        public frmTransportationRecord()
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
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand( "SELECT RTRIM(RouteID)[Route  ID],RTRIM(SourceLocation)[Source  Location],RTRIM(BusCharges)[Bus  Charges] FROM Transportation order by SourceLocation ", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmTransportationRecord_Load(object sender, EventArgs e)
        {
            GetData();
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
            frmTrasportation frm = new frmTrasportation();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.txtRouteID.Text = dr.Cells[0].Value.ToString();
            frm.txtSourceLocation.Text = dr.Cells[1].Value.ToString();
            frm.txtBusCharges.Text = dr.Cells[2].Value.ToString();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            
                frm.btnDelete.Enabled = true;
                frm.btnUpdate_record.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.txtSourceLocation.Focus();
                frm.label1.Text = label1.Text;
               
           
               
            }

        private void frmTransportationRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmTrasportation frm = new frmTrasportation();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }
        }
        }
    
