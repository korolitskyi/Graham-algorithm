using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graham_scan_WF
{
    class BorderedPictureBox : PictureBox
    {
        public static Color DefaultBorderColor = Color.Red;
        public static float DefaultBorderWidth = 2f;

        private Pen _BorderPen = new Pen(DefaultBorderColor, DefaultBorderWidth);
        /// <summary>
        /// Задает или возвращает цвет рамки
        /// </summary>
        public Color BorderColor { get { return _BorderPen.Color; } set { _BorderPen.Color = value; } }

        /// <summary>
        /// Задает или возвращает толщину рамки
        /// </summary>
        public float BorderWidth
        {
            get { return _BorderPen.Width; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _BorderPen.Width = value;
            }
        }

        private bool _DrawBorder = true;
        /// <summary>
        /// Определяет, будет ли отрисована рамка
        /// </summary>
        public bool DrawBorder { get { return _DrawBorder; } set { _DrawBorder = value; } }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawRectangle(_BorderPen, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Right - 1, ClientRectangle.Bottom - 1);

        }
    }
}
