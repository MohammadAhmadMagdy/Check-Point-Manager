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
        private void _FillData()
        {
            lblItemCode.Text = _Item.ItemCode.ToString();
            lblDescription.Text = _Item.Description;
            lblQty.Text = _Item.Qty.ToString();
            lblLzQty.Text = _Item.LzQty.ToString();
            lblPrice.Text = _Item.RetailPrice.ToString();
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
        }
    }
}
