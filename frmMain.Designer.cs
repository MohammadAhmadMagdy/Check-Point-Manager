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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListItems));
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.cmsGroupOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.gbxGroups = new System.Windows.Forms.GroupBox();
            this.lblSelectGroupTitle = new System.Windows.Forms.Label();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.gbxUpdateData = new System.Windows.Forms.GroupBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.chbFastMode = new System.Windows.Forms.CheckBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnBrowseFile = new Check_Point_Manager.ctrlButtonCard();
            this.ctrlButtonCardUpdate = new Check_Point_Manager.ctrlButtonCard();
            this.btnAddToGroup = new Check_Point_Manager.ctrlButtonCard();
            this.pcbGroupsBackground = new System.Windows.Forms.PictureBox();
            this.btnExportFile = new Check_Point_Manager.ctrlButtonCard();
            this.btnManageGroups = new Check_Point_Manager.ctrlButtonCard();
            this.deleteFromGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            this.cmsGroupOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.gbxGroups.SuspendLayout();
            this.gbxItems.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.gbxUpdateData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(6, 487);
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
            this.lblItemRecords.Location = new System.Drawing.Point(89, 487);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(21, 14);
            this.lblItemRecords.TabIndex = 3;
            this.lblItemRecords.Text = "??";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(9, 99);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(544, 22);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupItems.Location = new System.Drawing.Point(9, 126);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.ReadOnly = true;
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(544, 356);
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
            // dgvAllStockList
            // 
            this.dgvAllStockList.AllowUserToAddRows = false;
            this.dgvAllStockList.AllowUserToDeleteRows = false;
            this.dgvAllStockList.AllowUserToOrderColumns = true;
            this.dgvAllStockList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllStockList.Location = new System.Drawing.Point(6, 128);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(606, 356);
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
            this.cmbFilterBy.Location = new System.Drawing.Point(7, 17);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(161, 22);
            this.cmbFilterBy.TabIndex = 5;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(174, 17);
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
            this.gbxGroups.Location = new System.Drawing.Point(638, 193);
            this.gbxGroups.Name = "gbxGroups";
            this.gbxGroups.Size = new System.Drawing.Size(558, 501);
            this.gbxGroups.TabIndex = 12;
            this.gbxGroups.TabStop = false;
            this.gbxGroups.Text = "Groups";
            // 
            // lblSelectGroupTitle
            // 
            this.lblSelectGroupTitle.AutoSize = true;
            this.lblSelectGroupTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroupTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSelectGroupTitle.Location = new System.Drawing.Point(7, 81);
            this.lblSelectGroupTitle.Name = "lblSelectGroupTitle";
            this.lblSelectGroupTitle.Size = new System.Drawing.Size(104, 14);
            this.lblSelectGroupTitle.TabIndex = 16;
            this.lblSelectGroupTitle.Text = "Select a Group :";
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(9, 486);
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
            this.lblGroupRecord.Location = new System.Drawing.Point(92, 486);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(21, 14);
            this.lblGroupRecord.TabIndex = 12;
            this.lblGroupRecord.Text = "??";
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.groupBox1);
            this.gbxItems.Controls.Add(this.gbxFilter);
            this.gbxItems.Controls.Add(this.btnAddToGroup);
            this.gbxItems.Controls.Add(this.dgvAllStockList);
            this.gbxItems.Controls.Add(this.lblItemRecordsTitle);
            this.gbxItems.Controls.Add(this.lblItemRecords);
            this.gbxItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItems.Location = new System.Drawing.Point(12, 191);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(620, 503);
            this.gbxItems.TabIndex = 13;
            this.gbxItems.TabStop = false;
            this.gbxItems.Text = "Item List";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.cmbFilterBy);
            this.gbxFilter.Controls.Add(this.txbFilterValue);
            this.gbxFilter.Location = new System.Drawing.Point(6, 73);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(369, 49);
            this.gbxFilter.TabIndex = 18;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // gbxUpdateData
            // 
            this.gbxUpdateData.Controls.Add(this.btnBrowseFile);
            this.gbxUpdateData.Controls.Add(this.lblUpdateStatus);
            this.gbxUpdateData.Controls.Add(this.ctrlButtonCardUpdate);
            this.gbxUpdateData.Controls.Add(this.txbFilePath);
            this.gbxUpdateData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateData.Location = new System.Drawing.Point(12, 41);
            this.gbxUpdateData.Name = "gbxUpdateData";
            this.gbxUpdateData.Size = new System.Drawing.Size(385, 144);
            this.gbxUpdateData.TabIndex = 14;
            this.gbxUpdateData.TabStop = false;
            this.gbxUpdateData.Text = "Update Stock";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUpdateStatus.Location = new System.Drawing.Point(139, 107);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(0, 16);
            this.lblUpdateStatus.TabIndex = 3;
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(138, 37);
            this.txbFilePath.Multiline = true;
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(230, 20);
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
            this.chbFastMode.Location = new System.Drawing.Point(193, 20);
            this.chbFastMode.Name = "chbFastMode";
            this.chbFastMode.Size = new System.Drawing.Size(169, 17);
            this.chbFastMode.TabIndex = 17;
            this.chbFastMode.Text = "Add / Remove By Double Click";
            this.chbFastMode.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(6, 16);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 24);
            this.btnSelectAll.TabIndex = 19;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.chbFastMode);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 46);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fast Mode";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Check_Point_Manager.Properties.Resources.Logo__2_;
            this.pcbLogo.Location = new System.Drawing.Point(1014, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(180, 175);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 16;
            this.pcbLogo.TabStop = false;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFile.Icon = global::Check_Point_Manager.Properties.Resources.search;
            this.btnBrowseFile.Location = new System.Drawing.Point(12, 21);
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
            this.ctrlButtonCardUpdate.Location = new System.Drawing.Point(12, 80);
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
            this.btnAddToGroup.Location = new System.Drawing.Point(495, 17);
            this.btnAddToGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(118, 50);
            this.btnAddToGroup.TabIndex = 16;
            this.btnAddToGroup.Title = "Add To Group";
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // pcbGroupsBackground
            // 
            this.pcbGroupsBackground.Enabled = false;
            this.pcbGroupsBackground.Image = global::Check_Point_Manager.Properties.Resources.Logo__2_;
            this.pcbGroupsBackground.Location = new System.Drawing.Point(115, 141);
            this.pcbGroupsBackground.Name = "pcbGroupsBackground";
            this.pcbGroupsBackground.Size = new System.Drawing.Size(342, 324);
            this.pcbGroupsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsBackground.TabIndex = 18;
            this.pcbGroupsBackground.TabStop = false;
            this.pcbGroupsBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbGroupsBackground_Paint);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportFile.Icon = global::Check_Point_Manager.Properties.Resources.share__1_;
            this.btnExportFile.Location = new System.Drawing.Point(307, 15);
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
            this.btnManageGroups.Location = new System.Drawing.Point(435, 15);
            this.btnManageGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(121, 50);
            this.btnManageGroups.TabIndex = 16;
            this.btnManageGroups.Title = "Manage Groups";
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
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
            this.ClientSize = new System.Drawing.Size(1207, 703);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.gbxUpdateData);
            this.Controls.Add(this.gbxItems);
            this.Controls.Add(this.gbxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Point Assistant";
            this.Load += new System.EventHandler(this.frmListItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).EndInit();
            this.cmsGroupOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).EndInit();
            this.gbxGroups.ResumeLayout(false);
            this.gbxGroups.PerformLayout();
            this.gbxItems.ResumeLayout(false);
            this.gbxItems.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.gbxUpdateData.ResumeLayout(false);
            this.gbxUpdateData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}

