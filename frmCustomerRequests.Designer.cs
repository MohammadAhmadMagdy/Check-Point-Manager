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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllRequests = new System.Windows.Forms.DataGridView();
            this.cmsOrderOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revertNotifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.btnNotifyAll = new System.Windows.Forms.Button();
            this.cmbRequestsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbRequestsFilterValue = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.rdbDate = new System.Windows.Forms.RadioButton();
            this.rdbStatus = new System.Windows.Forms.RadioButton();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.lblNotified = new System.Windows.Forms.Label();
            this.lblNotifiedTitle = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblAvailableTitle = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblTotalRequests = new System.Windows.Forms.Label();
            this.lblTotalRequestsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRequests)).BeginInit();
            this.cmsOrderOptions.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllRequests
            // 
            this.dgvAllRequests.AllowUserToAddRows = false;
            this.dgvAllRequests.AllowUserToDeleteRows = false;
            this.dgvAllRequests.AllowUserToOrderColumns = true;
            this.dgvAllRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRequests.ContextMenuStrip = this.cmsOrderOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllRequests.Location = new System.Drawing.Point(12, 152);
            this.dgvAllRequests.Name = "dgvAllRequests";
            this.dgvAllRequests.ReadOnly = true;
            this.dgvAllRequests.RowHeadersVisible = false;
            this.dgvAllRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRequests.Size = new System.Drawing.Size(1264, 463);
            this.dgvAllRequests.TabIndex = 23;
            this.dgvAllRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllRequests_CellClick);
            this.dgvAllRequests.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAllRequests_DataBindingComplete);
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
            this.btnUpdate.Location = new System.Drawing.Point(412, 12);
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
            this.btnBrowse.Location = new System.Drawing.Point(12, 12);
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
            this.txtFilePath.Location = new System.Drawing.Point(173, 12);
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
            this.lblFileStatus.Location = new System.Drawing.Point(582, 18);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(0, 21);
            this.lblFileStatus.TabIndex = 32;
            // 
            // btnNotifyAll
            // 
            this.btnNotifyAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnNotifyAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotifyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifyAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifyAll.ForeColor = System.Drawing.Color.White;
            this.btnNotifyAll.Image = global::Check_Point_Manager.Properties.Resources.Hand_Right;
            this.btnNotifyAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifyAll.Location = new System.Drawing.Point(1150, 111);
            this.btnNotifyAll.Name = "btnNotifyAll";
            this.btnNotifyAll.Size = new System.Drawing.Size(126, 35);
            this.btnNotifyAll.TabIndex = 33;
            this.btnNotifyAll.Text = "  Notify All";
            this.btnNotifyAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotifyAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifyAll.UseVisualStyleBackColor = false;
            this.btnNotifyAll.Click += new System.EventHandler(this.btnNotify_Click);
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
            // rdbDate
            // 
            this.rdbDate.AutoSize = true;
            this.rdbDate.Location = new System.Drawing.Point(589, 121);
            this.rdbDate.Name = "rdbDate";
            this.rdbDate.Size = new System.Drawing.Size(48, 17);
            this.rdbDate.TabIndex = 37;
            this.rdbDate.TabStop = true;
            this.rdbDate.Text = "Date";
            this.rdbDate.UseVisualStyleBackColor = true;
            this.rdbDate.CheckedChanged += new System.EventHandler(this.rdbDate_CheckedChanged);
            // 
            // rdbStatus
            // 
            this.rdbStatus.AutoSize = true;
            this.rdbStatus.Location = new System.Drawing.Point(643, 121);
            this.rdbStatus.Name = "rdbStatus";
            this.rdbStatus.Size = new System.Drawing.Size(56, 17);
            this.rdbStatus.TabIndex = 38;
            this.rdbStatus.TabStop = true;
            this.rdbStatus.Text = "Status";
            this.rdbStatus.UseVisualStyleBackColor = true;
            this.rdbStatus.CheckedChanged += new System.EventHandler(this.rdbStatus_CheckedChanged);
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(518, 120);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(69, 17);
            this.lblOrderBy.TabIndex = 39;
            this.lblOrderBy.Text = "Order By :";
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatistics.AutoSize = true;
            this.pnlStatistics.BackColor = System.Drawing.Color.White;
            this.pnlStatistics.Controls.Add(this.lblNotified);
            this.pnlStatistics.Controls.Add(this.lblNotifiedTitle);
            this.pnlStatistics.Controls.Add(this.lblAvailable);
            this.pnlStatistics.Controls.Add(this.lblPending);
            this.pnlStatistics.Controls.Add(this.lblAvailableTitle);
            this.pnlStatistics.Controls.Add(this.lblPendingTitle);
            this.pnlStatistics.Controls.Add(this.lblTotalRequests);
            this.pnlStatistics.Controls.Add(this.lblTotalRequestsTitle);
            this.pnlStatistics.Location = new System.Drawing.Point(12, 621);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(1264, 45);
            this.pnlStatistics.TabIndex = 40;
            // 
            // lblNotified
            // 
            this.lblNotified.AutoSize = true;
            this.lblNotified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotified.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotified.ForeColor = System.Drawing.Color.Blue;
            this.lblNotified.Location = new System.Drawing.Point(1007, 12);
            this.lblNotified.Name = "lblNotified";
            this.lblNotified.Size = new System.Drawing.Size(24, 21);
            this.lblNotified.TabIndex = 39;
            this.lblNotified.Text = "??";
            // 
            // lblNotifiedTitle
            // 
            this.lblNotifiedTitle.AutoSize = true;
            this.lblNotifiedTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotifiedTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifiedTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblNotifiedTitle.Location = new System.Drawing.Point(924, 12);
            this.lblNotifiedTitle.Name = "lblNotifiedTitle";
            this.lblNotifiedTitle.Size = new System.Drawing.Size(77, 21);
            this.lblNotifiedTitle.TabIndex = 38;
            this.lblNotifiedTitle.Text = "Notified :";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.Color.Green;
            this.lblAvailable.Location = new System.Drawing.Point(554, 12);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(24, 21);
            this.lblAvailable.TabIndex = 37;
            this.lblAvailable.Text = "??";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.Red;
            this.lblPending.Location = new System.Drawing.Point(776, 12);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(24, 21);
            this.lblPending.TabIndex = 35;
            this.lblPending.Text = "??";
            // 
            // lblAvailableTitle
            // 
            this.lblAvailableTitle.AutoSize = true;
            this.lblAvailableTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailableTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTitle.ForeColor = System.Drawing.Color.Green;
            this.lblAvailableTitle.Location = new System.Drawing.Point(461, 12);
            this.lblAvailableTitle.Name = "lblAvailableTitle";
            this.lblAvailableTitle.Size = new System.Drawing.Size(87, 21);
            this.lblAvailableTitle.TabIndex = 36;
            this.lblAvailableTitle.Text = "Available :";
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTitle.ForeColor = System.Drawing.Color.Red;
            this.lblPendingTitle.Location = new System.Drawing.Point(693, 12);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(77, 21);
            this.lblPendingTitle.TabIndex = 34;
            this.lblPendingTitle.Text = "Pending :";
            // 
            // lblTotalRequests
            // 
            this.lblTotalRequests.AutoSize = true;
            this.lblTotalRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequests.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalRequests.Location = new System.Drawing.Point(345, 12);
            this.lblTotalRequests.Name = "lblTotalRequests";
            this.lblTotalRequests.Size = new System.Drawing.Size(24, 21);
            this.lblTotalRequests.TabIndex = 33;
            this.lblTotalRequests.Text = "??";
            // 
            // lblTotalRequestsTitle
            // 
            this.lblTotalRequestsTitle.AutoSize = true;
            this.lblTotalRequestsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalRequestsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequestsTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalRequestsTitle.Location = new System.Drawing.Point(215, 12);
            this.lblTotalRequestsTitle.Name = "lblTotalRequestsTitle";
            this.lblTotalRequestsTitle.Size = new System.Drawing.Size(124, 21);
            this.lblTotalRequestsTitle.TabIndex = 32;
            this.lblTotalRequestsTitle.Text = "Total Requests :";
            // 
            // frmCustomerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1288, 678);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.lblOrderBy);
            this.Controls.Add(this.rdbStatus);
            this.Controls.Add(this.rdbDate);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.cmbRequestsFilterBy);
            this.Controls.Add(this.txbRequestsFilterValue);
            this.Controls.Add(this.btnNotifyAll);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAllRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomerRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Requests";
            this.Load += new System.EventHandler(this.frmCustomerRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRequests)).EndInit();
            this.cmsOrderOptions.ResumeLayout(false);
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRequests;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.Button btnNotifyAll;
        private System.Windows.Forms.ContextMenuStrip cmsOrderOptions;
        private System.Windows.Forms.ToolStripMenuItem revertNotifiedToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbRequestsFilterBy;
        private System.Windows.Forms.TextBox txbRequestsFilterValue;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.RadioButton rdbDate;
        private System.Windows.Forms.RadioButton rdbStatus;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblTotalRequests;
        private System.Windows.Forms.Label lblTotalRequestsTitle;
        private System.Windows.Forms.Label lblNotified;
        private System.Windows.Forms.Label lblNotifiedTitle;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblAvailableTitle;
    }
}