using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckPointBusinessLayer;

namespace Check_Point_Manager
{
    public partial class frmRecordItemVariation : Form
    {
        private int _ItemCode = -1;
        private clsItem _Item;
        public frmRecordItemVariation(int ItemCode)
        {
            InitializeComponent();
            _ItemCode = ItemCode;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillData()
        {
            lblItemCode.Text = _Item.ItemCode.ToString();
            lblDescription.Text = _Item.Description;
            lblQty.Text = _Item.Qty.ToString();
            lblLzQty.Text = _Item.LzQty.ToString();
            lblPrice.Text = _Item.RetailPrice.ToString();
            txbVQty.Text = _Item.VariationQty.ToString();
            txbVLzQty.Text = _Item.VariationLzQty.ToString();
        }
        private void frmRecordItemVariation_Load(object sender, EventArgs e)
        {
            if (_ItemCode == -1)
            {
                MessageBox.Show("item not found !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _Item = clsItem.Find(_ItemCode);

            if(_Item == null)
            {
                MessageBox.Show("item not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _FillData();
            txbVQty.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int VariationQty = string.IsNullOrEmpty(txbVQty.Text) ? 0 : Convert.ToInt32(txbVQty.Text.Trim());
            _Item.VariationQty = VariationQty;

            int VariationLzQty = string.IsNullOrEmpty(txbVLzQty.Text) ? 0 : Convert.ToInt32(txbVLzQty.Text.Trim());
            _Item.VariationLzQty = VariationLzQty;

            if(!_Item.UpdateVariationRecord(VariationQty,VariationLzQty))
            {
                MessageBox.Show("Error in updating data !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSave.Enabled = false;
            txbVQty.Text = _Item.VariationQty.ToString();
            txbVLzQty.Text = _Item.VariationLzQty.ToString();
            txbVQty.Enabled = false;
            txbVLzQty.Enabled = false;

            MessageBox.Show("Variation Recrded Successfully", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar == '+' || e.KeyChar == '-') && ((sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                    && e.KeyChar != '-' && e.KeyChar != '+';
            }
        }
    }
}
