using CheckPointBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coloring = System.Drawing.Color;

namespace Check_Point_Manager
{
    public partial class frmCustomersList : Form
    {
        private DataTable _dtAllCustomersList;
        public frmCustomersList()
        {
            InitializeComponent();
        }
        private void _ConvertDateColumnToDateTimeFormat(DataTable dt)
        {
            string ColName = "CreatedDate";
            string TempCol = ColName + "_dt";
            dt.Columns.Add(TempCol, typeof(DateTime));

            foreach (DataRow Row in dt.Rows)
            {
                if (Row[ColName] != DBNull.Value &&
                    DateTime.TryParse(Row[ColName].ToString(), out DateTime ParsedDate))
                    Row[TempCol] = ParsedDate;
                else
                    Row[TempCol] = DBNull.Value;
            }

            int ColIndex = dt.Columns[ColName].Ordinal;
            dt.Columns.Remove(ColName);
            dt.Columns[TempCol].ColumnName = ColName;
            dt.Columns[ColName].SetOrdinal(ColIndex);
        }
        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Coloring.FromArgb(219, 220, 218);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Coloring.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);


            dgv.RowsDefaultCellStyle.BackColor = Coloring.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Coloring.FromArgb(241, 240, 241);
        }
        private void _LoadCustomersList()
        {
            _dtAllCustomersList = clsCustomer.GetAllCustomers();

            _ConvertDateColumnToDateTimeFormat(_dtAllCustomersList);

            dgvCustomersList.DataSource = _dtAllCustomersList;

            _AddVisualStyleToTable(dgvCustomersList);

            if (dgvCustomersList.Rows.Count > 0 )
            {
                dgvCustomersList.Columns["CustomerID"].HeaderText = "ID";
                dgvCustomersList.Columns["CustomerID"].Width = 50;

                dgvCustomersList.Columns["CustomerName"].HeaderText = "Name";
                dgvCustomersList.Columns["CustomerName"].Width = 220;

                dgvCustomersList.Columns["PhoneNumber"].HeaderText = "Phone";
                dgvCustomersList.Columns["PhoneNumber"].Width = 190;
                //dgvCustomersList.Columns["PhoneNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCustomersList.Columns["CreatedDate"].HeaderText = "Created Date";
                dgvCustomersList.Columns["CreatedDate"].Width = 140;
                dgvCustomersList.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/M/yyyy";
                //dgvCustomersList.Columns["CreatedDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCustomersList.Columns["CreatedByUserID"].HeaderText = "Created By";
                dgvCustomersList.Columns["CreatedByUserID"].Width = 60;
                dgvCustomersList.Columns["CreatedByUserID"].Visible = false;

                dgvCustomersList.Columns["CreatedByUserName"].HeaderText = "Created By";
                dgvCustomersList.Columns["CreatedByUserName"].Width = 120;
                //dgvCustomersList.Columns["CreatedByUserName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCustomersList.Columns["Notes"].HeaderText = "Notes";
                dgvCustomersList.Columns["Notes"].Width = 120;
                dgvCustomersList.Columns["Notes"].Visible = false;
            }

            lblTotalCustomers.Text = dgvCustomersList.Rows.Count.ToString();
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            _LoadCustomersList();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer();
            frm.ShowDialog();

            _LoadCustomersList();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = Convert.ToInt32(dgvCustomersList.CurrentRow.Cells["CustomerID"].Value);

            frmAddEditCustomer frm = new frmAddEditCustomer(CustomerID);
            frm.ShowDialog();

            _LoadCustomersList();
        }

        private void dgvCustomersList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvCustomersList.ClearSelection();
                dgvCustomersList.CurrentCell = dgvCustomersList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
    }
}
