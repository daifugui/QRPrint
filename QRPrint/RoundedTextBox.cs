using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRPrint
{
    class RoundedTextBox:TextBox
    {
        public Color color = Color.White;
        public int borderRadius = 25;
        public RoundedTextBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            SolidBrush brush = new SolidBrush(color);
            GraphicsPath GraphPath = FillRoundedRectangle(e.Graphics, brush, Rect, borderRadius);
            this.Region = new Region(GraphPath);
        }

        private GraphicsPath FillRoundedRectangle(Graphics graphics, SolidBrush brush, RectangleF rect, int borderRadius)
        {
            throw new NotImplementedException();
        }
    }
}
