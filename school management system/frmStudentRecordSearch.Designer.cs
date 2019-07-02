namespace school_management_system
{
    partial class frmStudentRecordSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRecordSearch));
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(479, 46);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(87, 32);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "&Search";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtStudentName);
            this.GroupBox3.Location = new System.Drawing.Point(6, 13);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox3.Size = new System.Drawing.Size(256, 115);
            this.GroupBox3.TabIndex = 35;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "By Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(22, 49);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(218, 24);
            this.txtStudentName.TabIndex = 0;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(154, 53);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(117, 24);
            this.dtpDateTo.TabIndex = 36;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dtpDateTo);
            this.GroupBox1.Controls.Add(this.dtpDateFrom);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Location = new System.Drawing.Point(881, 16);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox1.Size = new System.Drawing.Size(277, 130);
            this.GroupBox1.TabIndex = 39;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "By Admission Date";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(14, 53);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(111, 24);
            this.dtpDateFrom.TabIndex = 35;
            // 
            // Button2
            // 
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(107, 93);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(87, 32);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "&Search";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(152, 30);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(24, 17);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "To";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(11, 30);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 17);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "From";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(326, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 17);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Section";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(182, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 17);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Class";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 17);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Session";
            // 
            // cmbClass
            // 
            this.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClass.Enabled = false;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(181, 52);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 25);
            this.cmbClass.TabIndex = 1;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(17, 19);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 44);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cmbSection
            // 
            this.cmbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSection.Enabled = false;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(330, 52);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(116, 25);
            this.cmbSection.TabIndex = 2;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(17, 70);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(93, 44);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "&Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Button1);
            this.GroupBox4.Controls.Add(this.Label3);
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.cmbSection);
            this.GroupBox4.Controls.Add(this.cmbClass);
            this.GroupBox4.Controls.Add(this.cmbSession);
            this.GroupBox4.Location = new System.Drawing.Point(277, 15);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox4.Size = new System.Drawing.Size(594, 115);
            this.GroupBox4.TabIndex = 36;
            this.GroupBox4.TabStop = false;
            // 
            // cmbSession
            // 
            this.cmbSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(20, 52);
            this.cmbSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(144, 25);
            this.cmbSession.TabIndex = 0;
            this.cmbSession.SelectedIndexChanged += new System.EventHandler(this.cmbSession_SelectedIndexChanged);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.btnExportExcel);
            this.Panel1.Controls.Add(this.btnReset);
            this.Panel1.Location = new System.Drawing.Point(1381, 140);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(124, 138);
            this.Panel1.TabIndex = 37;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(6, 155);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.Size = new System.Drawing.Size(1265, 332);
            this.DataGridView1.TabIndex = 38;
            this.DataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            this.DataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1144, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1180, 67);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "&Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(639, 255);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(31, 16);
            this.lblUser.TabIndex = 85;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(608, 220);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 16);
            this.lblUserType.TabIndex = 84;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // frmStudentRecordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1279, 491);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStudentRecordSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Record Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStudentRecordSearch_FormClosing);
            this.Load += new System.EventHandler(this.frmStudentRecordSearch_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtStudentName;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.ComboBox cmbSection;
        public System.Windows.Forms.Button btnExportExcel;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.ComboBox cmbSession;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
    }
}