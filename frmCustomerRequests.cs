using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckPointBusinessLayer;
using Coloring = System.Drawing.Color;

namespace Check_Point_Manager
{
    public partial class frmCustomerRequests : Form
    {
        private DataTable _dtAllRequests;
        private string _DefaultExcelRequestsFile = "";
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
        private void _LoadRequestsTable()
        {
            _dtAllRequests = clsCustomerOrder.GetAllOrders();

            dgvAllRequests.DataSource = _dtAllRequests;

            _AddVisualStyleToTable(dgvAllRequests);

            if (dgvAllRequests.Rows.Count > 0)
            {
                dgvAllRequests.Columns[0].HeaderText = "Order ID";
                dgvAllRequests.Columns[0].Width = 30;

                dgvAllRequests.Columns[1].HeaderText = "Customer ID";
                dgvAllRequests.Columns[1].Width = 30;

                dgvAllRequests.Columns[2].HeaderText = "Customer Name";
                dgvAllRequests.Columns[2].Width = 120;

                dgvAllRequests.Columns[3].HeaderText = "Phone";
                dgvAllRequests.Columns[3].Width = 120;

                dgvAllRequests.Columns[4].HeaderText = "Item Code";
                dgvAllRequests.Columns[4].Width = 50;

                dgvAllRequests.Columns[5].HeaderText = "Description";
                dgvAllRequests.Columns[5].Width = 160;

                dgvAllRequests.Columns[6].HeaderText = "Current Qty";
                dgvAllRequests.Columns[6].Width = 50;

                dgvAllRequests.Columns[7].HeaderText = "Current LzQty";
                dgvAllRequests.Columns[7].Width = 50;

                dgvAllRequests.Columns[8].HeaderText = "Order Date";
                dgvAllRequests.Columns[8].Width = 50;

                dgvAllRequests.Columns[9].HeaderText = "Status";
                dgvAllRequests.Columns[9].Width = 50;

                dgvAllRequests.Columns[10].HeaderText = "Available Date";
                dgvAllRequests.Columns[10].Width = 50;

                dgvAllRequests.Columns[11].HeaderText = "Notified Date";
                dgvAllRequests.Columns[11].Width = 50;

                dgvAllRequests.Columns[12].HeaderText = "Created By ID";
                dgvAllRequests.Columns[12].Width = 50;

                dgvAllRequests.Columns[13].HeaderText = "Created By Name";
                dgvAllRequests.Columns[13].Width = 120;


            }
        }
        private string _GetDefaultRequestsFile()
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string TargetFolder = Path.Combine(DesktopPath, "Check Point Update");

            string XlsxFile = Path.Combine(TargetFolder, "Requests.xlsx");
            string XlsFile = Path.Combine(TargetFolder, "Requests.xls");

            if (File.Exists(XlsxFile))
                return XlsxFile;

            if (File.Exists(XlsFile))
                return XlsFile;

            return null;
        }
        public frmCustomerRequests()
        {
            InitializeComponent();

            _LoadRequestsTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProgressBox ProgressBox = new frmProgressBox();

            try
            {
                Cursor = Cursors.WaitCursor;

                ProgressBox.SetMessage("Updating Requests List ...");
                ProgressBox.Show(this);




                ProgressBox.SetMessage("Updating Requests .. Please Wait");

                _DefaultExcelRequestsFile = _GetDefaultRequestsFile();

                clsCustomerOrder.ImportFromExcel(_DefaultExcelRequestsFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!ProgressBox.IsDisposed)
                {
                    ProgressBox.Close();
                    ProgressBox.Dispose();
                }
                Cursor = Cursors.Default;
            }

            _LoadRequestsTable();
        }
    }
}
