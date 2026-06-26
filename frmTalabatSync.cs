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
        }

        private void _InitializeQuantityPolicyOptions()
        {
            cmbSingleQtyPolicy.Items.Clear();
            cmbSingleQtyPolicy.Items.Add("Treat Quantity (1) as Available (ONES)");
            cmbSingleQtyPolicy.Items.Add("Treat Quantity (1) as Out of Stock (ZEROS)");
            cmbSingleQtyPolicy.SelectedIndex = 1; // Default
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            _ExecuteSync();
        }

        private void _ExecuteSync()
        {
            // Fetch data from your Data Access Layer
            DataTable dtStock = clsItem.GetAllStockList();

            if (dtStock == null || dtStock.Rows.Count == 0)
            {
                MessageBox.Show("No stock data found to synchronize.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> zerosList = new List<string>();
            List<string> onesList = new List<string>();

            bool treatOneAsZero = (cmbSingleQtyPolicy.SelectedIndex == 1);

            // Classifying items
            foreach (DataRow row in dtStock.Rows)
            {
                string itemCode = row["ItemCode"].ToString();
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

            // Populating both panels side-by-side simultaneously
            _PopulateLanes(flpZeros, zerosList, "ZEROS");
            _PopulateLanes(flpOnes, onesList, "ONES");

            //MessageBox.Show("Data synchronization completed successfully!", "Success",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _PopulateLanes(FlowLayoutPanel panel, List<string> itemsList, string typeName)
        {
            panel.Controls.Clear(); // Clear side panel before reloading

            int chunkIndex = 1;
            for (int i = 0; i < itemsList.Count; i += CHUNK_SIZE)
            {
                List<string> chunk = itemsList.GetRange(i, Math.Min(CHUNK_SIZE, itemsList.Count - i));
                string joinedText = string.Join(Environment.NewLine, chunk);

                // Smart Card design for each chunk to fit inside the 50% width layout safely
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
                btnCopy.BackColor = Color.FromArgb(255, 90, 0); // Talabat Orange
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


