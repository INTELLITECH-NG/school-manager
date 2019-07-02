namespace school_management_system
{
    partial class frmChangePasswords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePasswords));
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUserID.Location = new System.Drawing.Point(222, 39);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(132, 25);
            this.txtUserID.TabIndex = 18;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(35, 42);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 18);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "UserID";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.Location = new System.Drawing.Point(105, 313);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(144, 42);
            this.btnChangePassword.TabIndex = 24;
            this.btnChangePassword.Text = "&Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(35, 216);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 18);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(222, 212);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '♠';
            this.txtConfirmPassword.Size = new System.Drawing.Size(132, 25);
            this.txtConfirmPassword.TabIndex = 23;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(222, 151);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '♠';
            this.txtNewPassword.Size = new System.Drawing.Size(132, 25);
            this.txtNewPassword.TabIndex = 22;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(222, 94);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '♠';
            this.txtOldPassword.Size = new System.Drawing.Size(132, 25);
            this.txtOldPassword.TabIndex = 20;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(35, 158);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 18);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "New Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(35, 97);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 18);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Old Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(283, 348);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 18);
            this.lblUser.TabIndex = 83;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserType.Location = new System.Drawing.Point(283, 302);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(67, 18);
            this.lblUserType.TabIndex = 82;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // frmChangePasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(391, 393);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChangePasswords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePasswords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChangePasswords_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnChangePassword;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtConfirmPassword;
        internal System.Windows.Forms.TextBox txtNewPassword;
        internal System.Windows.Forms.TextBox txtOldPassword;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblUserType;
    }
}