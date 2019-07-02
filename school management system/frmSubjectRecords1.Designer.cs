namespace school_management_system
{
    partial class frmSubjectRecords1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubjectRecords1));
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subject Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Course);
            this.GroupBox1.Location = new System.Drawing.Point(19, 17);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox1.Size = new System.Drawing.Size(260, 103);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(28, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 18);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Class";
            // 
            // Course
            // 
            this.Course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(34, 42);
            this.Course.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(167, 24);
            this.Course.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(38, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(429, 297);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Subject Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Class";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(18, 41);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(83, 29);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Get Data";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(121, 41);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(83, 28);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Reset";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblUserType);
            this.GroupBox2.Controls.Add(this.lblUser);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Location = new System.Drawing.Point(310, 17);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GroupBox2.Size = new System.Drawing.Size(215, 103);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserType.Location = new System.Drawing.Point(6, 14);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 96;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser.Location = new System.Drawing.Point(24, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 97;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // frmSubjectRecords1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 456);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSubjectRecords1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Records1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSubjectRecords1_FormClosing);
            this.Load += new System.EventHandler(this.frmSubjectRecords1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Label lblUser;
    }
}