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
    public partial class FrmSections : Form
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

        public FrmSections()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
            btnNew.Enabled = true;
        }
        public void GetData()  //is getdata function ko form ke load event par call kar lena
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(id)as [Section ID],RTRIM(SectionName) as [Section Name] from Section order by Sectionname", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Section");
                DataGridView1.DataSource = myDataSet.Tables["Section"].DefaultView;
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
                if (txtSectionName.Text == "")
                {
                    MessageBox.Show("Please enter Section name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSectionName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select SectionName from Section where SectionName='" +txtSectionName.Text+ "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Section Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSectionName.Text = "";
                    txtSectionName.Focus();
                   


                   if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Section(SectionName) VALUES ('" + txtSectionName.Text + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                GetData();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added the New Section '" +txtSectionName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;

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
                DataGridViewRow dr = DataGridView1.SelectedRows[0];
                txtID.Text = dr.Cells[0].Value.ToString();
               txtSectionName.Text = dr.Cells[1].Value.ToString();
          

              
               //btnupdate.Enabled = true; //ye button item select karne pe dikhe
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;                          //ye hide ho jaye kyu ki grid view se data laye he update k liye save ke lie nhi 
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
        private void Reset()
        {

            txtID.Text = "";
            txtSectionName.Text = "";
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
                string cm = "select Section from Class where Section=@find";


                cmd = new SqlCommand(cm);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Section"));


                cmd.Parameters["@find"].Value = txtSectionName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Section where Id='" + txtID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the Section '" +txtSectionName.Text + "'";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string ct = "select ID from Section where ID='" + txtID.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())   //textbox or databse table me rakhi value match ho to update kare 
                {
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string cb2 = "Update Section set SectionName= '" + txtSectionName.Text + "' where ID = '" +txtID.Text + "'";
                    cmd = new SqlCommand(cb2);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();

                }
                else 
                {
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string cb1 = "insert into Section(Sectionname) VALUES ('" + txtSectionName.Text + "')";
                    cmd = new SqlCommand(cb1);
                    cmd.Connection = con;

                    cmd.ExecuteReader();
                    con.Close();
                }
                
                GetData(); 
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the Section '" + txtSectionName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSections_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

       

        }
    }

