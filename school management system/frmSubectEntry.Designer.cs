namespace school_management_system
{
    partial class frmSubectEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubectEntry));
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.SubjectCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewRecord = new System.Windows.Forms.Button();
            this.Update_record = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClass
            // 
            this.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(162, 93);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(160, 23);
            this.cmbClass.TabIndex = 73;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.Class_SelectedIndexChanged);
            // 
            // SubjectCode
            // 
            this.SubjectCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCode.Location = new System.Drawing.Point(162, 24);
            this.SubjectCode.Name = "SubjectCode";
            this.SubjectCode.Size = new System.Drawing.Size(110, 22);
            this.SubjectCode.TabIndex = 70;
            this.SubjectCode.TextChanged += new System.EventHandler(this.SubjectCode_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Subject Code";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ViewRecord);
            this.panel1.Controls.Add(this.Update_record);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.NewRecord);
            this.panel1.Location = new System.Drawing.Point(32, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 90);
            this.panel1.TabIndex = 74;
            // 
            // ViewRecord
            // 
            this.ViewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecord.Location = new System.Drawing.Point(492, 26);
            this.ViewRecord.Name = "ViewRecord";
            this.ViewRecord.Size = new System.Drawing.Size(95, 33);
            this.ViewRecord.TabIndex = 5;
            this.ViewRecord.Text = "&View Record";
            this.ViewRecord.UseVisualStyleBackColor = true;
            this.ViewRecord.Click += new System.EventHandler(this.ViewRecord_Click);
            // 
            // Update_record
            // 
            this.Update_record.Enabled = false;
            this.Update_record.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_record.Location = new System.Drawing.Point(370, 26);
            this.Update_record.Name = "Update_record";
            this.Update_record.Size = new System.Drawing.Size(95, 33);
            this.Update_record.TabIndex = 3;
            this.Update_record.Text = "&Update";
            this.Update_record.UseVisualStyleBackColor = true;
            this.Update_record.Click += new System.EventHandler(this.Update_record_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(248, 26);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(95, 33);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(134, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(18, 26);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(95, 33);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Class Name";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Subject Name";
            // 
            // SubjectName
            // 
            this.SubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName.Location = new System.Drawing.Point(162, 58);
            this.SubjectName.Multiline = true;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SubjectName.Size = new System.Drawing.Size(322, 22);
            this.SubjectName.TabIndex = 72;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(550, 67);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 95;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserType.Location = new System.Drawing.Point(550, 33);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 94;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(554, -2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 96;
            this.TextBox1.Visible = false;
            // 
            // frmSubectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(666, 261);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.SubjectCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubectEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subect Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSubectEntry_FormClosing);
            this.Load += new System.EventHandler(this.frmSubectEntry_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbClass;
        public System.Windows.Forms.TextBox SubjectCode;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button ViewRecord;
        public System.Windows.Forms.Button Update_record;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button NewRecord;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox SubjectName;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.TextBox TextBox1;

    }
}