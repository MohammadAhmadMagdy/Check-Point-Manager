using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckPointBusinessLayer;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Check_Point_Manager
{
    public partial class frmMainScreen : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, string lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private const int EM_SETCUEBANNER = 0x1501;

        private void _SetCueBanner(TextBox textBox, string cueText, bool showIcon)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, showIcon ? 1 : 0, cueText);
        }


        private bool _IsLoadingGrous = false;
        private string _ExcelFile = "";
        private DataTable _dtAllStockList;
        private DataTable _dtNewlyAddedItems;
        private DataTable _dtGroupsList;
        private DataTable _dtSelectedGroupItems;
        private bool _IsAllItemsRowsSelected = false;
        private bool _IsAllGroupRowSelect = false;
        private bool _IsItemsTableHeaderChecked = false;
        private bool _IsGroupTableHeaderChecked = false;
        private int _NewlyAddedItemsCount = 0;

        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 220, 218);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);


            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(241,240,241);
        }
        private void _PrepareAutoCompleteForGroupsComboBox()
        {
            AutoCompleteStringCollection AC = new AutoCompleteStringCollection();

            foreach(DataRow Row in _dtGroupsList.Rows)
            {
                string GroupName = Row["GroupName"].ToString();
                string GroupNumber = Row["GroupNumber"].ToString();

                AC.Add(GroupName);
                AC.Add(GroupNumber);
            }

            cmbGroups.AutoCompleteCustomSource = AC;
        }
        private void _FillGroupsComboBox()
        {
            _IsLoadingGrous = true;

            _dtGroupsList = clsGroup.LoadAllGroupsInfo();

            DataRow Row = _dtGroupsList.NewRow();

            Row["GroupName"] = "None";
            Row["GroupID"] = -1;
            Row["GroupNumber"] = -1;
            Row["CheckCounter"] = 0;

            _dtGroupsList.Rows.InsertAt(Row, 0);

            cmbGroups.DataSource = _dtGroupsList;
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupID";

            cmbGroups.SelectedIndex = 0;
            lblGroupChecked.Visible = false;

            _IsLoadingGrous = false;

            _PrepareAutoCompleteForGroupsComboBox();
        }
        private void _LoadItemsTable()
        {
            _dtAllStockList = clsItem.GetAllStockList();

            _dtNewlyAddedItems = clsItem.GetNewlyAddedItemsList();

            if (cmbItemsFilterBy.Text == "Newly Added Items")
            {
                dgvAllStockList.DataSource = _dtNewlyAddedItems;
            }
            else
            {
                dgvAllStockList.DataSource = _dtAllStockList;
                dgvAllStockList.Columns["VariationQty"].Visible = false;
                dgvAllStockList.Columns["VariationLzQty"].Visible = false;

            }

            _AddVisualStyleToTable(dgvAllStockList);

            _IsAllItemsRowsSelected = false;
            btnSelectAll.Text = "Select All";

            txbFilterValue.Focus();

            if (dgvAllStockList.Rows.Count > 0)
            {
                dgvAllStockList.Columns["Selected"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvAllStockList.Columns["Selected"].HeaderText = "";
                dgvAllStockList.Columns["Selected"].Width = 30;

                dgvAllStockList.Columns["ItemCode"].HeaderText = "Code";
                dgvAllStockList.Columns["ItemCode"].Width = 53;

                dgvAllStockList.Columns["Description"].HeaderText = "Description";
                dgvAllStockList.Columns["Description"].Width = 301;

                dgvAllStockList.Columns["Qty"].HeaderText = "Qty";
                dgvAllStockList.Columns["Qty"].Width = 50;
                dgvAllStockList.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllStockList.Columns["LzQty"].HeaderText = "LzQty";
                dgvAllStockList.Columns["LzQty"].Width = 50;
                dgvAllStockList.Columns["LzQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllStockList.Columns["RetailPrice"].HeaderText = "Price";
                dgvAllStockList.Columns["RetailPrice"].Width = 50;
                dgvAllStockList.Columns["RetailPrice"].DefaultCellStyle.Format = "N3";
                dgvAllStockList.Columns["RetailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllStockList.Columns["GroupName"].HeaderText = "Group";
                dgvAllStockList.Columns["GroupName"].Width = 90;
            }


            txbFilterValue_TextChanged(null, null);
            lblItemRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
        private void _LoadSelectedGroupItems(int GroupID)
        {
            _dtSelectedGroupItems = clsItemGroup.GetGroupItemsByGroupID(GroupID);

            dgvGroupItems.DataSource = _dtSelectedGroupItems;

            pcbGroupsBackground.Visible = GroupID == -1;

            _IsAllGroupRowSelect = false;

            _AddVisualStyleToTable(dgvGroupItems);

            txbGroupsFilterValue.Focus();

            if (dgvGroupItems.Rows.Count > 0)
            {
                dgvGroupItems.Columns["Selected"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvGroupItems.Columns["Selected"].HeaderText = "";
                dgvGroupItems.Columns["Selected"].Width = 30;

                dgvGroupItems.Columns["ItemCode"].HeaderText = "Code";
                dgvGroupItems.Columns["ItemCode"].Width = 53;

                dgvGroupItems.Columns["Description"].HeaderText = "Description";
                dgvGroupItems.Columns["Description"].Width = 392;

                dgvGroupItems.Columns["Qty"].HeaderText = "Qty";
                dgvGroupItems.Columns["Qty"].Width = 50;
                dgvGroupItems.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvGroupItems.Columns["LzQty"].HeaderText = "LzQty";
                dgvGroupItems.Columns["LzQty"].Width = 50;
                dgvGroupItems.Columns["LzQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvGroupItems.Columns["RetailPrice"].HeaderText = "Price";
                dgvGroupItems.Columns["RetailPrice"].Width = 50;
                dgvGroupItems.Columns["RetailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGroupItems.Columns["RetailPrice"].DefaultCellStyle.Format = "N3";


            }

            txbGroupsFilterValue_TextChanged(null, null);
            lblGroupRecord.Text = dgvGroupItems.RowCount.ToString();
            lblGroupChecked.Text = clsGroup.FindByID(GroupID).CkeckCounter.ToString() + " Time(s)";
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
        private void _dgvSelectEntireRowByRightClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var DGV = (DataGridView)sender;

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0  && e.ColumnIndex >= 0)
            {
                DGV.ClearSelection();
                DGV.CurrentCell = DGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        private void _dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var DGV = (DataGridView)sender;

            if (e.ColumnIndex == DGV.Columns["Selected"].Index && e.RowIndex >= 0)
                DGV.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void _dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var DGV = (DataGridView)sender;

            if (e.ColumnIndex != 0)
            {
                e.Cancel = true;
            }
        }
        private string _GetColumnName(ComboBox cmb)
        {
            switch (cmb.Text)
            {
                case "Item Code":
                    return "ItemCode";
                case "Group Name":
                    return "GroupName";
                default:
                    return cmb.Text;

            }
        }
        private void _ApplyFilter(DataTable table, ComboBox cmb, TextBox txb)
        {
            if (table == null)
                return;

            string columnName = _GetColumnName(cmb);


            if (cmb.Text == "None" || string.IsNullOrEmpty(columnName))
            {
                table.DefaultView.RowFilter = "";
                return;
            }

            if (cmb.Text == "Not Assigned Items")
            {
                table.DefaultView.RowFilter = "GroupName = 'Not Assigned'";
                table.DefaultView.Sort = "Qty DESC, LzQty DESC";
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
                using (Brush semiTransparentBrush = new SolidBrush
                    (System.Drawing.Color.FromArgb(200, System.Drawing.Color.Transparent)))
                {
                    e.Graphics.FillRectangle(semiTransparentBrush, pcbGroupsBackground.ClientRectangle);
                }
            }
        }
        private void frmMainScreen_Load(object sender, EventArgs e)
        {


            _FillGroupsComboBox();

            _LoadItemsTable();

            cmbItemsFilterBy.SelectedIndex = 2;
            cmbGroupsFilterBy.SelectedIndex = 2;

            chbFastMode.Checked = true;

            btnUpdate.Enabled = false;

            _SetCueBanner(txbFilterValue, "Search", true);

            _SetCueBanner(txbGroupsFilterValue, "Search", true);
        }   
        private void txbFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllStockList.DataSource is DataTable dt)
                _ApplyFilter(dt, cmbItemsFilterBy, txbFilterValue);

            lblItemRecords.Text = dgvAllStockList.Rows.Count.ToString();
        }
        private void txbGroupsFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (dgvGroupItems.DataSource is DataTable dt)
                _ApplyFilter(dt, cmbGroupsFilterBy, txbGroupsFilterValue);

        }
        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbItemsFilterBy.Text == "Item Code")
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
        private void txbGroupsFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbGroupsFilterBy.Text == "Item Code")
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool needsText =
                 cmbItemsFilterBy.Text != "None" &&
                 cmbItemsFilterBy.Text != "Newly Added Items" &&
                 cmbItemsFilterBy.Text != "Not Assigned Items";

            txbFilterValue.Visible = needsText;
            pcbItemsSearchIcon.Visible = txbFilterValue.Visible;
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
            pcbGroupSearchIcon.Visible = txbGroupsFilterValue.Visible;
            txbGroupsFilterValue.Text = "";

            clsGroup ChoosenGroup = clsGroup.FindByName(cmbGroups.Text.Trim());

            if (ChoosenGroup != null)
                _LoadSelectedGroupItems(ChoosenGroup.GroupID);
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
                lblGroupChecked.Visible = false;
                return;
            }

            lblGroupChecked.Visible = true;
            txbGroupsFilterValue.Text = string.Empty;
            _LoadSelectedGroupItems(GroupID);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
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
                        lblUpdateStatus.Text = "Stock Updated Successfully, " + _NewlyAddedItemsCount + " New Items Added";

                        if (MessageBox.Show("Stock Updated Successfully\n" + _NewlyAddedItemsCount + " New Items Added\n" +
                            "Do you want to explore Newly Added Items ?", "Success",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmbItemsFilterBy.SelectedIndex = 5;
                        }
                    }
                    else
                    {
                        lblUpdateStatus.Text = "Stock Updated Successfully, No New Items Added";
                        MessageBox.Show("Stock Updated Successfully\nNo New Items Added", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txbFilePath.Text = "";

                    _LoadItemsTable();
                    btnUpdate.Enabled = false;
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
                btnUpdate.Enabled = true;
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

                if (MessageBox.Show("Are you sure you want to Remove these items to\n" + cmbGroups.Text + " Group ?",
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
        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroups.SelectedValue == null)
                    return;

                int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

                if (GroupID == -1)
                {
                    MessageBox.Show("You Should Select A Group First", "Not Allowed", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    cmbGroups.Focus();
                    return;
                }

                List<int> SelectedItems = new List<int>();

                foreach (DataGridViewRow DR in dgvGroupItems.Rows)
                {
                    bool IsSelected = DR.Cells["Selected"].Value != null
                        && Convert.ToBoolean(DR.Cells["Selected"].Value);

                    if (IsSelected)
                    {
                        int ItemCode = Convert.ToInt32(DR.Cells["ItemCode"].Value);
                        SelectedItems.Add(ItemCode);
                    }
                }

                if (SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please Select at Least One Item to Remove", "No Items", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to Remove these items to\n" + cmbGroups.Text + " Group ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }

                int NumberOfItemsRemoved = clsItemGroup.RemoveItemsListFromGroup(SelectedItems, GroupID);

                MessageBox.Show(NumberOfItemsRemoved + " Items Removed Successfully From Group", "Success",
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

            frmMainScreen_Load(null, null);
        }
        private void btnExportFile_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (_dtSelectedGroupItems == null || _dtSelectedGroupItems.Rows.Count == 0)
                {
                    MessageBox.Show("No Item To Export\nPlease Select a Group First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Confirming count this check or not :
                DialogResult Result = MessageBox.Show("Do you want to count this group check ?", "Confirmation",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (Result == DialogResult.Cancel)
                {
                    return;
                }

                int GroupID = Convert.ToInt32(cmbGroups.SelectedValue);

                if (Result == DialogResult.Yes)
                {
                    
                    clsGroup SelectedGroup = clsGroup.FindByID(GroupID);

                    if(SelectedGroup == null || !SelectedGroup.CounterPlus())
                    {
                        MessageBox.Show("Error in counting check !", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                DataView dv = new DataView(_dtSelectedGroupItems);
                dv.RowFilter = "Qty > 0 OR LzQty > 0";
                dv.Sort = "Description ASC";

                DataTable dtFilteredData = dv.ToTable(false, "ItemCode", "Description", "Qty", "LzQty", "RetailPrice");

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

                    // Add broders 
                    var range = ws.Range(1, 1, dtFilteredData.Rows.Count + 1, dtFilteredData.Columns.Count);

                    range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    range.Style.Border.RightBorder = XLBorderStyleValues.Thin;

                    // تنسيق الخطوط وضبط الأعمدة
                    ws.Columns().AdjustToContents();
                    ws.Style.Font.FontName = "Segoe UI";
                    ws.Style.Font.FontSize = 10;

                    ws.Column(3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Column(4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Column(5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                    ws.Column(5).Style.NumberFormat.Format = "0.000";

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

                    lblGroupChecked.Text = clsGroup.FindByID(GroupID).CkeckCounter.ToString() + " Time(s)";
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

            if (!clsItemGroup.Delete(ItemCode, GroupID))
            {
                MessageBox.Show("Error!!");
            }

            _LoadSelectedGroupItems(GroupID);
            _LoadItemsTable();
        }
        private void dgvAllStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!chbFastMode.Checked)
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

                if (clsItemGroup.DoesItemExistsInThisGroup(ItemCode, GroupID))
                {
                    MessageBox.Show("Item already exists in this group", "Not Allowed", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                clsItemGroup ItemGroup = new clsItemGroup();

                ItemGroup.ItemCode = ItemCode;
                ItemGroup.GroupID = GroupID;

                if (!ItemGroup.Save())
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
        private void dgvAllStockList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAllStockList.Columns[e.ColumnIndex].Name == "GroupName" && e.Value != null)
            {
                string GroupName = e.Value.ToString();

                if (GroupName == "Not Assigned")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Regular);
                }
                else
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Blue;
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var DGV = (DataGridView)sender;

            if (DGV.Columns[e.ColumnIndex].Name == "Selected")
            {
                bool IsChecked = DGV.Columns[e.ColumnIndex].Tag == null ? false :
                    (bool)DGV.Columns[e.ColumnIndex].Tag;

                IsChecked = !IsChecked;
                DGV.Columns[e.ColumnIndex].Tag = IsChecked;

                foreach (DataGridViewRow Row in DGV.Rows)
                {
                    Row.Cells["Selected"].Value = IsChecked;
                }

                DGV.EndEdit();

                DGV.Invalidate();
            }
        }
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var dgv = (DataGridView)sender;

           
            if (e.RowIndex == -1 && dgv.Columns[e.ColumnIndex].Name == "Selected")
            {

                using (Brush b = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }

                e.Paint(e.CellBounds, DataGridViewPaintParts.Border);

                Bitmap icon = Properties.Resources.SelectAllIcon;

                if (icon != null)
                {
               
                    int iconSize = 18;
                    int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;

                    
                    e.Graphics.DrawImage(icon, new Rectangle(x, y, iconSize, iconSize));
                }

                e.Handled = true;
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dgvAllStockList.Rows)
            {
                if (Row.IsNewRow) continue;

                Row.Cells["Selected"].Value = !_IsAllItemsRowsSelected;
            }

            _IsAllItemsRowsSelected = !_IsAllItemsRowsSelected;

            btnSelectAll.Text = _IsAllItemsRowsSelected ? "DeSelect All" : "Select All";
        }
        private void btnGroupsSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dgvGroupItems.Rows)
            {
                if (Row.IsNewRow) continue;

                Row.Cells["Selected"].Value = !_IsAllGroupRowSelect;
            }

            _IsAllGroupRowSelect = !_IsAllGroupRowSelect;

            btnGroupsSelectAll.Text = _IsAllGroupRowSelect ? "Deselect All" : "Select All";
        }
        private void frmMainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnAddToGroup.PerformClick();
            else if (e.KeyCode == Keys.F3)
                btnRemoveItems.PerformClick();
        }
        private void txbFilterValue_Enter(object sender, EventArgs e)
        {
            pcbItemsSearchIcon.Visible = false;
        }
        private void txbFilterValue_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbFilterValue.Text))
                pcbItemsSearchIcon.Visible = true;
        }
        private void pcbItemsSearchIcon_Click(object sender, EventArgs e)
        {
            txbFilterValue.Focus();
        }
        private void pcbGroupSearchIcon_Click(object sender, EventArgs e)
        {
            txbGroupsFilterValue.Focus();
        }
        private void txbGroupsFilterValue_Enter(object sender, EventArgs e)
        {
            pcbGroupSearchIcon.Visible = false;
        }
        private void txbGroupsFilterValue_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbGroupsFilterValue.Text))
                pcbGroupSearchIcon.Visible = true;
        }

        private void recordItemVariationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ItemCode = Convert.ToInt32(dgvAllStockList.CurrentRow.Cells["ItemCode"].Value);

            frmRecordItemVariation frm = new frmRecordItemVariation(ItemCode);

            frm.ShowDialog();

        }

        private void btnVariationList_Click(object sender, EventArgs e)
        {
            frmVariationsList frm = new frmVariationsList();
            frm.ShowDialog();


        }

       
    }
}
