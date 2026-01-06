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
    public partial class frmListItems : Form
    {
        private bool _IsLoadingGrous = false;
        private DataTable _dtAllStockList;
        private DataTable _dtSelectedGroupItems;
        public frmListItems()
        {
            InitializeComponent();
        }
        private void _FillGroupsComboBox()
        {
            _IsLoadingGrous = true;

            DataTable GroupsDT = clsGroup.LoadAllGroupsInfo();

            DataRow Row = GroupsDT.NewRow();

            Row["GroupName"] = "Choose a Check Group";
            Row["GroupID"] = -1;
            Row["GroupNumber"] = -1;

            GroupsDT.Rows.InsertAt(Row, 0);

            cmbGroups.DataSource = GroupsDT;
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupID";

            cmbGroups.SelectedIndex = 0;

            _IsLoadingGrous = false;
        }
        private void _LoadItemsTable()
        {
            _dtAllStockList = clsItem.GetAllStockList();

            dgvAllStockList.DataSource = _dtAllStockList;

            dgvAllStockList.EnableHeadersVisualStyles = false;
            dgvAllStockList.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvAllStockList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllStockList.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvAllStockList.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAllStockList.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;


            cmbFilterBy.SelectedIndex = 0;

            if (dgvAllStockList.Rows.Count > 0)
            {
                dgvAllStockList.Columns["Selected"].HeaderText = "Sel";
                dgvAllStockList.Columns["Selected"].Width = 35;

                dgvAllStockList.Columns["ItemCode"].HeaderText = "Code";
                dgvAllStockList.Columns["ItemCode"].Width = 60;

                dgvAllStockList.Columns["Description"].HeaderText = "Description";
                dgvAllStockList.Columns["Description"].Width = 300;

                dgvAllStockList.Columns["Qty"].HeaderText = "Qty";
                dgvAllStockList.Columns["Qty"].Width = 40;

                dgvAllStockList.Columns["LzQty"].HeaderText = "LzQty";
                dgvAllStockList.Columns["LzQty"].Width = 40;

                dgvAllStockList.Columns["RetailPrice"].HeaderText = "Price";
                dgvAllStockList.Columns["RetailPrice"].Width = 50;

                dgvAllStockList.Columns["GroupName"].HeaderText = "Group";
                dgvAllStockList.Columns["GroupName"].Width = 90;
            }

            lblRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
        private void _LoadSelectedGroupItems()
        {
            dgvGroupItems.DataSource = _dtSelectedGroupItems;

            dgvGroupItems.EnableHeadersVisualStyles = false;
            dgvGroupItems.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvGroupItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGroupItems.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvGroupItems.RowsDefaultCellStyle.BackColor = Color.White;
            dgvGroupItems.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;


         

            if (dgvGroupItems.Rows.Count > 0)
            {   
                //dgvGroupItems.Columns["Selected"].HeaderText = "Sel";
                //dgvGroupItems.Columns["Selected"].Width = 35;
            
                dgvGroupItems.Columns["ItemCode"].HeaderText = "Code";
                dgvGroupItems.Columns["ItemCode"].Width = 60;
          
                dgvGroupItems.Columns["Description"].HeaderText = "Description";
                dgvGroupItems.Columns["Description"].Width = 300;
        
                dgvGroupItems.Columns["Qty"].HeaderText = "Qty";
                dgvGroupItems.Columns["Qty"].Width = 40;
                
                dgvGroupItems.Columns["LzQty"].HeaderText = "LzQty";
                dgvGroupItems.Columns["LzQty"].Width = 40;
                
                dgvGroupItems.Columns["RetailPrice"].HeaderText = "Price";
                dgvGroupItems.Columns["RetailPrice"].Width = 50;
                
               
            }

           
        }
        private void frmListItems_Load(object sender, EventArgs e)
        {
            _FillGroupsComboBox();

            _LoadItemsTable();

            _LoadSelectedGroupItems();


        }
        private string _GetColumnName()
        {
            if (cmbFilterBy.Text == "Item Code")
                return "ItemCode";
            else
                return cmbFilterBy.Text;
        }

        private void dgvAllStockList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                dgvAllStockList.CurrentCell = dgvAllStockList.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dgvAllStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAllStockList.Columns["Selected"].Index && e.RowIndex >= 0)
                dgvAllStockList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void txbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = _GetColumnName();
            string SearchValue = txbFilterValue.Text.Trim();
            string Filter = "";

            if (!string.IsNullOrEmpty(SearchValue) && ColumnName != "None")
            {
                if (_dtAllStockList.Columns[ColumnName].DataType == typeof(string))
                {
                    SearchValue = SearchValue.Replace("'", "''");
                    Filter = $"{ColumnName} Like '%{SearchValue}%'";
                }
                else
                    Filter = $"{ColumnName} = {SearchValue}";

                _dtAllStockList.DefaultView.RowFilter = Filter;
            }
            else
            {
                _dtAllStockList.DefaultView.RowFilter = string.Empty;
            }

            lblRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilterValue.Visible = cmbFilterBy.SelectedIndex != 0;
            txbFilterValue.Text = "";

            if (txbFilterValue.Visible)
                txbFilterValue.Focus();

        }

        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Item Code")
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IsLoadingGrous)
                return;

            if (cmbGroups.SelectedValue == null)
                return;

            int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

            if (GroupID == -1)
                return;

            _dtSelectedGroupItems = clsItemGroup.GetGroupItemsByGroupID(GroupID);
            _LoadSelectedGroupItems();
        }

        private void btnAddSelectedToGroup_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> SelectedItems = new List<int>();

                foreach (DataGridViewRow Row in dgvAllStockList.Rows)
                {
                    bool IsSelected = Row.Cells["Selected"].Value != null &&
                                      Convert.ToBoolean(Row.Cells["Selected"].Value);
                    if (IsSelected)
                    {
                        int ItemCode = Convert.ToInt32(Row.Cells["ItemCode"].Value);
                        SelectedItems.Add(ItemCode);
                    }
                }

                int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);
                int NumberOfItemsAdded = clsItemGroup.AddItemsListToGroup(SelectedItems, GroupID);

                MessageBox.Show(NumberOfItemsAdded + " Items Added Successfully To Group", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _dtSelectedGroupItems = clsItemGroup.GetGroupItemsByGroupID(GroupID);
                _LoadSelectedGroupItems();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
