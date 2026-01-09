namespace Check_Point_Manager
{
    partial class frmListItems
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
        // Add this declaration to the designer file if missing
        private Check_Point_Manager.ctrlButtonCard ctrlButtonCardAddToGp;
        #region Windows Form Designer generated code
        // Add this declaration to the designer file if missing
        private Check_Point_Manager.ctrlButtonCard ctrlButtonCardBrowseFile;
        // Add this declaration to the designer file if missing
        private Check_Point_Manager.ctrlButtonCard ctrlButtonCardExport;
        // Add this declaration to the designer file if missing
        private Check_Point_Manager.ctrlButtonCard ctrlButtonCardManageGroups;
        // Add this declaration to the designer file if missing
       // private Check_Point_Manager.ctrlButtonCard ctrlButtonCardUpdate;


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.gbxGroups = new System.Windows.Forms.GroupBox();
            this.btnExportFile = new Check_Point_Manager.ctrlButtonCard();
            this.btnManageGroups = new Check_Point_Manager.ctrlButtonCard();
            this.lblSelectGroupTitle = new System.Windows.Forms.Label();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.btnAddToGroup = new Check_Point_Manager.ctrlButtonCard();
            this.gbxUpdateData = new System.Windows.Forms.GroupBox();
            this.btnBrowseFile = new Check_Point_Manager.ctrlButtonCard();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.ctrlButtonCardUpdate = new Check_Point_Manager.ctrlButtonCard();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.cmsGroupOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFromGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.gbxGroups.SuspendLayout();
            this.gbxItems.SuspendLayout();
            this.gbxUpdateData.SuspendLayout();
            this.cmsGroupOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(8, 406);
            this.lblItemRecordsTitle.Name = "lblItemRecordsTitle";
            this.lblItemRecordsTitle.Size = new System.Drawing.Size(77, 14);
            this.lblItemRecordsTitle.TabIndex = 2;
            this.lblItemRecordsTitle.Text = "# Records :";
            // 
            // lblItemRecords
            // 
            this.lblItemRecords.AutoSize = true;
            this.lblItemRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemRecords.Location = new System.Drawing.Point(91, 406);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(21, 14);
            this.lblItemRecords.TabIndex = 3;
            this.lblItemRecords.Text = "??";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(8, 48);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(265, 22);
            this.cmbGroups.TabIndex = 8;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // dgvGroupItems
            // 
            this.dgvGroupItems.AllowUserToAddRows = false;
            this.dgvGroupItems.AllowUserToDeleteRows = false;
            this.dgvGroupItems.AllowUserToOrderColumns = true;
            this.dgvGroupItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroupItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupItems.ContextMenuStrip = this.cmsGroupOption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupItems.Location = new System.Drawing.Point(8, 77);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(511, 327);
            this.dgvGroupItems.TabIndex = 9;
            // 
            // dgvAllStockList
            // 
            this.dgvAllStockList.AllowUserToAddRows = false;
            this.dgvAllStockList.AllowUserToDeleteRows = false;
            this.dgvAllStockList.AllowUserToOrderColumns = true;
            this.dgvAllStockList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllStockList.Location = new System.Drawing.Point(8, 76);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(637, 327);
            this.dgvAllStockList.TabIndex = 0;
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellContentClick);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFilterBy.Location = new System.Drawing.Point(8, 30);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(64, 14);
            this.lblFilterBy.TabIndex = 4;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description"});
            this.cmbFilterBy.Location = new System.Drawing.Point(8, 47);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(158, 22);
            this.cmbFilterBy.TabIndex = 5;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(172, 48);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(177, 22);
            this.txbFilterValue.TabIndex = 6;
            this.txbFilterValue.TextChanged += new System.EventHandler(this.txbFilterValue_TextChanged);
            this.txbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilterValue_KeyPress);
            // 
            // gbxGroups
            // 
            this.gbxGroups.Controls.Add(this.btnExportFile);
            this.gbxGroups.Controls.Add(this.btnManageGroups);
            this.gbxGroups.Controls.Add(this.lblSelectGroupTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecordTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecord);
            this.gbxGroups.Controls.Add(this.dgvGroupItems);
            this.gbxGroups.Controls.Add(this.cmbGroups);
            this.gbxGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGroups.Location = new System.Drawing.Point(669, 229);
            this.gbxGroups.Name = "gbxGroups";
            this.gbxGroups.Size = new System.Drawing.Size(527, 429);
            this.gbxGroups.TabIndex = 12;
            this.gbxGroups.TabStop = false;
            this.gbxGroups.Text = "Groups";
            // 
            // btnExportFile
            // 
            this.btnExportFile.Icon = global::Check_Point_Manager.Properties.Resources.share;
            this.btnExportFile.Location = new System.Drawing.Point(289, 25);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(111, 46);
            this.btnExportFile.TabIndex = 17;
            this.btnExportFile.Title = "Export File";
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.Icon = global::Check_Point_Manager.Properties.Resources.edit_16167227;
            this.btnManageGroups.Location = new System.Drawing.Point(408, 25);
            this.btnManageGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(111, 46);
            this.btnManageGroups.TabIndex = 16;
            this.btnManageGroups.Title = "Manage Groups";
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // lblSelectGroupTitle
            // 
            this.lblSelectGroupTitle.AutoSize = true;
            this.lblSelectGroupTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroupTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSelectGroupTitle.Location = new System.Drawing.Point(8, 30);
            this.lblSelectGroupTitle.Name = "lblSelectGroupTitle";
            this.lblSelectGroupTitle.Size = new System.Drawing.Size(104, 14);
            this.lblSelectGroupTitle.TabIndex = 16;
            this.lblSelectGroupTitle.Text = "Select a Group :";
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(8, 407);
            this.lblGroupRecordTitle.Name = "lblGroupRecordTitle";
            this.lblGroupRecordTitle.Size = new System.Drawing.Size(77, 14);
            this.lblGroupRecordTitle.TabIndex = 11;
            this.lblGroupRecordTitle.Text = "# Records :";
            // 
            // lblGroupRecord
            // 
            this.lblGroupRecord.AutoSize = true;
            this.lblGroupRecord.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGroupRecord.Location = new System.Drawing.Point(91, 407);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(21, 14);
            this.lblGroupRecord.TabIndex = 12;
            this.lblGroupRecord.Text = "??";
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.btnAddToGroup);
            this.gbxItems.Controls.Add(this.dgvAllStockList);
            this.gbxItems.Controls.Add(this.lblItemRecordsTitle);
            this.gbxItems.Controls.Add(this.lblItemRecords);
            this.gbxItems.Controls.Add(this.lblFilterBy);
            this.gbxItems.Controls.Add(this.txbFilterValue);
            this.gbxItems.Controls.Add(this.cmbFilterBy);
            this.gbxItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItems.Location = new System.Drawing.Point(12, 229);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(651, 429);
            this.gbxItems.TabIndex = 13;
            this.gbxItems.TabStop = false;
            this.gbxItems.Text = "Item List";
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.Icon = global::Check_Point_Manager.Properties.Resources.right_arrow;
            this.btnAddToGroup.Location = new System.Drawing.Point(533, 24);
            this.btnAddToGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(111, 46);
            this.btnAddToGroup.TabIndex = 16;
            this.btnAddToGroup.Title = "Add To Group";
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // gbxUpdateData
            // 
            this.gbxUpdateData.Controls.Add(this.btnBrowseFile);
            this.gbxUpdateData.Controls.Add(this.lblUpdateStatus);
            this.gbxUpdateData.Controls.Add(this.ctrlButtonCardUpdate);
            this.gbxUpdateData.Controls.Add(this.txbFilePath);
            this.gbxUpdateData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateData.Location = new System.Drawing.Point(12, 70);
            this.gbxUpdateData.Name = "gbxUpdateData";
            this.gbxUpdateData.Size = new System.Drawing.Size(397, 153);
            this.gbxUpdateData.TabIndex = 14;
            this.gbxUpdateData.TabStop = false;
            this.gbxUpdateData.Text = "Update Stock";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Icon = global::Check_Point_Manager.Properties.Resources.folder;
            this.btnBrowseFile.Location = new System.Drawing.Point(11, 21);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(111, 46);
            this.btnBrowseFile.TabIndex = 16;
            this.btnBrowseFile.Title = "Browse File";
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUpdateStatus.Location = new System.Drawing.Point(138, 108);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(0, 16);
            this.lblUpdateStatus.TabIndex = 3;
            // 
            // ctrlButtonCardUpdate
            // 
            this.ctrlButtonCardUpdate.Icon = global::Check_Point_Manager.Properties.Resources.file_update;
            this.ctrlButtonCardUpdate.Location = new System.Drawing.Point(11, 89);
            this.ctrlButtonCardUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlButtonCardUpdate.Name = "ctrlButtonCardUpdate";
            this.ctrlButtonCardUpdate.Size = new System.Drawing.Size(111, 46);
            this.ctrlButtonCardUpdate.TabIndex = 2;
            this.ctrlButtonCardUpdate.Title = "Update Stock";
            this.ctrlButtonCardUpdate.Click += new System.EventHandler(this.ctrlButtonCardUpdate_Click);
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(138, 37);
            this.txbFilePath.Multiline = true;
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(241, 20);
            this.txbFilePath.TabIndex = 1;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Eras Medium ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMainTitle.Location = new System.Drawing.Point(418, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(371, 43);
            this.lblMainTitle.TabIndex = 15;
            this.lblMainTitle.Text = "Check Point Manager";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsGroupOption
            // 
            this.cmsGroupOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFromGroupToolStripMenuItem});
            this.cmsGroupOption.Name = "cmsGroupOption";
            this.cmsGroupOption.Size = new System.Drawing.Size(175, 26);
            // 
            // deleteFromGroupToolStripMenuItem
            // 
            this.deleteFromGroupToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.recycle_bin;
            this.deleteFromGroupToolStripMenuItem.Name = "deleteFromGroupToolStripMenuItem";
            this.deleteFromGroupToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteFromGroupToolStripMenuItem.Text = "Delete From Group";
            this.deleteFromGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteFromGroupToolStripMenuItem_Click);
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 666);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.gbxUpdateData);
            this.Controls.Add(this.gbxItems);
            this.Controls.Add(this.gbxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Items";
            this.Load += new System.EventHandler(this.frmListItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).EndInit();
            this.gbxGroups.ResumeLayout(false);
            this.gbxGroups.PerformLayout();
            this.gbxItems.ResumeLayout(false);
            this.gbxItems.PerformLayout();
            this.gbxUpdateData.ResumeLayout(false);
            this.gbxUpdateData.PerformLayout();
            this.cmsGroupOption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemRecordsTitle;
        private System.Windows.Forms.Label lblItemRecords;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridView dgvGroupItems;
        private System.Windows.Forms.DataGridView dgvAllStockList;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txbFilterValue;
        private System.Windows.Forms.GroupBox gbxGroups;
        private System.Windows.Forms.GroupBox gbxItems;
        private System.Windows.Forms.Label lblGroupRecordTitle;
        private System.Windows.Forms.Label lblGroupRecord;
      
        
        private System.Windows.Forms.GroupBox gbxUpdateData;
       
        private ctrlButtonCard ctrlButtonCardUpdate;
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Label lblUpdateStatus;
      
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSelectGroupTitle;
        private ctrlButtonCard btnBrowseFile;
        private ctrlButtonCard btnAddToGroup;
        private ctrlButtonCard btnExportFile;
        private ctrlButtonCard btnManageGroups;
        private System.Windows.Forms.ContextMenuStrip cmsGroupOption;
        private System.Windows.Forms.ToolStripMenuItem deleteFromGroupToolStripMenuItem;
    }
}

