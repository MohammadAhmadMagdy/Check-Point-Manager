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
            this.dgvListGroups = new System.Windows.Forms.DataGridView();
            this.ctrlButtonCardAddNew = new Check_Point_Manager.ctrlButtonCard();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListGroups
            // 
            this.dgvListGroups.AllowUserToAddRows = false;
            this.dgvListGroups.AllowUserToDeleteRows = false;
            this.dgvListGroups.AllowUserToOrderColumns = true;
            this.dgvListGroups.BackgroundColor = System.Drawing.Color.White;
            this.dgvListGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGroups.Location = new System.Drawing.Point(12, 232);
            this.dgvListGroups.Name = "dgvListGroups";
            this.dgvListGroups.ReadOnly = true;
            this.dgvListGroups.Size = new System.Drawing.Size(844, 253);
            this.dgvListGroups.TabIndex = 0;
            // 
            // ctrlButtonCardAddNew
            // 
            this.ctrlButtonCardAddNew.Icon = global::Check_Point_Manager.Properties.Resources.list_11066076;
            this.ctrlButtonCardAddNew.Location = new System.Drawing.Point(756, 146);
            this.ctrlButtonCardAddNew.Name = "ctrlButtonCardAddNew";
            this.ctrlButtonCardAddNew.Size = new System.Drawing.Size(100, 80);
            this.ctrlButtonCardAddNew.TabIndex = 4;
            this.ctrlButtonCardAddNew.Title = "Add New Group";
            this.ctrlButtonCardAddNew.Click += new System.EventHandler(this.ctrlButtonCardAddNew_Click);
            // 
            // frmManageListGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 497);
            this.Controls.Add(this.ctrlButtonCardAddNew);
            this.Controls.Add(this.dgvListGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageListGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Groups";
            this.Load += new System.EventHandler(this.frmManageListGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListGroups;
        private ctrlButtonCard ctrlButtonCardAddNew;
    }
}