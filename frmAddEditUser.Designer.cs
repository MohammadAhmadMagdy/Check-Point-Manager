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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.pcbPassword = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbInActive = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 41);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbUserName
            // 
            this.pcbUserName.Image = global::Check_Point_Manager.Properties.Resources.items_32;
            this.pcbUserName.Location = new System.Drawing.Point(155, 78);
            this.pcbUserName.Name = "pcbUserName";
            this.pcbUserName.Size = new System.Drawing.Size(32, 28);
            this.pcbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUserName.TabIndex = 28;
            this.pcbUserName.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(12, 81);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(102, 21);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Text = "User Name :";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.txbUserName.Location = new System.Drawing.Point(193, 78);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(170, 28);
            this.txbUserName.TabIndex = 26;
            // 
            // pcbPassword
            // 
            this.pcbPassword.Image = global::Check_Point_Manager.Properties.Resources.items_32;
            this.pcbPassword.Location = new System.Drawing.Point(155, 121);
            this.pcbPassword.Name = "pcbPassword";
            this.pcbPassword.Size = new System.Drawing.Size(32, 28);
            this.pcbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPassword.TabIndex = 31;
            this.pcbPassword.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(24, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 21);
            this.lblPassword.TabIndex = 30;
            this.lblPassword.Text = "Password :";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.txbPassword.Location = new System.Drawing.Point(193, 121);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(170, 28);
            this.txbPassword.TabIndex = 29;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.rdbActive.Location = new System.Drawing.Point(18, 188);
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
            this.rdbInActive.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.rdbInActive.Location = new System.Drawing.Point(135, 188);
            this.rdbInActive.Name = "rdbInActive";
            this.rdbInActive.Size = new System.Drawing.Size(91, 25);
            this.rdbInActive.TabIndex = 33;
            this.rdbInActive.TabStop = true;
            this.rdbInActive.Text = "InActive";
            this.rdbInActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 166);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbInActive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.pcbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.pcbUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.PictureBox pcbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbInActive;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}