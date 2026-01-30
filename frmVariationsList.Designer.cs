namespace Check_Point_Manager
{
    partial class frmVariationsList
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
            this.dgvVariationList = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSettle = new System.Windows.Forms.Button();
            this.lblNoVariations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariationList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVariationList
            // 
            this.dgvVariationList.AllowUserToAddRows = false;
            this.dgvVariationList.AllowUserToDeleteRows = false;
            this.dgvVariationList.AllowUserToOrderColumns = true;
            this.dgvVariationList.BackgroundColor = System.Drawing.Color.White;
            this.dgvVariationList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVariationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVariationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVariationList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVariationList.Location = new System.Drawing.Point(12, 79);
            this.dgvVariationList.Name = "dgvVariationList";
            this.dgvVariationList.RowHeadersVisible = false;
            this.dgvVariationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariationList.Size = new System.Drawing.Size(929, 228);
            this.dgvVariationList.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Medium ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(929, 49);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Item Variations List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettle
            // 
            this.btnSettle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(174)))));
            this.btnSettle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettle.ForeColor = System.Drawing.Color.White;
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettle.Location = new System.Drawing.Point(759, 313);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(182, 57);
            this.btnSettle.TabIndex = 34;
            this.btnSettle.Text = "Settle Variation";
            this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettle.UseVisualStyleBackColor = false;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // lblNoVariations
            // 
            this.lblNoVariations.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoVariations.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNoVariations.Location = new System.Drawing.Point(20, 108);
            this.lblNoVariations.Name = "lblNoVariations";
            this.lblNoVariations.Size = new System.Drawing.Size(909, 46);
            this.lblNoVariations.TabIndex = 35;
            this.lblNoVariations.Text = "No Variations Found .. GREAT JOB !!";
            this.lblNoVariations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVariationsList
            // 
            this.AcceptButton = this.btnSettle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 382);
            this.Controls.Add(this.lblNoVariations);
            this.Controls.Add(this.btnSettle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvVariationList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVariationsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variations List";
            this.Load += new System.EventHandler(this.frmVariationsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVariationList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Label lblNoVariations;
    }
}