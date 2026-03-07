using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckPointBusinessLayer;

namespace Check_Point_Manager
{
    public partial class frmAppVersion : Form
    {
        public frmAppVersion()
        {
            InitializeComponent();
        }

        private void frmAppVersion_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text = clsSettings.GetValue(clsSettings.Keys.AppVersion);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NewVersion = txbUpdateAppVersion.Text.Trim();

            if(string.IsNullOrWhiteSpace(NewVersion))
            {
                MessageBox.Show("New App Version Can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUpdateAppVersion.Focus();
                return;
            }

            if (!clsSettings.SetValue(clsSettings.Keys.AppVersion, NewVersion))
            {
                MessageBox.Show("Error Saving App New Version !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("New version saved successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblCurrentVersion.Text = clsSettings.GetValue(clsSettings.Keys.AppVersion);
        }
    }
}
