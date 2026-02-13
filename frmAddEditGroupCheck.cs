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
        private int _GroupID = -1;
        private clsGroup _Group;
        public frmAddEditGroupCheck(int GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
        }

        private void frmAddEditGroupCheck_Load(object sender, EventArgs e)
        {
            dtpCheckDate.Format = DateTimePickerFormat.Custom;
            dtpCheckDate.CustomFormat = "dddd, dd/MM/yyyy - HH:mm tt";

            if (_GroupID == -1)
            {
                MessageBox.Show("No Group Found For This ID !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            lblGpID.Text = _Group.GroupID.ToString();
            lblGpName.Text = _Group.GroupName;
            lblGpNumber.Text = _Group.GroupNumber.ToString();
            lblCounter.Text = _Group.CheckCounter.ToString();

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
