namespace Check_Point_Manager
{
    partial class frmAddGroup
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pcbGroupName = new System.Windows.Forms.PictureBox();
            this.pcbGpNumber = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGpNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbGroupNumber
            // 
            this.txbGroupNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.txbGroupNumber.Location = new System.Drawing.Point(247, 73);
            this.txbGroupNumber.Name = "txbGroupNumber";
            this.txbGroupNumber.Size = new System.Drawing.Size(170, 28);
            this.txbGroupNumber.TabIndex = 0;
            this.txbGroupNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGroupNumber_KeyPress);
            // 
            // lblEnterGroupNumber
            // 
            this.lblEnterGroupNumber.AutoSize = true;
            this.lblEnterGroupNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGroupNumber.Location = new System.Drawing.Point(15, 74);
            this.lblEnterGroupNumber.Name = "lblEnterGroupNumber";
            this.lblEnterGroupNumber.Size = new System.Drawing.Size(176, 21);
            this.lblEnterGroupNumber.TabIndex = 1;
            this.lblEnterGroupNumber.Text = "Enter Group Number :";
            // 
            // lblEnterGroupName
            // 
            this.lblEnterGroupName.AutoSize = true;
            this.lblEnterGroupName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGroupName.Location = new System.Drawing.Point(15, 107);
            this.lblEnterGroupName.Name = "lblEnterGroupName";
            this.lblEnterGroupName.Size = new System.Drawing.Size(159, 21);
            this.lblEnterGroupName.TabIndex = 3;
            this.lblEnterGroupName.Text = "Enter Group Name :";
            // 
            // txbGroupName
            // 
            this.txbGroupName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.txbGroupName.Location = new System.Drawing.Point(247, 104);
            this.txbGroupName.Name = "txbGroupName";
            this.txbGroupName.Size = new System.Drawing.Size(331, 28);
            this.txbGroupName.TabIndex = 2;
            // 
            // lblNewGroupIDTitle
            // 
            this.lblNewGroupIDTitle.AutoSize = true;
            this.lblNewGroupIDTitle.Location = new System.Drawing.Point(6, 36);
            this.lblNewGroupIDTitle.Name = "lblNewGroupIDTitle";
            this.lblNewGroupIDTitle.Size = new System.Drawing.Size(125, 21);
            this.lblNewGroupIDTitle.TabIndex = 4;
            this.lblNewGroupIDTitle.Text = "New Group ID :";
            // 
            // lblNewGroupNumberTitle
            // 
            this.lblNewGroupNumberTitle.AutoSize = true;
            this.lblNewGroupNumberTitle.Location = new System.Drawing.Point(6, 70);
            this.lblNewGroupNumberTitle.Name = "lblNewGroupNumberTitle";
            this.lblNewGroupNumberTitle.Size = new System.Drawing.Size(171, 21);
            this.lblNewGroupNumberTitle.TabIndex = 5;
            this.lblNewGroupNumberTitle.Text = "New Group Number :";
            // 
            // lblNewGroupNameTile
            // 
            this.lblNewGroupNameTile.AutoSize = true;
            this.lblNewGroupNameTile.Location = new System.Drawing.Point(6, 104);
            this.lblNewGroupNameTile.Name = "lblNewGroupNameTile";
            this.lblNewGroupNameTile.Size = new System.Drawing.Size(154, 21);
            this.lblNewGroupNameTile.TabIndex = 6;
            this.lblNewGroupNameTile.Text = "New Group Name :";
            // 
            // lblNewGpID
            // 
            this.lblNewGpID.AutoSize = true;
            this.lblNewGpID.Location = new System.Drawing.Point(231, 36);
            this.lblNewGpID.Name = "lblNewGpID";
            this.lblNewGpID.Size = new System.Drawing.Size(43, 21);
            this.lblNewGpID.TabIndex = 7;
            this.lblNewGpID.Text = "[???]";
            // 
            // lblNewGpName
            // 
            this.lblNewGpName.AutoSize = true;
            this.lblNewGpName.Location = new System.Drawing.Point(231, 104);
            this.lblNewGpName.Name = "lblNewGpName";
            this.lblNewGpName.Size = new System.Drawing.Size(43, 21);
            this.lblNewGpName.TabIndex = 8;
            this.lblNewGpName.Text = "[???]";
            // 
            // lblNewGpNumber
            // 
            this.lblNewGpNumber.AutoSize = true;
            this.lblNewGpNumber.Location = new System.Drawing.Point(231, 70);
            this.lblNewGpNumber.Name = "lblNewGpNumber";
            this.lblNewGpNumber.Size = new System.Drawing.Size(43, 21);
            this.lblNewGpNumber.TabIndex = 9;
            this.lblNewGpNumber.Text = "[???]";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Check_Point_Manager.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(19, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 51);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(589, 49);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Add New Check Group";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbGroupName
            // 
            this.pcbGroupName.Image = global::Check_Point_Manager.Properties.Resources.document_6886723;
            this.pcbGroupName.Location = new System.Drawing.Point(197, 103);
            this.pcbGroupName.Name = "pcbGroupName";
            this.pcbGroupName.Size = new System.Drawing.Size(32, 25);
            this.pcbGroupName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGroupName.TabIndex = 13;
            this.pcbGroupName.TabStop = false;
            // 
            // pcbGpNumber
            // 
            this.pcbGpNumber.Image = global::Check_Point_Manager.Properties.Resources.numbers_11072538;
            this.pcbGpNumber.Location = new System.Drawing.Point(197, 73);
            this.pcbGpNumber.Name = "pcbGpNumber";
            this.pcbGpNumber.Size = new System.Drawing.Size(32, 25);
            this.pcbGpNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGpNumber.TabIndex = 12;
            this.pcbGpNumber.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Group";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Group Info";
            // 
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbGroupName);
            this.Controls.Add(this.pcbGpNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEnterGroupName);
            this.Controls.Add(this.txbGroupName);
            this.Controls.Add(this.lblEnterGroupNumber);
            this.Controls.Add(this.txbGroupNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Group";
            ((System.ComponentModel.ISupportInitialize)(this.pcbGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGpNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbGpNumber;
        private System.Windows.Forms.PictureBox pcbGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}