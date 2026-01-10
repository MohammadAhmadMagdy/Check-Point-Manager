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
        }
        public frmAddEditGroup(int GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
            _Mode = enMode.Update;
        }

       
        private void txbGroupNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void frmAddEditGroup_Load(object sender, EventArgs e)
        {
            if(_GroupID == -1)
            {
                _Mode = enMode.AddNew;
                _Group = new clsGroup();
                return;
            }

            if(_Mode == enMode.Update)
            {
                lblTitle.Text = "Update Group Info";
          
                _Group = clsGroup.FindByID(_GroupID);
                txbGroupNumber.Text = _Group.GroupNumber.ToString();
                txbGroupName.Text = _Group.GroupName;
                lblNewGpID.Text = _Group.GroupID.ToString();
                lblNewGpNumber.Text = _Group.GroupNumber.ToString();
                lblNewGpName.Text = _Group.GroupName;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int GroupNumber = Convert.ToInt32(txbGroupNumber.Text);
            string GroupName = txbGroupName.Text;

            _Group.GroupName = GroupName;
            _Group.GroupNumber = GroupNumber;

            if (_Group.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                   
                    MessageBox.Show("Group Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Group Info";

                    lblNewGpID.Text = _Group.GroupID.ToString();
                    lblNewGpName.Text = _Group.GroupName;
                    lblNewGpNumber.Text = _Group.GroupNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Group Info Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNewGpID.Text = _Group.GroupID.ToString();
                    lblNewGpName.Text = _Group.GroupName;
                    lblNewGpNumber.Text = _Group.GroupNumber.ToString();
                }

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
    }
}
