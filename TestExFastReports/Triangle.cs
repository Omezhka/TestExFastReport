namespace TestExFastReports
{
    class Triangle : Figure, IFigure
    {
        private readonly Form1 form1;
        private Point[] verticies;
        public Triangle(Form1 form)
        {
            form1 = form;
           
        }

        public override bool Contains(Point pt)
        {
            var bit = new Bitmap(form1.PictureBox.Width, form1.PictureBox.Height);
            var g = Graphics.FromImage(bit);
            g.DrawPolygon(Pens.Green, verticies);
            g.FillPolygon(Brushes.Aquamarine, verticies);

            Color pixelColor = bit.GetPixel(pt.X, pt.Y);
            Color zeroZeroColor = bit.GetPixel(0, 0);

            bit.Dispose();
            g.Dispose();

            if (pixelColor != zeroZeroColor)
                return true;
            else return false;
        }

        public override void Calcucate(object rectangle)
        {
            Point[] _points = (Point[])rectangle;

            verticies = CalculateVertices(_points[0]);
        }

        private Point[] CalculateVertices(Point point)
        {
            List<Point> points = new List<Point>();

            float step = 360.0f / 3;
            float startingAngle = (float)form1.NumAngle.Value;
            float radius = (float)form1.NumRadius.Value;

            float angle = startingAngle; //начальный угол
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //идти по кругу
            {
                points.Add(DegreesToXY(angle, radius, point));
                angle += step;
            }
            return points.ToArray();
        }

        private static Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillPolygon(brush, verticies);
            base.Fill(g, brush);
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawPolygon(pen, verticies);
            base.Draw(g, pen);
        }
    }
}
