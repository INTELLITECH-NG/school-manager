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
    public partial class frmSubectEntry : Form
    {

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        Connectionstring cs = new Connectionstring();
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmSubectEntry()
        {
            InitializeComponent();
        }
        private void Reset()
        {

            SubjectCode.Text = "";
            SubjectName.Text = "";

            cmbClass.Text = "";
          
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
            SubjectCode.Focus();
          
        }
        private void autocompleteclass()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM( Classname) from class";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbClass.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT subjectcode FROM subject", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "subject");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["SubjectCode"].ToString());

                }
                SubjectCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                SubjectCode.AutoCompleteCustomSource = col;
                SubjectCode.AutoCompleteMode = AutoCompleteMode.Suggest;

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
                string ct1 = "select SubjectCode from MarksEntry where SubjectCode=@find";


                cmd = new SqlCommand(ct1);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "SubjectCode"));


                cmd.Parameters["@find"].Value = SubjectCode.Text;


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


                string cq = "delete from subject where subjectcode=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "subjectcode"));


                cmd.Parameters["@DELETE1"].Value = SubjectCode.Text;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted subject whose subjectCode is'" + SubjectCode.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Reset();
                    Autocomplete();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SubjectCode.Text == "")
            {
                MessageBox.Show("Please enter subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectCode.Focus();
                return;
            }
            if (SubjectName.Text == "")
            {
                MessageBox.Show("Please enter subject name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectName.Focus();
                return;
            }
            if (cmbClass.Text == "")
            {
                MessageBox.Show("Please select course name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbClass.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "select subjectcode from subject where subjectcode=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "subjectcode"));
                cmd.Parameters["@find"].Value = SubjectCode.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Subject Code Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SubjectCode.Text = "";
                    SubjectCode.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into subject(subjectcode,subjectname,classname) VALUES (@d1,@d2,@d4)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "SubjectCode"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "subjectname"));


                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 20, "classname"));

                cmd.Parameters["@d1"].Value = SubjectCode.Text.Trim();
                cmd.Parameters["@d2"].Value = SubjectName.Text.Trim();

                cmd.Parameters["@d4"].Value = cmbClass.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Added New subject whose subjectCode is'" +SubjectCode.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSubectEntry_Load(object sender, EventArgs e)
        {
            Autocomplete();
            autocompleteclass();
        }

        private void SubjectCode_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM subject WHERE SubjectCode = '" + SubjectCode.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    SubjectName.Text = (String)rdr["SubjectName"];
                    cmbClass.Text = (String)rdr["ClassName"];

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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (SubjectCode.Text == "")
            {
                MessageBox.Show("Please enter subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectCode.Focus();
                return;
            }
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();


            }
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
             try{
              con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "update subject set subjectcode=@d1, subjectname=@d2,classname=@d4 where subjectcode='"+TextBox1.Text+"'"; 

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "SubjectCode"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "subjectname"));
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 20, "classname"));
                cmd.Parameters["@d1"].Value = SubjectCode.Text.Trim();
                cmd.Parameters["@d2"].Value = SubjectName.Text.Trim();
                cmd.Parameters["@d4"].Value = cmbClass.Text;
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated subject whose subjectCode is'" + SubjectCode.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                Update_record.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
            SubjectCode.Enabled = true;
        }

        private void ViewRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubjectRecords frm = new frmSubjectRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void frmSubectEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_Main_Menu frm = new frm_Main_Menu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
