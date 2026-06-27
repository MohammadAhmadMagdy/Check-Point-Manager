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

namespace Check_Point_Manager
{
    public partial class frmTalabatSync : Form
    {
        // Maximum number of items per chunk (max 999 as requested)
        private const int CHUNK_SIZE = 999;

        public frmTalabatSync()
        {
            InitializeComponent();
        }

        private void frmTalabatSync_Load(object sender, EventArgs e)
        {
            _InitializeQuantityPolicyOptions();

             //⚡ كود إنقاذ مؤقت لرفع الأكواد تلقائياً من الملف النصي إلى الداتابيز مباشرة
            //try
            //{
            //    string filePath = "New Text Document.txt"; // تأكد من وضع الملف بجانب ملف الـ .exe
            //    if (System.IO.File.Exists(filePath))
            //    {
            //        var lines = System.IO.File.ReadAllLines(filePath);
            //        foreach (string line in lines)
            //        {
            //            int code;
            //            if (int.TryParse(line.Trim(), out code))
            //            {
            //                // استدعاء دالة الإضافة التي كتبناها في الـ BL
            //                clsTalabatWhiteListCode.AddToWhiteList(code);
            //            }
            //        }
            //        //MessageBox.Show("تم رفع الأكواد بنجاح برمجياً إلى جدول TalabatWhiteList!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.WriteLine("In-App Import Error: " + ex.Message);
            //}
        }

        private void _InitializeQuantityPolicyOptions()
        {
            cmbSingleQtyPolicy.Items.Clear();
            cmbSingleQtyPolicy.Items.Add("Treat Quantity (1) as Available (ONES)");
            cmbSingleQtyPolicy.Items.Add("Treat Quantity (1) as Out of Stock (ZEROS)");
            cmbSingleQtyPolicy.SelectedIndex = 0; // Default
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            _ExecuteSync();
        }

        // 🔄 دالة ميكانيكية لجلب قائمة الأكواد المسموحة فقط (TalabatIncludedItems)
        private HashSet<int> _LoadIncludedItemCodes()
        {
            HashSet<int> includedCodes = new HashSet<int>();
            try
            {
                // استدعاء دالة جلب المسموحات من طبقة العمل (Business Layer)
                // تأكد من إضافة دالة GetAllIncludedItemCodes داخل كلاس clsItem في الـ BL
                DataTable dtIncluded = clsTalabatWhiteListCode.GetAllIncludedItemCodes();

                if (dtIncluded != null)
                {
                    foreach (DataRow row in dtIncluded.Rows)
                    {
                        if (row["ItemCode"] != DBNull.Value)
                        {
                            includedCodes.Add(Convert.ToInt32(row["ItemCode"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading included items: " + ex.Message);
            }
            return includedCodes;
        }

        // 🛠️ الدالة الرئيسية المحدثة تكتيكياً بناءً على سياسة السماح (Whitelist)
        private void _ExecuteSync()
        {
            try
            {
                // 1. جلب أكواد قائمة السماح
                HashSet<int> includedItems = _LoadIncludedItemCodes();

                // 🔍 فحص سريع: إذا كانت القائمة فارغة نبه المستخدم فوراً
                if (includedItems.Count == 0)
                {
                    MessageBox.Show("Warning: TalabatWhiteList table is empty in the database!", "Data Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. جلب بيانات المخزون
                DataTable dtStock = clsItem.GetAllStockList();

                if (dtStock == null || dtStock.Rows.Count == 0)
                {
                    MessageBox.Show("No stock data found to synchronize.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<int> zerosList = new List<int>();
                List<int> onesList = new List<int>();

                bool treatOneAsZero = (cmbSingleQtyPolicy.SelectedIndex == 1);

                // 3. الفرز والفلترة
                foreach (DataRow row in dtStock.Rows)
                {
                    if (row["ItemCode"] == DBNull.Value) continue;

                    // الفحص الآمن للتحويل مع إزالة أي مسافات مخفية .Trim()
                    int itemCode;
                    if (!int.TryParse(row["ItemCode"].ToString().Trim(), out itemCode))
                    {
                        continue;
                    }

                    // 🎯 شرط سياسة السماح
                    if (!includedItems.Contains(itemCode))
                    {
                        continue; // إذا لم يطابق كود الـ Whitelist يتجاوزه فوراً
                    }

                    // شرط طول الكود (تأكد أن أكواد صيدليتك لا تقل عن 5 خانات)
                    if (itemCode < 10000) continue;

                    decimal qty = Convert.ToDecimal(row["Qty"]);

                    if (qty <= 0)
                    {
                        zerosList.Add(itemCode);
                    }
                    else if (qty == 1)
                    {
                        if (treatOneAsZero)
                            zerosList.Add(itemCode);
                        else
                            onesList.Add(itemCode);
                    }
                    else
                    {
                        onesList.Add(itemCode);
                    }
                }

                // 4. ضخ وتحديث عناصر الواجهة
                _PopulateLanes(flpZeros, zerosList, "ZEROS");
                _PopulateLanes(flpOnes, onesList, "ONES");

                // إشعار النجاح المطور لإعطائك تقريراً دقيقاً عن الأرقام
                MessageBox.Show($"Synchronization Done!\n\n" +
                                $"Total items in WhiteList: {includedItems.Count}\n" +
                                $"Matched & Displayed in ZEROS: {zerosList.Count}\n" +
                                $"Matched & Displayed in ONES: {onesList.Count}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execution Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _PopulateLanes(FlowLayoutPanel panel, List<int> itemsList, string typeName)
        {
            panel.Controls.Clear(); // تفريغ اللوحة قبل إعادة التحميل

            int chunkIndex = 1;
            for (int i = 0; i < itemsList.Count; i += CHUNK_SIZE)
            {
                List<int> chunk = itemsList.GetRange(i, Math.Min(CHUNK_SIZE, itemsList.Count - i));
                string joinedText = string.Join(Environment.NewLine, chunk);

                Panel chunkPanel = new Panel();
                chunkPanel.Size = new Size(185, 110);
                chunkPanel.BorderStyle = BorderStyle.FixedSingle;
                chunkPanel.Margin = new Padding(6);
                chunkPanel.BackColor = Color.White;

                Label lblTitle = new Label();
                lblTitle.Text = $"{typeName} - Chunk {chunkIndex}\n({chunk.Count} Items)";
                lblTitle.Location = new Point(10, 12);
                lblTitle.AutoSize = true;
                lblTitle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                Button btnCopy = new Button();
                btnCopy.Text = "Copy Chunk";
                btnCopy.Size = new Size(163, 32);
                btnCopy.Location = new Point(10, 60);
                btnCopy.Cursor = Cursors.Hand;
                btnCopy.FlatStyle = FlatStyle.Flat;
                btnCopy.BackColor = Color.FromArgb(255, 90, 0); // لـون طلبات البرتقالي
                btnCopy.ForeColor = Color.White;
                btnCopy.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                btnCopy.Click += (s, e) =>
                {
                    try
                    {
                        Clipboard.SetText(joinedText);
                        btnCopy.Text = "Copied ✓";
                        btnCopy.Enabled = false;
                        btnCopy.BackColor = Color.LightGray;
                        btnCopy.ForeColor = Color.DimGray;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to copy chunk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                chunkPanel.Controls.Add(lblTitle);
                chunkPanel.Controls.Add(btnCopy);
                panel.Controls.Add(chunkPanel);

                chunkIndex++;
            }
        }
    }
}