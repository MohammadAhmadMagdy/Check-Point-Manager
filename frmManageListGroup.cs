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
    public partial class frmManageListGroup : Form
    {
        private DataTable _AllGroups;
        private DataTable _GroupsView;
        public frmManageListGroup()
        {
            InitializeComponent();
        }
     
        private void frmManageListGroup_Load(object sender, EventArgs e)
        {
            _AllGroups = clsGroup.LoadAllGroupsInfo();
           // _GroupsView = _AllGroups.DefaultView.ToTable(false, "GroupNumber", "GroupName");

            dgvListGroups.DataSource = _AllGroups;

           

           dgvListGroups.EnableHeadersVisualStyles = false;
           dgvListGroups.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
           dgvListGroups.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           dgvListGroups.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);

            dgvListGroups.RowsDefaultCellStyle.BackColor = Color.White;
            dgvListGroups.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            if (dgvListGroups.Rows.Count > 0)
            {
                dgvListGroups.Columns[0].HeaderText = "ID";
                dgvListGroups.Columns[0].Width = 30;
                dgvListGroups.Columns[0].Visible = false;

                dgvListGroups.Columns[1].HeaderText = "Group No.";
                dgvListGroups.Columns[1].Width = 100;

                dgvListGroups.Columns[2].HeaderText = "Group Name";
                dgvListGroups.Columns[2].Width = 630;
            }

            lblNumberOfGroups.Text = dgvListGroups.RowCount.ToString();
        }

        
        private void dgvListGroups_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var HitTestInfo = dgvListGroups.HitTest(e.X, e.Y);

                if (HitTestInfo.RowIndex >= 0)
                {
                    dgvListGroups.ClearSelection();
                    dgvListGroups.Rows[HitTestInfo.RowIndex].Selected = true;
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditGroup frm = new frmAddEditGroup();
            frm.ShowDialog();
            frmManageListGroup_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int GroupID = Convert.ToInt32(dgvListGroups.CurrentRow.Cells[0].Value);

            frmAddEditGroup frm = new frmAddEditGroup(GroupID);
            frm.ShowDialog();

            frmManageListGroup_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string GroupName = dgvListGroups.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show("Are you sure you want to delete Group\n(" + GroupName + ") ?", "Confirm",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int GroupID = Convert.ToInt32(dgvListGroups.CurrentRow.Cells[0].Value);

            if(!clsGroup.Delete(GroupID))
            {
                MessageBox.Show("Error While Deleting !", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Group\n(" + GroupName + ")\nDeleted successfully", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            frmManageListGroup_Load(null, null);
        }
    }
}
