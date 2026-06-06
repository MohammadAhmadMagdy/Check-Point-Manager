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
    public partial class frmUsersList : Form
    {
        DataTable _dtUsersList;
        public frmUsersList()
        {
            InitializeComponent();
        }
        private void _AdjustDataGridColumns()
        {
            dgvUsersList.Columns[0].HeaderText = "User ID";
            dgvUsersList.Columns[0].Width = 130;
            
            dgvUsersList.Columns[1].HeaderText = "User Name";
            dgvUsersList.Columns[1].Width = 262;
            
            dgvUsersList.Columns[2].HeaderText = "Is Active?";
            dgvUsersList.Columns[2].Width = 120;
          
           
        }
        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 220, 218);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);


            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(241, 240, 241);
        }
        private void _LoadAllUsersLis()
        {
            _dtUsersList = clsUser.GetAllUsers();

            dgvUsersList.DataSource = _dtUsersList;

            _AddVisualStyleToTable(dgvUsersList);

            if (dgvUsersList.Rows.Count > 0)
            {
                _AdjustDataGridColumns();

                lblTotalUsers.Text = dgvUsersList.RowCount.ToString();
            }
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _LoadAllUsersLis();
        }

        private void dgvUsersList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvUsersList.ClearSelection();
                dgvUsersList.CurrentCell = dgvUsersList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();

            _LoadAllUsersLis();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsersList.CurrentRow.Cells[0].Value);

            frmAddEditUser frm = new frmAddEditUser(UserID);
            frm.ShowDialog();

            _LoadAllUsersLis();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsersList.CurrentRow.Cells[0].Value);
            clsUser User = clsUser.FindByID(UserID);

            if (MessageBox.Show("Are you sure you want to delete user with ID " + UserID + " ?", "Confirm"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (User.IsAParticipantInChecks())
            {
                MessageBox.Show("User with ID " + UserID + " Can't be deleted\nbecause He/She is a participant in Checks" +
                    "\nYou may Inactivate user instead.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (clsUser.Delete(UserID))
            {
                MessageBox.Show("User with ID " + UserID + " deleted successfully", "Success"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                _LoadAllUsersLis();
            }
            else
            {
                MessageBox.Show("Error while deleting data !!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
