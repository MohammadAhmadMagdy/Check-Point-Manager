namespace Check_Point_Manager
{
    partial class frmAddEditGroupCheck
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
            this.dtpCheckDate = new System.Windows.Forms.DateTimePicker();
            this.gbxGroupInfo = new System.Windows.Forms.GroupBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblCounterTitle = new System.Windows.Forms.Label();
            this.lblGpName = new System.Windows.Forms.Label();
            this.lblGroupIDTitle = new System.Windows.Forms.Label();
            this.lblGroupNumberTitle = new System.Windows.Forms.Label();
            this.lblGroupNameTile = new System.Windows.Forms.Label();
            this.lblGpID = new System.Windows.Forms.Label();
            this.lblGpNumber = new System.Windows.Forms.Label();
            this.lblCheckDateTitle = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxGroupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCheckDate
            // 
            this.dtpCheckDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpCheckDate.CustomFormat = "dddd,dd/MM/yyyy - HH:MM tt";
            this.dtpCheckDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckDate.Location = new System.Drawing.Point(119, 254);
            this.dtpCheckDate.MaxDate = new System.DateTime(2026, 2, 15, 0, 0, 0, 0);
            this.dtpCheckDate.Name = "dtpCheckDate";
            this.dtpCheckDate.ShowUpDown = true;
            this.dtpCheckDate.Size = new System.Drawing.Size(234, 23);
            this.dtpCheckDate.TabIndex = 0;
            this.dtpCheckDate.Value = new System.DateTime(2026, 2, 13, 0, 0, 0, 0);
            // 
            // gbxGroupInfo
            // 
            this.gbxGroupInfo.Controls.Add(this.lblCounter);
            this.gbxGroupInfo.Controls.Add(this.lblCounterTitle);
            this.gbxGroupInfo.Controls.Add(this.lblGpName);
            this.gbxGroupInfo.Controls.Add(this.lblGroupIDTitle);
            this.gbxGroupInfo.Controls.Add(this.lblGroupNumberTitle);
            this.gbxGroupInfo.Controls.Add(this.lblGroupNameTile);
            this.gbxGroupInfo.Controls.Add(this.lblGpID);
            this.gbxGroupInfo.Controls.Add(this.lblGpNumber);
            this.gbxGroupInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGroupInfo.Location = new System.Drawing.Point(12, 60);
            this.gbxGroupInfo.Name = "gbxGroupInfo";
            this.gbxGroupInfo.Size = new System.Drawing.Size(812, 176);
            this.gbxGroupInfo.TabIndex = 16;
            this.gbxGroupInfo.TabStop = false;
            this.gbxGroupInfo.Text = "Group Info";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(187, 136);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(36, 17);
            this.lblCounter.TabIndex = 11;
            this.lblCounter.Text = "[???]";
            // 
            // lblCounterTitle
            // 
            this.lblCounterTitle.AutoSize = true;
            this.lblCounterTitle.Location = new System.Drawing.Point(6, 136);
            this.lblCounterTitle.Name = "lblCounterTitle";
            this.lblCounterTitle.Size = new System.Drawing.Size(107, 17);
            this.lblCounterTitle.TabIndex = 10;
            this.lblCounterTitle.Text = "Group Counter :";
            // 
            // lblGpName
            // 
            this.lblGpName.AutoSize = true;
            this.lblGpName.Location = new System.Drawing.Point(187, 104);
            this.lblGpName.Name = "lblGpName";
            this.lblGpName.Size = new System.Drawing.Size(36, 17);
            this.lblGpName.TabIndex = 8;
            this.lblGpName.Text = "[???]";
            // 
            // lblGroupIDTitle
            // 
            this.lblGroupIDTitle.AutoSize = true;
            this.lblGroupIDTitle.Location = new System.Drawing.Point(6, 36);
            this.lblGroupIDTitle.Name = "lblGroupIDTitle";
            this.lblGroupIDTitle.Size = new System.Drawing.Size(72, 17);
            this.lblGroupIDTitle.TabIndex = 4;
            this.lblGroupIDTitle.Text = "Group ID :";
            // 
            // lblGroupNumberTitle
            // 
            this.lblGroupNumberTitle.AutoSize = true;
            this.lblGroupNumberTitle.Location = new System.Drawing.Point(6, 70);
            this.lblGroupNumberTitle.Name = "lblGroupNumberTitle";
            this.lblGroupNumberTitle.Size = new System.Drawing.Size(108, 17);
            this.lblGroupNumberTitle.TabIndex = 5;
            this.lblGroupNumberTitle.Text = "Group Number :";
            // 
            // lblGroupNameTile
            // 
            this.lblGroupNameTile.AutoSize = true;
            this.lblGroupNameTile.Location = new System.Drawing.Point(6, 104);
            this.lblGroupNameTile.Name = "lblGroupNameTile";
            this.lblGroupNameTile.Size = new System.Drawing.Size(94, 17);
            this.lblGroupNameTile.TabIndex = 6;
            this.lblGroupNameTile.Text = "Group Name :";
            // 
            // lblGpID
            // 
            this.lblGpID.AutoSize = true;
            this.lblGpID.Location = new System.Drawing.Point(187, 36);
            this.lblGpID.Name = "lblGpID";
            this.lblGpID.Size = new System.Drawing.Size(36, 17);
            this.lblGpID.TabIndex = 7;
            this.lblGpID.Text = "[???]";
            // 
            // lblGpNumber
            // 
            this.lblGpNumber.AutoSize = true;
            this.lblGpNumber.Location = new System.Drawing.Point(187, 70);
            this.lblGpNumber.Name = "lblGpNumber";
            this.lblGpNumber.Size = new System.Drawing.Size(36, 17);
            this.lblGpNumber.TabIndex = 9;
            this.lblGpNumber.Text = "[???]";
            // 
            // lblCheckDateTitle
            // 
            this.lblCheckDateTitle.AutoSize = true;
            this.lblCheckDateTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckDateTitle.Location = new System.Drawing.Point(8, 256);
            this.lblCheckDateTitle.Name = "lblCheckDateTitle";
            this.lblCheckDateTitle.Size = new System.Drawing.Size(105, 20);
            this.lblCheckDateTitle.TabIndex = 17;
            this.lblCheckDateTitle.Text = "Choose Date :";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(691, 255);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(61, 21);
            this.lblCancel.TabIndex = 23;
            this.lblCancel.Text = "Cancel";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Check_Point_Manager.Properties.Resources.remove;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(695, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 48);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(770, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 48);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(766, 255);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(50, 21);
            this.lblSave.TabIndex = 20;
            this.lblSave.Text = " Save";
            // 
            // lblTitle
            // 
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Eras Medium ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(812, 34);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Add New Checking Point Time";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddEditGroupCheck
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 342);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblCheckDateTitle);
            this.Controls.Add(this.gbxGroupInfo);
            this.Controls.Add(this.dtpCheckDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditGroupCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Group Check";
            this.Load += new System.EventHandler(this.frmAddEditGroupCheck_Load);
            this.gbxGroupInfo.ResumeLayout(false);
            this.gbxGroupInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCheckDate;
        private System.Windows.Forms.GroupBox gbxGroupInfo;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblCounterTitle;
        private System.Windows.Forms.Label lblGpName;
        private System.Windows.Forms.Label lblGroupIDTitle;
        private System.Windows.Forms.Label lblGroupNumberTitle;
        private System.Windows.Forms.Label lblGroupNameTile;
        private System.Windows.Forms.Label lblGpID;
        private System.Windows.Forms.Label lblGpNumber;
        private System.Windows.Forms.Label lblCheckDateTitle;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblTitle;
    }
}