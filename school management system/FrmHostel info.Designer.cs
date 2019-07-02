namespace school_management_system
{
    partial class FrmHostel_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHostel_info));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHostelFees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtManagedBy = new System.Windows.Forms.TextBox();
            this.txtHostelName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtHostelFees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.txtManagedBy);
            this.groupBox1.Controls.Add(this.txtHostelName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hostel Details";
            // 
            // txtHostelFees
            // 
            this.txtHostelFees.Location = new System.Drawing.Point(161, 221);
            this.txtHostelFees.Name = "txtHostelFees";
            this.txtHostelFees.Size = new System.Drawing.Size(100, 24);
            this.txtHostelFees.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Hostel Fees (Yearly)";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(161, 109);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(130, 22);
            this.txtPhoneNo.TabIndex = 2;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(20, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 18);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Phone No.";
            // 
            // txtManagedBy
            // 
            this.txtManagedBy.Location = new System.Drawing.Point(161, 141);
            this.txtManagedBy.Name = "txtManagedBy";
            this.txtManagedBy.Size = new System.Drawing.Size(328, 24);
            this.txtManagedBy.TabIndex = 3;
            // 
            // txtHostelName
            // 
            this.txtHostelName.Location = new System.Drawing.Point(161, 40);
            this.txtHostelName.Name = "txtHostelName";
            this.txtHostelName.Size = new System.Drawing.Size(328, 24);
            this.txtHostelName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 75);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(407, 24);
            this.txtAddress.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(20, 142);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 18);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Managed By ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 18);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Hostel Name";
            // 
            // txtContactNo
            // 
            this.txtContactNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(161, 180);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(130, 22);
            this.txtContactNo.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 178);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 18);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Contact No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewRecord.Location = new System.Drawing.Point(25, 8);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(90, 35);
            this.btnNewRecord.TabIndex = 0;
            this.btnNewRecord.Text = "&New";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(25, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(25, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(334, 30);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(10, 13);
            this.Label6.TabIndex = 19;
            this.Label6.Text = ".";
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.Enabled = false;
            this.btnUpdate_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate_record.Location = new System.Drawing.Point(25, 126);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate_record.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate_record.TabIndex = 3;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.UseVisualStyleBackColor = true;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(25, 168);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 35);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "&Get Data";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(513, 283);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            this.txtID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(604, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 221);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(619, 283);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserType.Location = new System.Drawing.Point(610, 270);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // FrmHostel_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(763, 305);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHostel_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hostel info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHostel_info_FormClosing);
            this.Load += new System.EventHandler(this.FrmHostel_info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtManagedBy;
        internal System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label3;
        public System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnNewRecord;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Button btnUpdate_record;
        public System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtHostelName;
        public System.Windows.Forms.TextBox txtHostelFees;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
    }
}