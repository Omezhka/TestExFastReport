
namespace TestExFastReports
{
    class Circle : Figure, IFigure
    {
        readonly Form1 form1;
        public Circle(Form1 form)
        {
            form1 = form;
        }
        private Rectangle _rectangle;

        public override bool Contains(Point pt)
        {
            var bit = new Bitmap(form1.PictureBox.Width, form1.PictureBox.Height);
            var g = Graphics.FromImage(bit);
            g.DrawEllipse(Pens.Green, _rectangle);
            g.FillEllipse(Brushes.Aquamarine, _rectangle);

            Color pixelColor = bit.GetPixel(pt.X,pt.Y);
            Color zeroZeroColor = bit.GetPixel(0, 0);

            bit.Dispose();
            g.Dispose();

            if (pixelColor != zeroZeroColor)
                return true;
            else return false;
          
        }

        public override void Calcucate(object rectangle)
        {
            _rectangle = (Rectangle)rectangle;
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillEllipse(brush, _rectangle);
            base.Fill(g, brush);
        }
        public override void Draw(Graphics g, Pen pen)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawEllipse(pen, _rectangle);

            base.Draw(g, pen);
        }
    }
}
