using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Check_Point_Manager.ctrlButtonCard;

namespace Check_Point_Manager
{
    public partial class ctrlButtonCard : UserControl
    {
        public enum enButtonCardType { Primary, Secondary, Danger }
        private enButtonCardType _ButtonType = enButtonCardType.Primary;
        private Color _NormalColor = Color.LightCyan;
        private Color _HoverColor = Color.LightBlue;
        private Color _ClickColor = Color.SkyBlue;
        private bool _IsMouseOver = false;
        public ctrlButtonCard()
        {
            InitializeComponent();
        }
        //private void ApplyStyle()
        //{
        //    switch (_ButtonType)
        //    {
        //        case enButtonCardType.Primary:
        //            _NormalColor = Color.LightBlue;
        //            _HoverColor = Color.DodgerBlue;
        //            _ClickColor = Color.DeepSkyBlue;
        //            this.Cursor = Cursors.Hand;
        //            break;

        //        case enButtonCardType.Secondary:
        //            _NormalColor = Color.Gainsboro;
        //            _HoverColor = Color.LightGray;
        //            _ClickColor = Color.Silver;
        //            this.Cursor = Cursors.Hand;
        //            break;

        //        case enButtonCardType.Danger:
        //            _NormalColor = Color.MistyRose;
        //            _HoverColor = Color.LightCoral;
        //            _ClickColor = Color.IndianRed;
        //            this.Cursor = Cursors.No;
        //            break;
        //    }

        //    pnlMain.BackColor = _NormalColor;
        //}

        private void ApplyStyle()
        {
            switch (_ButtonType)
            {
                case enButtonCardType.Primary:
                    // Primary - أزرق حديث وواضح
                    _NormalColor = Color.FromArgb(200, 230, 255);   // Blue 500
                    _HoverColor = Color.FromArgb(170, 210, 250);   // Blue 600
                    _ClickColor = Color.FromArgb(140, 190, 240);   // Blue 700
                    this.Cursor = Cursors.Hand;
                    break;

                case enButtonCardType.Secondary:
                    // Secondary - أخضر حديث وواضح
                    _NormalColor = Color.FromArgb(220, 245, 220);    // Green 500
                    _HoverColor = Color.FromArgb(190, 230, 190);    // Green 600
                    _ClickColor = Color.FromArgb(160, 215, 160);    // Green 700
                    this.Cursor = Cursors.Hand;
                    break;

                case enButtonCardType.Danger:
                    // Danger - أحمر حديث وواضح
                    _NormalColor = Color.FromArgb(255, 220, 220);    // Red 500
                    _HoverColor = Color.FromArgb(250, 190, 190);    // Red 600
                    _ClickColor = Color.FromArgb(240, 160, 160);    // Red 700
                    this.Cursor = Cursors.No;
                    break;
            }

            pnlMain.BackColor = _NormalColor;
        }



        [Category("Button Card")]
        [Description("Controls the visual importance of the button")]
        public enButtonCardType ButtonType
        {
            get { return _ButtonType; }
            set
            {
                _ButtonType = value;
                ApplyStyle();
            }
        }


        [Category("Button Card")]
        public Color NormalColor
        {
            get { return _NormalColor; }
            set { _NormalColor = value; pnlMain.BackColor = _NormalColor; }
        }
        [Category("Button Card")]
        public Color HoverColor
        {
            get { return _HoverColor; }
            set { _HoverColor = value; }
        }
        [Category("Button Card")]
        public Color ClickColor
        {
            get { return _ClickColor; }
            set { _ClickColor = value; }
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
            _IsMouseOver = true;
            pnlMain.BackColor = _HoverColor;
           
        }

        private void pnlMain_MouseLeave(object sender, EventArgs e)
        {
            _IsMouseOver = false;
            pnlMain.BackColor = _NormalColor;
         
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            pnlMain.BackColor = _ClickColor;
        
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (_IsMouseOver)
                pnlMain.BackColor = _HoverColor;
            else
                pnlMain.BackColor = _NormalColor;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 12;
            Rectangle rect = this.ClientRectangle;

            using (System.Drawing.Drawing2D.GraphicsPath path =
                   new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }


        private void pnlMain_Click(object sender, EventArgs e)
        {
            OnClick(e);

            pnlMain.BackColor = _NormalColor;
        }
        private void Child_Click(object sender, EventArgs e)
        {
            pnlMain_Click(pnlMain, e);
        }

        private void ctrlButtonCard_VisibleChanged(object sender, EventArgs e)
        {
            //pnlMain.BackColor = _NormalColor;
            //_IsMouseOver = false;
        }
    }
}
