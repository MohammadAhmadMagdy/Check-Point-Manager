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
    public partial class frmVariationsList : Form
    {
        private DataTable _dtVariationList;
        public frmVariationsList()
        {
            InitializeComponent();
        }
        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(219, 220, 218);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);


            dgv.RowsDefaultCellStyle.BackColor = Color.White;
           // dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 240, 241);
        }
        private void frmVariationsList_Load(object sender, EventArgs e)
        {
            _dtVariationList = clsItem.GetAllVariations();

            dgvVariationList.DataSource = _dtVariationList;

            _AddVisualStyleToTable(dgvVariationList);

            if (dgvVariationList.Rows.Count > 0)
            {
                lblNoVariations.Visible = false;

                dgvVariationList.Columns["ItemCode"].HeaderText = "Code";
                dgvVariationList.Columns["ItemCode"].Width = 53;

                dgvVariationList.Columns["Description"].HeaderText = "Description";
                dgvVariationList.Columns["Description"].Width = 290;

                dgvVariationList.Columns["Qty"].HeaderText = "Qty";
                dgvVariationList.Columns["Qty"].Width = 50;
                dgvVariationList.Columns["Qty"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvVariationList.Columns["LzQty"].HeaderText = "LzQty";
                dgvVariationList.Columns["LzQty"].Width = 55;
                dgvVariationList.Columns["LzQty"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvVariationList.Columns["RetailPrice"].HeaderText = "Price";
                dgvVariationList.Columns["RetailPrice"].Width = 55;
                dgvVariationList.Columns["RetailPrice"].DefaultCellStyle.Format = "N3";
                dgvVariationList.Columns["RetailPrice"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvVariationList.Columns["VariationQty"].HeaderText = "Variation Qty";
                dgvVariationList.Columns["VariationQty"].Width = 140;
                dgvVariationList.Columns["VariationQty"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvVariationList.Columns["VariationLzQty"].HeaderText = "Variation LzQty";
                dgvVariationList.Columns["VariationLzQty"].Width = 140;
                dgvVariationList.Columns["VariationLzQty"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;


                dgvVariationList.Columns["GroupName"].HeaderText = "Group";
                dgvVariationList.Columns["GroupName"].Width = 144;
            }
            else
            {
                btnSettle.Enabled = false;
                lblNoVariations.Visible = true;
            }
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            int ItemCode = Convert.ToInt32(dgvVariationList.CurrentRow.Cells[0].Value);

            if(!clsItem.SettleItemVariation(ItemCode))
            {
                MessageBox.Show("Error while writing data !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Item Variation Settled Successfully\nGOOD WORK !", "Congratulations !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            frmVariationsList_Load(null, null);
        }
    }
}
