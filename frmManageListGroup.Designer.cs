namespace Check_Point_Manager
{
    partial class frmManageListGroup
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
            this.dgvListGroups = new System.Windows.Forms.DataGridView();
            this.pnlAddNew = new System.Windows.Forms.Panel();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.pnlEditGroup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDeleteGroup = new System.Windows.Forms.Panel();
            this.lblDeleteGroup = new System.Windows.Forms.Label();
            this.pcbDeleteGroup = new System.Windows.Forms.PictureBox();
            this.pcbEditGroup = new System.Windows.Forms.PictureBox();
            this.pcbAddNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).BeginInit();
            this.pnlAddNew.SuspendLayout();
            this.pnlEditGroup.SuspendLayout();
            this.pnlDeleteGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeleteGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListGroups
            // 
            this.dgvListGroups.AllowUserToAddRows = false;
            this.dgvListGroups.AllowUserToDeleteRows = false;
            this.dgvListGroups.AllowUserToOrderColumns = true;
            this.dgvListGroups.BackgroundColor = System.Drawing.Color.White;
            this.dgvListGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGroups.Location = new System.Drawing.Point(12, 232);
            this.dgvListGroups.Name = "dgvListGroups";
            this.dgvListGroups.ReadOnly = true;
            this.dgvListGroups.Size = new System.Drawing.Size(844, 253);
            this.dgvListGroups.TabIndex = 0;
            // 
            // pnlAddNew
            // 
            this.pnlAddNew.BackColor = System.Drawing.Color.Lavender;
            this.pnlAddNew.Controls.Add(this.lblAddNew);
            this.pnlAddNew.Controls.Add(this.pcbAddNew);
            this.pnlAddNew.Location = new System.Drawing.Point(762, 152);
            this.pnlAddNew.Name = "pnlAddNew";
            this.pnlAddNew.Size = new System.Drawing.Size(94, 74);
            this.pnlAddNew.TabIndex = 1;
            this.pnlAddNew.Click += new System.EventHandler(this._AddButtonCardClick);
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Location = new System.Drawing.Point(3, 56);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(82, 13);
            this.lblAddNew.TabIndex = 2;
            this.lblAddNew.Text = "Add New Group";
            this.lblAddNew.Click += new System.EventHandler(this._AddButtonCardClick);
            // 
            // pnlEditGroup
            // 
            this.pnlEditGroup.BackColor = System.Drawing.Color.Lavender;
            this.pnlEditGroup.Controls.Add(this.label1);
            this.pnlEditGroup.Controls.Add(this.pcbEditGroup);
            this.pnlEditGroup.Location = new System.Drawing.Point(662, 152);
            this.pnlEditGroup.Name = "pnlEditGroup";
            this.pnlEditGroup.Size = new System.Drawing.Size(94, 74);
            this.pnlEditGroup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Group";
            // 
            // pnlDeleteGroup
            // 
            this.pnlDeleteGroup.BackColor = System.Drawing.Color.Lavender;
            this.pnlDeleteGroup.Controls.Add(this.lblDeleteGroup);
            this.pnlDeleteGroup.Controls.Add(this.pcbDeleteGroup);
            this.pnlDeleteGroup.Location = new System.Drawing.Point(562, 152);
            this.pnlDeleteGroup.Name = "pnlDeleteGroup";
            this.pnlDeleteGroup.Size = new System.Drawing.Size(94, 74);
            this.pnlDeleteGroup.TabIndex = 3;
            // 
            // lblDeleteGroup
            // 
            this.lblDeleteGroup.AutoSize = true;
            this.lblDeleteGroup.Location = new System.Drawing.Point(12, 56);
            this.lblDeleteGroup.Name = "lblDeleteGroup";
            this.lblDeleteGroup.Size = new System.Drawing.Size(70, 13);
            this.lblDeleteGroup.TabIndex = 2;
            this.lblDeleteGroup.Text = "Delete Group";
            // 
            // pcbDeleteGroup
            // 
            this.pcbDeleteGroup.BackColor = System.Drawing.Color.Transparent;
            this.pcbDeleteGroup.Image = global::Check_Point_Manager.Properties.Resources.trash_can_4630680;
            this.pcbDeleteGroup.Location = new System.Drawing.Point(3, 3);
            this.pcbDeleteGroup.Name = "pcbDeleteGroup";
            this.pcbDeleteGroup.Size = new System.Drawing.Size(89, 50);
            this.pcbDeleteGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDeleteGroup.TabIndex = 2;
            this.pcbDeleteGroup.TabStop = false;
            // 
            // pcbEditGroup
            // 
            this.pcbEditGroup.BackColor = System.Drawing.Color.Transparent;
            this.pcbEditGroup.Image = global::Check_Point_Manager.Properties.Resources.clipboard_7235464;
            this.pcbEditGroup.Location = new System.Drawing.Point(3, 3);
            this.pcbEditGroup.Name = "pcbEditGroup";
            this.pcbEditGroup.Size = new System.Drawing.Size(89, 50);
            this.pcbEditGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEditGroup.TabIndex = 2;
            this.pcbEditGroup.TabStop = false;
            // 
            // pcbAddNew
            // 
            this.pcbAddNew.BackColor = System.Drawing.Color.Transparent;
            this.pcbAddNew.Image = global::Check_Point_Manager.Properties.Resources.list_11066076;
            this.pcbAddNew.Location = new System.Drawing.Point(3, 3);
            this.pcbAddNew.Name = "pcbAddNew";
            this.pcbAddNew.Size = new System.Drawing.Size(89, 50);
            this.pcbAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAddNew.TabIndex = 2;
            this.pcbAddNew.TabStop = false;
            this.pcbAddNew.Click += new System.EventHandler(this._AddButtonCardClick);
            // 
            // frmManageListGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 497);
            this.Controls.Add(this.pnlDeleteGroup);
            this.Controls.Add(this.pnlEditGroup);
            this.Controls.Add(this.pnlAddNew);
            this.Controls.Add(this.dgvListGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageListGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Groups";
            this.Load += new System.EventHandler(this.frmManageListGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).EndInit();
            this.pnlAddNew.ResumeLayout(false);
            this.pnlAddNew.PerformLayout();
            this.pnlEditGroup.ResumeLayout(false);
            this.pnlEditGroup.PerformLayout();
            this.pnlDeleteGroup.ResumeLayout(false);
            this.pnlDeleteGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeleteGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListGroups;
        private System.Windows.Forms.Panel pnlAddNew;
        private System.Windows.Forms.PictureBox pcbAddNew;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.Panel pnlEditGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbEditGroup;
        private System.Windows.Forms.Panel pnlDeleteGroup;
        private System.Windows.Forms.Label lblDeleteGroup;
        private System.Windows.Forms.PictureBox pcbDeleteGroup;
    }
}