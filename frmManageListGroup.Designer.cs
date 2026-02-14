namespace Check_Point_Manager
{
    partial class frmManageListGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListGroups = new System.Windows.Forms.DataGridView();
            this.cmsGroupOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showGroupCheckHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumberOfGroupsTitle = new System.Windows.Forms.Label();
            this.lblNumberOfGroups = new System.Windows.Forms.Label();
            this.gbxCounter = new System.Windows.Forms.GroupBox();
            this.btnCounterReset = new System.Windows.Forms.Button();
            this.btnCounterMinus = new System.Windows.Forms.Button();
            this.btnCounterPlus = new System.Windows.Forms.Button();
            this.lklShowCheckingHistory = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).BeginInit();
            this.cmsGroupOptions.SuspendLayout();
            this.gbxCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListGroups
            // 
            this.dgvListGroups.AllowUserToAddRows = false;
            this.dgvListGroups.AllowUserToDeleteRows = false;
            this.dgvListGroups.AllowUserToOrderColumns = true;
            this.dgvListGroups.BackgroundColor = System.Drawing.Color.White;
            this.dgvListGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGroups.ContextMenuStrip = this.cmsGroupOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListGroups.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListGroups.Location = new System.Drawing.Point(12, 46);
            this.dgvListGroups.Name = "dgvListGroups";
            this.dgvListGroups.ReadOnly = true;
            this.dgvListGroups.RowHeadersVisible = false;
            this.dgvListGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGroups.Size = new System.Drawing.Size(822, 605);
            this.dgvListGroups.TabIndex = 10;
            this.dgvListGroups.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListGroups_CellMouseDown);
            this.dgvListGroups.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListGroups_MouseDown);
            // 
            // cmsGroupOptions
            // 
            this.cmsGroupOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGroupCheckHistoryToolStripMenuItem});
            this.cmsGroupOptions.Name = "cmsGroupOptions";
            this.cmsGroupOptions.Size = new System.Drawing.Size(217, 26);
            // 
            // showGroupCheckHistoryToolStripMenuItem
            // 
            this.showGroupCheckHistoryToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.History2;
            this.showGroupCheckHistoryToolStripMenuItem.Name = "showGroupCheckHistoryToolStripMenuItem";
            this.showGroupCheckHistoryToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showGroupCheckHistoryToolStripMenuItem.Text = "Show Group Check History";
            this.showGroupCheckHistoryToolStripMenuItem.Click += new System.EventHandler(this.showGroupCheckHistoryToolStripMenuItem_Click);
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNew.Location = new System.Drawing.Point(863, 122);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(64, 16);
            this.lblAddNew.TabIndex = 15;
            this.lblAddNew.Text = "Add New";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(876, 234);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(31, 16);
            this.lblEdit.TabIndex = 16;
            this.lblEdit.Text = "Edit";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(871, 347);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(49, 16);
            this.lblDelete.TabIndex = 17;
            this.lblDelete.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Check_Point_Manager.Properties.Resources.remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(866, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 72);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::Check_Point_Manager.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(866, 159);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 72);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackgroundImage = global::Check_Point_Manager.Properties.Resources.AddNew;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Black;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddNew.Location = new System.Drawing.Point(866, 47);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(73, 72);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Medium ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(940, 34);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Manage Check Point Groups";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfGroupsTitle
            // 
            this.lblNumberOfGroupsTitle.AutoSize = true;
            this.lblNumberOfGroupsTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGroupsTitle.Location = new System.Drawing.Point(12, 663);
            this.lblNumberOfGroupsTitle.Name = "lblNumberOfGroupsTitle";
            this.lblNumberOfGroupsTitle.Size = new System.Drawing.Size(131, 16);
            this.lblNumberOfGroupsTitle.TabIndex = 19;
            this.lblNumberOfGroupsTitle.Text = "Number of Groups :";
            // 
            // lblNumberOfGroups
            // 
            this.lblNumberOfGroups.AutoSize = true;
            this.lblNumberOfGroups.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGroups.Location = new System.Drawing.Point(149, 663);
            this.lblNumberOfGroups.Name = "lblNumberOfGroups";
            this.lblNumberOfGroups.Size = new System.Drawing.Size(28, 16);
            this.lblNumberOfGroups.TabIndex = 20;
            this.lblNumberOfGroups.Text = "???";
            // 
            // gbxCounter
            // 
            this.gbxCounter.Controls.Add(this.btnCounterReset);
            this.gbxCounter.Controls.Add(this.btnCounterMinus);
            this.gbxCounter.Controls.Add(this.btnCounterPlus);
            this.gbxCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCounter.Location = new System.Drawing.Point(845, 378);
            this.gbxCounter.Name = "gbxCounter";
            this.gbxCounter.Size = new System.Drawing.Size(105, 273);
            this.gbxCounter.TabIndex = 21;
            this.gbxCounter.TabStop = false;
            this.gbxCounter.Text = "Counters";
            // 
            // btnCounterReset
            // 
            this.btnCounterReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnCounterReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCounterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounterReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterReset.ForeColor = System.Drawing.Color.White;
            this.btnCounterReset.Image = global::Check_Point_Manager.Properties.Resources.reset_20;
            this.btnCounterReset.Location = new System.Drawing.Point(16, 188);
            this.btnCounterReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnCounterReset.Name = "btnCounterReset";
            this.btnCounterReset.Size = new System.Drawing.Size(73, 72);
            this.btnCounterReset.TabIndex = 30;
            this.btnCounterReset.Text = "Counter Rest";
            this.btnCounterReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCounterReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCounterReset.UseVisualStyleBackColor = false;
            this.btnCounterReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCounterMinus
            // 
            this.btnCounterMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnCounterMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCounterMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounterMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterMinus.ForeColor = System.Drawing.Color.White;
            this.btnCounterMinus.Image = global::Check_Point_Manager.Properties.Resources.minus_20;
            this.btnCounterMinus.Location = new System.Drawing.Point(16, 109);
            this.btnCounterMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnCounterMinus.Name = "btnCounterMinus";
            this.btnCounterMinus.Size = new System.Drawing.Size(73, 72);
            this.btnCounterMinus.TabIndex = 29;
            this.btnCounterMinus.Text = "Counter Minus";
            this.btnCounterMinus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCounterMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCounterMinus.UseVisualStyleBackColor = false;
            this.btnCounterMinus.Click += new System.EventHandler(this.btnCounterMinus_Click);
            // 
            // btnCounterPlus
            // 
            this.btnCounterPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnCounterPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCounterPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounterPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterPlus.ForeColor = System.Drawing.Color.White;
            this.btnCounterPlus.Image = global::Check_Point_Manager.Properties.Resources.plus_20;
            this.btnCounterPlus.Location = new System.Drawing.Point(16, 30);
            this.btnCounterPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnCounterPlus.Name = "btnCounterPlus";
            this.btnCounterPlus.Size = new System.Drawing.Size(73, 72);
            this.btnCounterPlus.TabIndex = 28;
            this.btnCounterPlus.Text = "Counter Plus";
            this.btnCounterPlus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCounterPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCounterPlus.UseVisualStyleBackColor = false;
            this.btnCounterPlus.Click += new System.EventHandler(this.btnCounterPlus_Click);
            // 
            // lklShowCheckingHistory
            // 
            this.lklShowCheckingHistory.AutoSize = true;
            this.lklShowCheckingHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklShowCheckingHistory.Location = new System.Drawing.Point(688, 662);
            this.lklShowCheckingHistory.Name = "lklShowCheckingHistory";
            this.lklShowCheckingHistory.Size = new System.Drawing.Size(146, 17);
            this.lklShowCheckingHistory.TabIndex = 22;
            this.lklShowCheckingHistory.TabStop = true;
            this.lklShowCheckingHistory.Text = "Show Checking History";
            this.lklShowCheckingHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklShowCheckingHistory_LinkClicked);
            // 
            // frmManageListGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 689);
            this.Controls.Add(this.lklShowCheckingHistory);
            this.Controls.Add(this.gbxCounter);
            this.Controls.Add(this.lblNumberOfGroups);
            this.Controls.Add(this.lblNumberOfGroupsTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvListGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageListGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Groups";
            this.Load += new System.EventHandler(this.frmManageListGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).EndInit();
            this.cmsGroupOptions.ResumeLayout(false);
            this.gbxCounter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListGroups;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumberOfGroupsTitle;
        private System.Windows.Forms.Label lblNumberOfGroups;
        private System.Windows.Forms.GroupBox gbxCounter;
        private System.Windows.Forms.Button btnCounterPlus;
        private System.Windows.Forms.Button btnCounterMinus;
        private System.Windows.Forms.Button btnCounterReset;
        private System.Windows.Forms.ContextMenuStrip cmsGroupOptions;
        private System.Windows.Forms.ToolStripMenuItem showGroupCheckHistoryToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lklShowCheckingHistory;
    }
}