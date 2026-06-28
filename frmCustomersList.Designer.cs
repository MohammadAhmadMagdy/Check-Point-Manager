namespace Check_Point_Manager
{
    partial class frmCustomersList
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
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalCustomersTitle = new System.Windows.Forms.Label();
            this.btnAddNewCustomer = new MaterialSkin.Controls.MaterialButton();
            this.cmsCustomerOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.cmsCustomerOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AllowUserToOrderColumns = true;
            this.dgvCustomersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersList.ContextMenuStrip = this.cmsCustomerOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomersList.Location = new System.Drawing.Point(7, 116);
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersVisible = false;
            this.dgvCustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersList.Size = new System.Drawing.Size(725, 420);
            this.dgvCustomersList.TabIndex = 23;
            this.dgvCustomersList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomersList_CellMouseDown);
            // 
            // lblHeader
            // 
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(86)))), ((int)(((byte)(146)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(674, 40);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "Customers List";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalCustomers.Location = new System.Drawing.Point(179, 552);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(17, 15);
            this.lblTotalCustomers.TabIndex = 35;
            this.lblTotalCustomers.Text = "??";
            // 
            // lblTotalCustomersTitle
            // 
            this.lblTotalCustomersTitle.AutoSize = true;
            this.lblTotalCustomersTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomersTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalCustomersTitle.Location = new System.Drawing.Point(4, 552);
            this.lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            this.lblTotalCustomersTitle.Size = new System.Drawing.Size(169, 15);
            this.lblTotalCustomersTitle.TabIndex = 34;
            this.lblTotalCustomersTitle.Text = "Total Number of Customers :";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.AutoSize = false;
            this.btnAddNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewCustomer.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnAddNewCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnAddNewCustomer.Depth = 0;
            this.btnAddNewCustomer.HighEmphasis = true;
            this.btnAddNewCustomer.Icon = null;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(580, 68);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNewCustomer.Size = new System.Drawing.Size(151, 39);
            this.btnAddNewCustomer.TabIndex = 39;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewCustomer.UseAccentColor = false;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // cmsCustomerOptions
            // 
            this.cmsCustomerOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.cmsCustomerOptions.Name = "cmsCustomerOptions";
            this.cmsCustomerOptions.Size = new System.Drawing.Size(163, 48);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.edit;
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editCustomerToolStripMenuItem.Text = "Edit Customer";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.editCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Image = global::Check_Point_Manager.Properties.Resources.icons8_delete_25;
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 588);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.lblTotalCustomersTitle);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvCustomersList);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers List";
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.cmsCustomerOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomersList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersTitle;
        private MaterialSkin.Controls.MaterialButton btnAddNewCustomer;
        private System.Windows.Forms.ContextMenuStrip cmsCustomerOptions;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
    }
}