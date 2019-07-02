namespace school_management_system
{
    partial class frmEmployeeRecordss1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeRecordss1));
            this.label1 = new System.Windows.Forms.Label();
            this.Date_from = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Date_to = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Name";
            // 
            // Date_from
            // 
            this.Date_from.CustomFormat = "dd/MMM/yyyy";
            this.Date_from.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_from.Location = new System.Drawing.Point(38, 50);
            this.Date_from.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_from.Name = "Date_from";
            this.Date_from.Size = new System.Drawing.Size(114, 25);
            this.Date_from.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1284, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "By EmployeeName";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmployeeName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(624, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(256, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(17, 54);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(185, 24);
            this.txtEmployeeName.TabIndex = 16;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.CmbEmployeeName);
            this.groupBox8.Location = new System.Drawing.Point(22, 7);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(224, 100);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Name";
            // 
            // CmbEmployeeName
            // 
            this.CmbEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmployeeName.FormattingEnabled = true;
            this.CmbEmployeeName.Location = new System.Drawing.Point(22, 51);
            this.CmbEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbEmployeeName.Name = "CmbEmployeeName";
            this.CmbEmployeeName.Size = new System.Drawing.Size(164, 23);
            this.CmbEmployeeName.TabIndex = 7;
            this.CmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.CmbEmployeeName_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Location = new System.Drawing.Point(331, 8);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(256, 100);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(141, 43);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 32);
            this.button7.TabIndex = 4;
            this.button7.Text = "&Export Excel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(19, 43);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 32);
            this.button9.TabIndex = 1;
            this.button9.Text = "&Reset";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 136);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1061, 356);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(35, 19);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 18);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(1314, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "admin";
            // 
            // Date_to
            // 
            this.Date_to.CustomFormat = "dd/MMM/yyyy";
            this.Date_to.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_to.Location = new System.Drawing.Point(190, 49);
            this.Date_to.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_to.Name = "Date_to";
            this.Date_to.Size = new System.Drawing.Size(119, 25);
            this.Date_to.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 364);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Date_from);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Date_to);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(9, 7);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(315, 100);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(187, 19);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(25, 18);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 526);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Controls.Add(this.lblUserType);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.GroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1284, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "By All Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(848, 374);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(848, 335);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ExportExcel);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Location = new System.Drawing.Point(345, 8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(329, 100);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // ExportExcel
            // 
            this.ExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportExcel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExcel.Location = new System.Drawing.Point(225, 42);
            this.ExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(87, 32);
            this.ExportExcel.TabIndex = 4;
            this.ExportExcel.Text = "&Export Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(23, 41);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "&Get Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(125, 41);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 32);
            this.button6.TabIndex = 1;
            this.button6.Text = "&Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmEmployeeRecordss1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 520);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeRecordss1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Records 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeRecordss1_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeeRecordss1_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker Date_from;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CmbEmployeeName;
        internal System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button button9;
        public System.Windows.Forms.DataGridView dataGridView2;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.DateTimePicker Date_to;
        public System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        internal System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.Button ExportExcel;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.GroupBox groupBox2;
    }
}