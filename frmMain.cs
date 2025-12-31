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
                dgvAllStockList.Columns[0].HeaderText = "Item Code";
                dgvAllStockList.Columns[0].Width = 160;

                dgvAllStockList.Columns[1].HeaderText = "Description";
                dgvAllStockList.Columns[1].Width = 300;

                dgvAllStockList.Columns[2].HeaderText = "Qty";
                dgvAllStockList.Columns[2].Width = 100;

                dgvAllStockList.Columns[3].HeaderText = "LzQty";
                dgvAllStockList.Columns[3].Width = 100;

                dgvAllStockList.Columns[4].HeaderText = "Retail Price";
                dgvAllStockList.Columns[4].Width = 120;

                dgvAllStockList.Columns[5].HeaderText = "Group Name";
                dgvAllStockList.Columns[5].Width = 140;
            }

            lblRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
    }
}
