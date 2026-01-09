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
using ClosedXML.Excel;


namespace Check_Point_Manager
{
    public partial class frmListItems : Form
    {
        private bool _IsLoadingGrous = false;
        private string _ExcelFile = "";
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

            Row["GroupName"] = "None";
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

            lblItemRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
        private void _LoadSelectedGroupItems(int GroupID)
        {
            _dtSelectedGroupItems = clsItemGroup.GetGroupItemsByGroupID(GroupID);

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

            lblGroupRecord.Text = dgvGroupItems.RowCount.ToString();
        }
        private string _SelectExcelFile()
        {
            string FilePath = null;

            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string TargetFolder = Path.Combine(DesktopPath, "Check Point Update");

            if (!Directory.Exists(TargetFolder))
            {
                Directory.CreateDirectory(TargetFolder);
            }

            using (OpenFileDialog Dialog = new OpenFileDialog())
            {
                Dialog.Title = "Choose Stock File";
                Dialog.Filter = "Excel Files|*.xlsx;*.xls";
                Dialog.InitialDirectory = TargetFolder;

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = Dialog.FileName;
                }
            }

            return FilePath;
        }
        private void frmListItems_Load(object sender, EventArgs e)
        {
            _FillGroupsComboBox();

            _LoadItemsTable();

            ctrlButtonCardUpdate.Enabled = false;

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

            lblItemRecords.Text = dgvAllStockList.Rows.Count.ToString();
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
            {
                dgvGroupItems.DataSource = null;
                return;
            }

            _LoadSelectedGroupItems(GroupID);
        }

        private void ctrlButtonCardUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblUpdateStatus.Text = "Update in Progress .. Please Wait";
                lblUpdateStatus.Visible = true;
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;

                if (!String.IsNullOrEmpty(_ExcelFile))
                {
                    var NewItemsList = clsItem.UpdateStockAndGetNewItemsCodes(_ExcelFile);

                    if (NewItemsList.Count > 0)
                    {
                        lblUpdateStatus.Text = "Stock Updated";
                        MessageBox.Show("Stock Updated Successfully\n" + NewItemsList.Count + " New Items Added", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lblUpdateStatus.Text = "Stock Updated";
                        MessageBox.Show("Stock Updated Successfully\nNo New Items Added", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txbFilePath.Text = "";

                    frmListItems_Load(null, null);
                }
                else
                {
                    MessageBox.Show("No File Choosen !!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            _ExcelFile = _SelectExcelFile();

            if (!string.IsNullOrEmpty(_ExcelFile))
            {
                txbFilePath.Text = _ExcelFile;
                ctrlButtonCardUpdate.Enabled = true;
                lblUpdateStatus.Text = "";
            }
        }

        private void btnAddToGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroups.SelectedValue == null)
                {
                    return;
                }

                int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

                if (GroupID == -1)
                {
                    MessageBox.Show("You Should Select A Group First", "Not Allowed", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    cmbGroups.Focus();
                    return;
                }

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

                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please Select at Least One Item to Add", "No Items", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to add these items to\n" + cmbGroups.Text + " Group ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }

                int NumberOfItemsAdded = clsItemGroup.AddItemsListToGroup(SelectedItems, GroupID);

                MessageBox.Show(NumberOfItemsAdded + " Items Added Successfully To Group", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _LoadSelectedGroupItems(GroupID);
                _LoadItemsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnManageGroups_Click(object sender, EventArgs e)
        {
            cmbGroups.SelectedIndex = 0;

            frmManageListGroup frm = new frmManageListGroup();
            frm.ShowDialog();
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (_dtSelectedGroupItems == null || _dtSelectedGroupItems.Rows.Count == 0)
                {
                    MessageBox.Show("No Item To Export", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataTable dtFilteredData = _dtSelectedGroupItems.Clone();

                foreach (DataRow Row in _dtSelectedGroupItems.Rows)
                {
                    int Qty = Convert.ToInt32(Row["Qty"]);
                    int LzQty = Convert.ToInt32(Row["LzQty"]);

                    if (Qty > 0 || LzQty > 0)
                    {
                        dtFilteredData.ImportRow(Row);
                    }
                }

                if (dtFilteredData.Rows.Count == 0)
                {
                    MessageBox.Show("No Items With Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Group Items");

                    // إدخال العناوين يدويًا بدون فلتر أو ألوان
                    for (int col = 0; col < dtFilteredData.Columns.Count; col++)
                    {
                        ws.Cell(1, col + 1).Value = dtFilteredData.Columns[col].ColumnName;
                        ws.Cell(1, col + 1).Style.Font.Bold = true;
                        ws.Cell(1, col + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }

                    // إدخال البيانات مع تحويل آمن حسب نوع العمود
                    for (int row = 0; row < dtFilteredData.Rows.Count; row++)
                    {
                        for (int col = 0; col < dtFilteredData.Columns.Count; col++)
                        {
                            object value = dtFilteredData.Rows[row][col];
                            Type columnType = dtFilteredData.Columns[col].DataType;

                            if (columnType == typeof(int))
                                ws.Cell(row + 2, col + 1).Value = Convert.ToInt32(value);
                            else if (columnType == typeof(decimal))
                                ws.Cell(row + 2, col + 1).Value = Convert.ToDecimal(value);
                            else if (columnType == typeof(double))
                                ws.Cell(row + 2, col + 1).Value = Convert.ToDouble(value);
                            else if (columnType == typeof(DateTime))
                                ws.Cell(row + 2, col + 1).Value = Convert.ToDateTime(value);
                            else
                                ws.Cell(row + 2, col + 1).Value = Convert.ToString(value);
                        }
                    }

                    // تنسيق الخطوط وضبط الأعمدة
                    ws.Columns().AdjustToContents();
                    ws.Style.Font.FontName = "Segoe UI";
                    ws.Style.Font.FontSize = 11;

                    // حفظ الملف
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        FileName = "GroupItems.xlsx"
                    };

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("File Exported Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void deleteFromGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ItemCode = Convert.ToInt32(dgvGroupItems.CurrentRow.Cells["ItemCode"].Value);
            int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

            if (!clsItemGroup.Delete(ItemCode,GroupID))
            {
                MessageBox.Show("Error!!");
            }

            _LoadSelectedGroupItems(GroupID);
            _LoadItemsTable();
        }
    }
}
