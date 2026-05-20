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
    public partial class frmProgressBox : Form
    {
        public frmProgressBox()
        {
            InitializeComponent();
        }
        public void SetMessage(string message)
        {
            lblMessage.Text = message;

            Application.DoEvents();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            else
                base.OnFormClosing(e);
        }
    }
}
