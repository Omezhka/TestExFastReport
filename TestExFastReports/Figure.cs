namespace TestExFastReports
{
    class Figure : IFigure
    {
        public Brush Brush { get; private set; }

        public Pen Pen { get; private set; }

        public virtual void Calcucate(object rectangle)
        {
            throw new NotImplementedException();
        }

        public void ChangeBrushColor( Color color)
        {
            Brush = new SolidBrush(color);
        }

        public void ChangePenColor(Color color)
        {
            Pen = new Pen(color);
        }

        public static void DrawFigures(List<IFigure> figures, PictureBox pictureBox)
        {
            var bit = new Bitmap(pictureBox.Width, pictureBox.Height);
            var g = Graphics.FromImage(bit);
            foreach (var figure in figures)
            {
                figure.Fill(g, figure.Brush ?? Brushes.Yellow);
                figure.Draw(g, figure.Pen ?? Pens.Green);

            }
            pictureBox.Image = bit;
        }

        public virtual bool Contains(Point pt)
        {
            return false; 
        }

        public virtual void Draw(Graphics g, Pen pen)
        {
            Pen = pen;
        }

        public virtual void Fill(Graphics g, Brush brush)
        {
            Brush = brush;
        }
    }
}
