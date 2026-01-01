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

            if (dgvAllStockList.Rows.Count > 0 )
            {
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
    }
}
