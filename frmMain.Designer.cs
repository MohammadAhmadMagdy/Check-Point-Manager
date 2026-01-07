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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItemRecordsTitle = new System.Windows.Forms.Label();
            this.lblItemRecords = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvGroupItems = new System.Windows.Forms.DataGridView();
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.btnAddSelectedToGroup = new System.Windows.Forms.Button();
            this.lblAddToGroup = new System.Windows.Forms.Label();
            this.gbxGroups = new System.Windows.Forms.GroupBox();
            this.gbxItems = new System.Windows.Forms.GroupBox();
            this.btnManageGroups = new System.Windows.Forms.Button();
            this.lblGroupRecordTitle = new System.Windows.Forms.Label();
            this.lblGroupRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            this.gbxGroups.SuspendLayout();
            this.gbxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemRecordsTitle
            // 
            this.lblItemRecordsTitle.AutoSize = true;
            this.lblItemRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemRecordsTitle.Location = new System.Drawing.Point(6, 444);
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
            this.lblItemRecords.Location = new System.Drawing.Point(89, 444);
            this.lblItemRecords.Name = "lblItemRecords";
            this.lblItemRecords.Size = new System.Drawing.Size(21, 14);
            this.lblItemRecords.TabIndex = 3;
            this.lblItemRecords.Text = "??";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(6, 37);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(195, 22);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupItems.Location = new System.Drawing.Point(6, 62);
            this.dgvGroupItems.Name = "dgvGroupItems";
            this.dgvGroupItems.RowHeadersVisible = false;
            this.dgvGroupItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupItems.Size = new System.Drawing.Size(511, 378);
            this.dgvGroupItems.TabIndex = 9;
            // 
            // dgvAllStockList
            // 
            this.dgvAllStockList.AllowUserToAddRows = false;
            this.dgvAllStockList.AllowUserToDeleteRows = false;
            this.dgvAllStockList.AllowUserToOrderColumns = true;
            this.dgvAllStockList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllStockList.Location = new System.Drawing.Point(6, 63);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(637, 378);
            this.dgvAllStockList.TabIndex = 0;
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellContentClick);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(6, 21);
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
            this.cmbFilterBy.Location = new System.Drawing.Point(6, 38);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(158, 22);
            this.cmbFilterBy.TabIndex = 5;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(170, 39);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(177, 22);
            this.txbFilterValue.TabIndex = 6;
            this.txbFilterValue.TextChanged += new System.EventHandler(this.txbFilterValue_TextChanged);
            this.txbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilterValue_KeyPress);
            // 
            // btnAddSelectedToGroup
            // 
            this.btnAddSelectedToGroup.BackgroundImage = global::Check_Point_Manager.Properties.Resources.right;
            this.btnAddSelectedToGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSelectedToGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSelectedToGroup.Location = new System.Drawing.Point(581, 37);
            this.btnAddSelectedToGroup.Name = "btnAddSelectedToGroup";
            this.btnAddSelectedToGroup.Size = new System.Drawing.Size(62, 23);
            this.btnAddSelectedToGroup.TabIndex = 10;
            this.btnAddSelectedToGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSelectedToGroup.UseVisualStyleBackColor = true;
            this.btnAddSelectedToGroup.Click += new System.EventHandler(this.btnAddSelectedToGroup_Click);
            // 
            // lblAddToGroup
            // 
            this.lblAddToGroup.AutoSize = true;
            this.lblAddToGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToGroup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddToGroup.Location = new System.Drawing.Point(380, 39);
            this.lblAddToGroup.Name = "lblAddToGroup";
            this.lblAddToGroup.Size = new System.Drawing.Size(195, 16);
            this.lblAddToGroup.TabIndex = 11;
            this.lblAddToGroup.Text = "Add Selected Items To Group";
            // 
            // gbxGroups
            // 
            this.gbxGroups.Controls.Add(this.lblGroupRecordTitle);
            this.gbxGroups.Controls.Add(this.lblGroupRecord);
            this.gbxGroups.Controls.Add(this.btnManageGroups);
            this.gbxGroups.Controls.Add(this.dgvGroupItems);
            this.gbxGroups.Controls.Add(this.cmbGroups);
            this.gbxGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGroups.Location = new System.Drawing.Point(669, 191);
            this.gbxGroups.Name = "gbxGroups";
            this.gbxGroups.Size = new System.Drawing.Size(527, 466);
            this.gbxGroups.TabIndex = 12;
            this.gbxGroups.TabStop = false;
            this.gbxGroups.Text = "Groups";
            // 
            // gbxItems
            // 
            this.gbxItems.Controls.Add(this.dgvAllStockList);
            this.gbxItems.Controls.Add(this.lblItemRecordsTitle);
            this.gbxItems.Controls.Add(this.lblAddToGroup);
            this.gbxItems.Controls.Add(this.lblItemRecords);
            this.gbxItems.Controls.Add(this.btnAddSelectedToGroup);
            this.gbxItems.Controls.Add(this.lblFilterBy);
            this.gbxItems.Controls.Add(this.txbFilterValue);
            this.gbxItems.Controls.Add(this.cmbFilterBy);
            this.gbxItems.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItems.Location = new System.Drawing.Point(12, 190);
            this.gbxItems.Name = "gbxItems";
            this.gbxItems.Size = new System.Drawing.Size(651, 467);
            this.gbxItems.TabIndex = 13;
            this.gbxItems.TabStop = false;
            this.gbxItems.Text = "Item List";
            // 
            // btnManageGroups
            // 
            this.btnManageGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGroups.Location = new System.Drawing.Point(392, 27);
            this.btnManageGroups.Name = "btnManageGroups";
            this.btnManageGroups.Size = new System.Drawing.Size(125, 33);
            this.btnManageGroups.TabIndex = 10;
            this.btnManageGroups.Text = "Manage Groups";
            this.btnManageGroups.UseVisualStyleBackColor = true;
            this.btnManageGroups.Click += new System.EventHandler(this.btnManageGroups_Click);
            // 
            // lblGroupRecordTitle
            // 
            this.lblGroupRecordTitle.AutoSize = true;
            this.lblGroupRecordTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecordTitle.Location = new System.Drawing.Point(6, 443);
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
            this.lblGroupRecord.Location = new System.Drawing.Point(89, 443);
            this.lblGroupRecord.Name = "lblGroupRecord";
            this.lblGroupRecord.Size = new System.Drawing.Size(21, 14);
            this.lblGroupRecord.TabIndex = 12;
            this.lblGroupRecord.Text = "??";
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 666);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnAddSelectedToGroup;
        private System.Windows.Forms.Label lblAddToGroup;
        private System.Windows.Forms.GroupBox gbxGroups;
        private System.Windows.Forms.GroupBox gbxItems;
        private System.Windows.Forms.Button btnManageGroups;
        private System.Windows.Forms.Label lblGroupRecordTitle;
        private System.Windows.Forms.Label lblGroupRecord;
    }
}

