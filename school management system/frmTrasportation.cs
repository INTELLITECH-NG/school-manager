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
    public partial class frmTrasportation : Form
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
        public frmTrasportation()
        {
            InitializeComponent();
        }

        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT distinct SourceLocation FROM Transportation", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Transportation");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["SourceLocation"].ToString());

                }
                txtSourceLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSourceLocation.AutoCompleteCustomSource = col;
                txtSourceLocation.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            txtSourceLocation.Text = "";
            txtBusCharges.Text = "";
            btnSave.Enabled = true;
            btnUpdate_record.Enabled = false;
            btnDelete.Enabled = false;
            txtSourceLocation.Focus();
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmTrasportation_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (txtSourceLocation.Text == "")
            {
                MessageBox.Show("Please enter source location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSourceLocation.Focus();
                return;
            }
            if (txtBusCharges.Text == "")
            {
                MessageBox.Show("Please enter bus charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusCharges.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select SourceLocation from Transportation where SourceLocation= '" + txtSourceLocation.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Source Location Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSourceLocation.Text = "";
                    txtSourceLocation.Focus();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Transportation(SourceLocation,BusCharges) VALUES (@d1,@d2)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "BusCharges"));
                cmd.Parameters["@d1"].Value = txtSourceLocation.Text;
                cmd.Parameters["@d2"].Value = Convert.ToInt32(txtBusCharges.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Transportation Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added New SourceLocation in Transporation'" +txtSourceLocation.Text+ "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                Autocomplete();
                btnSave.Enabled = false;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
             try
            {
               
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "update Transportation set SourceLocation=@d1,BusCharges=@d2 where RouteID=@d3 ";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "BusCharges"));
                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.Int, 10, "RouteID"));
                cmd.Parameters["@d1"].Value = txtSourceLocation.Text;
                cmd.Parameters["@d2"].Value = Convert.ToInt32(txtBusCharges.Text);
                cmd.Parameters["@d3"].Value = Convert.ToInt32(txtRouteID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully updated", "Transportation Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated SourceLocation in Transporation'" + txtSourceLocation.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                Autocomplete();
                btnUpdate_record.Enabled = false;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void delete_records()
        {

            try
            {
                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cm5 = "select sourceLocation from BusHolders where sourcelocation=@find";


                cmd = new SqlCommand(cm5);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));


                cmd.Parameters["@find"].Value = txtSourceLocation.Text;


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
                string cq = "delete from Transportation where RouteID=@DELETE1";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "RouteID"));
                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtRouteID.Text);
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Updated SourceLocation in Transporation'" + txtSourceLocation.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Reset();
                    Autocomplete();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();

                }
                if (con.State == ConnectionState.Open)
                {
                        con.Close();
                }

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

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmTransportationRecord  frm = new frmTransportationRecord();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmTransportationRecord frm = new frmTransportationRecord();
            frm.lblUserType.Text = lblUserType.Text;
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void frmTrasportation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void txtBusCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        }
    }

