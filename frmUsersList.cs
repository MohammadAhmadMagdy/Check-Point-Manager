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
    public partial class frmUsersList : Form
    {
        DataTable _dtUsersList;
        public frmUsersList()
        {
            InitializeComponent();
        }
        private void _AdjustDataGridColumns()
        {
            dgvUsersList.Columns[0].HeaderText = "User ID";
            dgvUsersList.Columns[0].Width = 130;
            
            dgvUsersList.Columns[1].HeaderText = "User Name";
            dgvUsersList.Columns[1].Width = 262;
            
            dgvUsersList.Columns[2].HeaderText = "Is Active?";
            dgvUsersList.Columns[2].Width = 120;
          
           
        }
        private void _AddVisualStyleToTable(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 220, 218);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);


            dgv.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(241, 240, 241);
        }
        private void _LoadAllUsersLis()
        {
            _dtUsersList = clsUser.GetAllUsers();

            dgvUsersList.DataSource = _dtUsersList;

            _AddVisualStyleToTable(dgvUsersList);

            if (dgvUsersList.Rows.Count > 0)
            {
                _AdjustDataGridColumns();
            }
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _LoadAllUsersLis();
        }
    }
}
