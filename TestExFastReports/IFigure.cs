namespace TestExFastReports
{
    interface IFigure
    {
        Brush Brush { get; }
        Pen Pen { get; }
        bool Contains(Point pt);
        void Draw(Graphics g, Pen pen);
        void Fill(Graphics g, Brush brush);
        void Calcucate(object rectangle);
        void ChangeBrushColor(Color color);
        void ChangePenColor(Color color);
    }
}
