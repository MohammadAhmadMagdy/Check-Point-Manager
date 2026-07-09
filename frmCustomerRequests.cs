using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckPointBusinessLayer;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Coloring = System.Drawing.Color;

namespace Check_Point_Manager
{
    public partial class frmCustomerRequests : Form
    {
        private DataTable _dtAllRequests;
        private string _SelectedRequestsFile = "";

        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Coloring.FromArgb(219, 220, 218);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Coloring.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);


            dgv.RowsDefaultCellStyle.BackColor = Coloring.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Coloring.FromArgb(241, 240, 241);
        }
        private void _ConvertDateColumnsToDateTimeFormat(DataTable dt)
        {
            string[] DateColumns = { "OrderDate", "AvailableDate", "NotifiedDate" };

            foreach (string ColName in DateColumns)
            {
                if (!dt.Columns.Contains(ColName)) continue;


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
        }
        private void _LoadRequestsTable()
        {
            _dtAllRequests = clsCustomerOrder.GetAllOrders();

            _ConvertDateColumnsToDateTimeFormat(_dtAllRequests);

            if (!_dtAllRequests.Columns.Contains("Notify"))
            {
                _dtAllRequests.Columns.Add("Notify",typeof(string));
            }

            if (!_dtAllRequests.Columns.Contains("StatusSortOrder"))
                _dtAllRequests.Columns.Add("StatusSortOrder", typeof(int));

            foreach (DataRow Row in _dtAllRequests.Rows)
            {
                string Status = Row["Status"].ToString();

                Row["Notify"] = Status == "Available" ? "Notify" : "--";

               
                Row["StatusSortOrder"] = Status == "Available" ? 0
                                        : Status == "Pending" ? 1
                                        : Status == "Notified" ? 2
                                        : 3;
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
                dgvAllRequests.Columns[2].Width = 110;

                dgvAllRequests.Columns[3].HeaderText = "Phone";
                dgvAllRequests.Columns[3].Width = 100;

                dgvAllRequests.Columns[4].HeaderText = "Item Code";
                dgvAllRequests.Columns[4].Width = 70;

                dgvAllRequests.Columns[5].HeaderText = "Description";
                dgvAllRequests.Columns[5].Width = 312;

                dgvAllRequests.Columns[6].HeaderText = "Current Qty";
                dgvAllRequests.Columns[6].Width = 70;

                dgvAllRequests.Columns[7].HeaderText = "Current LzQty";
                dgvAllRequests.Columns[7].Width = 70;

                dgvAllRequests.Columns[8].HeaderText = "Order Date";
                dgvAllRequests.Columns[8].DefaultCellStyle.Format = "dd/M/yyyy";
                dgvAllRequests.Columns[8].Width = 90;

                dgvAllRequests.Columns[9].HeaderText = "Status";
                dgvAllRequests.Columns[9].Width = 90;
                dgvAllRequests.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllRequests.Columns[10].HeaderText = "Available Date";
                dgvAllRequests.Columns[10].DefaultCellStyle.Format = "dd/M/yyyy";
                dgvAllRequests.Columns[10].Width = 90;

                dgvAllRequests.Columns[11].HeaderText = "Notified Date";
                dgvAllRequests.Columns[11].DefaultCellStyle.Format = "dd/M/yyyy";
                dgvAllRequests.Columns[11].Width = 90;

                dgvAllRequests.Columns[12].HeaderText = "Created By ID";
                dgvAllRequests.Columns[12].Width = 50;
                dgvAllRequests.Columns[12].Visible = false;

                dgvAllRequests.Columns[13].HeaderText = "Staff Name";
                dgvAllRequests.Columns[13].Width = 90;

                if (dgvAllRequests.Columns.Contains("StatusSortOrder"))
                    dgvAllRequests.Columns["StatusSortOrder"].Visible = false;

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

            _ApplySort();


            lblTotalRequests.Text = dgvAllRequests.RowCount.ToString();
            lblAvailable.Text = clsCustomerOrder.GetOrdersCountByStatus(clsCustomerOrder.enStatus.Available).ToString();
            lblPending.Text = clsCustomerOrder.GetOrdersCountByStatus(clsCustomerOrder.enStatus.Pending).ToString();
            lblNotified.Text = clsCustomerOrder.GetOrdersCountByStatus(clsCustomerOrder.enStatus.Notified).ToString();
        }
        private void _ColorRowsByStatus()
        {
            foreach (DataGridViewRow Row in dgvAllRequests.Rows)
            {
                if (Row.IsNewRow) continue;


                if (Row.Cells["Status"] == null) continue;

                string Status = Row.Cells["Status"].Value?.ToString();


                DataGridViewCell statusCell = Row.Cells["Status"];

                switch (Status)
                {
                    case "Available":
                        statusCell.Style.BackColor = Coloring.FromArgb(212, 239, 223);
                        statusCell.Style.ForeColor = Coloring.FromArgb(21, 67, 34);
                        statusCell.Style.SelectionBackColor = Coloring.FromArgb(169, 223, 191);
                        statusCell.Style.SelectionForeColor = Coloring.FromArgb(21, 67, 34);
                        statusCell.Style.Font = new System.Drawing.Font(dgvAllRequests.Font, FontStyle.Bold);
                        break;

                    case "Notified":
                        statusCell.Style.BackColor = Coloring.FromArgb(214, 234, 248);
                        statusCell.Style.ForeColor = Coloring.FromArgb(27, 79, 114);
                        statusCell.Style.SelectionBackColor = Coloring.FromArgb(169, 204, 227);
                        statusCell.Style.SelectionForeColor = Coloring.FromArgb(27, 79, 114);
                        statusCell.Style.Font = new System.Drawing.Font(dgvAllRequests.Font, FontStyle.Bold);
                        break;

                    default:
                        statusCell.Style.BackColor = Coloring.FromArgb(249, 215, 215);
                        statusCell.Style.ForeColor = Coloring.FromArgb(120, 40, 40);
                        statusCell.Style.SelectionBackColor = Coloring.FromArgb(242, 174, 174);
                        statusCell.Style.SelectionForeColor = Coloring.FromArgb(120, 40, 40);
                        statusCell.Style.Font = new System.Drawing.Font(dgvAllRequests.Font, FontStyle.Bold);
                        break;
                }
            }
        }
        private bool _IsValidRequestsFile(string filePath)
        {
            string tempFile = null;

            try
            {
               
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
                if (tempFile != null && File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
        private string _GetColumnName()
        {
            switch (cmbRequestsFilterBy.Text)
            {
                case "Customer Name":
                    return "CustomerName";
                case "Phone Number":
                    return "PhoneNumber";
                case "Item Code":
                    return "ItemCode";
                case "Item Description":
                    return "ItemDescription";
                default:
                    return cmbRequestsFilterBy.Text;
            }
        }
        private void _ApplySort()
        {
            if (rdbStatus.Checked)
                _dtAllRequests.DefaultView.Sort = "StatusSortOrder ASC";
            else if (rdbDate.Checked)
                _dtAllRequests.DefaultView.Sort = "OrderDate DESC";
        }
        public frmCustomerRequests()
        {
            InitializeComponent();

            btnUpdate.Enabled = false;

            cmbRequestsFilterBy.SelectedIndex = 0;

            _LoadRequestsTable();
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
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
                    await Task.Run(() => clsCustomerOrder.ImportFromExcel(_SelectedRequestsFile));


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
        private async void btnBrowse_Click(object sender, EventArgs e)
        {
            string SavedRequestsFolder = clsSettings.GetValue(clsSettings.Keys.DefaultRequestsFolder);
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Requests File";
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.InitialDirectory = string.IsNullOrEmpty(SavedRequestsFolder) ? Desktop :
                    Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop), SavedRequestsFolder);

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                string selectedFile = ofd.FileName;

                string currentFolderPath = Path.GetDirectoryName(selectedFile);
                string currentFolderName = Path.GetFileName(currentFolderPath);

                if (!clsSettings.SetValue(clsSettings.Keys.DefaultRequestsFolder, currentFolderName))
                {
                    MessageBox.Show("Error Saving Current Folder Path\nDefault path will be Desktop.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmProgressBox progressBox = new frmProgressBox();

                try
                {
                    Cursor = Cursors.WaitCursor;

                    progressBox.Show(this);
                    progressBox.SetMessage("\"Validating Update File ...");

                    bool ValidFile = await Task.Run(
                        () => _IsValidRequestsFile(selectedFile));

                    if (ValidFile)
                    {
                        _SelectedRequestsFile = selectedFile;
                        txtFilePath.Text = selectedFile;
                        btnUpdate.Enabled = true;
                        lblFileStatus.Text = "✔ Valid file";
                        lblFileStatus.ForeColor = Coloring.Green;
                    }
                    else
                    {
                        _SelectedRequestsFile = "";
                        txtFilePath.Text = "";
                        btnUpdate.Enabled = false;
                        lblFileStatus.Text = "✘ Invalid file - wrong format";
                        lblFileStatus.ForeColor = Coloring.Red;

                        MessageBox.Show(
                            "The selected file is not a valid Requests file.\n\n",
                            "Invalid File",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {

                    MessageBox.Show(
                        "Error while getting file\n\n" + ex.Message,
                        "Invalid File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                finally
                {
                    if (!progressBox.IsDisposed)
                    {
                        progressBox.Close();
                        progressBox.Dispose();
                    }

                    Cursor = Cursors.Default;
                }
                
            }
        }
        private void btnNotify_Click(object sender, EventArgs e)
        {
            int Count = clsWhatsApp.NotifyAllAvailable();

            _LoadRequestsTable();

            MessageBox.Show($"Sent {Count} notification(s) successfully. ✅",
                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void revertNotifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgvAllRequests.CurrentRow.Cells["OrderID"].Value);

            if (OrderID == -1) return;

            clsCustomerOrder Order = clsCustomerOrder.FindByID(OrderID);

            if (Order == null)
            {
                MessageBox.Show("Order Not Found !", "Error", MessageBoxButtons.OK
                       , MessageBoxIcon.Error);
                return;
            }

            bool IsAvailable = false;

            if (Order.ItemInfo != null)
            {
                IsAvailable = (Order.ItemInfo.Qty > 0 || Order.ItemInfo.LzQty > 0);
            }
            else
            {
                IsAvailable = false;
            }


            if (IsAvailable)
            {
                if (!clsCustomerOrder.RevertNotifiedToAvailable(OrderID))
                {
                    MessageBox.Show("Error performing revert notification !", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!clsCustomerOrder.RevertOrderNotifiedToPending(OrderID))
                {
                    MessageBox.Show("Error performing revert notification !", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }

                _LoadRequestsTable();
        }
        private void dgvAllRequests_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var HitTest = dgvAllRequests.HitTest(e.X, e.Y);

            if (HitTest.RowIndex < 0 || HitTest.ColumnIndex < 0) return;

            dgvAllRequests.ClearSelection();
            dgvAllRequests.CurrentCell = dgvAllRequests.Rows[HitTest.RowIndex].Cells[HitTest.ColumnIndex];
        }
        private void txbRequestsFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = _GetColumnName();

            if (ColumnName == null) return;

            string FilterValue = txbRequestsFilterValue.Text.Trim().Replace("'", "''");

            if (ColumnName == "None" || string.IsNullOrEmpty(ColumnName) || string.IsNullOrEmpty(FilterValue))
            {
                _dtAllRequests.DefaultView.RowFilter = "";
                return;
            }

            if (_dtAllRequests.Columns[ColumnName].DataType == typeof(string))
            {
                _dtAllRequests.DefaultView.RowFilter = $"{ColumnName} LIKE '%{FilterValue}%'";
            }
            else
                _dtAllRequests.DefaultView.RowFilter = $"{ColumnName} = {FilterValue}";
        }
        private void cmbRequestsFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txbRequestsFilterValue.Enabled = cmbRequestsFilterBy.SelectedIndex != 0;

            bool NeedsText =
                cmbRequestsFilterBy.Text != "Pending" &&
                cmbRequestsFilterBy.Text != "Available" &&
                cmbRequestsFilterBy.Text != "Notified";

            txbRequestsFilterValue.Visible = NeedsText;

            if (txbRequestsFilterValue.Visible)
            {
                _dtAllRequests.DefaultView.RowFilter = "";
            }

            if (!NeedsText)
            {
                _dtAllRequests.DefaultView.RowFilter = $"Status LIKE '%{cmbRequestsFilterBy.Text}%'";
            }

                txbRequestsFilterValue.Text = "";

        }
        private void txbRequestsFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbRequestsFilterBy.Text == "Item Code")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void dgvAllRequests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            _ColorRowsByStatus();
        }
        private void rdbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDate.Checked)
                _ApplySort();
        }
        private void rdbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStatus.Checked)
                _ApplySort();
        }
        private void frmCustomerRequests_Load(object sender, EventArgs e)
        {
            rdbStatus.Checked = true;

        }

        private void markAsNotifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgvAllRequests.CurrentRow.Cells["OrderID"].Value);

            if (OrderID == -1) return;

            if (!clsCustomerOrder.MarkAsNotified(OrderID))
            {
                MessageBox.Show("Error while marking as notified !", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

            _LoadRequestsTable();
        }

        private void deleteRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgvAllRequests.CurrentRow.Cells["OrderID"].Value);

            if (OrderID == -1) return;

            clsCustomerOrder Order = clsCustomerOrder.FindByID(OrderID);

            if (Order == null) return;

            string CustomerName = clsCustomer.FindByID(Order.CustomerID).CustomerName;

            if (MessageBox.Show($"Are you sure you want to delete this request for \"{CustomerName}\"? ", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsCustomerOrder.Delete(OrderID))
                {
                    MessageBox.Show("Error while Deleting Request !", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                }

                MessageBox.Show("Request Deleted Successfully", "Success", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                _LoadRequestsTable();
            }
            else
                return;
        }
    }
}

