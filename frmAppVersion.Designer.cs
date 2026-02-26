namespace Check_Point_Manager
{
    partial class frmAppVersion
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
            this.lblCurrentVersionTitle = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblUpdateAppVersionTitle = new System.Windows.Forms.Label();
            this.txbUpdateAppVersion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentVersionTitle
            // 
            this.lblCurrentVersionTitle.AutoSize = true;
            this.lblCurrentVersionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVersionTitle.Location = new System.Drawing.Point(12, 49);
            this.lblCurrentVersionTitle.Name = "lblCurrentVersionTitle";
            this.lblCurrentVersionTitle.Size = new System.Drawing.Size(195, 25);
            this.lblCurrentVersionTitle.TabIndex = 0;
            this.lblCurrentVersionTitle.Text = "Current App Version :";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVersion.Location = new System.Drawing.Point(213, 49);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(28, 25);
            this.lblCurrentVersion.TabIndex = 1;
            this.lblCurrentVersion.Text = "??";
            // 
            // lblUpdateAppVersionTitle
            // 
            this.lblUpdateAppVersionTitle.AutoSize = true;
            this.lblUpdateAppVersionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAppVersionTitle.Location = new System.Drawing.Point(12, 89);
            this.lblUpdateAppVersionTitle.Name = "lblUpdateAppVersionTitle";
            this.lblUpdateAppVersionTitle.Size = new System.Drawing.Size(192, 25);
            this.lblUpdateAppVersionTitle.TabIndex = 2;
            this.lblUpdateAppVersionTitle.Text = "Update App Version :";
            // 
            // txbUpdateAppVersion
            // 
            this.txbUpdateAppVersion.Location = new System.Drawing.Point(210, 94);
            this.txbUpdateAppVersion.Name = "txbUpdateAppVersion";
            this.txbUpdateAppVersion.Size = new System.Drawing.Size(100, 20);
            this.txbUpdateAppVersion.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(174, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 28);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(71, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 28);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAppVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 202);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbUpdateAppVersion);
            this.Controls.Add(this.lblUpdateAppVersionTitle);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.lblCurrentVersionTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAppVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Version";
            this.Load += new System.EventHandler(this.frmAppVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentVersionTitle;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblUpdateAppVersionTitle;
        private System.Windows.Forms.TextBox txbUpdateAppVersion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}