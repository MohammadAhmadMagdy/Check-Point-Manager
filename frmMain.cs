using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private DataTable _dtNewlyAddedItems;
        private DataTable _dtSelectedGroupItems;
        private bool _IsAllRowsSelected = false;
        private int _NewlyAddedItemsCount = 0;
        public frmListItems()
        {
            InitializeComponent();
        }
        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
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

            _dtNewlyAddedItems = clsItem.GetNewlyAddedItemsList();

            if(cmbItemsFilterBy.Text == "Newly Added Items")
            {
                dgvAllStockList.DataSource = _dtNewlyAddedItems;
            }
            else
            {
                dgvAllStockList.DataSource = _dtAllStockList;
            }

            _AddVisualStyleToTable(dgvAllStockList);

            _IsAllRowsSelected = false;
            btnSelectAll.Text = "Select All";
            
            txbFilterValue.Focus();

            if (dgvAllStockList.Rows.Count > 0)
            {
                dgvAllStockList.Columns["Selected"].HeaderText = "Sel";
                dgvAllStockList.Columns["Selected"].Width = 30;

                dgvAllStockList.Columns["ItemCode"].HeaderText = "Code";
                dgvAllStockList.Columns["ItemCode"].Width = 55;

                dgvAllStockList.Columns["Description"].HeaderText = "Description";
                dgvAllStockList.Columns["Description"].Width = 290;

                dgvAllStockList.Columns["Qty"].HeaderText = "Qty";
                dgvAllStockList.Columns["Qty"].Width = 40;

                dgvAllStockList.Columns["LzQty"].HeaderText = "LzQty";
                dgvAllStockList.Columns["LzQty"].Width = 40;

                dgvAllStockList.Columns["RetailPrice"].HeaderText = "Price";
                dgvAllStockList.Columns["RetailPrice"].Width = 50;

                dgvAllStockList.Columns["GroupName"].HeaderText = "Group";
                dgvAllStockList.Columns["GroupName"].Width = 105;
            }

            txbFilterValue_TextChanged(null, null);
            lblItemRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
        private void _LoadSelectedGroupItems(int GroupID)
        {
            _dtSelectedGroupItems = clsItemGroup.GetGroupItemsByGroupID(GroupID);
            
            dgvGroupItems.DataSource = _dtSelectedGroupItems;

            pcbGroupsBackground.Visible = GroupID == -1;

            _AddVisualStyleToTable(dgvGroupItems);


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
        private void _dgvSelectAllRowByRightClick(object sender, MouseEventArgs e)
        {
            var DGV = (DataGridView)sender;

            if (e.Button == MouseButtons.Right)
            {
                var HitTestInfo = DGV.HitTest(e.X, e.Y);
                if(HitTestInfo.RowIndex >= 0)
                {
                    DGV.ClearSelection();
                    DGV.Rows[HitTestInfo.RowIndex].Selected = true;
                }
            }
        }
        private string _GetColumnName()
        {
            string ColumnName = "";

            switch (cmbItemsFilterBy.Text)
            {
                case "Item Code":
                    ColumnName = "ItemCode";
                    break;
                case "Not Assigned Items":
                    ColumnName = "GroupName";
                    break;
                case "Group Name":
                    ColumnName = "GroupName";
                    break;
                default:
                    ColumnName = cmbItemsFilterBy.Text;
                    break;

            }

            return ColumnName;
        }
        private void _ApplyFilter(DataTable table, ComboBox cmb, TextBox txb)
        {
            if (table == null)
                return;

            string columnName = _GetColumnName();

            // لا فلترة
            if (cmb.Text == "None" || string.IsNullOrEmpty(columnName))
            {
                table.DefaultView.RowFilter = "";
                return;
            }

            // فلتر ثابت: Not Assigned
            if (cmb.Text == "Not Assigned Items")
            {
                table.DefaultView.RowFilter = "GroupName = 'Not Assigned'";
                return;
            }

            string searchValue = txb.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(searchValue))
            {
                table.DefaultView.RowFilter = "";
                return;
            }

            if (table.Columns[columnName].DataType == typeof(string))
                table.DefaultView.RowFilter = $"{columnName} LIKE '%{searchValue}%'";
            else
                table.DefaultView.RowFilter = $"{columnName} = {searchValue}";
        }

        private void pcbGroupsBackground_Paint(object sender, PaintEventArgs e)
        {
            if (pcbGroupsBackground.Image != null)
            {
                e.Graphics.DrawImage(pcbGroupsBackground.Image, new Rectangle(0, 0, pcbGroupsBackground.Width,
                    pcbGroupsBackground.Height));
                using (Brush semiTransparentBrush = new SolidBrush(Color.FromArgb(200, Color.Transparent)))
                {
                    e.Graphics.FillRectangle(semiTransparentBrush, pcbGroupsBackground.ClientRectangle);
                }
            }
        }
        private void frmListItems_Load(object sender, EventArgs e)
        {
            _FillGroupsComboBox();

            _LoadItemsTable();

            cmbItemsFilterBy.SelectedIndex = 2;
            cmbGroupsFilterBy.SelectedIndex = 2;

            ctrlButtonCardUpdate.Enabled = false;

        }
        private void dgvAllStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAllStockList.Columns["Selected"].Index && e.RowIndex >= 0)
                dgvAllStockList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void txbFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllStockList.DataSource is DataTable dt)
                _ApplyFilter(dt, cmbItemsFilterBy, txbFilterValue);

            //string ColumnName = _GetColumnName();

            //if(cmbFilterBy.Text == "Not Assigned Items")
            //{
            //    txbFilterValue.Text = "Not Assigned";
            //}

            //string SearchValue = txbFilterValue.Text.Trim();

            //string Filter = "";

            //if (!string.IsNullOrEmpty(SearchValue) && ColumnName != "None")
            //{
            //    if (_dtAllStockList.Columns[ColumnName].DataType == typeof(string))
            //    {
            //        SearchValue = SearchValue.Replace("'", "''");
            //        Filter = $"{ColumnName} Like '%{SearchValue}%'";
            //    }
            //    else
            //        Filter = $"{ColumnName} = {SearchValue}";

            //    _dtAllStockList.DefaultView.RowFilter = Filter;
            //}
            //else
            //{
            //    _dtAllStockList.DefaultView.RowFilter = string.Empty;
            //}

            lblItemRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool needsText =
                 cmbItemsFilterBy.Text != "None" &&
                 cmbItemsFilterBy.Text != "Newly Added Items" &&
                 cmbItemsFilterBy.Text != "Not Assigned Items";

            txbFilterValue.Visible = needsText;
            txbFilterValue.Text = "";

            _LoadItemsTable();

            //txbFilterValue.Visible = (cmbFilterBy.Text != "None" && cmbFilterBy.Text != "Newly Added Items");
            //txbFilterValue.Text = "";

            //if (txbFilterValue.Visible)
            //    txbFilterValue.Focus();

            //_LoadItemsTable();
        }
        private void cmbGroupsFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbGroupsFilterValue.Visible = cmbGroupsFilterBy.Text != "None";
        }
        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbItemsFilterBy.Text == "Item Code")
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
                pcbGroupsBackground.Visible = true;
                lblGroupRecord.Text = dgvGroupItems.RowCount.ToString();
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
                    _NewlyAddedItemsCount = clsItem.UpdateStockAndGetNewItemsCount(_ExcelFile);

                    if (_NewlyAddedItemsCount > 0)
                    {
                        lblUpdateStatus.Text = "Stock Updated";
                        
                        if (MessageBox.Show("Stock Updated Successfully\n" + _NewlyAddedItemsCount + " New Items Added\n" +
                            "Do you want to explore Newly Added Items ?", "Success",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmbItemsFilterBy.SelectedIndex = 4;
                        }
                    }
                    else
                    {
                        lblUpdateStatus.Text = "Stock Updated";
                        MessageBox.Show("Stock Updated Successfully\nNo New Items Added", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txbFilePath.Text = "";

                    _LoadItemsTable();
                    ctrlButtonCardUpdate.Enabled = false;
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

            frmListItems_Load(null, null);
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
        private void dgvAllStockList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                e.Cancel = true;
            }
        }
        private void dgvAllStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!chbFastMode.Checked)
            {
                return;
            }

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

                int ItemCode = Convert.ToInt32(dgvAllStockList.CurrentRow.Cells[1].Value);

                if(clsItemGroup.DoesItemExistsInThisGroup(ItemCode,GroupID))
                {
                    MessageBox.Show("Item already exists in this group","Not Allowed", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                clsItemGroup ItemGroup = new clsItemGroup();

                ItemGroup.ItemCode = ItemCode;
                ItemGroup.GroupID = GroupID;

                if(!ItemGroup.Save())
                {
                    MessageBox.Show("Error in Adding to Group", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

                _LoadSelectedGroupItems(GroupID);
                _LoadItemsTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvGroupItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!chbFastMode.Checked)
            {
                return;
            }

            int ItemCode = Convert.ToInt32(dgvGroupItems.CurrentRow.Cells["ItemCode"].Value);
            int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

            if (!clsItemGroup.Delete(ItemCode, GroupID))
            {
                MessageBox.Show("Error!!");
            }

            _LoadSelectedGroupItems(GroupID);
            _LoadItemsTable();
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow Row in dgvAllStockList.Rows)
            {
                if (Row.IsNewRow) continue;

                Row.Cells["Selected"].Value = !_IsAllRowsSelected;
            }

            _IsAllRowsSelected = !_IsAllRowsSelected;

            btnSelectAll.Text = _IsAllRowsSelected ? "DeSelect All" : "Select All";
        }
        private void dgvAllStockList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAllStockList.Columns[e.ColumnIndex].Name == "GroupName" && e.Value != null)
            {
                string GroupName = e.Value.ToString();

                if (GroupName == "Not Assigned")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Blue;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void txbGroupsFilterValue_TextChanged(object sender, EventArgs e)
        {
            if(dgvGroupItems.DataSource is DataTable dt)
                _ApplyFilter(dt, cmbGroupsFilterBy, txbGroupsFilterValue);
        }
    }
}
