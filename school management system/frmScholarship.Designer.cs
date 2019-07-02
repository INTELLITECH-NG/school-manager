namespace school_management_system
{
    partial class frmScholarship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScholarship));
            this.label1 = new System.Windows.Forms.Label();
            this.Update_record = new System.Windows.Forms.Button();
            this.GetDetails = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScholarshipID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.ScholarshipName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Update_record
            // 
            this.Update_record.Enabled = false;
            this.Update_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_record.Location = new System.Drawing.Point(352, 22);
            this.Update_record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_record.Name = "Update_record";
            this.Update_record.Size = new System.Drawing.Size(96, 43);
            this.Update_record.TabIndex = 3;
            this.Update_record.Text = "&Update";
            this.Update_record.UseVisualStyleBackColor = true;
            this.Update_record.Click += new System.EventHandler(this.Update_record_Click);
            // 
            // GetDetails
            // 
            this.GetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetDetails.Location = new System.Drawing.Point(466, 22);
            this.GetDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetDetails.Name = "GetDetails";
            this.GetDetails.Size = new System.Drawing.Size(96, 43);
            this.GetDetails.TabIndex = 4;
            this.GetDetails.Text = "&Get Data";
            this.GetDetails.UseVisualStyleBackColor = true;
            this.GetDetails.Click += new System.EventHandler(this.GetDetails_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewRecord.Location = new System.Drawing.Point(17, 22);
            this.NewRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(96, 43);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(235, 22);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 43);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(127, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Update_record);
            this.panel1.Controls.Add(this.GetDetails);
            this.panel1.Controls.Add(this.NewRecord);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 84);
            this.panel1.TabIndex = 95;
            // 
            // ScholarshipID
            // 
            this.ScholarshipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipID.Location = new System.Drawing.Point(408, 25);
            this.ScholarshipID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScholarshipID.Name = "ScholarshipID";
            this.ScholarshipID.Size = new System.Drawing.Size(99, 22);
            this.ScholarshipID.TabIndex = 97;
            this.ScholarshipID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.ScholarshipID);
            this.groupBox1.Controls.Add(this.ScholarshipName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(535, 257);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scholarship Details";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(59, 260);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 102;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(104, 260);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 101;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(224, 113);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(110, 22);
            this.Amount.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(224, 167);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Description.Size = new System.Drawing.Size(293, 59);
            this.Description.TabIndex = 2;
            // 
            // ScholarshipName
            // 
            this.ScholarshipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipName.Location = new System.Drawing.Point(224, 62);
            this.ScholarshipName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScholarshipName.Multiline = true;
            this.ScholarshipName.Name = "ScholarshipName";
            this.ScholarshipName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ScholarshipName.Size = new System.Drawing.Size(293, 29);
            this.ScholarshipName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(38, 167);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 18);
            this.label14.TabIndex = 91;
            this.label14.Text = "Description";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(38, 62);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 18);
            this.Label2.TabIndex = 89;
            this.Label2.Text = "Scholarship Name";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(38, 113);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 18);
            this.Label8.TabIndex = 90;
            this.Label8.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 100;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // frmScholarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(591, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmScholarship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scholarship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScholarship_FormClosing);
            this.Load += new System.EventHandler(this.frmScholarship_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Update_record;
        public System.Windows.Forms.Button GetDetails;
        public System.Windows.Forms.Button NewRecord;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox ScholarshipID;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox Amount;
        public System.Windows.Forms.TextBox Description;
        public System.Windows.Forms.TextBox ScholarshipName;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
    }
}