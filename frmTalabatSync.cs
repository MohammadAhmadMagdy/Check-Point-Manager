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

        private const int CHUNK_SIZE = 999;

        public frmTalabatSync()
        {
            InitializeComponent();
        }

        private void frmTalabatSync_Load(object sender, EventArgs e)
        {
            _InitializeQuantityPolicyOptions();

            lblStatus.Text = "";


            //⚡ Code to import multiple white list codes from txt file:
            //try
            //{
            //    string filePath = "New Text Document.txt"; // put in main directory beside .exe
            //    if (System.IO.File.Exists(filePath))
            //    {
            //        var lines = System.IO.File.ReadAllLines(filePath);
            //        foreach (string line in lines)
            //        {
            //            int code;
            //            if (int.TryParse(line.Trim(), out code))
            //            {
            //               
            //                clsTalabatWhiteListCode.AddToWhiteList(code);
            //            }
            //        }
            //        //MessageBox.Show("Codes imported successfully to TalabatWhiteList!");
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
            cmbSingleQtyPolicy.Items.Add("Show Last Piece");
            cmbSingleQtyPolicy.Items.Add("Hide Last Piece");
            cmbSingleQtyPolicy.SelectedIndex = 0; 
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            _ExecuteSync();
        }

        private HashSet<int> _LoadIncludedItemCodes()
        {
            HashSet<int> includedCodes = new HashSet<int>();
            try
            {
                
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

        
        private void _ExecuteSync()
        {
            try
            {
                
                HashSet<int> includedItems = _LoadIncludedItemCodes();

                if (includedItems.Count == 0)
                {
                    MessageBox.Show("Warning: TalabatWhiteList table is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                DataTable dtStock = clsItem.GetAllStockList();

                if (dtStock == null)
                {
                    MessageBox.Show("Error fetching stock list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                Dictionary<int, decimal> stockDictionary = new Dictionary<int, decimal>();
                foreach (DataRow row in dtStock.Rows)
                {
                    if (row["ItemCode"] == DBNull.Value) continue;

                    int itemCode;
                    if (int.TryParse(row["ItemCode"].ToString().Trim(), out itemCode))
                    {
                        decimal qty = row["Qty"] != DBNull.Value ? Convert.ToDecimal(row["Qty"]) : 0;

                        
                        if (!stockDictionary.ContainsKey(itemCode))
                        {
                            stockDictionary.Add(itemCode, qty);
                        }
                    }
                }

                List<int> zerosList = new List<int>();
                List<int> onesList = new List<int>();

                bool treatOneAsZero = (cmbSingleQtyPolicy.SelectedIndex == 1);

               
                foreach (int itemCode in includedItems)
                {
                    if (itemCode < 10000) continue; 

                    decimal qty = 0;

                    
                    if (stockDictionary.ContainsKey(itemCode))
                    {
                        qty = stockDictionary[itemCode];
                    }
                    else
                    {
                        qty = 0;
                    }

          
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


                _PopulateLanes(flpZeros, zerosList, "ZEROS");
                _PopulateLanes(flpOnes, onesList, "ONES");

                lblStatus.Text = $"Total Items : {includedItems.Count}";
                gbxZeros.Text = $"ZEROS: ({zerosList.Count} Items)";
                gbxOnes.Text = $"ONES: ({onesList.Count} Items)";

                //MessageBox.Show($"Synchronization Done successfully!\n\n" +
                //                $"Total in WhiteList: {includedItems.Count}\n" +
                //                $"Displayed in ZEROS: {zerosList.Count}\n" +
                //                $"Displayed in ONES: {onesList.Count}\n\n",
                //                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execution Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _PopulateLanes(FlowLayoutPanel panel, List<int> itemsList, string typeName)
        {
            panel.Controls.Clear(); 

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
                btnCopy.BackColor = Color.FromArgb(255, 90, 0);
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