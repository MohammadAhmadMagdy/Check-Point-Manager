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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListGroups = new System.Windows.Forms.DataGridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCounterMinus = new System.Windows.Forms.Button();
            this.btnCounterPlus = new System.Windows.Forms.Button();
            this.cmsGroupOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCheckPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCheckPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).BeginInit();
            this.gbxCounter.SuspendLayout();
            this.cmsGroupOptions.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListGroups.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListGroups.Location = new System.Drawing.Point(12, 81);
            this.dgvListGroups.Name = "dgvListGroups";
            this.dgvListGroups.ReadOnly = true;
            this.dgvListGroups.RowHeadersVisible = false;
            this.dgvListGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGroups.Size = new System.Drawing.Size(822, 605);
            this.dgvListGroups.TabIndex = 10;
            this.dgvListGroups.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListGroups_MouseDown);
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNew.Location = new System.Drawing.Point(863, 157);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(64, 16);
            this.lblAddNew.TabIndex = 15;
            this.lblAddNew.Text = "Add New";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(876, 269);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(31, 16);
            this.lblEdit.TabIndex = 16;
            this.lblEdit.Text = "Edit";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(871, 382);
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
            this.btnDelete.Location = new System.Drawing.Point(866, 307);
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
            this.btnEdit.Location = new System.Drawing.Point(866, 194);
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
            this.btnAddNew.Location = new System.Drawing.Point(866, 82);
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
            this.lblTitle.Font = new System.Drawing.Font("Eras Medium ITC", 27.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(940, 49);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Manage Check Point Groups";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfGroupsTitle
            // 
            this.lblNumberOfGroupsTitle.AutoSize = true;
            this.lblNumberOfGroupsTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGroupsTitle.Location = new System.Drawing.Point(9, 689);
            this.lblNumberOfGroupsTitle.Name = "lblNumberOfGroupsTitle";
            this.lblNumberOfGroupsTitle.Size = new System.Drawing.Size(131, 16);
            this.lblNumberOfGroupsTitle.TabIndex = 19;
            this.lblNumberOfGroupsTitle.Text = "Number of Groups :";
            // 
            // lblNumberOfGroups
            // 
            this.lblNumberOfGroups.AutoSize = true;
            this.lblNumberOfGroups.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGroups.Location = new System.Drawing.Point(146, 689);
            this.lblNumberOfGroups.Name = "lblNumberOfGroups";
            this.lblNumberOfGroups.Size = new System.Drawing.Size(28, 16);
            this.lblNumberOfGroups.TabIndex = 20;
            this.lblNumberOfGroups.Text = "???";
            // 
            // gbxCounter
            // 
            this.gbxCounter.Controls.Add(this.button1);
            this.gbxCounter.Controls.Add(this.btnCounterMinus);
            this.gbxCounter.Controls.Add(this.btnCounterPlus);
            this.gbxCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCounter.Location = new System.Drawing.Point(845, 413);
            this.gbxCounter.Name = "gbxCounter";
            this.gbxCounter.Size = new System.Drawing.Size(105, 273);
            this.gbxCounter.TabIndex = 21;
            this.gbxCounter.TabStop = false;
            this.gbxCounter.Text = "Counters";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Check_Point_Manager.Properties.Resources.reset_20;
            this.button1.Location = new System.Drawing.Point(16, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 72);
            this.button1.TabIndex = 30;
            this.button1.Text = "Counter Rest";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // cmsGroupOptions
            // 
            this.cmsGroupOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCheckPointToolStripMenuItem,
            this.editCheckPointToolStripMenuItem});
            this.cmsGroupOptions.Name = "cmsGroupOptions";
            this.cmsGroupOptions.Size = new System.Drawing.Size(181, 70);
            // 
            // addCheckPointToolStripMenuItem
            // 
            this.addCheckPointToolStripMenuItem.Name = "addCheckPointToolStripMenuItem";
            this.addCheckPointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCheckPointToolStripMenuItem.Text = "Add Check Point";
            this.addCheckPointToolStripMenuItem.Click += new System.EventHandler(this.addCheckPointToolStripMenuItem_Click);
            // 
            // editCheckPointToolStripMenuItem
            // 
            this.editCheckPointToolStripMenuItem.Name = "editCheckPointToolStripMenuItem";
            this.editCheckPointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCheckPointToolStripMenuItem.Text = "Edit Check Point";
            // 
            // frmManageListGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 714);
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
            this.gbxCounter.ResumeLayout(false);
            this.cmsGroupOptions.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsGroupOptions;
        private System.Windows.Forms.ToolStripMenuItem addCheckPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCheckPointToolStripMenuItem;
    }
}