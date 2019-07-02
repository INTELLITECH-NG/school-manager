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
    public partial class FrmHostelinfoRecord : Form
    {
       
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public FrmHostelinfoRecord()
        {
            InitializeComponent();
        }
        public void GetData()  //is getdata function ko form ke load event par call kar lena
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ID) as [ID],RTRIM(HostelName) as [Hostel Name],RTRIM(Hostel_Address) as [Address],RTRIM(Hostel_Phone) as [Phone No],RTRIM(ManagedBy) as [Managed By], RTRIM(Hostel_ContactNo) as [Contact No],HostelFees from HostelInfo order by HostelName ", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "HostelInfo");
                DataGridView1.DataSource = myDataSet.Tables["HostelInfo"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmHostelinfoRecord_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            try
            {
                this.Hide();
                FrmHostel_info frm =new FrmHostel_info();
                frm.Show();
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
             frm.txtID.Text = dr.Cells[0].Value.ToString();
            frm.txtHostelName.Text = dr.Cells[1].Value.ToString();
            frm.txtAddress.Text = dr.Cells[2].Value.ToString();
            frm.txtPhoneNo.Text = dr.Cells[3].Value.ToString();
            frm.txtManagedBy.Text = dr.Cells[4].Value.ToString();
            frm.txtContactNo.Text = dr.Cells[5].Value.ToString();
            frm.txtHostelFees.Text = dr.Cells[6].Value.ToString();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.btnUpdate_record.Enabled =true;
            frm.btnDelete.Enabled = true;
            frm.btnSave.Enabled = false;
                              //ye hide ho jaye kyu ki grid view se data laye he update k liye save ke lie nhi 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmHostelinfoRecord_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            FrmHostel_info frm = new FrmHostel_info();
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

