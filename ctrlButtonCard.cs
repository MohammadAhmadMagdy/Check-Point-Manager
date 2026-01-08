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
    public partial class ctrlButtonCard : UserControl
    {
        
        public ctrlButtonCard()
        {
            InitializeComponent();
            pnlMain.BackColor = Color.Azure;
        }
        [Category("Button Card")]
        public Image Icon
        {
            get { return pcbIcon.Image; }
            set { pcbIcon.Image = value; }
        }
        [Category("Button Card")]
        public string Title
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        private void pnlMain_MouseEnter(object sender, EventArgs e)
        {
            pnlMain.BackColor = Color.Lavender;
        }

        private void pnlMain_MouseLeave(object sender, EventArgs e)
        {
            pnlMain.BackColor = Color.Azure;
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            pnlMain.BackColor = Color.SkyBlue;
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            pnlMain.BackColor = Color.Azure;
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

       

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
