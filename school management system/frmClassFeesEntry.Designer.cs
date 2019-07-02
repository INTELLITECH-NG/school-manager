namespace school_management_system
{
    partial class frmClassFeesEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassFeesEntry));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbFeeName = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFeeID = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.cmbMonth1 = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.cmbClass1 = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column7});
            this.DataGridView1.Location = new System.Drawing.Point(12, 17);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.Size = new System.Drawing.Size(499, 258);
            this.DataGridView1.TabIndex = 51;
            this.DataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Class ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Class Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fee ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fee Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fee";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Month";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(621, 181);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 24);
            this.txtID.TabIndex = 48;
            this.txtID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(113, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbFeeName
            // 
            this.cmbFeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeeName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeeName.FormattingEnabled = true;
            this.cmbFeeName.Location = new System.Drawing.Point(169, 97);
            this.cmbFeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFeeName.Name = "cmbFeeName";
            this.cmbFeeName.Size = new System.Drawing.Size(201, 24);
            this.cmbFeeName.TabIndex = 1;
            this.cmbFeeName.SelectedIndexChanged += new System.EventHandler(this.cmbFeeName_SelectedIndexChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.btnNew);
            this.Panel1.Controls.Add(this.btnDelete);
            this.Panel1.Controls.Add(this.btnSave);
            this.Panel1.Controls.Add(this.btnUpdate);
            this.Panel1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(16, 303);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(417, 77);
            this.Panel1.TabIndex = 46;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(8, 21);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 36);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(211, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(309, 21);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(169, 44);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(201, 24);
            this.cmbClass.TabIndex = 0;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(38, 101);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Fee Name";
            // 
            // txtFeeID
            // 
            this.txtFeeID.Location = new System.Drawing.Point(784, 181);
            this.txtFeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFeeID.Name = "txtFeeID";
            this.txtFeeID.Size = new System.Drawing.Size(122, 24);
            this.txtFeeID.TabIndex = 50;
            this.txtFeeID.Visible = false;
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(169, 197);
            this.txtFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(201, 22);
            this.txtFee.TabIndex = 2;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(28, 45);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(146, 22);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(458, 181);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(157, 24);
            this.txtClassID.TabIndex = 49;
            this.txtClassID.Visible = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Location = new System.Drawing.Point(441, 23);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(214, 94);
            this.GroupBox2.TabIndex = 47;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search By Class";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(38, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Class";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cmbMonth);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.cmbFeeName);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cmbClass);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtFee);
            this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(8, 21);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.GroupBox1.Size = new System.Drawing.Size(428, 258);
            this.GroupBox1.TabIndex = 45;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Class Fee Info";
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(169, 146);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(173, 24);
            this.cmbMonth.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(37, 146);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Month";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(38, 196);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Fee";
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.Button1);
            this.GroupBox3.Controls.Add(this.cmbMonth1);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.cmbClass1);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox3.Location = new System.Drawing.Point(661, 26);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Size = new System.Drawing.Size(436, 94);
            this.GroupBox3.TabIndex = 52;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Search By Class and Month";
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(319, 41);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(87, 34);
            this.Button1.TabIndex = 38;
            this.Button1.Text = "&Search";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbMonth1
            // 
            this.cmbMonth1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMonth1.FormattingEnabled = true;
            this.cmbMonth1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth1.Location = new System.Drawing.Point(177, 47);
            this.cmbMonth1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMonth1.Name = "cmbMonth1";
            this.cmbMonth1.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth1.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(174, 26);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 16);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Month";
            // 
            // cmbClass1
            // 
            this.cmbClass1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClass1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbClass1.FormattingEnabled = true;
            this.cmbClass1.Location = new System.Drawing.Point(17, 47);
            this.cmbClass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbClass1.Name = "cmbClass1";
            this.cmbClass1.Size = new System.Drawing.Size(119, 24);
            this.cmbClass1.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(14, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 16);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1038, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1050, 205);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(1038, 246);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridView1);
            this.panel2.Location = new System.Drawing.Point(457, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 285);
            this.panel2.TabIndex = 84;
            // 
            // frmClassFeesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1101, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtFeeID);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClassFeesEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Fees Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClassFeesEntry_FormClosing);
            this.Load += new System.EventHandler(this.frmClassFeesEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.ComboBox cmbFeeName;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.ComboBox cmbClass;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtFeeID;
        internal System.Windows.Forms.TextBox txtFee;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox txtClassID;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbMonth;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox cmbMonth1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cmbClass1;
        internal System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Panel panel2;
    }
}