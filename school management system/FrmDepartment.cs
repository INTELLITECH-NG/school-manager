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
    public partial class FrmDepartment : Form
    {

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public FrmDepartment()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ID),RTRIM(DepartmentName) from Department", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(rdr[0], rdr[1]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
               try
            {
                if (txtDepartmentName.Text == "")
                {
                    MessageBox.Show("Please enter department name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepartmentName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select DepartmentName from Department where DepartmentName='" +txtDepartmentName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Department Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepartmentName.Text = "";
                     txtDepartmentName.Focus();
                   


                   if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Department(DepartmentName) VALUES ('" +  txtDepartmentName.Text + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                GetData();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added the New Department'" +txtDepartmentName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                
                btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                txtID.Text = dr.Cells[0].Value.ToString();
                txtDepartmentName.Text = dr.Cells[1].Value.ToString();



                btnUpdate.Enabled = true; //ye button item select karne pe dikhe
                btnSave.Enabled = false;
                btnDelete.Enabled = true;                            //ye hide ho jaye kyu ki grid view se data laye he update k liye save ke lie nhi 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();


                string cb2 = "Update Department set DepartmentName= '" + txtDepartmentName.Text + "' where ID = '" + txtID.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                GetData();  //  1 table update karna h to yha tak ka code hata de
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the Department'" + txtDepartmentName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {

            txtID.Text = "";
            txtDepartmentName.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Department where ID='" + txtID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the Department'" + txtDepartmentName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
          

                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records(); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FrmDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        }
    }

