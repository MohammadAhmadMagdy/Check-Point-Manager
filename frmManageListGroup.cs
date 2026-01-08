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
    public partial class frmManageListGroup : Form
    {
        private DataTable _AllGroups;
        public frmManageListGroup()
        {
            InitializeComponent();
        }
        //private void _AddButtonCardClick(object sender, EventArgs e)
        //{
        //    frmAddGroup frm = new frmAddGroup();
        //    frm.ShowDialog();
        //    frmManageListGroup_Load(null, null);
        //}

        private void frmManageListGroup_Load(object sender, EventArgs e)
        {
            _AllGroups = clsGroup.LoadAllGroupsInfo();

            dgvListGroups.DataSource = _AllGroups;
        }

        private void ctrlButtonCardAddNew_Click(object sender, EventArgs e)
        {
            frmAddGroup frm = new frmAddGroup();
            frm.ShowDialog();
            frmManageListGroup_Load(null, null);
        }

    }
}
