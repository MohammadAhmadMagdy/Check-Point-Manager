namespace Check_Point_Manager
{
    partial class frmAddEditUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pcbUserName = new System.Windows.Forms.PictureBox();
            this.lblEnterUserName = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.pcbPassword = new System.Windows.Forms.PictureBox();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbInActive = new System.Windows.Forms.RadioButton();
            this.gbxUserInfo = new System.Windows.Forms.GroupBox();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblUserNameTitle = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblIsActiveTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).BeginInit();
            this.gbxUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 41);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbUserName
            // 
            this.pcbUserName.Image = global::Check_Point_Manager.Properties.Resources.person_25;
            this.pcbUserName.Location = new System.Drawing.Point(171, 63);
            this.pcbUserName.Name = "pcbUserName";
            this.pcbUserName.Size = new System.Drawing.Size(32, 28);
            this.pcbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUserName.TabIndex = 28;
            this.pcbUserName.TabStop = false;
            // 
            // lblEnterUserName
            // 
            this.lblEnterUserName.AutoSize = true;
            this.lblEnterUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUserName.Location = new System.Drawing.Point(12, 66);
            this.lblEnterUserName.Name = "lblEnterUserName";
            this.lblEnterUserName.Size = new System.Drawing.Size(146, 21);
            this.lblEnterUserName.TabIndex = 27;
            this.lblEnterUserName.Text = "Enter User Name :";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txbUserName.Location = new System.Drawing.Point(209, 63);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(170, 29);
            this.txbUserName.TabIndex = 26;
            // 
            // pcbPassword
            // 
            this.pcbPassword.Image = global::Check_Point_Manager.Properties.Resources.password_30;
            this.pcbPassword.Location = new System.Drawing.Point(171, 106);
            this.pcbPassword.Name = "pcbPassword";
            this.pcbPassword.Size = new System.Drawing.Size(32, 28);
            this.pcbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPassword.TabIndex = 31;
            this.pcbPassword.TabStop = false;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnterPassword.Location = new System.Drawing.Point(24, 109);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(134, 21);
            this.lblEnterPassword.TabIndex = 30;
            this.lblEnterPassword.Text = "Enter Password :";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txbPassword.Location = new System.Drawing.Point(209, 106);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(170, 29);
            this.txbPassword.TabIndex = 29;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rdbActive.Location = new System.Drawing.Point(27, 150);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(76, 25);
            this.rdbActive.TabIndex = 32;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Active";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbInActive
            // 
            this.rdbInActive.AutoSize = true;
            this.rdbInActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rdbInActive.Location = new System.Drawing.Point(144, 150);
            this.rdbInActive.Name = "rdbInActive";
            this.rdbInActive.Size = new System.Drawing.Size(91, 25);
            this.rdbInActive.TabIndex = 33;
            this.rdbInActive.TabStop = true;
            this.rdbInActive.Text = "InActive";
            this.rdbInActive.UseVisualStyleBackColor = true;
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Controls.Add(this.lblIsActive);
            this.gbxUserInfo.Controls.Add(this.pictureBox4);
            this.gbxUserInfo.Controls.Add(this.lblIsActiveTitle);
            this.gbxUserInfo.Controls.Add(this.lblPassword);
            this.gbxUserInfo.Controls.Add(this.lblUserName);
            this.gbxUserInfo.Controls.Add(this.lblUserID);
            this.gbxUserInfo.Controls.Add(this.pictureBox3);
            this.gbxUserInfo.Controls.Add(this.pictureBox1);
            this.gbxUserInfo.Controls.Add(this.pictureBox2);
            this.gbxUserInfo.Controls.Add(this.lblUserIDTitle);
            this.gbxUserInfo.Controls.Add(this.lblPasswordTitle);
            this.gbxUserInfo.Controls.Add(this.lblUserNameTitle);
            this.gbxUserInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbxUserInfo.Location = new System.Drawing.Point(15, 204);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Size = new System.Drawing.Size(364, 186);
            this.gbxUserInfo.TabIndex = 34;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "User Info";
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.Location = new System.Drawing.Point(23, 112);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(74, 17);
            this.lblPasswordTitle.TabIndex = 32;
            this.lblPasswordTitle.Text = "Password :";
            // 
            // lblUserNameTitle
            // 
            this.lblUserNameTitle.AutoSize = true;
            this.lblUserNameTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameTitle.Location = new System.Drawing.Point(14, 74);
            this.lblUserNameTitle.Name = "lblUserNameTitle";
            this.lblUserNameTitle.Size = new System.Drawing.Size(83, 17);
            this.lblUserNameTitle.TabIndex = 31;
            this.lblUserNameTitle.Text = "User Name :";
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDTitle.Location = new System.Drawing.Point(36, 36);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(61, 17);
            this.lblUserIDTitle.TabIndex = 33;
            this.lblUserIDTitle.Text = "User ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Check_Point_Manager.Properties.Resources.password_30;
            this.pictureBox1.Location = new System.Drawing.Point(118, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Check_Point_Manager.Properties.Resources.person_25;
            this.pictureBox2.Location = new System.Drawing.Point(118, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Check_Point_Manager.Properties.Resources.person_25;
            this.pictureBox3.Location = new System.Drawing.Point(118, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(165, 36);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(32, 17);
            this.lblUserID.TabIndex = 37;
            this.lblUserID.Text = "????";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(165, 74);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 17);
            this.lblUserName.TabIndex = 38;
            this.lblUserName.Text = "????";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(165, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(32, 17);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "????";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(165, 150);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(32, 17);
            this.lblIsActive.TabIndex = 42;
            this.lblIsActive.Text = "????";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Check_Point_Manager.Properties.Resources.InfoIco_25;
            this.pictureBox4.Location = new System.Drawing.Point(118, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // lblIsActiveTitle
            // 
            this.lblIsActiveTitle.AutoSize = true;
            this.lblIsActiveTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveTitle.Location = new System.Drawing.Point(19, 150);
            this.lblIsActiveTitle.Name = "lblIsActiveTitle";
            this.lblIsActiveTitle.Size = new System.Drawing.Size(78, 17);
            this.lblIsActiveTitle.TabIndex = 40;
            this.lblIsActiveTitle.Text = "Is Active ? :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(86)))), ((int)(((byte)(146)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(66, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 39);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(86)))), ((int)(((byte)(146)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(220, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 39);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 457);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxUserInfo);
            this.Controls.Add(this.rdbInActive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.pcbPassword);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.pcbUserName);
            this.Controls.Add(this.lblEnterUserName);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).EndInit();
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbUserName;
        private System.Windows.Forms.Label lblEnterUserName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.PictureBox pcbPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbInActive;
        private System.Windows.Forms.GroupBox gbxUserInfo;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblUserNameTitle;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblIsActiveTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}