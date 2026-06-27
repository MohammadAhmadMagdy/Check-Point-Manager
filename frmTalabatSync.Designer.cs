namespace Check_Point_Manager
{
    partial class frmTalabatSync
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
            this.cmbSingleQtyPolicy = new MaterialSkin.Controls.MaterialComboBox();
            this.flpZeros = new System.Windows.Forms.FlowLayoutPanel();
            this.flpOnes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSync = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxOnes = new System.Windows.Forms.GroupBox();
            this.gbxZeros = new System.Windows.Forms.GroupBox();
            this.lblSingleQtyPolicy = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxOnes.SuspendLayout();
            this.gbxZeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSingleQtyPolicy
            // 
            this.cmbSingleQtyPolicy.AutoResize = false;
            this.cmbSingleQtyPolicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSingleQtyPolicy.Depth = 0;
            this.cmbSingleQtyPolicy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSingleQtyPolicy.DropDownHeight = 174;
            this.cmbSingleQtyPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingleQtyPolicy.DropDownWidth = 121;
            this.cmbSingleQtyPolicy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSingleQtyPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSingleQtyPolicy.FormattingEnabled = true;
            this.cmbSingleQtyPolicy.IntegralHeight = false;
            this.cmbSingleQtyPolicy.ItemHeight = 43;
            this.cmbSingleQtyPolicy.Location = new System.Drawing.Point(13, 62);
            this.cmbSingleQtyPolicy.MaxDropDownItems = 4;
            this.cmbSingleQtyPolicy.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSingleQtyPolicy.Name = "cmbSingleQtyPolicy";
            this.cmbSingleQtyPolicy.Size = new System.Drawing.Size(275, 49);
            this.cmbSingleQtyPolicy.StartIndex = 0;
            this.cmbSingleQtyPolicy.TabIndex = 0;
            // 
            // flpZeros
            // 
            this.flpZeros.AutoScroll = true;
            this.flpZeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpZeros.Location = new System.Drawing.Point(3, 16);
            this.flpZeros.Name = "flpZeros";
            this.flpZeros.Size = new System.Drawing.Size(265, 447);
            this.flpZeros.TabIndex = 1;
            // 
            // flpOnes
            // 
            this.flpOnes.AutoScroll = true;
            this.flpOnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOnes.Location = new System.Drawing.Point(3, 16);
            this.flpOnes.Name = "flpOnes";
            this.flpOnes.Size = new System.Drawing.Size(266, 447);
            this.flpOnes.TabIndex = 2;
            // 
            // btnSync
            // 
            this.btnSync.AutoSize = false;
            this.btnSync.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSync.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnSync.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSync.Depth = 0;
            this.btnSync.HighEmphasis = true;
            this.btnSync.Icon = null;
            this.btnSync.Location = new System.Drawing.Point(434, 75);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSync.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSync.Name = "btnSync";
            this.btnSync.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSync.Size = new System.Drawing.Size(134, 36);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Sync Stock";
            this.btnSync.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSync.UseAccentColor = false;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxOnes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxZeros, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 472);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // gbxOnes
            // 
            this.gbxOnes.Controls.Add(this.flpOnes);
            this.gbxOnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOnes.Location = new System.Drawing.Point(280, 3);
            this.gbxOnes.Name = "gbxOnes";
            this.gbxOnes.Size = new System.Drawing.Size(272, 466);
            this.gbxOnes.TabIndex = 5;
            this.gbxOnes.TabStop = false;
            this.gbxOnes.Text = "ONES";
            // 
            // gbxZeros
            // 
            this.gbxZeros.Controls.Add(this.flpZeros);
            this.gbxZeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxZeros.Location = new System.Drawing.Point(3, 3);
            this.gbxZeros.Name = "gbxZeros";
            this.gbxZeros.Size = new System.Drawing.Size(271, 466);
            this.gbxZeros.TabIndex = 5;
            this.gbxZeros.TabStop = false;
            this.gbxZeros.Text = "ZEROS";
            // 
            // lblSingleQtyPolicy
            // 
            this.lblSingleQtyPolicy.AutoSize = true;
            this.lblSingleQtyPolicy.Depth = 0;
            this.lblSingleQtyPolicy.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSingleQtyPolicy.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblSingleQtyPolicy.ForeColor = System.Drawing.Color.Coral;
            this.lblSingleQtyPolicy.Location = new System.Drawing.Point(13, 35);
            this.lblSingleQtyPolicy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSingleQtyPolicy.Name = "lblSingleQtyPolicy";
            this.lblSingleQtyPolicy.Size = new System.Drawing.Size(223, 17);
            this.lblSingleQtyPolicy.TabIndex = 5;
            this.lblSingleQtyPolicy.Text = "Choose to Show or Hide last piece :";
            this.lblSingleQtyPolicy.UseAccent = true;
            // 
            // frmTalabatSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 604);
            this.Controls.Add(this.lblSingleQtyPolicy);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.cmbSingleQtyPolicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTalabatSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talabat Sync";
            this.Load += new System.EventHandler(this.frmTalabatSync_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxOnes.ResumeLayout(false);
            this.gbxZeros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbSingleQtyPolicy;
        private System.Windows.Forms.FlowLayoutPanel flpZeros;
        private System.Windows.Forms.FlowLayoutPanel flpOnes;
        private MaterialSkin.Controls.MaterialButton btnSync;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxZeros;
        private System.Windows.Forms.GroupBox gbxOnes;
        private MaterialSkin.Controls.MaterialLabel lblSingleQtyPolicy;
    }
}