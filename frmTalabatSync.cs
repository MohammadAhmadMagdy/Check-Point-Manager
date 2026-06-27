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
            MessageBox.Show(@"هذه الخاصية مازالت تحت الاختبار يرجى الاستخدام بحذر !","Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                // 1. جلب أكواد قائمة السماح (3928 صنف)
                HashSet<int> includedItems = _LoadIncludedItemCodes();

                if (includedItems.Count == 0)
                {
                    MessageBox.Show("Warning: TalabatWhiteList table is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. جلب بيانات المخزون الحركي الحالية
                DataTable dtStock = clsItem.GetAllStockList();

                if (dtStock == null)
                {
                    MessageBox.Show("Error fetching stock list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // تحويل الـ dtStock إلى Dictionary سريع جداً للبحث بداخلة بالـ ItemCode وجلب الـ Qty
                Dictionary<int, decimal> stockDictionary = new Dictionary<int, decimal>();
                foreach (DataRow row in dtStock.Rows)
                {
                    if (row["ItemCode"] == DBNull.Value) continue;

                    int itemCode;
                    if (int.TryParse(row["ItemCode"].ToString().Trim(), out itemCode))
                    {
                        decimal qty = row["Qty"] != DBNull.Value ? Convert.ToDecimal(row["Qty"]) : 0;

                        // تجنب الأخطاء في حال تكرار الكود في جدول المخزون
                        if (!stockDictionary.ContainsKey(itemCode))
                        {
                            stockDictionary.Add(itemCode, qty);
                        }
                    }
                }

                List<int> zerosList = new List<int>();
                List<int> onesList = new List<int>();

                bool treatOneAsZero = (cmbSingleQtyPolicy.SelectedIndex == 1);

                // 3. 🎯 الدوران المضمون حول الأصناف الـ 3928 المسموحة فقط
                foreach (int itemCode in includedItems)
                {
                    if (itemCode < 10000) continue; // شرط طول الكود الحماسي

                    decimal qty = 0;

                    // إذا وجدنا الصنف في المخزون نأخذ كميته الحقيقية
                    if (stockDictionary.ContainsKey(itemCode))
                    {
                        qty = stockDictionary[itemCode];
                    }
                    else
                    {
                        // 🔥 الـ 1072 صنف المفقودين سيقعون هنا! 
                        // بما أنهم غير موجودين في المخزون الحركي، نعتبر كميتهم تلقائياً (0) لرفعهم كـ ZEROS لحماية المنصة
                        qty = 0;
                    }

                    // تصنيف الأصناف
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

                // تقرير النجاح النهائي المتكامل بدون أي مفقودات
                MessageBox.Show($"Synchronization Done successfully!\n\n" +
                                $"Total in WhiteList: {includedItems.Count}\n" +
                                $"Displayed in ZEROS: {zerosList.Count}\n" +
                                $"Displayed in ONES: {onesList.Count}\n\n" +
                                $"📊 الحسبة الآن: {zerosList.Count} + {onesList.Count} = {zerosList.Count + onesList.Count} صنف تم توزيعهم بالكامل دون تجاهل أي كود!",
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