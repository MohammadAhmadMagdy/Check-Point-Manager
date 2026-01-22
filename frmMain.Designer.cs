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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListItems));
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.cmsGroupOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.cmbItemsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.gbxGroups = new System.Windows.Forms.GroupBox();
            this.gbxFilterGroups = new System.Windows.Forms.GroupBox();
            this.btnGroupsSelectAll = new System.Windows.Forms.Button();
            this.cmbGroupsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbGroupsFilterValue = new System.Windows.Forms.TextBox();
            this.lblSelectGroupTitle = new System.Windows.Forms.Label();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.chbFastMode = new System.Windows.Forms.CheckBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.gbxUpdateData = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChooseFile = new System.Windows.Forms.Label();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.pcbGroupsBackground = new System.Windows.Forms.PictureBox();
            this.deleteFromGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportFile = new Check_Point_Manager.ctrlButtonCard();
            this.btnBrowseFile = new Check_Point_Manager.ctrlButtonCard();
            this.btnManageGroups = new Check_Point_Manager.ctrlButtonCard();
            this.ctrlButtonCardUpdate = new Check_Point_Manager.ctrlButtonCard();
            this.btnAddToGroup = new Check_Point_Manager.ctrlButtonCard();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            this.cmsGroupOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.gbxGroups.SuspendLayout();
            this.gbxFilterGroups.SuspendLayout();
            this.gbxItems.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.gbxUpdateData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(4, 559);
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
            this.lblItemRecords.Location = new System.Drawing.Point(87, 559);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(21, 14);
            this.lblItemRecords.TabIndex = 3;
            this.lblItemRecords.Text = "??";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(6, 41);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(521, 22);
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
            this.dgvGroupItems.Location = new System.Drawing.Point(6, 118);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.ReadOnly = true;
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(521, 438);
            this.dgvGroupItems.TabIndex = 9;
            this.dgvGroupItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupItems_CellDoubleClick);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllStockList.Location = new System.Drawing.Point(6, 118);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(630, 438);
            this.dgvAllStockList.TabIndex = 0;
            this.dgvAllStockList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAllStockList_CellBeginEdit);
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellContentClick);
            this.dgvAllStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellDoubleClick);
            this.dgvAllStockList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllStockList_CellFormatting);
            // 
            // cmbItemsFilterBy
            // 
            this.cmbItemsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemsFilterBy.FormattingEnabled = true;
            this.cmbItemsFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description",
            "Group Name",
            "Not Assigned Items",
            "Newly Added Items"});
            this.cmbItemsFilterBy.Location = new System.Drawing.Point(7, 17);
            this.cmbItemsFilterBy.Name = "cmbItemsFilterBy";
            this.cmbItemsFilterBy.Size = new System.Drawing.Size(161, 22);
            this.cmbItemsFilterBy.TabIndex = 5;
            this.cmbItemsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
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
            this.gbxGroups.Controls.Add(this.gbxFilterGroups);
            this.gbxGroups.Controls.Add(this.pcbGroupsBackground);
            this.gbxGroups.Controls.Add(this.lblSelectGroupTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecordTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecord);
            this.gbxGroups.Controls.Add(this.dgvGroupItems);
            this.gbxGroups.Controls.Add(this.cmbGroups);
            this.gbxGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGroups.Location = new System.Drawing.Point(661, 12);
            this.gbxGroups.Name = "gbxGroups";
            this.gbxGroups.Size = new System.Drawing.Size(534, 588);
            this.gbxGroups.TabIndex = 12;
            this.gbxGroups.TabStop = false;
            this.gbxGroups.Text = "Groups";
            // 
            // gbxFilterGroups
            // 
            this.gbxFilterGroups.Controls.Add(this.btnGroupsSelectAll);
            this.gbxFilterGroups.Controls.Add(this.cmbGroupsFilterBy);
            this.gbxFilterGroups.Controls.Add(this.txbGroupsFilterValue);
            this.gbxFilterGroups.Location = new System.Drawing.Point(6, 67);
            this.gbxFilterGroups.Name = "gbxFilterGroups";
            this.gbxFilterGroups.Size = new System.Drawing.Size(481, 49);
            this.gbxFilterGroups.TabIndex = 19;
            this.gbxFilterGroups.TabStop = false;
            this.gbxFilterGroups.Text = "Filter";
            // 
            // btnGroupsSelectAll
            // 
            this.btnGroupsSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGroupsSelectAll.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupsSelectAll.Location = new System.Drawing.Point(369, 15);
            this.btnGroupsSelectAll.Name = "btnGroupsSelectAll";
            this.btnGroupsSelectAll.Size = new System.Drawing.Size(75, 24);
            this.btnGroupsSelectAll.TabIndex = 20;
            this.btnGroupsSelectAll.Text = "Select All";
            this.btnGroupsSelectAll.UseVisualStyleBackColor = true;
            this.btnGroupsSelectAll.Click += new System.EventHandler(this.btnGroupsSelectAll_Click);
            // 
            // cmbGroupsFilterBy
            // 
            this.cmbGroupsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupsFilterBy.FormattingEnabled = true;
            this.cmbGroupsFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description"});
            this.cmbGroupsFilterBy.Location = new System.Drawing.Point(7, 17);
            this.cmbGroupsFilterBy.Name = "cmbGroupsFilterBy";
            this.cmbGroupsFilterBy.Size = new System.Drawing.Size(161, 22);
            this.cmbGroupsFilterBy.TabIndex = 5;
            this.cmbGroupsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbGroupsFilterBy_SelectedIndexChanged);
            // 
            // txbGroupsFilterValue
            // 
            this.txbGroupsFilterValue.Location = new System.Drawing.Point(174, 17);
            this.txbGroupsFilterValue.Name = "txbGroupsFilterValue";
            this.txbGroupsFilterValue.Size = new System.Drawing.Size(189, 22);
            this.txbGroupsFilterValue.TabIndex = 6;
            this.txbGroupsFilterValue.TextChanged += new System.EventHandler(this.txbGroupsFilterValue_TextChanged);
            this.txbGroupsFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGroupsFilterValue_KeyPress);
            // 
            // lblSelectGroupTitle
            // 
            this.lblSelectGroupTitle.AutoSize = true;
            this.lblSelectGroupTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroupTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSelectGroupTitle.Location = new System.Drawing.Point(3, 21);
            this.lblSelectGroupTitle.Name = "lblSelectGroupTitle";
            this.lblSelectGroupTitle.Size = new System.Drawing.Size(104, 14);
            this.lblSelectGroupTitle.TabIndex = 16;
            this.lblSelectGroupTitle.Text = "Select a Group :";
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(6, 559);
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
            this.lblGroupRecord.Location = new System.Drawing.Point(89, 559);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(21, 14);
            this.lblGroupRecord.TabIndex = 12;
            this.lblGroupRecord.Text = "??";
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.chbFastMode);
            this.gbxItems.Controls.Add(this.gbxFilter);
            this.gbxItems.Controls.Add(this.btnAddToGroup);
            this.gbxItems.Controls.Add(this.dgvAllStockList);
            this.gbxItems.Controls.Add(this.lblItemRecordsTitle);
            this.gbxItems.Controls.Add(this.lblItemRecords);
            this.gbxItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItems.Location = new System.Drawing.Point(12, 12);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(643, 588);
            this.gbxItems.TabIndex = 13;
            this.gbxItems.TabStop = false;
            this.gbxItems.Text = "Item List";
            // 
            // chbFastMode
            // 
            this.chbFastMode.AutoSize = true;
            this.chbFastMode.ForeColor = System.Drawing.Color.DarkBlue;
            this.chbFastMode.Location = new System.Drawing.Point(6, 30);
            this.chbFastMode.Name = "chbFastMode";
            this.chbFastMode.Size = new System.Drawing.Size(191, 18);
            this.chbFastMode.TabIndex = 17;
            this.chbFastMode.Text = "Add / Remove By Double Click";
            this.chbFastMode.UseVisualStyleBackColor = true;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnSelectAll);
            this.gbxFilter.Controls.Add(this.cmbItemsFilterBy);
            this.gbxFilter.Controls.Add(this.txbFilterValue);
            this.gbxFilter.Location = new System.Drawing.Point(6, 67);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(481, 49);
            this.gbxFilter.TabIndex = 18;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(369, 15);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 24);
            this.btnSelectAll.TabIndex = 19;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // gbxUpdateData
            // 
            this.gbxUpdateData.Controls.Add(this.panel1);
            this.gbxUpdateData.Controls.Add(this.lblChooseFile);
            this.gbxUpdateData.Controls.Add(this.btnExportFile);
            this.gbxUpdateData.Controls.Add(this.btnBrowseFile);
            this.gbxUpdateData.Controls.Add(this.btnManageGroups);
            this.gbxUpdateData.Controls.Add(this.lblUpdateStatus);
            this.gbxUpdateData.Controls.Add(this.ctrlButtonCardUpdate);
            this.gbxUpdateData.Controls.Add(this.txbFilePath);
            this.gbxUpdateData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateData.Location = new System.Drawing.Point(12, 606);
            this.gbxUpdateData.Name = "gbxUpdateData";
            this.gbxUpdateData.Size = new System.Drawing.Size(1183, 85);
            this.gbxUpdateData.TabIndex = 14;
            this.gbxUpdateData.TabStop = false;
            this.gbxUpdateData.Text = "Update Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(847, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 50);
            this.panel1.TabIndex = 18;
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFile.Location = new System.Drawing.Point(6, 41);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(83, 14);
            this.lblChooseFile.TabIndex = 17;
            this.lblChooseFile.Text = "Choose File :";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUpdateStatus.Location = new System.Drawing.Point(631, 39);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(56, 16);
            this.lblUpdateStatus.TabIndex = 3;
            this.lblUpdateStatus.Text = "???????";
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(95, 24);
            this.txbFilePath.Multiline = true;
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(246, 47);
            this.txbFilePath.TabIndex = 1;
            // 
            // pcbGroupsBackground
            // 
            this.pcbGroupsBackground.Enabled = false;
            this.pcbGroupsBackground.Image = global::Check_Point_Manager.Properties.Resources.Logo__2_;
            this.pcbGroupsBackground.Location = new System.Drawing.Point(20, 132);
            this.pcbGroupsBackground.Name = "pcbGroupsBackground";
            this.pcbGroupsBackground.Size = new System.Drawing.Size(494, 409);
            this.pcbGroupsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsBackground.TabIndex = 18;
            this.pcbGroupsBackground.TabStop = false;
            this.pcbGroupsBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbGroupsBackground_Paint);
            // 
            // deleteFromGroupToolStripMenuItem
            // 
            this.deleteFromGroupToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.recycle_bin;
            this.deleteFromGroupToolStripMenuItem.Name = "deleteFromGroupToolStripMenuItem";
            this.deleteFromGroupToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteFromGroupToolStripMenuItem.Text = "Delete From Group";
            this.deleteFromGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteFromGroupToolStripMenuItem_Click);
            // 
            // btnExportFile
            // 
            this.btnExportFile.ButtonType = Check_Point_Manager.ctrlButtonCard.enButtonCardType.Primary;
            this.btnExportFile.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnExportFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportFile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.btnExportFile.Icon = global::Check_Point_Manager.Properties.Resources.share__1_;
            this.btnExportFile.Location = new System.Drawing.Point(927, 21);
            this.btnExportFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btnExportFile.Size = new System.Drawing.Size(120, 50);
            this.btnExportFile.TabIndex = 17;
            this.btnExportFile.Title = "Export File";
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.ButtonType = Check_Point_Manager.ctrlButtonCard.enButtonCardType.Primary;
            this.btnBrowseFile.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.btnBrowseFile.Icon = global::Check_Point_Manager.Properties.Resources.search;
            this.btnBrowseFile.Location = new System.Drawing.Point(369, 21);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btnBrowseFile.Size = new System.Drawing.Size(120, 53);
            this.btnBrowseFile.TabIndex = 16;
            this.btnBrowseFile.Title = "Browse File";
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.ButtonType = Check_Point_Manager.ctrlButtonCard.enButtonCardType.Primary;
            this.btnManageGroups.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnManageGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageGroups.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.btnManageGroups.Icon = global::Check_Point_Manager.Properties.Resources.touch;
            this.btnManageGroups.Location = new System.Drawing.Point(1055, 21);
            this.btnManageGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btnManageGroups.Size = new System.Drawing.Size(121, 50);
            this.btnManageGroups.TabIndex = 16;
            this.btnManageGroups.Title = "Manage Groups";
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // ctrlButtonCardUpdate
            // 
            this.ctrlButtonCardUpdate.ButtonType = Check_Point_Manager.ctrlButtonCard.enButtonCardType.Secondary;
            this.ctrlButtonCardUpdate.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(160)))));
            this.ctrlButtonCardUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrlButtonCardUpdate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(190)))));
            this.ctrlButtonCardUpdate.Icon = global::Check_Point_Manager.Properties.Resources.data_processing;
            this.ctrlButtonCardUpdate.Location = new System.Drawing.Point(497, 21);
            this.ctrlButtonCardUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlButtonCardUpdate.Name = "ctrlButtonCardUpdate";
            this.ctrlButtonCardUpdate.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(220)))));
            this.ctrlButtonCardUpdate.Size = new System.Drawing.Size(120, 53);
            this.ctrlButtonCardUpdate.TabIndex = 2;
            this.ctrlButtonCardUpdate.Title = "Update Stock";
            this.ctrlButtonCardUpdate.Click += new System.EventHandler(this.ctrlButtonCardUpdate_Click);
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.ButtonType = Check_Point_Manager.ctrlButtonCard.enButtonCardType.Primary;
            this.btnAddToGroup.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnAddToGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToGroup.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.btnAddToGroup.Icon = global::Check_Point_Manager.Properties.Resources.right;
            this.btnAddToGroup.Location = new System.Drawing.Point(518, 17);
            this.btnAddToGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btnAddToGroup.Size = new System.Drawing.Size(118, 50);
            this.btnAddToGroup.TabIndex = 16;
            this.btnAddToGroup.Title = "Add To Group";
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 703);
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
            this.gbxFilterGroups.ResumeLayout(false);
            this.gbxFilterGroups.PerformLayout();
            this.gbxItems.ResumeLayout(false);
            this.gbxItems.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.gbxUpdateData.ResumeLayout(false);
            this.gbxUpdateData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblItemRecordsTitle;
        private System.Windows.Forms.Label lblItemRecords;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridView dgvGroupItems;
        private System.Windows.Forms.DataGridView dgvAllStockList;
        private System.Windows.Forms.ComboBox cmbItemsFilterBy;
        private System.Windows.Forms.TextBox txbFilterValue;
        private System.Windows.Forms.GroupBox gbxGroups;
        private System.Windows.Forms.GroupBox gbxItems;
        private System.Windows.Forms.Label lblGroupRecordTitle;
        private System.Windows.Forms.Label lblGroupRecord;
      
        
        private System.Windows.Forms.GroupBox gbxUpdateData;
       
        private ctrlButtonCard ctrlButtonCardUpdate;
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Label lblUpdateStatus;
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
        private System.Windows.Forms.Label lblChooseFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxFilterGroups;
        private System.Windows.Forms.ComboBox cmbGroupsFilterBy;
        private System.Windows.Forms.TextBox txbGroupsFilterValue;
        private System.Windows.Forms.Button btnGroupsSelectAll;
    }
}

