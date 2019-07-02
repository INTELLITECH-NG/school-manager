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
    public partial class frmBusHolders : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        Connectionstring cs = new Connectionstring();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
       
        public frmBusHolders()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            cmbAdmissionNo.Text = "";
            StudentName.Text = "";
            txtclass.Text = "";
            txtsection.Text = "";
            cmbSourceLocation.Text = "";
            dtpStartingDate.Text = DateTime.Today.ToString();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            cmbAdmissionNo.Focus();
        }

        private void Autocomplete()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(SourceLocation) from Transportation ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSourceLocation.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutocompleteAdmissionNo()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(AdmissionNo) from student ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbAdmissionNo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void frmBusHolders_Load(object sender, EventArgs e)
        {
            Autocomplete();
            AutocompleteAdmissionNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdmissionNo.Text == "")
                {
                    MessageBox.Show("Please select AdmissionNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbAdmissionNo.Focus();
                    return;
                }
                if (cmbSourceLocation.Text == "")
                {
                    MessageBox.Show("Please select Source Location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSourceLocation.Focus();
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select AdmissionNo from BusHolders where AdmissionNo= '" + cmbAdmissionNo.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbAdmissionNo.Text = "";
                    cmbSourceLocation.Text = "";
                    txtclass.Text = "";
                    txtsection.Text = "";
                    StudentName.Text = "";
                    cmbAdmissionNo.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into BusHolders(AdmissionNo,SourceLocation,StartingDate) VALUES (@d1,@d2,@d3)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;


                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "StartingDate"));


                cmd.Parameters["@d1"].Value = cmbAdmissionNo.Text;
                cmd.Parameters["@d2"].Value = cmbSourceLocation.Text;
                cmd.Parameters["@d3"].Value = dtpStartingDate.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "New Bus Holder Is Added  having  AdmissionNo='" + cmbAdmissionNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                button1.Enabled = true;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScholarNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText ="SELECT StudentName,Class,Section FROM student WHERE AdmissionNo = '" +cmbAdmissionNo.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    StudentName.Text = rdr.GetString(0).Trim();


                    txtclass.Text = rdr.GetString(1).Trim();

                   txtsection.Text = rdr.GetString(2).Trim();
                    cmbSourceLocation.Focus();
                }


                if ((rdr != null))
                {
                    rdr.Close();
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

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBcon);
            con.Open();

            string cb = "update BusHolders set SourceLocation=@d2,StartingDate=@d3 where AdmissionNo=@d1";

            cmd = new SqlCommand(cb);

            cmd.Connection = con;


            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "AdmissionNo"));
            cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));

            cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "StartingDate"));


            cmd.Parameters["@d1"].Value = cmbAdmissionNo.Text;
            cmd.Parameters["@d2"].Value = cmbSourceLocation.Text;
            cmd.Parameters["@d3"].Value = dtpStartingDate.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            st1 = lblUser.Text;
            st2 = "Bus Holder Is Updated  having AdmissionNo='" + cmbAdmissionNo.Text + "'";
            cf.LogFunc(st1, System.DateTime.Now, st2);

            btnUpdate_record.Enabled = false;
            button1.Enabled = true;
            con.Close();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
           this.Hide();
            frmBusholderRecords frm = new frmBusholderRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.label5.Text = label3.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusholderRecords frm = new  frmBusholderRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.label5.Text = label3.Text;
            frm.Show();
        }
        private void delete_records()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                string ct = "select AdmissionNo from BusFeePayment where AdmissionNo= '" + cmbAdmissionNo.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    Autocomplete();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                int RowsAffected = 0;

                con = new SqlConnection(cs.DBcon);

                con.Open();


                string cq = "delete from BusHolders where AdmissionNo= '" + cmbAdmissionNo.Text + "'";
                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Bus Holder Is Deleted  having AdmissionNo='" + cmbAdmissionNo.Text + "'";
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

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmBusHolders_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                BusHoldersRecept frm = new BusHoldersRecept();
                RptBusHoldersReport rpt = new RptBusHoldersReport();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();

                ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from BusHolders,Student where Student.AdmissionNo=BusHolders.AdmissionNo and BusHolders.AdmissionNo='"+cmbAdmissionNo.Text+"' order by Studentname ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "BusHolders");
                myDA.Fill(myDS, "Student");

                rpt.SetDataSource(myDS);

                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }
    }
}
