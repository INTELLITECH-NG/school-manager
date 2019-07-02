using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace school_management_system
{
    public partial class frmClassFeePaymentcs : Form
    {
       
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;

        public frmClassFeePaymentcs()
        {
            InitializeComponent();
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txtFeePaymentID.Text = "FP-" + GetUniqueKey(8);
        }

       
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentRecordSearch frm = new  frmStudentRecordSearch();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.label4.Text = "Student Record";
            frm.Show();
        }
      
     
        private void frmClassFeePaymentcs_Load(object sender, EventArgs e)
        {
            for (int i = 2010; i <= 2050; i++)
            {
                cmbYear.Items.Add(i);
            }
           
          
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtAdmissionNo.Text == "")
                {
                    MessageBox.Show("Please Select Student's  AdmissionNo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdmissionNo.Focus();
                    return;
                }
              
               Calculate1();
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string ct = "select year,month,admissionNo from CourseFeePayment,CourseFeePayment_Join where CourseFeePayment.ID=CourseFeePayment_Join.PaymentID and AdmissionNo='" + txtAdmissionNo.Text + "' and Month='" + row.Cells[3].Value + "' and Year=" + cmbYear.Text + "";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("This Fee Already Paid By Student", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                }
                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb ="insert into CourseFeePayment(ID, AdmissionNo, Year,PreviousDue, Fine, GrandTotal, TotalPaid, ModeOfPayment,PaymentDate, PaymentModeDetails,PaymentDue,Fee) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1",txtFeePaymentID.Text);
                cmd.Parameters.AddWithValue("@d2", txtAdmissionNo.Text);
                cmd.Parameters.AddWithValue("@d3", cmbYear.Text);
              cmd.Parameters.AddWithValue("@d4",txtPreviousDue.Text);
                cmd.Parameters.AddWithValue("@d5",txtFine.Text);
                cmd.Parameters.AddWithValue("@d6", txtGrandTotal.Text);
                cmd.Parameters.AddWithValue("@d7", txtTotalPaid.Text);
                cmd.Parameters.AddWithValue("@d8", cmbPaymentMode.Text);
                cmd.Parameters.AddWithValue("@d9", dtpPaymentDate.Text);
                cmd.Parameters.AddWithValue("@d10",txtPaymentModeDetails.Text);
                cmd.Parameters.AddWithValue("@d11",txtCurrentDue.Text);
                cmd.Parameters.AddWithValue("@d12",txtFee.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb1 = "insert into CourseFeePayment_Join(PaymentID, Month, FeeId, Fee) VALUES (@d1,@d2,@d3,@d5)";

                cmd = new SqlCommand(cb1);

                cmd.Connection = con;
                  // Add Parameters to Command Parameters collection
            cmd.Prepare();

            // Data to be inserted
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                   
                    cmd.Parameters.AddWithValue("@d1",txtFeePaymentID.Text);
                    cmd.Parameters.AddWithValue("@d2",row.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@d3",Convert.ToInt32(row.Cells[0].Value));
                    cmd.Parameters.AddWithValue("@d5",Convert.ToDouble(row.Cells[2].Value));
                    cmd.ExecuteNonQuery();
                   
                    cmd.Parameters.Clear();
            }
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = " ClassFee Payment Is Done admissionNo='" +txtAdmissionNo.Text + "' having PaymentID ='"+txtFeePaymentID.Text+"'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                btnPrint.Enabled = true;
            }
                
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

       
       public void Calculate1()
       {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
           int val4=0;
  
            int.TryParse(txtFee.Text, out val1);
            int.TryParse(txtFine.Text, out val2);
            int.TryParse(txtPreviousDue.Text, out val3);
           int.TryParse(txtTotalPaid.Text, out val4);
           int I = (val1 + val2+val3);
           txtGrandTotal.Text =I.ToString();
           txtCurrentDue.Text = (I - val4).ToString();
   
  }
       public void GetData()
       {
           try
           {
               con = new SqlConnection(cs.DBcon);
               con.Open();
               cmd = new SqlCommand("SELECT distinct CourseFeePayment.AdmissionNo, RTRIM(CourseFeePayment_Join.Month),RTRIM(CourseFeePayment.Year) FROM CourseFeePayment_Join INNER JOIN CourseFeePayment ON CourseFeePayment_Join.PaymentID = CourseFeePayment.ID and AdmissionNo='" + txtAdmissionNo.Text + "'", con);
               rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               dataGridView2.Rows.Clear();
               while (rdr.Read() == true)
               {
                   dataGridView2.Rows.Add(rdr[1], rdr[2]);
               }
               con.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void btnAdd_Click(object sender, EventArgs e)
       {
           try
           {
               if (cmbMonth.Text == "")
               {
                   MessageBox.Show("Please Select month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   cmbMonth.Focus();
                   return;
               }
               if (cmbYear.Text == "")
               {
                   MessageBox.Show("Please Select year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   cmbYear.Focus();
                   return;
               }
               foreach (DataGridViewRow row in DataGridView1.Rows)
               {

                   if (row.Cells[3].Value.ToString() == cmbMonth.Text)
                   {
                       MessageBox.Show("Month already added", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       cmbMonth.SelectedIndex = -1;
                       return;
                   }
                   
                   // cmd.Parameters.Clear();
               }

               con = new SqlConnection(cs.DBcon);
               con.Open();
               cmd = new SqlCommand("SELECT RTRIM(FeeID),RTRIM(Feename),RTRIM(Fee),RTRIM(Month) from Class,CourseFee,Fee where Class.ID=CourseFee.ClassID and Fee.ID=CourseFee.FeeID and ClassName='" + txtClass.Text + "' and Month='" +cmbMonth.Text+ "' order By FeeName", con);
               rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
              // DataGridView1.Rows.Clear();
               while (rdr.Read() == true)
               {
                   DataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
               }
               Int64 sum = 0;
               foreach (DataGridViewRow row in DataGridView1.Rows)
               {
                   sum = sum + Convert.ToInt32(row.Cells[2].Value);//fees addition
               }
               txtFee.Text = sum.ToString();//fee text box me sum karke value add

               con.Close();
             

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
     
      
        private void txtFine_TextChanged(object sender, EventArgs e)
        {
         
           Calculate1();
 
   
        }

        private void txtTotalPaid_TextChanged(object sender, EventArgs e)
        {
            Calculate1();
         
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {
         
        
              con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb ="Update CourseFeePayment AdmissionNo=@d2, Year=@d3, PreviousDue=@d6, Fine=@d7, GrandTotal=@d8, TotalPaid=@d9, ModeOfPayment=@d10,PaymentDate=@d11, PaymentModeDetails=@d12,PaymentDue=@d13,Fee=@d14 where ID=@d1";
          
                cmd.Parameters.AddWithValue("@d11", dtpPaymentDate.Text);
                cmd.Parameters.AddWithValue("@d12",txtPaymentModeDetails.Text);
                cmd.Parameters.AddWithValue("@d13",txtCurrentDue.Text);
                cmd.Parameters.AddWithValue("@d14",txtFee.Text);
               
                cmd.ExecuteReader();
                con.Close();
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb1 = "Delete from CourseFeePayment_Join where PaymentID='" + txtFeePaymentID.Text + "'";
                cmd = new SqlCommand(cb1);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb2 = "insert into CourseFeePayment_Join(PaymentID, Month, FeeId, Fee) VALUES (@d1,@d2,@d3,@d5)";

                cmd = new SqlCommand(cb2);

                cmd.Connection = con;
                  // Add Parameters to Command Parameters collection
            cmd.Prepare();

            // Data to be inserted
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                   
                    cmd.Parameters.AddWithValue("@d1",txtFeePaymentID.Text);
                    cmd.Parameters.AddWithValue("@d2",row.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@d3",Convert.ToInt32(row.Cells[0].Value));
                    cmd.Parameters.AddWithValue("@d5",Convert.ToDouble(row.Cells[2].Value));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
            }
              
                con.Close();

                MessageBox.Show("Successfully updated", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = " ClassFee Payment Is upated  admissionNo='" + txtAdmissionNo.Text + "' having PaymentID ='" + txtFeePaymentID.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate_record.Enabled = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 ="delete from CourseFeePayment_Join where PaymentID= '" +txtFeePaymentID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();
               
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq = "delete from CourseFeePayment where ID= '" + txtFeePaymentID.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = " ClassFee Payment Is Deleted  admissionNo='" + txtAdmissionNo.Text + "' having PaymentID ='" + txtFeePaymentID.Text + "'";
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
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      public void Reset()
      {
  
        txtAdmissionNo.Text = "";
        txtPaymentModeDetails.Text = "";
        txtCurrentDue.Text = "";
        txtClass.Text = "";
        txtEnrollmentNo.Text = "";
        txtFee.Text = "";
        txtFeePaymentID.Text = "";
        txtFine.Text = "";
        txtGrandTotal.Text = "";
        txtPreviousDue.Text = "";
        txtSchoolName.Text = "";
        txtSection.Text = "";
        txtSession.Text = "";
        txtStudentName.Text = "";
        txtTotalPaid.Text = "";
        cmbPaymentMode.SelectedIndex = -1;
        cmbYear.SelectedIndex = -1;
        dtpPaymentDate.Text ="";
        DataGridView1.Rows.Clear();
        btnSave.Enabled = true;
        btnUpdate_record.Enabled = false;
        btnDelete.Enabled = false;
        cmbMonth.Enabled = false;
        btnAdd.Enabled = true;
  
        btnPrint.Enabled = false;
     
        DataGridView1.Visible = true;
      }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmClassFeePaymentcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
           frm_Main_Menu frm = new frm_Main_Menu();
           frm.UserType.Text = lblUserType.Text;
           frm.User.Text = lblUser.Text;
           frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseFeePayment_Record_Search_ frm = new CourseFeePayment_Record_Search_();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            Calculate1();
    
        }

      
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                frmclassfeepaymentReport frm = new  frmclassfeepaymentReport();
                RptclassFeePayment rpt = new  RptclassFeePayment();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                 ERPS_DBDataSet myDS = new ERPS_DBDataSet();
                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from CourseFeePayment,student where student.AdmissionNo=courseFeePayment.AdmissionNo and CourseFeePayment.ID= '" +txtFeePaymentID.Text + "'";
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "CourseFeePayment");
                myDA.Fill(myDS, "Student");
               // myDA.Fill(myDS, "CourseFeePayment_join");
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Sum(PaymentDue-previousDue) from CourseFeePayment where AdmissionNo=@d1 group by AdmissionNo";
                cmd.Parameters.AddWithValue("@d1", txtAdmissionNo.Text);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtPreviousDue.Text = rdr.GetValue(0).ToString();
                }
                else
                {
                    txtPreviousDue.Text = (0).ToString();
                }

                if (con.State == ConnectionState.Open)
                    con.Close();
                Calculate1();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
           {
               con = new SqlConnection(cs.DBcon);
               con.Open();
               cmd = new SqlCommand("SELECT distinct CourseFeePayment.AdmissionNo, RTRIM(CourseFeePayment_Join.Month),RTRIM(CourseFeePayment.Year) FROM CourseFeePayment_Join INNER JOIN CourseFeePayment ON CourseFeePayment_Join.PaymentID = CourseFeePayment.ID and AdmissionNo='" + txtAdmissionNo.Text + "' and Year Like'"+ textBox1.Text+"%'", con);
               rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               dataGridView2.Rows.Clear();
               while (rdr.Read() == true)
               {
                   dataGridView2.Rows.Add(rdr[1], rdr[2]);
               }
               con.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

        private void txtTotalPaid_Validating(object sender, CancelEventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
          
            int.TryParse(txtGrandTotal.Text, out val1);
            int.TryParse(txtTotalPaid.Text, out val2);
          
            if (val2> val1)
            {
                MessageBox.Show("Total Paid can not be more than from Grand Total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPaid.Focus();
            }
        }
        }
  
    }

