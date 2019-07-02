namespace school_management_system
{
    partial class frmEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpStartingTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndingTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActivities = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndingDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(848, 344);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(82, 20);
            this.txtEventID.TabIndex = 10;
            this.txtEventID.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(187, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 21);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Same as Starting Date and Time";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpStartingTime
            // 
            this.dtpStartingTime.CustomFormat = "hh:mm tt";
            this.dtpStartingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartingTime.Location = new System.Drawing.Point(342, 71);
            this.dtpStartingTime.Name = "dtpStartingTime";
            this.dtpStartingTime.Size = new System.Drawing.Size(123, 24);
            this.dtpStartingTime.TabIndex = 2;
            // 
            // dtpEndingTime
            // 
            this.dtpEndingTime.CustomFormat = "hh:mm tt";
            this.dtpEndingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndingTime.Location = new System.Drawing.Point(341, 144);
            this.dtpEndingTime.Name = "dtpEndingTime";
            this.dtpEndingTime.Size = new System.Drawing.Size(123, 24);
            this.dtpEndingTime.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Activities";
            // 
            // txtActivities
            // 
            this.txtActivities.Location = new System.Drawing.Point(187, 241);
            this.txtActivities.Multiline = true;
            this.txtActivities.Name = "txtActivities";
            this.txtActivities.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtActivities.Size = new System.Drawing.Size(573, 120);
            this.txtActivities.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Managed By";
            // 
            // dtpEndingDate
            // 
            this.dtpEndingDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpEndingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndingDate.Location = new System.Drawing.Point(187, 144);
            this.dtpEndingDate.Name = "dtpEndingDate";
            this.dtpEndingDate.Size = new System.Drawing.Size(137, 24);
            this.dtpEndingDate.TabIndex = 3;
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.Enabled = false;
            this.btnUpdate_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate_record.Location = new System.Drawing.Point(19, 146);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate_record.TabIndex = 3;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.UseVisualStyleBackColor = true;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(19, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(19, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewRecord.Location = new System.Drawing.Point(19, 14);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(91, 33);
            this.btnNewRecord.TabIndex = 0;
            this.btnNewRecord.Text = "&New";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Location = new System.Drawing.Point(828, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 234);
            this.panel1.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(19, 187);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 33);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ending Date";
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpStartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartingDate.Location = new System.Drawing.Point(187, 71);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(137, 24);
            this.dtpStartingDate.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(549, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Starting Date";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(187, 30);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(353, 22);
            this.txtEventName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dtpStartingTime);
            this.groupBox1.Controls.Add(this.dtpEndingTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtActivities);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEndingDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStartingDate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEventName);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 380);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Details";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(717, 96);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 85;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 51);
            this.textBox1.TabIndex = 59;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserType.Location = new System.Drawing.Point(717, 62);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 84;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(973, 398);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEvents_FormClosing);
            this.Load += new System.EventHandler(this.frmEvents_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.DateTimePicker dtpStartingTime;
        public System.Windows.Forms.DateTimePicker dtpEndingTime;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtActivities;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpEndingDate;
        public System.Windows.Forms.Button btnUpdate_record;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEventName;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer timer1;
    }
}