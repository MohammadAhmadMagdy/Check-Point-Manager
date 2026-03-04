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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlItemsList = new System.Windows.Forms.Panel();
            this.btnVariationList = new System.Windows.Forms.Button();
            this.pcbItemsSearchIcon = new System.Windows.Forms.PictureBox();
            this.chbFastMode = new System.Windows.Forms.CheckBox();
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.btnAddToGroup = new System.Windows.Forms.Button();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.cmsItemOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recordItemVariationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.cmbItemsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.pcbItemsList = new System.Windows.Forms.PictureBox();
            this.lblItemsListTitle = new System.Windows.Forms.Label();
            this.pnlAllItemsSep = new System.Windows.Forms.Panel();
            this.pnlGroupsList = new System.Windows.Forms.Panel();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.lblGroupCheckedTitle = new System.Windows.Forms.Label();
            this.lblGroupCheckedCounter = new System.Windows.Forms.Label();
            this.pcbGroupSearchIcon = new System.Windows.Forms.PictureBox();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.btnGroupsSelectAll = new System.Windows.Forms.Button();
            this.pcbGroupsBackground = new System.Windows.Forms.PictureBox();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.cmbGroupsFilterBy = new System.Windows.Forms.ComboBox();
            this.txbGroupsFilterValue = new System.Windows.Forms.TextBox();
            this.pcbGroupsList = new System.Windows.Forms.PictureBox();
            this.pnlGroupsListSep = new System.Windows.Forms.Panel();
            this.lblGroupsListTitle = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.lblLastStockUpdateTitle = new System.Windows.Forms.Label();
            this.lblLastStockUpdate = new System.Windows.Forms.Label();
            this.pnlUpdateInfo = new System.Windows.Forms.Panel();
            this.pcbWarning = new System.Windows.Forms.PictureBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.pcbUpdateStock = new System.Windows.Forms.PictureBox();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lklShowCheckingHistory = new System.Windows.Forms.LinkLabel();
            this.lblLastGroupChecked = new System.Windows.Forms.Label();
            this.lblLastGroupCheckedTitle = new System.Windows.Forms.Label();
            this.btnClearNewItems = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlItemsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemsSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.cmsItemOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemsList)).BeginInit();
            this.pnlGroupsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsList)).BeginInit();
            this.pnlAction.SuspendLayout();
            this.pnlUpdateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdateStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblAppVersion);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1347, 35);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(86)))), ((int)(((byte)(146)))));
            this.lblAppVersion.Location = new System.Drawing.Point(250, 14);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(26, 15);
            this.lblAppVersion.TabIndex = 34;
            this.lblAppVersion.Text = "Ver.";
            this.lblAppVersion.DoubleClick += new System.EventHandler(this.lblAppVersion_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Check_Point_Manager.Properties.Resources.icons8_exit_60;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1315, 5);
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
            this.btnMinimize.Location = new System.Drawing.Point(1284, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 24);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(86)))), ((int)(((byte)(146)))));
            this.lblHeader.Location = new System.Drawing.Point(35, 2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(218, 30);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Checkpoint Manager";
            // 
            // pnlItemsList
            // 
            this.pnlItemsList.BackColor = System.Drawing.Color.White;
            this.pnlItemsList.Controls.Add(this.btnClearNewItems);
            this.pnlItemsList.Controls.Add(this.btnVariationList);
            this.pnlItemsList.Controls.Add(this.pcbItemsSearchIcon);
            this.pnlItemsList.Controls.Add(this.chbFastMode);
            this.pnlItemsList.Controls.Add(this.lblItemRecordsTitle);
            this.pnlItemsList.Controls.Add(this.btnAddToGroup);
            this.pnlItemsList.Controls.Add(this.lblItemRecords);
            this.pnlItemsList.Controls.Add(this.dgvAllStockList);
            this.pnlItemsList.Controls.Add(this.btnSelectAll);
            this.pnlItemsList.Controls.Add(this.cmbItemsFilterBy);
            this.pnlItemsList.Controls.Add(this.txbFilterValue);
            this.pnlItemsList.Controls.Add(this.pcbItemsList);
            this.pnlItemsList.Controls.Add(this.lblItemsListTitle);
            this.pnlItemsList.Controls.Add(this.pnlAllItemsSep);
            this.pnlItemsList.Location = new System.Drawing.Point(6, 89);
            this.pnlItemsList.Name = "pnlItemsList";
            this.pnlItemsList.Size = new System.Drawing.Size(664, 625);
            this.pnlItemsList.TabIndex = 2;
            // 
            // btnVariationList
            // 
            this.btnVariationList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnVariationList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVariationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariationList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariationList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnVariationList.Image = global::Check_Point_Manager.Properties.Resources.Variation_24;
            this.btnVariationList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVariationList.Location = new System.Drawing.Point(482, 581);
            this.btnVariationList.Name = "btnVariationList";
            this.btnVariationList.Size = new System.Drawing.Size(172, 37);
            this.btnVariationList.TabIndex = 30;
            this.btnVariationList.Text = "Variations List";
            this.btnVariationList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariationList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVariationList.UseVisualStyleBackColor = false;
            this.btnVariationList.Click += new System.EventHandler(this.btnVariationList_Click);
            // 
            // pcbItemsSearchIcon
            // 
            this.pcbItemsSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbItemsSearchIcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pcbItemsSearchIcon.Image = global::Check_Point_Manager.Properties.Resources.search_icon;
            this.pcbItemsSearchIcon.Location = new System.Drawing.Point(349, 64);
            this.pcbItemsSearchIcon.Name = "pcbItemsSearchIcon";
            this.pcbItemsSearchIcon.Size = new System.Drawing.Size(16, 16);
            this.pcbItemsSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbItemsSearchIcon.TabIndex = 29;
            this.pcbItemsSearchIcon.TabStop = false;
            this.pcbItemsSearchIcon.Click += new System.EventHandler(this.pcbItemsSearchIcon_Click);
            // 
            // chbFastMode
            // 
            this.chbFastMode.AutoSize = true;
            this.chbFastMode.ForeColor = System.Drawing.Color.DarkBlue;
            this.chbFastMode.Location = new System.Drawing.Point(578, 66);
            this.chbFastMode.Name = "chbFastMode";
            this.chbFastMode.Size = new System.Drawing.Size(76, 17);
            this.chbFastMode.TabIndex = 25;
            this.chbFastMode.Text = "Fast Mode";
            this.chbFastMode.UseVisualStyleBackColor = true;
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(7, 593);
            this.lblItemRecordsTitle.Name = "lblItemRecordsTitle";
            this.lblItemRecordsTitle.Size = new System.Drawing.Size(90, 15);
            this.lblItemRecordsTitle.TabIndex = 23;
            this.lblItemRecordsTitle.Text = "Total Records :";
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnAddToGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToGroup.ForeColor = System.Drawing.Color.Black;
            this.btnAddToGroup.Image = global::Check_Point_Manager.Properties.Resources.arrow_Right_25;
            this.btnAddToGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToGroup.Location = new System.Drawing.Point(482, 7);
            this.btnAddToGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(172, 32);
            this.btnAddToGroup.TabIndex = 26;
            this.btnAddToGroup.Text = "F2 - Add To Group";
            this.btnAddToGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddToGroup.UseVisualStyleBackColor = false;
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // lblItemRecords
            // 
            this.lblItemRecords.AutoSize = true;
            this.lblItemRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemRecords.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemRecords.Location = new System.Drawing.Point(103, 593);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(0, 15);
            this.lblItemRecords.TabIndex = 24;
            // 
            // dgvAllStockList
            // 
            this.dgvAllStockList.AllowUserToAddRows = false;
            this.dgvAllStockList.AllowUserToDeleteRows = false;
            this.dgvAllStockList.AllowUserToOrderColumns = true;
            this.dgvAllStockList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllStockList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStockList.ContextMenuStrip = this.cmsItemOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllStockList.Location = new System.Drawing.Point(11, 88);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(643, 487);
            this.dgvAllStockList.TabIndex = 22;
            this.dgvAllStockList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this._dgv_CellBeginEdit);
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv_CellContentClick);
            this.dgvAllStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellDoubleClick);
            this.dgvAllStockList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllStockList_CellFormatting);
            this.dgvAllStockList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dgvSelectEntireRowByRightClick);
            this.dgvAllStockList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgvAllStockList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            // 
            // cmsItemOptions
            // 
            this.cmsItemOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordItemVariationToolStripMenuItem});
            this.cmsItemOptions.Name = "cmsItemOptions";
            this.cmsItemOptions.Size = new System.Drawing.Size(188, 26);
            // 
            // recordItemVariationToolStripMenuItem
            // 
            this.recordItemVariationToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.Variation_48;
            this.recordItemVariationToolStripMenuItem.Name = "recordItemVariationToolStripMenuItem";
            this.recordItemVariationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.recordItemVariationToolStripMenuItem.Text = "Record Item Variation";
            this.recordItemVariationToolStripMenuItem.Click += new System.EventHandler(this.recordItemVariationToolStripMenuItem_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(373, 62);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(62, 21);
            this.btnSelectAll.TabIndex = 20;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
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
            this.cmbItemsFilterBy.Location = new System.Drawing.Point(11, 61);
            this.cmbItemsFilterBy.Name = "cmbItemsFilterBy";
            this.cmbItemsFilterBy.Size = new System.Drawing.Size(161, 21);
            this.cmbItemsFilterBy.TabIndex = 7;
            this.cmbItemsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(178, 62);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(189, 20);
            this.txbFilterValue.TabIndex = 8;
            this.txbFilterValue.TextChanged += new System.EventHandler(this.txbFilterValue_TextChanged);
            this.txbFilterValue.Enter += new System.EventHandler(this.txbFilterValue_Enter);
            this.txbFilterValue.Leave += new System.EventHandler(this.txbFilterValue_Leave);
            // 
            // pcbItemsList
            // 
            this.pcbItemsList.Image = global::Check_Point_Manager.Properties.Resources.touch;
            this.pcbItemsList.Location = new System.Drawing.Point(11, 13);
            this.pcbItemsList.Name = "pcbItemsList";
            this.pcbItemsList.Size = new System.Drawing.Size(29, 21);
            this.pcbItemsList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbItemsList.TabIndex = 2;
            this.pcbItemsList.TabStop = false;
            // 
            // lblItemsListTitle
            // 
            this.lblItemsListTitle.AutoSize = true;
            this.lblItemsListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsListTitle.Location = new System.Drawing.Point(38, 13);
            this.lblItemsListTitle.Name = "lblItemsListTitle";
            this.lblItemsListTitle.Size = new System.Drawing.Size(101, 20);
            this.lblItemsListTitle.TabIndex = 1;
            this.lblItemsListTitle.Text = "All Items List";
            // 
            // pnlAllItemsSep
            // 
            this.pnlAllItemsSep.BackColor = System.Drawing.Color.LightGray;
            this.pnlAllItemsSep.Location = new System.Drawing.Point(10, 42);
            this.pnlAllItemsSep.Name = "pnlAllItemsSep";
            this.pnlAllItemsSep.Size = new System.Drawing.Size(644, 2);
            this.pnlAllItemsSep.TabIndex = 0;
            // 
            // pnlGroupsList
            // 
            this.pnlGroupsList.BackColor = System.Drawing.Color.White;
            this.pnlGroupsList.Controls.Add(this.btnRemoveItems);
            this.pnlGroupsList.Controls.Add(this.lblGroupCheckedTitle);
            this.pnlGroupsList.Controls.Add(this.lblGroupCheckedCounter);
            this.pnlGroupsList.Controls.Add(this.pcbGroupSearchIcon);
            this.pnlGroupsList.Controls.Add(this.lblGroupRecordTitle);
            this.pnlGroupsList.Controls.Add(this.btnManageGroups);
            this.pnlGroupsList.Controls.Add(this.lblGroupRecord);
            this.pnlGroupsList.Controls.Add(this.btnExportFile);
            this.pnlGroupsList.Controls.Add(this.btnGroupsSelectAll);
            this.pnlGroupsList.Controls.Add(this.pcbGroupsBackground);
            this.pnlGroupsList.Controls.Add(this.dgvGroupItems);
            this.pnlGroupsList.Controls.Add(this.lblSelectGroup);
            this.pnlGroupsList.Controls.Add(this.cmbGroups);
            this.pnlGroupsList.Controls.Add(this.cmbGroupsFilterBy);
            this.pnlGroupsList.Controls.Add(this.txbGroupsFilterValue);
            this.pnlGroupsList.Controls.Add(this.pcbGroupsList);
            this.pnlGroupsList.Controls.Add(this.pnlGroupsListSep);
            this.pnlGroupsList.Controls.Add(this.lblGroupsListTitle);
            this.pnlGroupsList.Location = new System.Drawing.Point(676, 89);
            this.pnlGroupsList.Name = "pnlGroupsList";
            this.pnlGroupsList.Size = new System.Drawing.Size(664, 625);
            this.pnlGroupsList.TabIndex = 3;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnRemoveItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveItems.Image = global::Check_Point_Manager.Properties.Resources.arrow_Left_25;
            this.btnRemoveItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItems.Location = new System.Drawing.Point(447, 7);
            this.btnRemoveItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(207, 32);
            this.btnRemoveItems.TabIndex = 27;
            this.btnRemoveItems.Text = "F3 - Remove From Group";
            this.btnRemoveItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // lblGroupCheckedTitle
            // 
            this.lblGroupCheckedTitle.AutoSize = true;
            this.lblGroupCheckedTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroupCheckedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupCheckedTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGroupCheckedTitle.Location = new System.Drawing.Point(450, 82);
            this.lblGroupCheckedTitle.Name = "lblGroupCheckedTitle";
            this.lblGroupCheckedTitle.Size = new System.Drawing.Size(98, 15);
            this.lblGroupCheckedTitle.TabIndex = 31;
            this.lblGroupCheckedTitle.Text = "Group Counted :";
            // 
            // lblGroupCheckedCounter
            // 
            this.lblGroupCheckedCounter.AutoSize = true;
            this.lblGroupCheckedCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroupCheckedCounter.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupCheckedCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGroupCheckedCounter.Location = new System.Drawing.Point(554, 82);
            this.lblGroupCheckedCounter.Name = "lblGroupCheckedCounter";
            this.lblGroupCheckedCounter.Size = new System.Drawing.Size(17, 15);
            this.lblGroupCheckedCounter.TabIndex = 32;
            this.lblGroupCheckedCounter.Text = "??";
            // 
            // pcbGroupSearchIcon
            // 
            this.pcbGroupSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbGroupSearchIcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pcbGroupSearchIcon.Image = global::Check_Point_Manager.Properties.Resources.search_icon;
            this.pcbGroupSearchIcon.Location = new System.Drawing.Point(348, 81);
            this.pcbGroupSearchIcon.Name = "pcbGroupSearchIcon";
            this.pcbGroupSearchIcon.Size = new System.Drawing.Size(16, 16);
            this.pcbGroupSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupSearchIcon.TabIndex = 30;
            this.pcbGroupSearchIcon.TabStop = false;
            this.pcbGroupSearchIcon.Click += new System.EventHandler(this.pcbGroupSearchIcon_Click);
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(7, 593);
            this.lblGroupRecordTitle.Name = "lblGroupRecordTitle";
            this.lblGroupRecordTitle.Size = new System.Drawing.Size(90, 15);
            this.lblGroupRecordTitle.TabIndex = 28;
            this.lblGroupRecordTitle.Text = "Total Records :";
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
            this.btnManageGroups.Location = new System.Drawing.Point(482, 581);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(172, 37);
            this.btnManageGroups.TabIndex = 29;
            this.btnManageGroups.Text = "Manage Groups";
            this.btnManageGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageGroups.UseVisualStyleBackColor = false;
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // lblGroupRecord
            // 
            this.lblGroupRecord.AutoSize = true;
            this.lblGroupRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroupRecord.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGroupRecord.Location = new System.Drawing.Point(103, 593);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(0, 15);
            this.lblGroupRecord.TabIndex = 29;
            // 
            // btnExportFile
            // 
            this.btnExportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnExportFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.ForeColor = System.Drawing.Color.White;
            this.btnExportFile.Image = global::Check_Point_Manager.Properties.Resources.downloading_updates_25;
            this.btnExportFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportFile.Location = new System.Drawing.Point(353, 581);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(123, 38);
            this.btnExportFile.TabIndex = 27;
            this.btnExportFile.Text = "  Export";
            this.btnExportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFile.UseVisualStyleBackColor = false;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // btnGroupsSelectAll
            // 
            this.btnGroupsSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnGroupsSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGroupsSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGroupsSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnGroupsSelectAll.Location = new System.Drawing.Point(372, 79);
            this.btnGroupsSelectAll.Name = "btnGroupsSelectAll";
            this.btnGroupsSelectAll.Size = new System.Drawing.Size(62, 21);
            this.btnGroupsSelectAll.TabIndex = 25;
            this.btnGroupsSelectAll.Text = "Select All";
            this.btnGroupsSelectAll.UseVisualStyleBackColor = false;
            this.btnGroupsSelectAll.Click += new System.EventHandler(this.btnGroupsSelectAll_Click);
            // 
            // pcbGroupsBackground
            // 
            this.pcbGroupsBackground.Enabled = false;
            this.pcbGroupsBackground.Image = global::Check_Point_Manager.Properties.Resources.Logo__2_;
            this.pcbGroupsBackground.Location = new System.Drawing.Point(16, 119);
            this.pcbGroupsBackground.Name = "pcbGroupsBackground";
            this.pcbGroupsBackground.Size = new System.Drawing.Size(628, 443);
            this.pcbGroupsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsBackground.TabIndex = 27;
            this.pcbGroupsBackground.TabStop = false;
            this.pcbGroupsBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbGroupsBackground_Paint);
            // 
            // dgvGroupItems
            // 
            this.dgvGroupItems.AllowUserToAddRows = false;
            this.dgvGroupItems.AllowUserToDeleteRows = false;
            this.dgvGroupItems.AllowUserToOrderColumns = true;
            this.dgvGroupItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroupItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroupItems.Location = new System.Drawing.Point(10, 105);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(644, 470);
            this.dgvGroupItems.TabIndex = 26;
            this.dgvGroupItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this._dgv_CellBeginEdit);
            this.dgvGroupItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv_CellContentClick);
            this.dgvGroupItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupItems_CellDoubleClick);
            this.dgvGroupItems.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._dgvSelectEntireRowByRightClick);
            this.dgvGroupItems.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgvGroupItems.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroup.Location = new System.Drawing.Point(16, 51);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(103, 17);
            this.lblSelectGroup.TabIndex = 24;
            this.lblSelectGroup.Text = "Select a Group :";
            // 
            // cmbGroups
            // 
            this.cmbGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGroups.BackColor = System.Drawing.Color.White;
            this.cmbGroups.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.ItemHeight = 17;
            this.cmbGroups.Location = new System.Drawing.Point(126, 50);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(528, 25);
            this.cmbGroups.TabIndex = 23;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // cmbGroupsFilterBy
            // 
            this.cmbGroupsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupsFilterBy.FormattingEnabled = true;
            this.cmbGroupsFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description"});
            this.cmbGroupsFilterBy.Location = new System.Drawing.Point(10, 78);
            this.cmbGroupsFilterBy.Name = "cmbGroupsFilterBy";
            this.cmbGroupsFilterBy.Size = new System.Drawing.Size(161, 21);
            this.cmbGroupsFilterBy.TabIndex = 7;
            this.cmbGroupsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbGroupsFilterBy_SelectedIndexChanged);
            // 
            // txbGroupsFilterValue
            // 
            this.txbGroupsFilterValue.Location = new System.Drawing.Point(177, 79);
            this.txbGroupsFilterValue.Name = "txbGroupsFilterValue";
            this.txbGroupsFilterValue.Size = new System.Drawing.Size(189, 20);
            this.txbGroupsFilterValue.TabIndex = 8;
            this.txbGroupsFilterValue.TextChanged += new System.EventHandler(this.txbGroupsFilterValue_TextChanged);
            this.txbGroupsFilterValue.Enter += new System.EventHandler(this.txbGroupsFilterValue_Enter);
            this.txbGroupsFilterValue.Leave += new System.EventHandler(this.txbGroupsFilterValue_Leave);
            // 
            // pcbGroupsList
            // 
            this.pcbGroupsList.Image = global::Check_Point_Manager.Properties.Resources.article;
            this.pcbGroupsList.Location = new System.Drawing.Point(10, 13);
            this.pcbGroupsList.Name = "pcbGroupsList";
            this.pcbGroupsList.Size = new System.Drawing.Size(29, 21);
            this.pcbGroupsList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupsList.TabIndex = 4;
            this.pcbGroupsList.TabStop = false;
            // 
            // pnlGroupsListSep
            // 
            this.pnlGroupsListSep.BackColor = System.Drawing.Color.LightGray;
            this.pnlGroupsListSep.Location = new System.Drawing.Point(10, 42);
            this.pnlGroupsListSep.Name = "pnlGroupsListSep";
            this.pnlGroupsListSep.Size = new System.Drawing.Size(644, 2);
            this.pnlGroupsListSep.TabIndex = 0;
            // 
            // lblGroupsListTitle
            // 
            this.lblGroupsListTitle.AutoSize = true;
            this.lblGroupsListTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupsListTitle.Location = new System.Drawing.Point(37, 13);
            this.lblGroupsListTitle.Name = "lblGroupsListTitle";
            this.lblGroupsListTitle.Size = new System.Drawing.Size(97, 20);
            this.lblGroupsListTitle.TabIndex = 3;
            this.lblGroupsListTitle.Text = "Group Items";
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.White;
            this.pnlAction.Controls.Add(this.lblLastStockUpdateTitle);
            this.pnlAction.Controls.Add(this.lblLastStockUpdate);
            this.pnlAction.Controls.Add(this.pnlUpdateInfo);
            this.pnlAction.Controls.Add(this.btnUpdate);
            this.pnlAction.Controls.Add(this.btnBrowseFile);
            this.pnlAction.Controls.Add(this.txbFilePath);
            this.pnlAction.Controls.Add(this.pcbUpdateStock);
            this.pnlAction.Controls.Add(this.lblUpdateStock);
            this.pnlAction.Location = new System.Drawing.Point(6, 41);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(1334, 42);
            this.pnlAction.TabIndex = 4;
            // 
            // lblLastStockUpdateTitle
            // 
            this.lblLastStockUpdateTitle.AutoSize = true;
            this.lblLastStockUpdateTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastStockUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastStockUpdateTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLastStockUpdateTitle.Location = new System.Drawing.Point(1006, 14);
            this.lblLastStockUpdateTitle.Name = "lblLastStockUpdateTitle";
            this.lblLastStockUpdateTitle.Size = new System.Drawing.Size(114, 15);
            this.lblLastStockUpdateTitle.TabIndex = 33;
            this.lblLastStockUpdateTitle.Text = "Last Stock Update :";
            // 
            // lblLastStockUpdate
            // 
            this.lblLastStockUpdate.AutoSize = true;
            this.lblLastStockUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastStockUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLastStockUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastStockUpdate.Location = new System.Drawing.Point(1129, 14);
            this.lblLastStockUpdate.Name = "lblLastStockUpdate";
            this.lblLastStockUpdate.Size = new System.Drawing.Size(17, 15);
            this.lblLastStockUpdate.TabIndex = 32;
            this.lblLastStockUpdate.Text = "??";
            // 
            // pnlUpdateInfo
            // 
            this.pnlUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.pnlUpdateInfo.Controls.Add(this.pcbWarning);
            this.pnlUpdateInfo.Controls.Add(this.lblUpdateStatus);
            this.pnlUpdateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(102)))), ((int)(((byte)(72)))));
            this.pnlUpdateInfo.Location = new System.Drawing.Point(589, 5);
            this.pnlUpdateInfo.Name = "pnlUpdateInfo";
            this.pnlUpdateInfo.Size = new System.Drawing.Size(387, 34);
            this.pnlUpdateInfo.TabIndex = 27;
            // 
            // pcbWarning
            // 
            this.pcbWarning.Image = global::Check_Point_Manager.Properties.Resources.Warning_25;
            this.pcbWarning.Location = new System.Drawing.Point(3, 3);
            this.pcbWarning.Name = "pcbWarning";
            this.pcbWarning.Size = new System.Drawing.Size(27, 28);
            this.pcbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbWarning.TabIndex = 31;
            this.pcbWarning.TabStop = false;
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Check_Point_Manager.Properties.Resources.update_25;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(448, 4);
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
            this.btnBrowseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnBrowseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseFile.Location = new System.Drawing.Point(143, 4);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(116, 35);
            this.btnBrowseFile.TabIndex = 27;
            this.btnBrowseFile.Text = "Browse File ...";
            this.btnBrowseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // txbFilePath
            // 
            this.txbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFilePath.Location = new System.Drawing.Point(265, 4);
            this.txbFilePath.Multiline = true;
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(177, 35);
            this.txbFilePath.TabIndex = 19;
            // 
            // pcbUpdateStock
            // 
            this.pcbUpdateStock.Image = global::Check_Point_Manager.Properties.Resources.data_processing1;
            this.pcbUpdateStock.Location = new System.Drawing.Point(6, 10);
            this.pcbUpdateStock.Name = "pcbUpdateStock";
            this.pcbUpdateStock.Size = new System.Drawing.Size(29, 21);
            this.pcbUpdateStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUpdateStock.TabIndex = 4;
            this.pcbUpdateStock.TabStop = false;
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(35, 11);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(102, 20);
            this.lblUpdateStock.TabIndex = 3;
            this.lblUpdateStock.Text = "Update Stock";
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackColor = System.Drawing.Color.White;
            this.pcbIcon.Image = global::Check_Point_Manager.Properties.Resources.icons8_clipboard_64;
            this.pcbIcon.Location = new System.Drawing.Point(5, 5);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(24, 24);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lklShowCheckingHistory);
            this.panel1.Controls.Add(this.lblLastGroupChecked);
            this.panel1.Controls.Add(this.lblLastGroupCheckedTitle);
            this.panel1.Location = new System.Drawing.Point(6, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 30);
            this.panel1.TabIndex = 5;
            // 
            // lklShowCheckingHistory
            // 
            this.lklShowCheckingHistory.AutoSize = true;
            this.lklShowCheckingHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklShowCheckingHistory.Location = new System.Drawing.Point(1214, 6);
            this.lklShowCheckingHistory.Name = "lklShowCheckingHistory";
            this.lklShowCheckingHistory.Size = new System.Drawing.Size(110, 17);
            this.lklShowCheckingHistory.TabIndex = 34;
            this.lklShowCheckingHistory.TabStop = true;
            this.lklShowCheckingHistory.Text = "Checking History";
            this.lklShowCheckingHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklShowCheckingHistory_LinkClicked);
            // 
            // lblLastGroupChecked
            // 
            this.lblLastGroupChecked.AutoSize = true;
            this.lblLastGroupChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastGroupChecked.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastGroupChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastGroupChecked.Location = new System.Drawing.Point(140, 8);
            this.lblLastGroupChecked.Name = "lblLastGroupChecked";
            this.lblLastGroupChecked.Size = new System.Drawing.Size(17, 15);
            this.lblLastGroupChecked.TabIndex = 33;
            this.lblLastGroupChecked.Text = "??";
            // 
            // lblLastGroupCheckedTitle
            // 
            this.lblLastGroupCheckedTitle.AutoSize = true;
            this.lblLastGroupCheckedTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastGroupCheckedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastGroupCheckedTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLastGroupCheckedTitle.Location = new System.Drawing.Point(7, 8);
            this.lblLastGroupCheckedTitle.Name = "lblLastGroupCheckedTitle";
            this.lblLastGroupCheckedTitle.Size = new System.Drawing.Size(124, 15);
            this.lblLastGroupCheckedTitle.TabIndex = 32;
            this.lblLastGroupCheckedTitle.Text = "Last Group Checked :";
            // 
            // btnClearNewItems
            // 
            this.btnClearNewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnClearNewItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearNewItems.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNewItems.ForeColor = System.Drawing.Color.White;
            this.btnClearNewItems.Location = new System.Drawing.Point(178, 61);
            this.btnClearNewItems.Name = "btnClearNewItems";
            this.btnClearNewItems.Size = new System.Drawing.Size(125, 21);
            this.btnClearNewItems.TabIndex = 31;
            this.btnClearNewItems.Text = "Clear New Items";
            this.btnClearNewItems.UseVisualStyleBackColor = false;
            this.btnClearNewItems.Click += new System.EventHandler(this.btnClearNewItems_Click);
            // 
            // frmMainScreen
            // 
            this.AcceptButton = this.btnAddToGroup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1347, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlGroupsList);
            this.Controls.Add(this.pnlItemsList);
            this.Controls.Add(this.pcbIcon);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckPoint Manager";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainScreen_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlItemsList.ResumeLayout(false);
            this.pnlItemsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemsSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).EndInit();
            this.cmsItemOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemsList)).EndInit();
            this.pnlGroupsList.ResumeLayout(false);
            this.pnlGroupsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupsList)).EndInit();
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.pnlUpdateInfo.ResumeLayout(false);
            this.pnlUpdateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdateStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbItemsFilterBy;
        private System.Windows.Forms.TextBox txbFilterValue;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ComboBox cmbGroupsFilterBy;
        private System.Windows.Forms.TextBox txbGroupsFilterValue;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.Button btnGroupsSelectAll;
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
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Button btnAddToGroup;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Panel pnlUpdateInfo;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.PictureBox pcbItemsSearchIcon;
        private System.Windows.Forms.PictureBox pcbGroupSearchIcon;
        private System.Windows.Forms.Label lblGroupCheckedTitle;
        private System.Windows.Forms.Label lblGroupCheckedCounter;
        private System.Windows.Forms.ContextMenuStrip cmsItemOptions;
        private System.Windows.Forms.ToolStripMenuItem recordItemVariationToolStripMenuItem;
        private System.Windows.Forms.Button btnVariationList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLastGroupChecked;
        private System.Windows.Forms.Label lblLastGroupCheckedTitle;
        private System.Windows.Forms.PictureBox pcbWarning;
        private System.Windows.Forms.Label lblLastStockUpdate;
        private System.Windows.Forms.Label lblLastStockUpdateTitle;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.LinkLabel lklShowCheckingHistory;
        private System.Windows.Forms.Button btnClearNewItems;
    }
}