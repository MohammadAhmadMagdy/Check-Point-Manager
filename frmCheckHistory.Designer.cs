namespace Check_Point_Manager
{
    partial class frmCheckHistory
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
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgvCheckHistory = new System.Windows.Forms.DataGridView();
            this.btnAddCheckRecord = new System.Windows.Forms.Button();
            this.btnEditCheckRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroup.Location = new System.Drawing.Point(13, 27);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(103, 17);
            this.lblSelectGroup.TabIndex = 26;
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
            this.cmbGroups.Location = new System.Drawing.Point(122, 24);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(548, 25);
            this.cmbGroups.TabIndex = 25;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // dgvCheckHistory
            // 
            this.dgvCheckHistory.AllowUserToAddRows = false;
            this.dgvCheckHistory.AllowUserToDeleteRows = false;
            this.dgvCheckHistory.AllowUserToOrderColumns = true;
            this.dgvCheckHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheckHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCheckHistory.Location = new System.Drawing.Point(16, 55);
            this.dgvCheckHistory.Name = "dgvCheckHistory";
            this.dgvCheckHistory.ReadOnly = true;
            this.dgvCheckHistory.RowHeadersVisible = false;
            this.dgvCheckHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckHistory.Size = new System.Drawing.Size(654, 401);
            this.dgvCheckHistory.TabIndex = 27;
            this.dgvCheckHistory.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCheckHistory_CellMouseDown);
            // 
            // btnAddCheckRecord
            // 
            this.btnAddCheckRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnAddCheckRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCheckRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCheckRecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCheckRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnAddCheckRecord.Image = global::Check_Point_Manager.Properties.Resources.History1;
            this.btnAddCheckRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCheckRecord.Location = new System.Drawing.Point(697, 103);
            this.btnAddCheckRecord.Name = "btnAddCheckRecord";
            this.btnAddCheckRecord.Size = new System.Drawing.Size(161, 37);
            this.btnAddCheckRecord.TabIndex = 30;
            this.btnAddCheckRecord.Text = "Add Check Record";
            this.btnAddCheckRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCheckRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCheckRecord.UseVisualStyleBackColor = false;
            this.btnAddCheckRecord.Click += new System.EventHandler(this.btnAddCheckRecord_Click);
            // 
            // btnEditCheckRecord
            // 
            this.btnEditCheckRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnEditCheckRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditCheckRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCheckRecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCheckRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnEditCheckRecord.Image = global::Check_Point_Manager.Properties.Resources.History1;
            this.btnEditCheckRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditCheckRecord.Location = new System.Drawing.Point(697, 162);
            this.btnEditCheckRecord.Name = "btnEditCheckRecord";
            this.btnEditCheckRecord.Size = new System.Drawing.Size(161, 37);
            this.btnEditCheckRecord.TabIndex = 31;
            this.btnEditCheckRecord.Text = "Edit Check Record";
            this.btnEditCheckRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCheckRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCheckRecord.UseVisualStyleBackColor = false;
            this.btnEditCheckRecord.Click += new System.EventHandler(this.btnEditCheckRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnDeleteRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnDeleteRecord.Image = global::Check_Point_Manager.Properties.Resources.History1;
            this.btnDeleteRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteRecord.Location = new System.Drawing.Point(697, 221);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(161, 37);
            this.btnDeleteRecord.TabIndex = 32;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // frmCheckHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 474);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditCheckRecord);
            this.Controls.Add(this.btnAddCheckRecord);
            this.Controls.Add(this.dgvCheckHistory);
            this.Controls.Add(this.lblSelectGroup);
            this.Controls.Add(this.cmbGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCheckHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check History";
            this.Load += new System.EventHandler(this.frmCheckHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridView dgvCheckHistory;
        private System.Windows.Forms.Button btnAddCheckRecord;
        private System.Windows.Forms.Button btnEditCheckRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
    }
}