using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace school_management_system
{
    public partial class frmSubjectRecords : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmSubjectRecords()
        {
            InitializeComponent();
        }
        private void AutocompleteClass()
        {

            try
            {


                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(ClassName) FROM class", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                Course.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    Course.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmSubjectRecords_Load(object sender, EventArgs e)
        {
            AutocompleteClass();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("select RTrim(SubjectCode)[Subject Code], RTRIM(SubjectName)[Subject Name],RTRIM(ClassName)[Class Name] from subject  where ClassName= '" + Course.Text + "' order by className,subjectcode", con);
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
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Course.Text == "")
                {
                    MessageBox.Show("Please select class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Course.Focus();
                    return;
                }

                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmSubectEntry frm = new frmSubectEntry();
                // or simply use column name instead of index
                //dr.Cells["id"].Value.ToString();
                frm.Show();
                frm.SubjectCode.Text = dr.Cells[0].Value.ToString();
                frm.TextBox1.Text = dr.Cells[0].Value.ToString();
                frm.SubjectName.Text = dr.Cells[1].Value.ToString();
                frm.cmbClass.Text= dr.Cells[2].Value.ToString();
               // frm.txtClassID.Text = dr.Cells[3].Value.ToString();
                frm.lblUser.Text = lblUser.Text;
                frm.lblUserType.Text = lblUserType.Text;
                frm.SubjectCode.Enabled = false;
                frm.Delete.Enabled = true;
                frm.Update_record.Enabled = true;
                frm.btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Course.Text = "";
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = null;
            Course.Focus();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSubjectRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmSubectEntry frm = new frmSubectEntry();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }
    }
}
