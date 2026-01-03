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
        private DataTable _dtAllStockList;
        public frmListItems()
        {
            InitializeComponent();
        }

        private void frmListItems_Load(object sender, EventArgs e)
        {
            _dtAllStockList = clsItem.GetAllStockList();

            dgvAllStockList.DataSource = _dtAllStockList;

            cmbFilterBy.SelectedIndex = 0;

            if (dgvAllStockList.Rows.Count > 0 )
            {
                dgvAllStockList.Columns["Selected"].HeaderText = "Selected";
                dgvAllStockList.Columns["Selected"].Width = 55;

                dgvAllStockList.Columns["ItemCode"].HeaderText = "Item Code";
                dgvAllStockList.Columns["ItemCode"].Width = 100;

                dgvAllStockList.Columns["Description"].HeaderText = "Description";
                dgvAllStockList.Columns["Description"].Width = 350;

                dgvAllStockList.Columns["Qty"].HeaderText = "Qty";
                dgvAllStockList.Columns["Qty"].Width = 60;

                dgvAllStockList.Columns["LzQty"].HeaderText = "LzQty";
                dgvAllStockList.Columns["LzQty"].Width = 60;

                dgvAllStockList.Columns["RetailPrice"].HeaderText = "Retail Price";
                dgvAllStockList.Columns["RetailPrice"].Width = 90;

                dgvAllStockList.Columns["GroupName"].HeaderText = "Group Name";
                dgvAllStockList.Columns["GroupName"].Width = 270;
            }

            lblRecords.Text = dgvAllStockList.Rows.Count.ToString();
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
                    Filter = $"{ColumnName} Like '%{SearchValue}%'";
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

        }

        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Item Code")
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
