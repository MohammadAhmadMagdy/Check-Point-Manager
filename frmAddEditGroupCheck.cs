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
    public partial class frmAddEditGroupCheck : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;
        private int _CheckID = -1;
        private clsCheck _Check;
        private int _GroupID = -1;
        private clsGroup _Group;
        public frmAddEditGroupCheck(int ID, enMode Mode)
        {
            InitializeComponent();
            _Mode = Mode;
            if (_Mode == enMode.AddNew)
            {
                _GroupID = ID;
            }
            else
                _CheckID = ID;
        }

        private void frmAddEditGroupCheck_Load(object sender, EventArgs e)
        {
            dtpCheckDate.Format = DateTimePickerFormat.Custom;
            dtpCheckDate.CustomFormat = "dddd, dd/MM/yyyy - HH:mm tt";
            dtpCheckDate.MaxDate = DateTime.Now;
            dtpCheckDate.Value = DateTime.Now;

            if(_Mode == enMode.AddNew)
            {
                if (_GroupID == -1)
                {
                    MessageBox.Show("Please Select a group first to add a check point to it !", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _Group = clsGroup.FindByID(_GroupID);

                if (_Group == null)
                {
                    MessageBox.Show("Error loading selected group !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lblTitle.Text = "Add New Checkpoint Time";
                lblGpID.Text = _Group.GroupID.ToString();
                lblGpName.Text = _Group.GroupName;
                lblGpNumber.Text = _Group.GroupNumber.ToString();
                lblCounter.Text = _Group.CheckCounter.ToString();

                _Check = clsCheck.CreateNewCheckForGroup(_GroupID);

            }
            else
            {
                if (_Mode == enMode.Update && _CheckID == -1)
                {
                    MessageBox.Show("Please Select a Checkpoint first to edit it !", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _Check = clsCheck.FindByID(_CheckID);

                if (_Check == null)
                {
                    MessageBox.Show("Error loading selected Checkpoint !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lblTitle.Text = "Edit Checkpoint Time";
                lblGpID.Text = _Check.GroupID.ToString();
                lblGpName.Text = _Check.GroupInfo.GroupName;
                lblGpNumber.Text = _Check.GroupInfo.GroupNumber.ToString();
                lblCounter.Text = _Check.GroupInfo.CheckCounter.ToString();
            }

            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime CheckDate = dtpCheckDate.Value;

            clsCheck NewCheckRecord = clsCheck.CreateNewCheckForGroup(_GroupID);

            NewCheckRecord.CheckedDate = CheckDate;

            if(!NewCheckRecord.Save())
            {
                MessageBox.Show("Error Saving Check Record !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Group : {_Group.GroupName} Checked Successfully\n" +
                $"at Date {CheckDate}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
