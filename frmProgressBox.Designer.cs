namespace Check_Point_Manager
{
    partial class frmProgressBox
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMessage.Location = new System.Drawing.Point(24, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(246, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "???";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbLoading
            // 
            this.pgbLoading.BackColor = System.Drawing.SystemColors.Highlight;
            this.pgbLoading.Location = new System.Drawing.Point(108, 63);
            this.pgbLoading.MarqueeAnimationSpeed = 50;
            this.pgbLoading.Minimum = 50;
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(79, 10);
            this.pgbLoading.Step = 50;
            this.pgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbLoading.TabIndex = 1;
            this.pgbLoading.UseWaitCursor = true;
            this.pgbLoading.Value = 50;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.pnlContainer.Controls.Add(this.pgbLoading);
            this.pnlContainer.Controls.Add(this.lblMessage);
            this.pnlContainer.Location = new System.Drawing.Point(3, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(294, 93);
            this.pnlContainer.TabIndex = 2;
            // 
            // frmProgressBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgressBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgressBox";
            this.TopMost = true;
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Panel pnlContainer;
    }
}