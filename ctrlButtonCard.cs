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
            this.Cursor = Cursors.Hand;
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
            pnlMain.BackColor = Color.LightBlue;
            pnlMain.Location = new Point(pnlMain.Left, pnlMain.Top - 2);
        }

        private void pnlMain_MouseLeave(object sender, EventArgs e)
        {
            pnlMain.BackColor = Color.LightCyan;
            pnlMain.Location = new Point(pnlMain.Left, pnlMain.Top + 2);
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            pnlMain.BackColor = Color.SkyBlue;
            pnlMain.Location = new Point(pnlMain.Left, pnlMain.Top + 2);
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            pnlMain.BackColor = Color.LightCyan;
            pnlMain.Location = new Point(pnlMain.Left, pnlMain.Top - 2);
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void Child_Click(object sender, EventArgs e)
        {
            pnlMain_Click(pnlMain, e);
        }

        private void ctrlButtonCard_Load(object sender, EventArgs e)
        {
            pnlMain.BackColor = Color.LightCyan;
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
