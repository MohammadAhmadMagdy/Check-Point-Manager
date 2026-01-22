namespace Check_Point_Manager
{
    partial class frmMainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlItemsList = new System.Windows.Forms.Panel();
            this.chbFastMode = new System.Windows.Forms.CheckBox();
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lblSearchItems = new System.Windows.Forms.Label();
            this.cmbItemsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.lblItemsListTitle = new System.Windows.Forms.Label();
            this.pnlAllItemsSep = new System.Windows.Forms.Panel();
            this.pnlGroupsList = new System.Windows.Forms.Panel();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.btnGroupsSelectAll = new System.Windows.Forms.Button();
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.lblSearchGroup = new System.Windows.Forms.Label();
            this.cmbGroupsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbGroupsFilterValue = new System.Windows.Forms.TextBox();
            this.pnlGroupsListSep = new System.Windows.Forms.Panel();
            this.lblGroupsListTitle = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.pnlActionSep2 = new System.Windows.Forms.Panel();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.lblChooseFile = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.pnlActionSep1 = new System.Windows.Forms.Panel();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.pcbUpdateStock = new System.Windows.Forms.PictureBox();
            this.pcbGroupsBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbGroupsList = new System.Windows.Forms.PictureBox();
            this.btnAddToGroup = new System.Windows.Forms.Button();
            this.pcbSelectAll = new System.Windows.Forms.PictureBox();
            this.pcbItemsList = new System.Windows.Forms.PictureBox();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlUpdateInfo = new System.Windows.Forms.Panel();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.pnlGroupsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdateStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSelectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.pnlUpdateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1305, 35);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(86)))), ((int)(((byte)(146)))));
            this.lblHeader.Location = new System.Drawing.Point(35, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(218, 30);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Checkpoint Manager";
            // 
            // pnlItemsList
            // 
            this.pnlItemsList.BackColor = System.Drawing.Color.White;
            this.pnlItemsList.Controls.Add(this.btnAddToGroup);
            this.pnlItemsList.Controls.Add(this.chbFastMode);
            this.pnlItemsList.Controls.Add(this.lblItemRecordsTitle);
            this.pnlItemsList.Controls.Add(this.lblItemRecords);
            this.pnlItemsList.Controls.Add(this.dgvAllStockList);
            this.pnlItemsList.Controls.Add(this.pcbSelectAll);
            this.pnlItemsList.Controls.Add(this.btnSelectAll);
            this.pnlItemsList.Controls.Add(this.lblSearchItems);
            this.pnlItemsList.Controls.Add(this.cmbItemsFilterBy);
            this.pnlItemsList.Controls.Add(this.txbFilterValue);
            this.pnlItemsList.Controls.Add(this.pcbItemsList);
            this.pnlItemsList.Controls.Add(this.lblItemsListTitle);
            this.pnlItemsList.Controls.Add(this.pnlAllItemsSep);
            this.pnlItemsList.Location = new System.Drawing.Point(9, 41);
            this.pnlItemsList.Name = "pnlItemsList";
            this.pnlItemsList.Size = new System.Drawing.Size(640, 527);
            this.pnlItemsList.TabIndex = 2;
            // 
            // chbFastMode
            // 
            this.chbFastMode.AutoSize = true;
            this.chbFastMode.ForeColor = System.Drawing.Color.DarkBlue;
            this.chbFastMode.Location = new System.Drawing.Point(122, 83);
            this.chbFastMode.Name = "chbFastMode";
            this.chbFastMode.Size = new System.Drawing.Size(169, 17);
            this.chbFastMode.TabIndex = 25;
            this.chbFastMode.Text = "Add / Remove By Double Click";
            this.chbFastMode.UseVisualStyleBackColor = true;
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(7, 503);
            this.lblItemRecordsTitle.Name = "lblItemRecordsTitle";
            this.lblItemRecordsTitle.Size = new System.Drawing.Size(77, 14);
            this.lblItemRecordsTitle.TabIndex = 23;
            this.lblItemRecordsTitle.Text = "# Records :";
            // 
            // lblItemRecords
            // 
            this.lblItemRecords.AutoSize = true;
            this.lblItemRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemRecords.Location = new System.Drawing.Point(90, 503);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(21, 14);
            this.lblItemRecords.TabIndex = 24;
            this.lblItemRecords.Text = "??";
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
            this.dgvAllStockList.Location = new System.Drawing.Point(11, 107);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(615, 393);
            this.dgvAllStockList.TabIndex = 22;
            this.dgvAllStockList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAllStockList_CellBeginEdit);
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellContentClick);
            this.dgvAllStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellDoubleClick);
            this.dgvAllStockList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllStockList_CellFormatting);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(198)))));
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(45, 80);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(67, 21);
            this.btnSelectAll.TabIndex = 20;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lblSearchItems
            // 
            this.lblSearchItems.AutoSize = true;
            this.lblSearchItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItems.Location = new System.Drawing.Point(376, 54);
            this.lblSearchItems.Name = "lblSearchItems";
            this.lblSearchItems.Size = new System.Drawing.Size(48, 17);
            this.lblSearchItems.TabIndex = 9;
            this.lblSearchItems.Text = "Search";
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
            this.cmbItemsFilterBy.Location = new System.Drawing.Point(14, 53);
            this.cmbItemsFilterBy.Name = "cmbItemsFilterBy";
            this.cmbItemsFilterBy.Size = new System.Drawing.Size(161, 21);
            this.cmbItemsFilterBy.TabIndex = 7;
            this.cmbItemsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(181, 54);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(189, 20);
            this.txbFilterValue.TabIndex = 8;
            this.txbFilterValue.TextChanged += new System.EventHandler(this.txbFilterValue_TextChanged);
            // 
            // lblItemsListTitle
            // 
            this.lblItemsListTitle.AutoSize = true;
            this.lblItemsListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsListTitle.Location = new System.Drawing.Point(41, 18);
            this.lblItemsListTitle.Name = "lblItemsListTitle";
            this.lblItemsListTitle.Size = new System.Drawing.Size(101, 20);
            this.lblItemsListTitle.TabIndex = 1;
            this.lblItemsListTitle.Text = "All Items List";
            // 
            // pnlAllItemsSep
            // 
            this.pnlAllItemsSep.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAllItemsSep.Location = new System.Drawing.Point(14, 46);
            this.pnlAllItemsSep.Name = "pnlAllItemsSep";
            this.pnlAllItemsSep.Size = new System.Drawing.Size(615, 2);
            this.pnlAllItemsSep.TabIndex = 0;
            // 
            // pnlGroupsList
            // 
            this.pnlGroupsList.BackColor = System.Drawing.Color.White;
            this.pnlGroupsList.Controls.Add(this.btnRemoveItems);
            this.pnlGroupsList.Controls.Add(this.lblGroupRecordTitle);
            this.pnlGroupsList.Controls.Add(this.lblGroupRecord);
            this.pnlGroupsList.Controls.Add(this.pcbGroupsBackground);
            this.pnlGroupsList.Controls.Add(this.dgvGroupItems);
            this.pnlGroupsList.Controls.Add(this.pictureBox1);
            this.pnlGroupsList.Controls.Add(this.btnGroupsSelectAll);
            this.pnlGroupsList.Controls.Add(this.lblSelectGroup);
            this.pnlGroupsList.Controls.Add(this.cmbGroups);
            this.pnlGroupsList.Controls.Add(this.lblSearchGroup);
            this.pnlGroupsList.Controls.Add(this.cmbGroupsFilterBy);
            this.pnlGroupsList.Controls.Add(this.txbGroupsFilterValue);
            this.pnlGroupsList.Controls.Add(this.pcbGroupsList);
            this.pnlGroupsList.Controls.Add(this.pnlGroupsListSep);
            this.pnlGroupsList.Controls.Add(this.lblGroupsListTitle);
            this.pnlGroupsList.Location = new System.Drawing.Point(656, 41);
            this.pnlGroupsList.Name = "pnlGroupsList";
            this.pnlGroupsList.Size = new System.Drawing.Size(640, 527);
            this.pnlGroupsList.TabIndex = 3;
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(7, 503);
            this.lblGroupRecordTitle.Name = "lblGroupRecordTitle";
            this.lblGroupRecordTitle.Size = new System.Drawing.Size(77, 14);
            this.lblGroupRecordTitle.TabIndex = 28;
            this.lblGroupRecordTitle.Text = "# Records :";
            // 
            // lblGroupRecord
            // 
            this.lblGroupRecord.AutoSize = true;
            this.lblGroupRecord.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGroupRecord.Location = new System.Drawing.Point(90, 503);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(21, 14);
            this.lblGroupRecord.TabIndex = 29;
            this.lblGroupRecord.Text = "??";
            // 
            // dgvGroupItems
            // 
            this.dgvGroupItems.AllowUserToAddRows = false;
            this.dgvGroupItems.AllowUserToDeleteRows = false;
            this.dgvGroupItems.AllowUserToOrderColumns = true;
            this.dgvGroupItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroupItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupItems.Location = new System.Drawing.Point(11, 107);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.ReadOnly = true;
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(615, 393);
            this.dgvGroupItems.TabIndex = 26;
            this.dgvGroupItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupItems_CellDoubleClick);
            // 
            // btnGroupsSelectAll
            // 
            this.btnGroupsSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(198)))));
            this.btnGroupsSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGroupsSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGroupsSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnGroupsSelectAll.Location = new System.Drawing.Point(45, 79);
            this.btnGroupsSelectAll.Name = "btnGroupsSelectAll";
            this.btnGroupsSelectAll.Size = new System.Drawing.Size(67, 21);
            this.btnGroupsSelectAll.TabIndex = 25;
            this.btnGroupsSelectAll.Text = "Select All";
            this.btnGroupsSelectAll.UseVisualStyleBackColor = false;
            this.btnGroupsSelectAll.Click += new System.EventHandler(this.btnGroupsSelectAll_Click);
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroup.Location = new System.Drawing.Point(15, 53);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(103, 17);
            this.lblSelectGroup.TabIndex = 24;
            this.lblSelectGroup.Text = "Select a Group :";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(124, 52);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(505, 21);
            this.cmbGroups.TabIndex = 23;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // lblSearchGroup
            // 
            this.lblSearchGroup.AutoSize = true;
            this.lblSearchGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGroup.Location = new System.Drawing.Point(486, 80);
            this.lblSearchGroup.Name = "lblSearchGroup";
            this.lblSearchGroup.Size = new System.Drawing.Size(48, 17);
            this.lblSearchGroup.TabIndex = 22;
            this.lblSearchGroup.Text = "Search";
            // 
            // cmbGroupsFilterBy
            // 
            this.cmbGroupsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupsFilterBy.FormattingEnabled = true;
            this.cmbGroupsFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description"});
            this.cmbGroupsFilterBy.Location = new System.Drawing.Point(124, 79);
            this.cmbGroupsFilterBy.Name = "cmbGroupsFilterBy";
            this.cmbGroupsFilterBy.Size = new System.Drawing.Size(161, 21);
            this.cmbGroupsFilterBy.TabIndex = 7;
            this.cmbGroupsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbGroupsFilterBy_SelectedIndexChanged);
            // 
            // txbGroupsFilterValue
            // 
            this.txbGroupsFilterValue.Location = new System.Drawing.Point(291, 80);
            this.txbGroupsFilterValue.Name = "txbGroupsFilterValue";
            this.txbGroupsFilterValue.Size = new System.Drawing.Size(189, 20);
            this.txbGroupsFilterValue.TabIndex = 8;
            this.txbGroupsFilterValue.TextChanged += new System.EventHandler(this.txbGroupsFilterValue_TextChanged);
            // 
            // pnlGroupsListSep
            // 
            this.pnlGroupsListSep.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlGroupsListSep.Location = new System.Drawing.Point(14, 45);
            this.pnlGroupsListSep.Name = "pnlGroupsListSep";
            this.pnlGroupsListSep.Size = new System.Drawing.Size(615, 2);
            this.pnlGroupsListSep.TabIndex = 0;
            // 
            // lblGroupsListTitle
            // 
            this.lblGroupsListTitle.AutoSize = true;
            this.lblGroupsListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupsListTitle.Location = new System.Drawing.Point(41, 18);
            this.lblGroupsListTitle.Name = "lblGroupsListTitle";
            this.lblGroupsListTitle.Size = new System.Drawing.Size(97, 20);
            this.lblGroupsListTitle.TabIndex = 3;
            this.lblGroupsListTitle.Text = "Group Items";
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.White;
            this.pnlAction.Controls.Add(this.pnlUpdateInfo);
            this.pnlAction.Controls.Add(this.btnManageGroups);
            this.pnlAction.Controls.Add(this.btnExportFile);
            this.pnlAction.Controls.Add(this.btnUpdate);
            this.pnlAction.Controls.Add(this.btnBrowseFile);
            this.pnlAction.Controls.Add(this.pnlActionSep2);
            this.pnlAction.Controls.Add(this.txbFilePath);
            this.pnlAction.Controls.Add(this.lblChooseFile);
            this.pnlAction.Controls.Add(this.pcbUpdateStock);
            this.pnlAction.Controls.Add(this.lblUpdateStock);
            this.pnlAction.Controls.Add(this.pnlActionSep1);
            this.pnlAction.Location = new System.Drawing.Point(9, 574);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(1287, 143);
            this.pnlAction.TabIndex = 4;
            // 
            // pnlActionSep2
            // 
            this.pnlActionSep2.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlActionSep2.Location = new System.Drawing.Point(13, 88);
            this.pnlActionSep2.Name = "pnlActionSep2";
            this.pnlActionSep2.Size = new System.Drawing.Size(1255, 2);
            this.pnlActionSep2.TabIndex = 2;
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(72)))));
            this.lblUpdateStatus.Location = new System.Drawing.Point(36, 9);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(266, 17);
            this.lblUpdateStatus.TabIndex = 20;
            this.lblUpdateStatus.Text = "Please Update Stock Before Exporting File";
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(96, 54);
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(246, 20);
            this.txbFilePath.TabIndex = 19;
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFile.Location = new System.Drawing.Point(10, 58);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(83, 14);
            this.lblChooseFile.TabIndex = 18;
            this.lblChooseFile.Text = "Choose File :";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(44, 11);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(102, 20);
            this.lblUpdateStock.TabIndex = 3;
            this.lblUpdateStock.Text = "Update Stock";
            // 
            // pnlActionSep1
            // 
            this.pnlActionSep1.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlActionSep1.Location = new System.Drawing.Point(13, 39);
            this.pnlActionSep1.Name = "pnlActionSep1";
            this.pnlActionSep1.Size = new System.Drawing.Size(1255, 2);
            this.pnlActionSep1.TabIndex = 1;
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnManageGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGroups.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnManageGroups.Image = global::Check_Point_Manager.Properties.Resources.manage_25;
            this.btnManageGroups.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageGroups.Location = new System.Drawing.Point(623, 96);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(172, 37);
            this.btnManageGroups.TabIndex = 29;
            this.btnManageGroups.Text = "Manage Groups";
            this.btnManageGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageGroups.UseVisualStyleBackColor = false;
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // btnExportFile
            // 
            this.btnExportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(126)))), ((int)(((byte)(201)))));
            this.btnExportFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.ForeColor = System.Drawing.Color.White;
            this.btnExportFile.Image = global::Check_Point_Manager.Properties.Resources.downloading_updates_25;
            this.btnExportFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportFile.Location = new System.Drawing.Point(486, 96);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(123, 38);
            this.btnExportFile.TabIndex = 27;
            this.btnExportFile.Text = "  Export";
            this.btnExportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFile.UseVisualStyleBackColor = false;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(118)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Check_Point_Manager.Properties.Resources.data_update_25;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(401, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 35);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Stock";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnBrowseFile.BackgroundImage = global::Check_Point_Manager.Properties.Resources.folder;
            this.btnBrowseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseFile.Location = new System.Drawing.Point(348, 48);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(47, 31);
            this.btnBrowseFile.TabIndex = 27;
            this.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // pcbUpdateStock
            // 
            this.pcbUpdateStock.Image = global::Check_Point_Manager.Properties.Resources.data_processing1;
            this.pcbUpdateStock.Location = new System.Drawing.Point(9, 11);
            this.pcbUpdateStock.Name = "pcbUpdateStock";
            this.pcbUpdateStock.Size = new System.Drawing.Size(29, 21);
            this.pcbUpdateStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUpdateStock.TabIndex = 4;
            this.pcbUpdateStock.TabStop = false;
            // 
            // pcbGroupsBackground
            // 
            this.pcbGroupsBackground.Enabled = false;
            this.pcbGroupsBackground.Image = global::Check_Point_Manager.Properties.Resources.Logo__2_;
            this.pcbGroupsBackground.Location = new System.Drawing.Point(18, 116);
            this.pcbGroupsBackground.Name = "pcbGroupsBackground";
            this.pcbGroupsBackground.Size = new System.Drawing.Size(604, 373);
            this.pcbGroupsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsBackground.TabIndex = 27;
            this.pcbGroupsBackground.TabStop = false;
            this.pcbGroupsBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbGroupsBackground_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Check_Point_Manager.Properties.Resources.add1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pcbGroupsList
            // 
            this.pcbGroupsList.Image = global::Check_Point_Manager.Properties.Resources.article;
            this.pcbGroupsList.Location = new System.Drawing.Point(14, 18);
            this.pcbGroupsList.Name = "pcbGroupsList";
            this.pcbGroupsList.Size = new System.Drawing.Size(29, 21);
            this.pcbGroupsList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsList.TabIndex = 4;
            this.pcbGroupsList.TabStop = false;
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnAddToGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnAddToGroup.Image = global::Check_Point_Manager.Properties.Resources.hand_right_20;
            this.btnAddToGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToGroup.Location = new System.Drawing.Point(505, 8);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(124, 31);
            this.btnAddToGroup.TabIndex = 26;
            this.btnAddToGroup.Text = "Add To Group";
            this.btnAddToGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddToGroup.UseVisualStyleBackColor = false;
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // pcbSelectAll
            // 
            this.pcbSelectAll.Image = global::Check_Point_Manager.Properties.Resources.add1;
            this.pcbSelectAll.Location = new System.Drawing.Point(14, 80);
            this.pcbSelectAll.Name = "pcbSelectAll";
            this.pcbSelectAll.Size = new System.Drawing.Size(29, 21);
            this.pcbSelectAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSelectAll.TabIndex = 21;
            this.pcbSelectAll.TabStop = false;
            // 
            // pcbItemsList
            // 
            this.pcbItemsList.Image = global::Check_Point_Manager.Properties.Resources.touch;
            this.pcbItemsList.Location = new System.Drawing.Point(14, 18);
            this.pcbItemsList.Name = "pcbItemsList";
            this.pcbItemsList.Size = new System.Drawing.Size(29, 21);
            this.pcbItemsList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbItemsList.TabIndex = 2;
            this.pcbItemsList.TabStop = false;
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcon.Image = global::Check_Point_Manager.Properties.Resources.article;
            this.pcbIcon.Location = new System.Drawing.Point(5, 5);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(24, 24);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Check_Point_Manager.Properties.Resources.icons8_exit_60;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1277, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::Check_Point_Manager.Properties.Resources.icons8_minimize_90;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1246, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 24);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlUpdateInfo
            // 
            this.pnlUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.pnlUpdateInfo.Controls.Add(this.lblUpdateStatus);
            this.pnlUpdateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(72)))));
            this.pnlUpdateInfo.Location = new System.Drawing.Point(584, 47);
            this.pnlUpdateInfo.Name = "pnlUpdateInfo";
            this.pnlUpdateInfo.Size = new System.Drawing.Size(479, 35);
            this.pnlUpdateInfo.TabIndex = 27;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRemoveItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemoveItems.Image = global::Check_Point_Manager.Properties.Resources.hand_left_20;
            this.btnRemoveItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItems.Location = new System.Drawing.Point(462, 8);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(167, 31);
            this.btnRemoveItems.TabIndex = 27;
            this.btnRemoveItems.Text = "Remove From Group";
            this.btnRemoveItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1305, 725);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlGroupsList);
            this.Controls.Add(this.pnlItemsList);
            this.Controls.Add(this.pcbIcon);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckPoint Manager";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlItemsList.ResumeLayout(false);
            this.pnlItemsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).EndInit();
            this.pnlGroupsList.ResumeLayout(false);
            this.pnlGroupsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).EndInit();
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdateStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSelectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.pnlUpdateInfo.ResumeLayout(false);
            this.pnlUpdateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlItemsList;
        private System.Windows.Forms.Panel pnlAllItemsSep;
        private System.Windows.Forms.Panel pnlGroupsList;
        private System.Windows.Forms.Panel pnlGroupsListSep;
        private System.Windows.Forms.PictureBox pcbItemsList;
        private System.Windows.Forms.Label lblItemsListTitle;
        private System.Windows.Forms.PictureBox pcbGroupsList;
        private System.Windows.Forms.Label lblGroupsListTitle;
        private System.Windows.Forms.Label lblSearchItems;
        private System.Windows.Forms.ComboBox cmbItemsFilterBy;
        private System.Windows.Forms.TextBox txbFilterValue;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.PictureBox pcbSelectAll;
        private System.Windows.Forms.Label lblSearchGroup;
        private System.Windows.Forms.ComboBox cmbGroupsFilterBy;
        private System.Windows.Forms.TextBox txbGroupsFilterValue;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.Button btnGroupsSelectAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvGroupItems;
        private System.Windows.Forms.PictureBox pcbGroupsBackground;
        private System.Windows.Forms.DataGridView dgvAllStockList;
        private System.Windows.Forms.Label lblGroupRecordTitle;
        private System.Windows.Forms.Label lblGroupRecord;
        private System.Windows.Forms.Label lblItemRecordsTitle;
        private System.Windows.Forms.Label lblItemRecords;
        private System.Windows.Forms.CheckBox chbFastMode;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.PictureBox pcbUpdateStock;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Panel pnlActionSep1;
        private System.Windows.Forms.Label lblChooseFile;
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Panel pnlActionSep2;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Button btnAddToGroup;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Panel pnlUpdateInfo;
        private System.Windows.Forms.Button btnRemoveItems;
    }
}