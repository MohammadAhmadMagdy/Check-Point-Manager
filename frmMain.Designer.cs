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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.cmsGroupOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFromGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.gbxGroups = new System.Windows.Forms.GroupBox();
            this.pcbGroupsBackground = new System.Windows.Forms.PictureBox();
            this.lblSelectGroupTitle = new System.Windows.Forms.Label();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.gbxUpdateData = new System.Windows.Forms.GroupBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.chbFastMode = new System.Windows.Forms.CheckBox();
            this.btnBrowseFile = new Check_Point_Manager.ctrlButtonCard();
            this.ctrlButtonCardUpdate = new Check_Point_Manager.ctrlButtonCard();
            this.btnAddToGroup = new Check_Point_Manager.ctrlButtonCard();
            this.btnExportFile = new Check_Point_Manager.ctrlButtonCard();
            this.btnManageGroups = new Check_Point_Manager.ctrlButtonCard();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            this.cmsGroupOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.gbxGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).BeginInit();
            this.gbxItems.SuspendLayout();
            this.gbxUpdateData.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(6, 427);
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
            this.lblItemRecords.Location = new System.Drawing.Point(89, 427);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(21, 14);
            this.lblItemRecords.TabIndex = 3;
            this.lblItemRecords.Text = "??";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(8, 67);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroupItems.Location = new System.Drawing.Point(8, 96);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.ReadOnly = true;
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(511, 327);
            this.dgvGroupItems.TabIndex = 9;
            this.dgvGroupItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupItems_CellDoubleClick);
            this.dgvGroupItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this._dgvSelectAllRowByRightClick);
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
            // dgvAllStockList
            // 
            this.dgvAllStockList.AllowUserToAddRows = false;
            this.dgvAllStockList.AllowUserToDeleteRows = false;
            this.dgvAllStockList.AllowUserToOrderColumns = true;
            this.dgvAllStockList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllStockList.Location = new System.Drawing.Point(6, 97);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(637, 327);
            this.dgvAllStockList.TabIndex = 0;
            this.dgvAllStockList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAllStockList_CellBeginEdit);
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellContentClick);
            this.dgvAllStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellDoubleClick);
            this.dgvAllStockList.MouseDown += new System.Windows.Forms.MouseEventHandler(this._dgvSelectAllRowByRightClick);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description"});
            this.cmbFilterBy.Location = new System.Drawing.Point(6, 21);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(161, 22);
            this.cmbFilterBy.TabIndex = 5;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(173, 21);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(189, 22);
            this.txbFilterValue.TabIndex = 6;
            this.txbFilterValue.TextChanged += new System.EventHandler(this.txbFilterValue_TextChanged);
            this.txbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilterValue_KeyPress);
            // 
            // gbxGroups
            // 
            this.gbxGroups.Controls.Add(this.pcbGroupsBackground);
            this.gbxGroups.Controls.Add(this.btnExportFile);
            this.gbxGroups.Controls.Add(this.btnManageGroups);
            this.gbxGroups.Controls.Add(this.lblSelectGroupTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecordTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecord);
            this.gbxGroups.Controls.Add(this.dgvGroupItems);
            this.gbxGroups.Controls.Add(this.cmbGroups);
            this.gbxGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGroups.Location = new System.Drawing.Point(669, 249);
            this.gbxGroups.Name = "gbxGroups";
            this.gbxGroups.Size = new System.Drawing.Size(527, 445);
            this.gbxGroups.TabIndex = 12;
            this.gbxGroups.TabStop = false;
            this.gbxGroups.Text = "Groups";
            // 
            // pcbGroupsBackground
            // 
            this.pcbGroupsBackground.Enabled = false;
            this.pcbGroupsBackground.Image = global::Check_Point_Manager.Properties.Resources.article;
            this.pcbGroupsBackground.Location = new System.Drawing.Point(25, 113);
            this.pcbGroupsBackground.Name = "pcbGroupsBackground";
            this.pcbGroupsBackground.Size = new System.Drawing.Size(475, 295);
            this.pcbGroupsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsBackground.TabIndex = 18;
            this.pcbGroupsBackground.TabStop = false;
            // 
            // lblSelectGroupTitle
            // 
            this.lblSelectGroupTitle.AutoSize = true;
            this.lblSelectGroupTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroupTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSelectGroupTitle.Location = new System.Drawing.Point(8, 49);
            this.lblSelectGroupTitle.Name = "lblSelectGroupTitle";
            this.lblSelectGroupTitle.Size = new System.Drawing.Size(104, 14);
            this.lblSelectGroupTitle.TabIndex = 16;
            this.lblSelectGroupTitle.Text = "Select a Group :";
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(8, 426);
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
            this.lblGroupRecord.Location = new System.Drawing.Point(91, 426);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(21, 14);
            this.lblGroupRecord.TabIndex = 12;
            this.lblGroupRecord.Text = "??";
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.gbxFilter);
            this.gbxItems.Controls.Add(this.chbSelectAll);
            this.gbxItems.Controls.Add(this.btnAddToGroup);
            this.gbxItems.Controls.Add(this.dgvAllStockList);
            this.gbxItems.Controls.Add(this.lblItemRecordsTitle);
            this.gbxItems.Controls.Add(this.lblItemRecords);
            this.gbxItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItems.Location = new System.Drawing.Point(12, 249);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(651, 445);
            this.gbxItems.TabIndex = 13;
            this.gbxItems.TabStop = false;
            this.gbxItems.Text = "Item List";
            // 
            // gbxUpdateData
            // 
            this.gbxUpdateData.Controls.Add(this.btnBrowseFile);
            this.gbxUpdateData.Controls.Add(this.lblUpdateStatus);
            this.gbxUpdateData.Controls.Add(this.ctrlButtonCardUpdate);
            this.gbxUpdateData.Controls.Add(this.txbFilePath);
            this.gbxUpdateData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateData.Location = new System.Drawing.Point(12, 49);
            this.gbxUpdateData.Name = "gbxUpdateData";
            this.gbxUpdateData.Size = new System.Drawing.Size(397, 153);
            this.gbxUpdateData.TabIndex = 14;
            this.gbxUpdateData.TabStop = false;
            this.gbxUpdateData.Text = "Update Stock";
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
            this.lblMainTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMainTitle.Location = new System.Drawing.Point(418, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(371, 43);
            this.lblMainTitle.TabIndex = 15;
            this.lblMainTitle.Text = "Check Point Manager";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbFastMode
            // 
            this.chbFastMode.AutoSize = true;
            this.chbFastMode.ForeColor = System.Drawing.Color.DarkBlue;
            this.chbFastMode.Location = new System.Drawing.Point(12, 226);
            this.chbFastMode.Name = "chbFastMode";
            this.chbFastMode.Size = new System.Drawing.Size(266, 17);
            this.chbFastMode.TabIndex = 17;
            this.chbFastMode.Text = "Fast Mode ( Add / Remove Items By Double Click )";
            this.chbFastMode.UseVisualStyleBackColor = true;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFile.Icon = global::Check_Point_Manager.Properties.Resources.search;
            this.btnBrowseFile.Location = new System.Drawing.Point(11, 21);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(120, 58);
            this.btnBrowseFile.TabIndex = 16;
            this.btnBrowseFile.Title = "Browse File";
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // ctrlButtonCardUpdate
            // 
            this.ctrlButtonCardUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlButtonCardUpdate.Icon = global::Check_Point_Manager.Properties.Resources.data_processing;
            this.ctrlButtonCardUpdate.Location = new System.Drawing.Point(11, 85);
            this.ctrlButtonCardUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlButtonCardUpdate.Name = "ctrlButtonCardUpdate";
            this.ctrlButtonCardUpdate.Size = new System.Drawing.Size(120, 53);
            this.ctrlButtonCardUpdate.TabIndex = 2;
            this.ctrlButtonCardUpdate.Title = "Update Stock";
            this.ctrlButtonCardUpdate.Click += new System.EventHandler(this.ctrlButtonCardUpdate_Click);
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToGroup.Icon = global::Check_Point_Manager.Properties.Resources.right;
            this.btnAddToGroup.Location = new System.Drawing.Point(523, 40);
            this.btnAddToGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(120, 50);
            this.btnAddToGroup.TabIndex = 16;
            this.btnAddToGroup.Title = "Add To Group";
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportFile.Icon = global::Check_Point_Manager.Properties.Resources.share__1_;
            this.btnExportFile.Location = new System.Drawing.Point(280, 40);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(120, 50);
            this.btnExportFile.TabIndex = 17;
            this.btnExportFile.Title = "Export File";
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageGroups.Icon = global::Check_Point_Manager.Properties.Resources.touch;
            this.btnManageGroups.Location = new System.Drawing.Point(398, 40);
            this.btnManageGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(121, 50);
            this.btnManageGroups.TabIndex = 16;
            this.btnManageGroups.Title = "Manage Groups";
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbSelectAll.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSelectAll.ForeColor = System.Drawing.Color.Black;
            this.chbSelectAll.Location = new System.Drawing.Point(18, 79);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(79, 18);
            this.chbSelectAll.TabIndex = 17;
            this.chbSelectAll.Text = "   Select All";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            this.chbSelectAll.CheckedChanged += new System.EventHandler(this.chbSelectAll_CheckedChanged);
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.cmbFilterBy);
            this.gbxFilter.Controls.Add(this.txbFilterValue);
            this.gbxFilter.Location = new System.Drawing.Point(6, 24);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(369, 49);
            this.gbxFilter.TabIndex = 18;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 703);
            this.Controls.Add(this.chbFastMode);
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
            this.cmsGroupOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).EndInit();
            this.gbxGroups.ResumeLayout(false);
            this.gbxGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).EndInit();
            this.gbxItems.ResumeLayout(false);
            this.gbxItems.PerformLayout();
            this.gbxUpdateData.ResumeLayout(false);
            this.gbxUpdateData.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemRecordsTitle;
        private System.Windows.Forms.Label lblItemRecords;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridView dgvGroupItems;
        private System.Windows.Forms.DataGridView dgvAllStockList;
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
        private System.Windows.Forms.CheckBox chbFastMode;
        private System.Windows.Forms.PictureBox pcbGroupsBackground;
        private System.Windows.Forms.CheckBox chbSelectAll;
        private System.Windows.Forms.GroupBox gbxFilter;
    }
}

