using System;
using System.Collections.Generic;
using System.Drawing;

namespace FigureBasis
{
    public interface IFigureFabric
    {
        public Figure Produce();
    }
    public abstract class Figure
    {
        public abstract string Name { get; }

        public List<Point> Points = new List<Point>();
        public Pen Pen { get; set; } = new Pen(Color.Black, 1);
        public bool Filled { get; set; } = true;

        public abstract void Draw(Graphics graphics);
        public abstract bool TryAddPoint(Point point);
        public abstract bool IsFigureOkay();

    }
}
