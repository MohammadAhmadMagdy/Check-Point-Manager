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
    public partial class frmAddEditUser : Form
    {
        private enum enMode { AddNew = 0, Update =1 }
        private enMode _Mode = enMode.AddNew;
        private int _UserID = -1;
        private clsUser _User;
        private const string _AddNewTitle = "Add New User";
        private const string _UpdateTitle = "Update User";
        public frmAddEditUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = _AddNewTitle;

                _User = new clsUser();
            }
            else
            {
                lblTitle.Text = _UpdateTitle;
            }

            rdbActive.Checked = true;
            txbUserName.Text = "";
            txbPassword.Text = "";
            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            lblPassword.Text = "[????]";
            lblIsActive.Text = "[????]";
        }
        private void _LoadUserData()
        {
            if (_UserID == -1)
            {
                MessageBox.Show("This user ID is not exists !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _User = clsUser.FindByID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("User with ID " + _UserID + " is not found !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            rdbActive.Checked = _User.IsActive;
            rdbInActive.Checked = !_User.IsActive;
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblPassword.Text = _User.Password;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadUserData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbUserName.Text))
            {
                MessageBox.Show("User name required","Required Field",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txbUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                MessageBox.Show("Password required", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPassword.Focus();
                return;
            }

            _User.IsActive = rdbActive.Checked;
            _User.UserName = txbUserName.Text.Trim();
            _User.Password = txbPassword.Text.Trim();

            if (!_User.Save())
            {
                MessageBox.Show("Error saving data !!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("User data saved successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblTitle.Text = _UpdateTitle;
            _UserID = _User.UserID;
            _LoadUserData();
        }
    }
}
