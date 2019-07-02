namespace school_management_system
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.DOB = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.Browse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQualifications = new System.Windows.Forms.TextBox();
            this.txtYOP = new System.Windows.Forms.TextBox();
            this.dtpDateOfJoining = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtMobileNo = new System.Windows.Forms.MaskedTextBox();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTAddress = new System.Windows.Forms.TextBox();
            this.txtPAddress = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtmotherName = new System.Windows.Forms.TextBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(192, 206);
            this.DOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DOB.Mask = "00/00/0000";
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(125, 22);
            this.DOB.TabIndex = 99;
            this.DOB.ValidatingType = typeof(System.DateTime);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(18, 200);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 17);
            this.label24.TabIndex = 98;
            this.label24.Text = "DOB";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(385, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 30);
            this.button2.TabIndex = 97;
            this.button2.Text = "View Records";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(193, 25);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(149, 22);
            this.txtStaffID.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGender.Location = new System.Drawing.Point(193, 118);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(70, 24);
            this.cmbGender.TabIndex = 2;
            // 
            // Browse
            // 
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Browse.Location = new System.Drawing.Point(746, 149);
            this.Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(160, 30);
            this.Browse.TabIndex = 94;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.NewRecord);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(963, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 227);
            this.panel1.TabIndex = 61;
            // 
            // btnupdate
            // 
            this.btnupdate.Enabled = false;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(19, 173);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 38);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Update_record_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(19, 122);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(80, 38);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(19, 69);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewRecord.Location = new System.Drawing.Point(19, 18);
            this.NewRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(80, 38);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 509);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 91;
            this.label14.Text = "Department";
            // 
            // txtQualifications
            // 
            this.txtQualifications.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualifications.Location = new System.Drawing.Point(599, 572);
            this.txtQualifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQualifications.Multiline = true;
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQualifications.Size = new System.Drawing.Size(286, 30);
            this.txtQualifications.TabIndex = 11;
            // 
            // txtYOP
            // 
            this.txtYOP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYOP.Location = new System.Drawing.Point(192, 587);
            this.txtYOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYOP.Name = "txtYOP";
            this.txtYOP.Size = new System.Drawing.Size(147, 22);
            this.txtYOP.TabIndex = 12;
            // 
            // dtpDateOfJoining
            // 
            this.dtpDateOfJoining.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateOfJoining.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfJoining.Location = new System.Drawing.Point(193, 552);
            this.dtpDateOfJoining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateOfJoining.Name = "dtpDateOfJoining";
            this.dtpDateOfJoining.Size = new System.Drawing.Size(164, 22);
            this.dtpDateOfJoining.TabIndex = 10;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(492, 573);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 17);
            this.Label9.TabIndex = 79;
            this.Label9.Text = "Qualifications";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(18, 584);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(88, 17);
            this.Label13.TabIndex = 81;
            this.Label13.Text = "Experience(yr.)";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(17, 552);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(89, 17);
            this.Label11.TabIndex = 80;
            this.Label11.Text = "Date of joining";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(193, 460);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobileNo.Mask = "0000000000";
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(84, 22);
            this.txtMobileNo.TabIndex = 7;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(195, 421);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNo.Mask = "0000000000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(83, 22);
            this.txtPhoneNo.TabIndex = 6;
            // 
            // txtTAddress
            // 
            this.txtTAddress.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAddress.Location = new System.Drawing.Point(192, 379);
            this.txtTAddress.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTAddress.Multiline = true;
            this.txtTAddress.Name = "txtTAddress";
            this.txtTAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTAddress.Size = new System.Drawing.Size(297, 30);
            this.txtTAddress.TabIndex = 5;
            // 
            // txtPAddress
            // 
            this.txtPAddress.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAddress.Location = new System.Drawing.Point(192, 333);
            this.txtPAddress.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPAddress.Multiline = true;
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPAddress.Size = new System.Drawing.Size(297, 30);
            this.txtPAddress.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(17, 28);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 17);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Staff ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(17, 72);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 17);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Staff Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(192, 248);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(221, 22);
            this.txtFatherName.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(612, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 16);
            this.label23.TabIndex = 64;
            this.label23.Text = "label23";
            this.label23.Visible = false;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(193, 69);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(296, 22);
            this.txtStaffName.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(14, 333);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(118, 17);
            this.Label4.TabIndex = 49;
            this.Label4.Text = " Permanent Address";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(16, 248);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(87, 17);
            this.Label10.TabIndex = 68;
            this.Label10.Text = "Father\'s Name";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(17, 379);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(117, 17);
            this.Label5.TabIndex = 50;
            this.Label5.Text = "Temporary Address";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(18, 421);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 17);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "PhoneNo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 463);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "ContactNo";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(18, 118);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 17);
            this.Label8.TabIndex = 53;
            this.Label8.Text = "Gender";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(612, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 16);
            this.label21.TabIndex = 63;
            this.label21.Text = "label21";
            this.label21.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.lblUser);
            this.GroupBox1.Controls.Add(this.label23);
            this.GroupBox1.Controls.Add(this.txtDesignation);
            this.GroupBox1.Controls.Add(this.label21);
            this.GroupBox1.Controls.Add(this.lblUserType);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtEmail);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.txtBasicSalary);
            this.GroupBox1.Controls.Add(this.label25);
            this.GroupBox1.Controls.Add(this.label16);
            this.GroupBox1.Controls.Add(this.txtmotherName);
            this.GroupBox1.Controls.Add(this.cmbstatus);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.txtDepartment);
            this.GroupBox1.Controls.Add(this.DOB);
            this.GroupBox1.Controls.Add(this.label24);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.txtStaffID);
            this.GroupBox1.Controls.Add(this.cmbGender);
            this.GroupBox1.Controls.Add(this.Browse);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.label14);
            this.GroupBox1.Controls.Add(this.txtQualifications);
            this.GroupBox1.Controls.Add(this.txtYOP);
            this.GroupBox1.Controls.Add(this.dtpDateOfJoining);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.txtMobileNo);
            this.GroupBox1.Controls.Add(this.txtPhoneNo);
            this.GroupBox1.Controls.Add(this.txtTAddress);
            this.GroupBox1.Controls.Add(this.txtPAddress);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtFatherName);
            this.GroupBox1.Controls.Add(this.txtStaffName);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(1, -3);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.GroupBox1.Size = new System.Drawing.Size(939, 622);
            this.GroupBox1.TabIndex = 59;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Personal Profile";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(581, 153);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(31, 16);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(599, 520);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesignation.Multiline = true;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDesignation.Size = new System.Drawing.Size(286, 30);
            this.txtDesignation.TabIndex = 111;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(550, 118);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 16);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(492, 517);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 17);
            this.Label3.TabIndex = 112;
            this.Label3.Text = "Designation";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(598, 432);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 22);
            this.txtEmail.TabIndex = 109;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(496, 433);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(38, 17);
            this.Label7.TabIndex = 110;
            this.Label7.Text = "Email";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBasicSalary.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.Location = new System.Drawing.Point(599, 475);
            this.txtBasicSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(138, 22);
            this.txtBasicSalary.TabIndex = 107;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(492, 475);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 108;
            this.label25.Text = "Basic Salary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(16, 288);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 106;
            this.label16.Text = "Mother\'s Name";
            // 
            // txtmotherName
            // 
            this.txtmotherName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotherName.Location = new System.Drawing.Point(192, 288);
            this.txtmotherName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtmotherName.Name = "txtmotherName";
            this.txtmotherName.Size = new System.Drawing.Size(221, 22);
            this.txtmotherName.TabIndex = 105;
            // 
            // cmbstatus
            // 
            this.cmbstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstatus.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Married",
            "Unmarried"});
            this.cmbstatus.Location = new System.Drawing.Point(193, 162);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(124, 24);
            this.cmbstatus.TabIndex = 103;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 162);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 104;
            this.label15.Text = "Status";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.FormattingEnabled = true;
            this.txtDepartment.Location = new System.Drawing.Point(193, 509);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(179, 24);
            this.txtDepartment.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::school_management_system.Properties.Resources.photo1;
            this.pictureBox1.Location = new System.Drawing.Point(745, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1089, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployee_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox DOB;
        internal System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtStaffID;
        public System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button Browse;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtQualifications;
        public System.Windows.Forms.TextBox txtYOP;
        public System.Windows.Forms.DateTimePicker dtpDateOfJoining;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.MaskedTextBox txtMobileNo;
        public System.Windows.Forms.MaskedTextBox txtPhoneNo;
        public System.Windows.Forms.TextBox txtTAddress;
        public System.Windows.Forms.TextBox txtPAddress;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.TextBox txtFatherName;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox txtStaffName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label label21;
        internal System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.ComboBox cmbstatus;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtmotherName;
        public System.Windows.Forms.TextBox txtDesignation;
        internal System.Windows.Forms.Label Label3;
        public System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label7;
        public System.Windows.Forms.TextBox txtBasicSalary;
        internal System.Windows.Forms.Label label25;
        public System.Windows.Forms.ComboBox txtDepartment;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Timer timer1;
    }
}