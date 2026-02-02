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
    public partial class frmAddEditGroup : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private int _GroupID = -1;
        private clsGroup _Group;
        public frmAddEditGroup()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditGroup(int GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
            _Mode = enMode.Update;
        }
        private void _ResetDefaultValues()
        {
            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Checking Group";
               
                _Group = new clsGroup();
            }
            else
            {
                lblTitle.Text = "Update Checking Group Info";
            }

            txbGroupNumber.Text = "";
            txbGroupNumber.Text = clsGroup.GenerateNextGroupNumber().ToString();
            txbCounter.Text = "0";
            lblNewGpID.Text = "[???]";
            lblNewGpNumber.Text = "[???]";
            lblNewGpName.Text = "[???]";
            lblNewCounter.Text = "[???];";
        }
        private void _LoadData()
        {
            _Group = clsGroup.FindByID(_GroupID);

            if(_Group == null)
            {
                MessageBox.Show("Group With ID " + _GroupID + "is not Exists !", "Group Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txbGroupNumber.Text = _Group.GroupNumber.ToString();
            txbGroupName.Text = _Group.GroupName;
            txbCounter.Text = _Group.CheckCounter.ToString();
            lblNewGpID.Text = _Group.GroupID.ToString();
            lblNewGpNumber.Text = _Group.GroupNumber.ToString();
            lblNewGpName.Text = _Group.GroupName;
            lblNewCounter.Text = _Group.CheckCounter.ToString();
        }
       
        private void frmAddEditGroup_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if(_Mode == enMode.Update)
            {
                _LoadData();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Please Check Errors in Required Fields To Proceed", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int GroupNumber = Convert.ToInt32(txbGroupNumber.Text.Trim());
            
            if(_Mode == enMode.AddNew || _Group.GroupNumber != GroupNumber)
            {
                if (clsGroup.DoesGroupNumberExist(GroupNumber))
                {
                    MessageBox.Show("Group Number Already Exists, Choose Another Number", "Not Allowed",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            string GroupName = txbGroupName.Text.Trim();
            int CheckCounter = Convert.ToInt32(txbCounter.Text.Trim());

            _Group.GroupName = GroupName;
            _Group.GroupNumber = GroupNumber;
            _Group.CheckCounter = CheckCounter;

            if (_Group.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Group Info";

                    lblNewGpID.Text = _Group.GroupID.ToString();
                    lblNewGpName.Text = _Group.GroupName;
                    lblNewGpNumber.Text = _Group.GroupNumber.ToString();
                    lblNewCounter.Text = _Group.CheckCounter.ToString();

                    MessageBox.Show("Group Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    lblNewGpID.Text = _Group.GroupID.ToString();
                    lblNewGpName.Text = _Group.GroupName;
                    lblNewGpNumber.Text = _Group.GroupNumber.ToString();
                    lblNewCounter.Text = _Group.CheckCounter.ToString();

                    MessageBox.Show("Group Info Updated Successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.Close();

            }
            else
            {
                MessageBox.Show("Error While Adding Group !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbGroupNumber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbGroupNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbGroupNumber, "Group Number Cann't Be Empty");
            }
            else
            {
                errorProvider1.SetError(txbGroupNumber,null);
            }

            if(_Mode == enMode.AddNew)
            {
                if (clsGroup.DoesGroupNumberExist(Convert.ToInt32(txbGroupNumber.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txbGroupNumber, "Group Number Already Exists, Choose Another Number");
                }
                else
                {
                    errorProvider1.SetError(txbGroupNumber, null);
                }
            }
            
        }

        private void txbGroupName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbGroupName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbGroupName, "Group Name Cann't Be Empty");
            }
            else
            {
                errorProvider1.SetError(txbGroupName, null);
            }
        }

        private void txbCounter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbCounter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbCounter, "Counter Cann't Be Empty");
            }
            else
            {
                errorProvider1.SetError(txbCounter, null);
            }
        }

        private void txbCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
        private void txbGroupNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
