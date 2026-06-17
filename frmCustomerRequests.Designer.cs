namespace Check_Point_Manager
{
    partial class frmCustomerRequests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllRequests = new System.Windows.Forms.DataGridView();
            this.cmsOrderOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revertNotifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.btnNotify = new System.Windows.Forms.Button();
            this.cmbRequestsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbRequestsFilterValue = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRequests)).BeginInit();
            this.cmsOrderOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllRequests
            // 
            this.dgvAllRequests.AllowUserToAddRows = false;
            this.dgvAllRequests.AllowUserToDeleteRows = false;
            this.dgvAllRequests.AllowUserToOrderColumns = true;
            this.dgvAllRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRequests.ContextMenuStrip = this.cmsOrderOptions;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRequests.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllRequests.Location = new System.Drawing.Point(12, 148);
            this.dgvAllRequests.Name = "dgvAllRequests";
            this.dgvAllRequests.RowHeadersVisible = false;
            this.dgvAllRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRequests.Size = new System.Drawing.Size(1264, 422);
            this.dgvAllRequests.TabIndex = 23;
            this.dgvAllRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllRequests_CellClick);
            this.dgvAllRequests.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAllRequests_MouseDown);
            // 
            // cmsOrderOptions
            // 
            this.cmsOrderOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revertNotifiedToolStripMenuItem});
            this.cmsOrderOptions.Name = "cmsOrderOptions";
            this.cmsOrderOptions.Size = new System.Drawing.Size(154, 26);
            // 
            // revertNotifiedToolStripMenuItem
            // 
            this.revertNotifiedToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.remove_red_32;
            this.revertNotifiedToolStripMenuItem.Name = "revertNotifiedToolStripMenuItem";
            this.revertNotifiedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.revertNotifiedToolStripMenuItem.Text = "Revert Notified";
            this.revertNotifiedToolStripMenuItem.Click += new System.EventHandler(this.revertNotifiedToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Check_Point_Manager.Properties.Resources.update_25;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(412, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 35);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "  Update List";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = global::Check_Point_Manager.Properties.Resources.icons8_open_folder_25;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(12, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(155, 35);
            this.btnBrowse.TabIndex = 30;
            this.btnBrowse.Text = "  Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(173, 50);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(233, 35);
            this.txtFilePath.TabIndex = 31;
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.AutoSize = true;
            this.lblFileStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileStatus.Location = new System.Drawing.Point(582, 56);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(0, 21);
            this.lblFileStatus.TabIndex = 32;
            // 
            // btnNotify
            // 
            this.btnNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnNotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotify.ForeColor = System.Drawing.Color.White;
            this.btnNotify.Image = global::Check_Point_Manager.Properties.Resources.Hand_Right;
            this.btnNotify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotify.Location = new System.Drawing.Point(744, 50);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(108, 35);
            this.btnNotify.TabIndex = 33;
            this.btnNotify.Text = "  Notify";
            this.btnNotify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotify.UseVisualStyleBackColor = false;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // cmbRequestsFilterBy
            // 
            this.cmbRequestsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestsFilterBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRequestsFilterBy.FormattingEnabled = true;
            this.cmbRequestsFilterBy.Items.AddRange(new object[] {
            "None",
            "Phone Number",
            "Customer Name",
            "Item Code",
            "Item Description",
            "Pending",
            "Available",
            "Notified"});
            this.cmbRequestsFilterBy.Location = new System.Drawing.Point(82, 117);
            this.cmbRequestsFilterBy.Name = "cmbRequestsFilterBy";
            this.cmbRequestsFilterBy.Size = new System.Drawing.Size(155, 25);
            this.cmbRequestsFilterBy.TabIndex = 34;
            this.cmbRequestsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbRequestsFilterBy_SelectedIndexChanged);
            // 
            // txbRequestsFilterValue
            // 
            this.txbRequestsFilterValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRequestsFilterValue.Location = new System.Drawing.Point(243, 117);
            this.txbRequestsFilterValue.Name = "txbRequestsFilterValue";
            this.txbRequestsFilterValue.Size = new System.Drawing.Size(233, 25);
            this.txbRequestsFilterValue.TabIndex = 35;
            this.txbRequestsFilterValue.TextChanged += new System.EventHandler(this.txbRequestsFilterValue_TextChanged);
            this.txbRequestsFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRequestsFilterValue_KeyPress);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(12, 120);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(64, 17);
            this.lblFilterBy.TabIndex = 36;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // frmCustomerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1288, 582);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.cmbRequestsFilterBy);
            this.Controls.Add(this.txbRequestsFilterValue);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAllRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomerRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRequests)).EndInit();
            this.cmsOrderOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRequests;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.ContextMenuStrip cmsOrderOptions;
        private System.Windows.Forms.ToolStripMenuItem revertNotifiedToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbRequestsFilterBy;
        private System.Windows.Forms.TextBox txbRequestsFilterValue;
        private System.Windows.Forms.Label lblFilterBy;
    }
}