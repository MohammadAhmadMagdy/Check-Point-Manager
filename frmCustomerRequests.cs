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
        private string _SelectedRequestsFile = "";

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

            if(!_dtAllRequests.Columns.Contains("Notify"))
            {
                _dtAllRequests.Columns.Add("Notify",typeof(string));
            }
            foreach (DataRow Row in _dtAllRequests.Rows)
            {
                Row["Notify"] = Row["Status"].ToString() == "Available" ? "Notify" : "--";
            }

            dgvAllRequests.DataSource = _dtAllRequests;

            _AddVisualStyleToTable(dgvAllRequests);

            if (dgvAllRequests.Rows.Count > 0)
            {
                dgvAllRequests.Columns[0].HeaderText = "Order ID";
                dgvAllRequests.Columns[0].Width = 30;
                dgvAllRequests.Columns[0].Visible = false;

                dgvAllRequests.Columns[1].HeaderText = "Customer ID";
                dgvAllRequests.Columns[1].Width = 30;
                dgvAllRequests.Columns[1].Visible = false;

                dgvAllRequests.Columns[2].HeaderText = "Customer Name";
                dgvAllRequests.Columns[2].Width = 90;

                dgvAllRequests.Columns[3].HeaderText = "Phone";
                dgvAllRequests.Columns[3].Width = 90;

                dgvAllRequests.Columns[4].HeaderText = "Item Code";
                dgvAllRequests.Columns[4].Width = 50;

                dgvAllRequests.Columns[5].HeaderText = "Description";
                dgvAllRequests.Columns[5].Width = 290;

                dgvAllRequests.Columns[6].HeaderText = "Current Qty";
                dgvAllRequests.Columns[6].Width = 60;

                dgvAllRequests.Columns[7].HeaderText = "Current LzQty";
                dgvAllRequests.Columns[7].Width = 60;

                dgvAllRequests.Columns[8].HeaderText = "Order Date";
                dgvAllRequests.Columns[8].Width = 90;

                dgvAllRequests.Columns[9].HeaderText = "Status";
                dgvAllRequests.Columns[9].Width = 90;

                dgvAllRequests.Columns[10].HeaderText = "Available Date";
                dgvAllRequests.Columns[10].Width = 90;

                dgvAllRequests.Columns[11].HeaderText = "Notified Date";
                dgvAllRequests.Columns[11].Width = 90;

                dgvAllRequests.Columns[12].HeaderText = "Created By ID";
                dgvAllRequests.Columns[12].Width = 50;
                dgvAllRequests.Columns[12].Visible = false;

                dgvAllRequests.Columns[13].HeaderText = "Staff Name";
                dgvAllRequests.Columns[13].Width = 90;

                if (dgvAllRequests.Columns["Notify"] != null)
                {
                    int ColumnIndex = dgvAllRequests.Columns["Notify"].Index;

                    dgvAllRequests.Columns.Remove("Notify");

                    DataGridViewButtonColumn btnNotify = new DataGridViewButtonColumn();

                    btnNotify.Name = "Notify";
                    btnNotify.HeaderText = "Action";
                    btnNotify.DataPropertyName = "Notify";
                    btnNotify.Width = 80;

                    dgvAllRequests.Columns.Insert(ColumnIndex, btnNotify);
                }
            }
        }

        private bool _IsValidRequestsFile(string filePath)
        {
            string tempFile = null;

            frmProgressBox ProgressBox = new frmProgressBox();

            try
            {
                Cursor = Cursors.WaitCursor;
                
                ProgressBox.Show(this);
                ProgressBox.SetMessage("Validating Update File ...");


                tempFile = Path.GetTempFileName() + Path.GetExtension(filePath);
                File.Copy(filePath, tempFile, overwrite: true);

                using (var workbook = new ClosedXML.Excel.XLWorkbook(tempFile))
                {
                    var ws = workbook.Worksheet(1);
                    string c1 = ws.Cell("C1").GetValue<string>().Trim();
                    string j1 = ws.Cell("J1").GetValue<string>().Trim();

                    return string.Equals(c1, "Bounced Quantity", StringComparison.OrdinalIgnoreCase)
                        && string.Equals(j1, "Repetition", StringComparison.OrdinalIgnoreCase);
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if(!ProgressBox.IsDisposed)
                {
                    ProgressBox.Close();
                    ProgressBox.Dispose();
                }

                Cursor = Cursors.Default;
               
                if (tempFile != null && File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        public frmCustomerRequests()
        {
            InitializeComponent();

            btnUpdate.Enabled = false;
            _LoadRequestsTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_SelectedRequestsFile))
            {
                MessageBox.Show("Please select a valid file first.",
                    "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmProgressBox ProgressBox = new frmProgressBox();

            try
            {
                Cursor = Cursors.WaitCursor;
                ProgressBox.SetMessage("Updating Requests List ...");
                ProgressBox.Show(this);

                ProgressBox.SetMessage("Updating Requests .. Please Wait");

                clsCustomerOrder.ImportOrdersResult UpdatedRequestsResult =
                    clsCustomerOrder.ImportFromExcel(_SelectedRequestsFile);

                MessageBox.Show("Requests updated successfully ✔\n\n" +
                                $"Customers Added: {UpdatedRequestsResult.CustomersAdded}\n" +
                                $"Requests Added: {UpdatedRequestsResult.OrdersAdded}\n",
                                "Import Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Requests File";
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.InitialDirectory = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "Bounced Sheet 2026");

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                string selectedFile = ofd.FileName;

                if (_IsValidRequestsFile(selectedFile))
                {
                    _SelectedRequestsFile = selectedFile;
                    txtFilePath.Text = selectedFile;         // اختياري: TextBox لعرض المسار
                    btnUpdate.Enabled = true;
                    lblFileStatus.Text = "✔ Valid file";     // اختياري: Label للحالة
                    lblFileStatus.ForeColor = Color.Green;
                }
                else
                {
                    _SelectedRequestsFile = "";
                    txtFilePath.Text = "";
                    btnUpdate.Enabled = false;
                    lblFileStatus.Text = "✘ Invalid file - wrong format";
                    lblFileStatus.ForeColor = Color.Red;

                    MessageBox.Show(
                        "The selected file is not a valid Requests file.\n\n",
                        "Invalid File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgvAllRequests.CurrentRow.Cells["OrderID"].Value);

            if (clsWhatsApp.NotifyCustomer(OrderID))
            {
                // تحديث الـ Grid
                _LoadRequestsTable();
            }
            else
            {
                MessageBox.Show("Failed to notify customer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAllRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvAllRequests.Columns[e.ColumnIndex].Name != "Notify")
                return;

            string status = dgvAllRequests.Rows[e.RowIndex].Cells["Status"].Value?.ToString();


            if (!status.Equals("Available", StringComparison.OrdinalIgnoreCase))
                return;

            int orderID = Convert.ToInt32(
                dgvAllRequests.Rows[e.RowIndex]
                .Cells["OrderID"].Value);

            if (clsWhatsApp.NotifyCustomer(orderID))
            {
                _LoadRequestsTable();
            }
        }
    }
}

