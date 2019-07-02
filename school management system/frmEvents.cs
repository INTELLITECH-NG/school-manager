using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace school_management_system
{
    public partial class frmEvents : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
   
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmEvents()
        {
            InitializeComponent();
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT distinct EventName FROM event", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Event");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["EventName"].ToString());

                }
                txtEventName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtEventName.AutoCompleteCustomSource = col;
                txtEventName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (txtEventName.Text == "")
            {
                MessageBox.Show("Please enter event name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEventName.Focus();
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter  event managers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select EventName from Event where EventName= '" + txtEventName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Event Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEventName.Text = "";
                    txtEventName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Event(EventName,StartingDate,StartingTime,Endingdate,EndingTime,ManagedBy,Activities) VALUES ('" + txtEventName.Text + "','" + dtpStartingDate.Text + "','" + dtpStartingTime.Text + "','" + dtpEndingDate.Text + "','" + dtpEndingTime.Text + "','" + textBox1.Text + "','" + txtActivities.Text + "')";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added New Event'" +txtEventName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);

                Autocomplete();

                btnSave.Enabled = false;
                btnPrint.Enabled = true;
                con.Close();


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

                string cb = "update Event set Eventname='"+txtEventName.Text+"', StartingDate='"+dtpStartingDate.Text+"' , StartingTime='"+dtpStartingTime.Text+"' , EndingDate='"+dtpEndingDate.Text+"' , EndingTime ='"+dtpEndingTime.Text+"' , ManagedBy='"+textBox1.Text+"' , Activities='"+txtActivities.Text+"' where EventID='"+txtEventID.Text+"' ";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                frmEventRecords frm = new frmEventRecords();
                frm.GetData();
                MessageBox.Show("Successfully updated", "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the Event'" + txtEventName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate_record.Enabled = false;


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
        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;

                con = new SqlConnection(cs.DBcon);

                con.Open();


                string cq = "delete from Event where EventID= '" + txtEventID.Text + "'";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted the Event'" + txtEventName.Text + "'";
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
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }
        private void Reset()
        {
            txtEventName.Text = "";
            dtpStartingDate.Text = System.DateTime.Today.ToString();
            dtpStartingTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            dtpEndingDate.Text = System.DateTime.Today.ToString();
            dtpEndingTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            textBox1.Text = "";
            txtActivities.Text = "";
       
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            checkBox1.Checked = false;

        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            Autocomplete();
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                dtpEndingDate.Text = dtpStartingDate.Text;
                dtpEndingTime.Text = dtpStartingTime.Text;
                dtpEndingDate.Enabled = false;
                dtpEndingTime.Enabled = false;
            }
            else
            {
                dtpEndingDate.Text = System.DateTime.Today.ToString();
                dtpEndingTime.Text = System.DateTime.Now.TimeOfDay.ToString();
                dtpEndingDate.Enabled = true;
                dtpEndingTime.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEventRecords form2 = new frmEventRecords();
            form2.lblUser.Text = lblUser.Text;
            form2.lblUserType.Text = lblUserType.Text;
       
            form2.Show();
        }

        private void frmEvents_FormClosing(object sender, FormClosingEventArgs e)
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
                frmEventReport frm = new frmEventReport();

                rptEventsReport1 rpt = new rptEventsReport1();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                 ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select *  from Event";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Event");
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
