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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllStockList = new System.Windows.Forms.DataGridView();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStockList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllStockList.Location = new System.Drawing.Point(12, 357);
            this.dgvAllStockList.Name = "dgvAllStockList";
            this.dgvAllStockList.RowHeadersVisible = false;
            this.dgvAllStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStockList.Size = new System.Drawing.Size(723, 353);
            this.dgvAllStockList.TabIndex = 0;
            this.dgvAllStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStockList_CellContentClick);
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsTitle.Location = new System.Drawing.Point(12, 713);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(77, 14);
            this.lblRecordsTitle.TabIndex = 2;
            this.lblRecordsTitle.Text = "# Records :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecords.Location = new System.Drawing.Point(95, 713);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(21, 14);
            this.lblRecords.TabIndex = 3;
            this.lblRecords.Text = "??";
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(12, 332);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(64, 14);
            this.lblFilterBy.TabIndex = 4;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Code",
            "Description"});
            this.cmbFilterBy.Location = new System.Drawing.Point(80, 330);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(158, 21);
            this.cmbFilterBy.TabIndex = 5;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(244, 331);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(177, 20);
            this.txbFilterValue.TabIndex = 6;
            this.txbFilterValue.TextChanged += new System.EventHandler(this.txbFilterValue_TextChanged);
            this.txbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilterValue_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(741, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 353);
            this.dataGridView1.TabIndex = 7;
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(741, 330);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(195, 21);
            this.cmbGroups.TabIndex = 8;
            // 
            // frmListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbFilterValue);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.dgvAllStockList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllStockList;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txbFilterValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbGroups;
    }
}

