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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void _FillComboBoxUsers()
        {
            DataTable dtUsers = clsUser.GetAllActiveUsers();

            cmbUsers.DataSource = dtUsers;
            cmbUsers.DisplayMember = "UserName";
            cmbUsers.ValueMember = "UserID";
            cmbUsers.SelectedIndex = -1;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _FillComboBoxUsers();

            btnLogin.Enabled = false;
            txbPassword.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = cmbUsers.SelectedIndex != -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(cmbUsers.SelectedValue);

            if (!clsUser.Login(UserID))
            {
                MessageBox.Show("This user is inactive!", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            frmMainScreen frm = new frmMainScreen();
            frm.ShowDialog();
            this.Close();
        }
    }
}
