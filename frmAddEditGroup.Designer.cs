namespace Check_Point_Manager
{
    partial class frmAddEditGroup
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
            this.txbGroupNumber = new System.Windows.Forms.TextBox();
            this.lblEnterGroupNumber = new System.Windows.Forms.Label();
            this.lblEnterGroupName = new System.Windows.Forms.Label();
            this.txbGroupName = new System.Windows.Forms.TextBox();
            this.lblNewGroupIDTitle = new System.Windows.Forms.Label();
            this.lblNewGroupNumberTitle = new System.Windows.Forms.Label();
            this.lblNewGroupNameTile = new System.Windows.Forms.Label();
            this.lblNewGpID = new System.Windows.Forms.Label();
            this.lblNewGpName = new System.Windows.Forms.Label();
            this.lblNewGpNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbGroupName = new System.Windows.Forms.PictureBox();
            this.pcbGpNumber = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGpNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGroupNumber
            // 
            this.txbGroupNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.txbGroupNumber.Location = new System.Drawing.Point(196, 116);
            this.txbGroupNumber.Name = "txbGroupNumber";
            this.txbGroupNumber.Size = new System.Drawing.Size(170, 28);
            this.txbGroupNumber.TabIndex = 0;
            this.txbGroupNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGroupNumber_KeyPress);
            // 
            // lblEnterGroupNumber
            // 
            this.lblEnterGroupNumber.AutoSize = true;
            this.lblEnterGroupNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGroupNumber.Location = new System.Drawing.Point(15, 119);
            this.lblEnterGroupNumber.Name = "lblEnterGroupNumber";
            this.lblEnterGroupNumber.Size = new System.Drawing.Size(132, 21);
            this.lblEnterGroupNumber.TabIndex = 1;
            this.lblEnterGroupNumber.Text = "Group Number :";
            // 
            // lblEnterGroupName
            // 
            this.lblEnterGroupName.AutoSize = true;
            this.lblEnterGroupName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGroupName.Location = new System.Drawing.Point(15, 150);
            this.lblEnterGroupName.Name = "lblEnterGroupName";
            this.lblEnterGroupName.Size = new System.Drawing.Size(115, 21);
            this.lblEnterGroupName.TabIndex = 3;
            this.lblEnterGroupName.Text = "Group Name :";
            // 
            // txbGroupName
            // 
            this.txbGroupName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.txbGroupName.Location = new System.Drawing.Point(196, 147);
            this.txbGroupName.Name = "txbGroupName";
            this.txbGroupName.Size = new System.Drawing.Size(456, 28);
            this.txbGroupName.TabIndex = 2;
            // 
            // lblNewGroupIDTitle
            // 
            this.lblNewGroupIDTitle.AutoSize = true;
            this.lblNewGroupIDTitle.Location = new System.Drawing.Point(6, 36);
            this.lblNewGroupIDTitle.Name = "lblNewGroupIDTitle";
            this.lblNewGroupIDTitle.Size = new System.Drawing.Size(86, 21);
            this.lblNewGroupIDTitle.TabIndex = 4;
            this.lblNewGroupIDTitle.Text = "Group ID :";
            // 
            // lblNewGroupNumberTitle
            // 
            this.lblNewGroupNumberTitle.AutoSize = true;
            this.lblNewGroupNumberTitle.Location = new System.Drawing.Point(6, 70);
            this.lblNewGroupNumberTitle.Name = "lblNewGroupNumberTitle";
            this.lblNewGroupNumberTitle.Size = new System.Drawing.Size(132, 21);
            this.lblNewGroupNumberTitle.TabIndex = 5;
            this.lblNewGroupNumberTitle.Text = "Group Number :";
            // 
            // lblNewGroupNameTile
            // 
            this.lblNewGroupNameTile.AutoSize = true;
            this.lblNewGroupNameTile.Location = new System.Drawing.Point(6, 104);
            this.lblNewGroupNameTile.Name = "lblNewGroupNameTile";
            this.lblNewGroupNameTile.Size = new System.Drawing.Size(115, 21);
            this.lblNewGroupNameTile.TabIndex = 6;
            this.lblNewGroupNameTile.Text = "Group Name :";
            // 
            // lblNewGpID
            // 
            this.lblNewGpID.AutoSize = true;
            this.lblNewGpID.Location = new System.Drawing.Point(187, 36);
            this.lblNewGpID.Name = "lblNewGpID";
            this.lblNewGpID.Size = new System.Drawing.Size(43, 21);
            this.lblNewGpID.TabIndex = 7;
            this.lblNewGpID.Text = "[???]";
            // 
            // lblNewGpName
            // 
            this.lblNewGpName.AutoSize = true;
            this.lblNewGpName.Location = new System.Drawing.Point(187, 104);
            this.lblNewGpName.Name = "lblNewGpName";
            this.lblNewGpName.Size = new System.Drawing.Size(43, 21);
            this.lblNewGpName.TabIndex = 8;
            this.lblNewGpName.Text = "[???]";
            // 
            // lblNewGpNumber
            // 
            this.lblNewGpNumber.AutoSize = true;
            this.lblNewGpNumber.Location = new System.Drawing.Point(187, 70);
            this.lblNewGpNumber.Name = "lblNewGpNumber";
            this.lblNewGpNumber.Size = new System.Drawing.Size(43, 21);
            this.lblNewGpNumber.TabIndex = 9;
            this.lblNewGpNumber.Text = "[???]";
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Medium ITC", 27.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(666, 49);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Add New Check Point Group";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(602, 388);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(50, 21);
            this.lblSave.TabIndex = 14;
            this.lblSave.Text = " Save";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNewGpName);
            this.groupBox1.Controls.Add(this.lblNewGroupIDTitle);
            this.groupBox1.Controls.Add(this.lblNewGroupNumberTitle);
            this.groupBox1.Controls.Add(this.lblNewGroupNameTile);
            this.groupBox1.Controls.Add(this.lblNewGpID);
            this.groupBox1.Controls.Add(this.lblNewGpNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Info";
            // 
            // pcbGroupName
            // 
            this.pcbGroupName.Image = global::Check_Point_Manager.Properties.Resources.article;
            this.pcbGroupName.Location = new System.Drawing.Point(158, 147);
            this.pcbGroupName.Name = "pcbGroupName";
            this.pcbGroupName.Size = new System.Drawing.Size(32, 28);
            this.pcbGroupName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupName.TabIndex = 13;
            this.pcbGroupName.TabStop = false;
            // 
            // pcbGpNumber
            // 
            this.pcbGpNumber.Image = global::Check_Point_Manager.Properties.Resources.counter;
            this.pcbGpNumber.Location = new System.Drawing.Point(158, 116);
            this.pcbGpNumber.Name = "pcbGpNumber";
            this.pcbGpNumber.Size = new System.Drawing.Size(32, 28);
            this.pcbGpNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGpNumber.TabIndex = 12;
            this.pcbGpNumber.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Check_Point_Manager.Properties.Resources.remove;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(523, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Check_Point_Manager.Properties.Resources.AddNew;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(606, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(519, 388);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(61, 21);
            this.lblCancel.TabIndex = 19;
            this.lblCancel.Text = "Cancel";
            // 
            // frmAddEditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 415);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.pcbGroupName);
            this.Controls.Add(this.pcbGpNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEnterGroupName);
            this.Controls.Add(this.txbGroupName);
            this.Controls.Add(this.lblEnterGroupNumber);
            this.Controls.Add(this.txbGroupNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Group";
            this.Load += new System.EventHandler(this.frmAddEditGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGpNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGroupNumber;
        private System.Windows.Forms.Label lblEnterGroupNumber;
        private System.Windows.Forms.Label lblEnterGroupName;
        private System.Windows.Forms.TextBox txbGroupName;
        private System.Windows.Forms.Label lblNewGroupIDTitle;
        private System.Windows.Forms.Label lblNewGroupNumberTitle;
        private System.Windows.Forms.Label lblNewGroupNameTile;
        private System.Windows.Forms.Label lblNewGpID;
        private System.Windows.Forms.Label lblNewGpName;
        private System.Windows.Forms.Label lblNewGpNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbGpNumber;
        private System.Windows.Forms.PictureBox pcbGroupName;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCancel;
    }
}