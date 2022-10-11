namespace TestExFastReports
{
    public partial class Form1 : Form
    {
        readonly List<IFigure> _figures = new();
      
        public Form1()
        {
            InitializeComponent();
        }
        public PictureBox PictureBox
        {
            get
            {
                return pictureBox1;
            }
            private set { pictureBox1 = value; }
        }

        public NumericUpDown NumAngle
        {
            get
            {
                return nAngle;
            }
            private set { nAngle = value; }
        }

        public NumericUpDown NumRadius
        {
            get
            {
                return nRadius;
            }
            private set { nRadius = value; }
        }

        private void ChangeBrushColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //DrawButton.BackColor = colorDialog1.Color;
                foreach (var figure in _figures)
                {
                    figure.ChangeBrushColor(colorDialog1.Color);
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }

        private void ChangePenColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var figure in _figures)
                {
                    figure.ChangePenColor(colorDialog1.Color);
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = _figures.Exists(f => f.Contains(e.Location)) ? Cursors.Hand : Cursors.Default;
        }

        private void R_ValueChanged(object sender, EventArgs e)
        {
            var countCircle = _figures.Where(f => f.GetType() == typeof(Circle)).Count();

            if (countCircle < 1)
                _figures.Add(new Circle(this));

            if (_figures.Count > 0)
            {
                foreach (var figure in _figures)
                {
                    if (figure is Circle)
                    {
                        figure.Calcucate(
                            new Rectangle((pictureBox1.Width / 2) - ((int)R.Value),
                                          (pictureBox1.Height / 2) - ((int)R.Value),
                                          (int)R.Value * 2, (int)R.Value * 2));
                    }
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }

        private void NumUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            var countSquare = _figures.Where(f => f.GetType() == typeof(Square)).Count();

            if (countSquare < 1)
                _figures.Add(new Square());

            if (_figures.Count > 0)
            {
                foreach (var figure in _figures)
                {
                    if (figure is Square)
                        figure.Calcucate(new Rectangle(100, 100, (int)NumUpDownWidth.Value, (int)NumUpDownHeight.Value));
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }

        private void NumUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            var countSquare = _figures.Where(f => f.GetType() == typeof(Square)).Count();

            if (countSquare < 1)
                _figures.Add(new Square());

            if (_figures.Count > 0)
            {
                foreach (var figure in _figures)
                {
                    if (figure is Square)
                        figure.Calcucate(new Rectangle(100, 100, (int)NumUpDownWidth.Value, (int)NumUpDownHeight.Value));
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }

        private void nRadius_ValueChanged(object sender, EventArgs e)
        {
            var countCircle = _figures.Where(f => f.GetType() == typeof(Triangle)).Count();

            if (countCircle < 1)
                _figures.Add(new Triangle(this));

            if (_figures.Count > 0)
            {
                foreach (var figure in _figures)
                {
                    if (figure is Triangle)
                        figure.Calcucate(new Point[] {
                             new Point(PictureBox.Width / 3 + PictureBox.Width / 2 - pictureBox1.Width / 5,
                                      PictureBox.Height / 2),
                        });
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }

        private void nAngle_ValueChanged(object sender, EventArgs e)
        {
            var countCircle = _figures.Where(f => f.GetType() == typeof(Triangle)).Count();

            if (countCircle < 1)
                _figures.Add(new Triangle(this));

            if (_figures.Count > 0)
            {
                foreach (var figure in _figures)
                {
                    if (figure is Triangle)
                        figure.Calcucate(new Point[] {
                           new Point(PictureBox.Width / 3 + PictureBox.Width / 2 - pictureBox1.Width / 5,
                                      PictureBox.Height / 2),                       
                        });
                }
                Figure.DrawFigures(_figures, pictureBox1);
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_figures.Exists(f => f.Contains(e.Location)))
                MessageBox.Show("Данная точка находится внутри примитива");
            else
                MessageBox.Show("Данная точка НЕ находится внутри примитива");
        }
    }
}