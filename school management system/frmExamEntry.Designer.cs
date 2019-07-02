namespace school_management_system
{
    partial class frmExamEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamEntry));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbExamType = new System.Windows.Forms.ComboBox();
            this.NewRecord = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_record = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridView1.Location = new System.Drawing.Point(19, 160);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.Size = new System.Drawing.Size(517, 230);
            this.DataGridView1.TabIndex = 85;
            this.DataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Exam Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 275;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Exam Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // cmbExamType
            // 
            this.cmbExamType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbExamType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExamType.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExamType.FormattingEnabled = true;
            this.cmbExamType.Items.AddRange(new object[] {
            "Viva",
            "Practical",
            "Theoretical",
            "Practical and Theoretical"});
            this.cmbExamType.Location = new System.Drawing.Point(165, 100);
            this.cmbExamType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.Size = new System.Drawing.Size(239, 24);
            this.cmbExamType.TabIndex = 81;
            // 
            // NewRecord
            // 
            this.NewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewRecord.Location = new System.Drawing.Point(19, 23);
            this.NewRecord.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(93, 37);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(143, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(366, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 22);
            this.textBox1.TabIndex = 78;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Update_record);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.NewRecord);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 77);
            this.panel1.TabIndex = 82;
            // 
            // Update_record
            // 
            this.Update_record.Enabled = false;
            this.Update_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_record.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_record.Location = new System.Drawing.Point(409, 23);
            this.Update_record.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Update_record.Name = "Update_record";
            this.Update_record.Size = new System.Drawing.Size(93, 37);
            this.Update_record.TabIndex = 3;
            this.Update_record.Text = "&Update";
            this.Update_record.UseVisualStyleBackColor = true;
            this.Update_record.Click += new System.EventHandler(this.Update_record_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(275, 23);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(93, 37);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Exam Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Exam Name";
            // 
            // txtExamName
            // 
            this.txtExamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExamName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamName.Location = new System.Drawing.Point(165, 44);
            this.txtExamName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExamName.Size = new System.Drawing.Size(179, 22);
            this.txtExamName.TabIndex = 80;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(470, 137);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(31, 16);
            this.lblUser.TabIndex = 97;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserType.Location = new System.Drawing.Point(470, 103);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 16);
            this.lblUserType.TabIndex = 96;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // frmExamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(568, 521);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.cmbExamType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExamName);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExamEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Entry";
            this.Load += new System.EventHandler(this.frmExamEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.ComboBox cmbExamType;
        public System.Windows.Forms.Button NewRecord;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Update_record;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtExamName;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;

    }
}