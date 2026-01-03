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
    public partial class frmAddGroup : Form
    {
        public frmAddGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int GroupNumber = Convert.ToInt32(txbGroupNumber.Text);
            string GroupName = txbGroupName.Text;

            clsGroup NewGroup = new clsGroup();

            NewGroup.GroupName = GroupName;
            NewGroup.GroupNumber = GroupNumber;

            if(NewGroup.Save())
            {
                btnAdd.Enabled = false;
                MessageBox.Show("Group Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblNewGpID.Text = NewGroup.GroupID.ToString();
                lblNewGpName.Text = NewGroup.GroupName;
                lblNewGpNumber.Text = NewGroup.GroupNumber.ToString();
            }
            else
            {
                MessageBox.Show("Error While Adding Group !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbGroupNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
