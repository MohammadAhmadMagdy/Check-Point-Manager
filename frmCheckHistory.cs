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
    public partial class frmCheckHistory : Form
    {
        private bool _IsLoadingGroup = false;
        private int _GroupID = -1;
        private DataTable _dtGroupsList;
        private DataTable _dtAllGroupsHistory;
        private DataTable _dtSelectedGroupHistory;
        public frmCheckHistory()
        {
            InitializeComponent();
        }
        public frmCheckHistory(int GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
        }
        private void _PrepareAutoCompleteForGroupsComboBox()
        {
            AutoCompleteStringCollection AC = new AutoCompleteStringCollection();

            foreach (DataRow Row in _dtGroupsList.Rows)
            {
                string GroupName = Row["GroupName"].ToString();
                string GroupNumber = Row["GroupNumber"].ToString();

                AC.Add(GroupName);
                AC.Add(GroupNumber);
            }

            cmbGroups.AutoCompleteCustomSource = AC;
        }
        private void _FillGroupsComboBox()
        {
            _IsLoadingGroup = true;

            _dtGroupsList = clsGroup.LoadAllGroupsInfo();

            DataRow Row = _dtGroupsList.NewRow();

            Row["GroupName"] = "All Groups History";
            Row["GroupID"] = -1;
            Row["GroupNumber"] = -1;
            Row["CheckCounter"] = 0;

            _dtGroupsList.Rows.InsertAt(Row, 0);

            cmbGroups.DataSource = _dtGroupsList;
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupID";

            cmbGroups.SelectedIndex = 0;
            //lblGroupChecked.Visible = false;

            _IsLoadingGroup = false;

            _PrepareAutoCompleteForGroupsComboBox();
        }
        private void _AdjustDataGridColumns()
        {
            dgvCheckHistory.Columns[0].HeaderText = "C.ID";
            dgvCheckHistory.Columns[0].Width = 40;
            dgvCheckHistory.Columns[0].Visible = false;

            dgvCheckHistory.Columns[1].HeaderText = "G.ID";
            dgvCheckHistory.Columns[1].Width = 40;
            dgvCheckHistory.Columns[1].Visible = false;

            dgvCheckHistory.Columns[2].HeaderText = "G.Num";
            dgvCheckHistory.Columns[2].Width = 50;
            dgvCheckHistory.Columns[2].Visible = false;

            dgvCheckHistory.Columns[3].HeaderText = "Group Name";
            dgvCheckHistory.Columns[3].Width = 500;

            dgvCheckHistory.Columns[4].HeaderText = "Check Date";
            dgvCheckHistory.Columns[4].Width = 152;
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
        private void _LoadAllGroupsHistory()
        {
            _dtAllGroupsHistory = clsCheck.LoadAllChecks();

            dgvCheckHistory.DataSource = _dtAllGroupsHistory;

            _AddVisualStyleToTable(dgvCheckHistory);

            if (dgvCheckHistory.Rows.Count > 0)
            {
                _AdjustDataGridColumns();
            }
        }
        private void _LoadSelectedGroupHistory(int GroupID)
        {
            _dtSelectedGroupHistory = clsCheck.GetChecksByGroupID(GroupID);

            dgvCheckHistory.DataSource = _dtSelectedGroupHistory;

            _AddVisualStyleToTable(dgvCheckHistory);

            if (dgvCheckHistory.Rows.Count > 0)
            {
                _AdjustDataGridColumns();
            }
        }
        private void frmCheckHistory_Load(object sender, EventArgs e)
        {
            _FillGroupsComboBox();

            if (_GroupID == -1)
                _LoadAllGroupsHistory();
            else
            {
                cmbGroups.SelectedValue = _GroupID;
                _LoadSelectedGroupHistory(_GroupID); 
            }
        }
        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IsLoadingGroup)
                return;

            if (cmbGroups.SelectedValue == null)
                return;

            _GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

            if (_GroupID == -1)
                _LoadAllGroupsHistory();
            else
                _LoadSelectedGroupHistory(_GroupID);
        }

        private void btnAddCheckRecord_Click(object sender, EventArgs e)
        {
            frmAddEditGroupCheck frm = new frmAddEditGroupCheck(_GroupID);

            frm.ShowDialog();
        }
    }
}
