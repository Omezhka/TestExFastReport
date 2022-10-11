using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace TestExFastReports
{
    class Square : Figure, IFigure
    {
        private Rectangle _rectangle;
       
        public override bool Contains(Point pt)
        {
            return _rectangle.Contains(pt);
        }

        public override void Calcucate(object rectangle)
        {
            _rectangle = (Rectangle)rectangle;
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, _rectangle);
            base.Fill(g, brush);
        }
        public override void Draw(Graphics g, Pen pen)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawRectangle(pen, _rectangle);
            
            base.Draw(g, pen);
        }
    }
}
