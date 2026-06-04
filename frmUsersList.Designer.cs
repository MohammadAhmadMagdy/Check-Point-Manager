namespace Check_Point_Manager
{
    partial class frmUsersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.cmsUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblTotalUsersTitle = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToOrderColumns = true;
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.cmsUserOptions;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsersList.Location = new System.Drawing.Point(12, 121);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersList.Size = new System.Drawing.Size(514, 181);
            this.dgvUsersList.TabIndex = 23;
            this.dgvUsersList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsersList_CellMouseDown);
            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.cmsUserOptions.Name = "cmsUserOptions";
            this.cmsUserOptions.Size = new System.Drawing.Size(134, 48);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.edit;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.remove;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(103)))));
            this.btnAddNewUser.Image = global::Check_Point_Manager.Properties.Resources.AddNewUser;
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddNewUser.Location = new System.Drawing.Point(384, 73);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(142, 42);
            this.btnAddNewUser.TabIndex = 31;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblTotalUsersTitle
            // 
            this.lblTotalUsersTitle.AutoSize = true;
            this.lblTotalUsersTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalUsersTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsersTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalUsersTitle.Location = new System.Drawing.Point(9, 321);
            this.lblTotalUsersTitle.Name = "lblTotalUsersTitle";
            this.lblTotalUsersTitle.Size = new System.Drawing.Size(76, 15);
            this.lblTotalUsersTitle.TabIndex = 32;
            this.lblTotalUsersTitle.Text = "Total Users :";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalUsers.Location = new System.Drawing.Point(91, 321);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(0, 15);
            this.lblTotalUsers.TabIndex = 33;
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 41);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Users List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 345);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotalUsersTitle);
            this.Controls.Add(this.lblTotalUsers);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dgvUsersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.cmsUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblTotalUsersTitle;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
    }
}