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
    public partial class frmExamEntry : Form
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
        public frmExamEntry()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(ID),RTRIM(ExamName),RTRIM(ExamType) from Exams", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
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
                if (txtExamName.Text == "")
                {
                    MessageBox.Show("Please enter Exam name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtExamName.Focus();
                    return;
                }
                if (cmbExamType.Text == "")
                {
                    MessageBox.Show("Please enter ExamType", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbExamType.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select ExamName from Exams where ExamName='" + txtExamName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Exam Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtExamName.Text = "";
                    txtExamName.Focus();



                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Exams(ExamName,ExamType) VALUES ('" + txtExamName.Text + "','" + cmbExamType.Text + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                GetData();
                st1 = lblUser.Text;
                st2 = "Added New Exam '" + txtExamName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);


                btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExamEntry_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
         Reset();   
        }
         private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Exams where ID = '" + textBox1.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted Exam '" +txtExamName.Text+ "'";
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
        private void Reset()
        {
      
            txtExamName.Text = "";
            textBox1.Text = "";
            cmbExamType.Text = "";
            
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
        }
        private void Update_record_Click(object sender, EventArgs e)
        {
             try
            {

         
             con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "update Exams set ExamName='" + txtExamName.Text + "',ExamType='" +cmbExamType.Text  + "' where  ID='" +textBox1.Text  + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                 cmd.ExecuteReader();
                 GetData();
                MessageBox.Show("Successfully updated", "Exam Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated Exam'" +txtExamName.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
               Update_record.Enabled=false;
      
           
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Delete_Click(object sender, EventArgs e)
        {
          delete_records();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                textBox1.Text = dr.Cells[0].Value.ToString();
                txtExamName.Text = dr.Cells[1].Value.ToString();
                cmbExamType.Text = dr.Cells[2].Value.ToString();

                Update_record.Enabled = true; //ye button item select karne pe dikhe
                btnSave.Enabled = false;
                Delete.Enabled = true;                            //ye hide ho jaye kyu ki grid view se data laye he update k liye save ke lie nhi 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        }
    }

