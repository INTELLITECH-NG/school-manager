namespace school_management_system
{
    partial class frmBusHolders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusHolders));
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSourceLocation = new System.Windows.Forms.ComboBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAdmissionNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpStartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartingDate.Location = new System.Drawing.Point(212, 289);
            this.dtpStartingDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(145, 24);
            this.dtpStartingDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Starting Date";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(441, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSourceLocation
            // 
            this.cmbSourceLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSourceLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSourceLocation.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSourceLocation.FormattingEnabled = true;
            this.cmbSourceLocation.Location = new System.Drawing.Point(212, 235);
            this.cmbSourceLocation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbSourceLocation.Name = "cmbSourceLocation";
            this.cmbSourceLocation.Size = new System.Drawing.Size(338, 25);
            this.cmbSourceLocation.TabIndex = 4;
            // 
            // txtsection
            // 
            this.txtsection.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsection.Location = new System.Drawing.Point(212, 183);
            this.txtsection.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtsection.Name = "txtsection";
            this.txtsection.ReadOnly = true;
            this.txtsection.Size = new System.Drawing.Size(237, 24);
            this.txtsection.TabIndex = 3;
            // 
            // txtclass
            // 
            this.txtclass.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclass.Location = new System.Drawing.Point(212, 133);
            this.txtclass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtclass.Name = "txtclass";
            this.txtclass.ReadOnly = true;
            this.txtclass.Size = new System.Drawing.Size(201, 24);
            this.txtclass.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 21);
            this.label10.TabIndex = 64;
            this.label10.Text = "Source Location";
            // 
            // StudentName
            // 
            this.StudentName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(212, 84);
            this.StudentName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(338, 24);
            this.StudentName.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(28, 136);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 21);
            this.label26.TabIndex = 22;
            this.label26.Text = "Class";
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.Enabled = false;
            this.btnUpdate_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate_record.Location = new System.Drawing.Point(296, 22);
            this.btnUpdate_record.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate_record.TabIndex = 3;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.UseVisualStyleBackColor = true;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetDetails.Location = new System.Drawing.Point(397, 20);
            this.btnGetDetails.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(82, 30);
            this.btnGetDetails.TabIndex = 4;
            this.btnGetDetails.Text = "&Get Data";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewRecord.Location = new System.Drawing.Point(6, 23);
            this.btnNewRecord.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(82, 30);
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
            this.btnDelete.Location = new System.Drawing.Point(195, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(28, 186);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 21);
            this.label25.TabIndex = 21;
            this.label25.Text = "Section";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Student Name";
            // 
            // cmbAdmissionNo
            // 
            this.cmbAdmissionNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAdmissionNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAdmissionNo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdmissionNo.FormattingEnabled = true;
            this.cmbAdmissionNo.Location = new System.Drawing.Point(212, 35);
            this.cmbAdmissionNo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbAdmissionNo.Name = "cmbAdmissionNo";
            this.cmbAdmissionNo.Size = new System.Drawing.Size(201, 25);
            this.cmbAdmissionNo.TabIndex = 0;
            this.cmbAdmissionNo.SelectedIndexChanged += new System.EventHandler(this.ScholarNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admission No.";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(103, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.btnGetDetails);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(28, 386);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 79);
            this.panel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.dtpStartingDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cmbSourceLocation);
            this.groupBox1.Controls.Add(this.txtsection);
            this.groupBox1.Controls.Add(this.txtclass);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.StudentName);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbAdmissionNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(589, 354);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(499, 335);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(499, 290);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(496, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBusHolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(644, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmBusHolders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Holders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBusHolders_FormClosing);
            this.Load += new System.EventHandler(this.frmBusHolders_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cmbSourceLocation;
        public System.Windows.Forms.TextBox txtsection;
        public System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.Button btnUpdate_record;
        public System.Windows.Forms.Button btnGetDetails;
        public System.Windows.Forms.Button btnNewRecord;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbAdmissionNo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}