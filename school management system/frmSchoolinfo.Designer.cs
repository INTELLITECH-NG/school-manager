namespace school_management_system
{
    partial class frmSchoolinfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolinfo));
            this.Label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(389, 39);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(11, 16);
            this.Label6.TabIndex = 19;
            this.Label6.Text = ".";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(659, 303);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 22);
            this.txtID.TabIndex = 7;
            this.txtID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(18, 59);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewRecord.Location = new System.Drawing.Point(18, 11);
            this.btnNewRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(92, 39);
            this.btnNewRecord.TabIndex = 0;
            this.btnNewRecord.Text = "&New";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(18, 108);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.Enabled = false;
            this.btnUpdate_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate_record.Location = new System.Drawing.Point(18, 159);
            this.btnUpdate_record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate_record.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate_record.TabIndex = 3;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.UseVisualStyleBackColor = true;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(646, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 281);
            this.panel1.TabIndex = 6;
            // 
            // btnGetData
            // 
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetData.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetData.Location = new System.Drawing.Point(18, 221);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetData.Size = new System.Drawing.Size(92, 39);
            this.btnGetData.TabIndex = 20;
            this.btnGetData.Text = "GetData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(165, 305);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWebsite.Multiline = true;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(382, 29);
            this.txtWebsite.TabIndex = 6;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(165, 245);
            this.txtEmailID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailID.Multiline = true;
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(382, 29);
            this.txtEmailID.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(24, 299);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(50, 17);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Website";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(24, 244);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(56, 17);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Email ID";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(165, 141);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(164, 24);
            this.txtContactNo.TabIndex = 2;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(24, 141);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Contact No.";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolName.Location = new System.Drawing.Point(165, 44);
            this.txtSchoolName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(382, 24);
            this.txtSchoolName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(165, 89);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(433, 29);
            this.txtAddress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txtWebsite);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.txtEmailID);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.txtSchoolName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(628, 389);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Info";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(565, 182);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(514, 148);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(24, 44);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 17);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "School Name";
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(165, 196);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(164, 24);
            this.txtFax.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 193);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Fax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // frmSchoolinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(791, 404);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSchoolinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSchoolinfo_FormClosing);
            this.Load += new System.EventHandler(this.frmSchoolinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnNewRecord;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate_record;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtContactNo;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtFax;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtWebsite;
        public System.Windows.Forms.TextBox txtEmailID;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.TextBox txtSchoolName;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnGetData;
    }
}