namespace school_management_system
{
    partial class Frmhosteler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhosteler));
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHostelName = new System.Windows.Forms.ComboBox();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AdmissionNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbsection = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(231, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(212, 265);
            this.dtpJoiningDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(145, 24);
            this.dtpJoiningDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Joining Date";
            // 
            // cmbHostelName
            // 
            this.cmbHostelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHostelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHostelName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHostelName.FormattingEnabled = true;
            this.cmbHostelName.Location = new System.Drawing.Point(212, 214);
            this.cmbHostelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHostelName.Name = "cmbHostelName";
            this.cmbHostelName.Size = new System.Drawing.Size(338, 25);
            this.cmbHostelName.TabIndex = 4;
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.Enabled = false;
            this.btnUpdate_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate_record.Location = new System.Drawing.Point(337, 16);
            this.btnUpdate_record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.Size = new System.Drawing.Size(99, 38);
            this.btnUpdate_record.TabIndex = 3;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.UseVisualStyleBackColor = true;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetDetails.Location = new System.Drawing.Point(443, 16);
            this.btnGetDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(99, 38);
            this.btnGetDetails.TabIndex = 4;
            this.btnGetDetails.Text = "&Get Data";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewRecord.Location = new System.Drawing.Point(19, 16);
            this.btnNewRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(99, 38);
            this.btnNewRecord.TabIndex = 0;
            this.btnNewRecord.Text = "&New";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.btnGetDetails);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(-3, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 75);
            this.panel1.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(125, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(212, 126);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(201, 24);
            this.txtClass.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 64;
            this.label10.Text = "Hostel Name";
            // 
            // StudentName
            // 
            this.StudentName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(212, 79);
            this.StudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(338, 24);
            this.StudentName.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(28, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 18);
            this.label26.TabIndex = 22;
            this.label26.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Student Name";
            // 
            // AdmissionNo
            // 
            this.AdmissionNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AdmissionNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AdmissionNo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmissionNo.FormattingEnabled = true;
            this.AdmissionNo.Location = new System.Drawing.Point(212, 33);
            this.AdmissionNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdmissionNo.Name = "AdmissionNo";
            this.AdmissionNo.Size = new System.Drawing.Size(201, 25);
            this.AdmissionNo.TabIndex = 0;
            this.AdmissionNo.SelectedIndexChanged += new System.EventHandler(this.AdmissionNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admission No.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.cmbsection);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpJoiningDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbHostelName);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.StudentName);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AdmissionNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(589, 308);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(505, 134);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // cmbsection
            // 
            this.cmbsection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbsection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsection.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsection.FormattingEnabled = true;
            this.cmbsection.Location = new System.Drawing.Point(212, 174);
            this.cmbsection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbsection.Name = "cmbsection";
            this.cmbsection.Size = new System.Drawing.Size(201, 25);
            this.cmbsection.TabIndex = 69;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(489, 134);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Section";
            // 
            // Frmhosteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(604, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frmhosteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hosteler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmhosteler_FormClosing);
            this.Load += new System.EventHandler(this.Frmhosteler_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbHostelName;
        public System.Windows.Forms.Button btnUpdate_record;
        public System.Windows.Forms.Button btnGetDetails;
        public System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox AdmissionNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbsection;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
    }
}