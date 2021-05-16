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
        public SimplifiedPen Pen { get; set; } = new Pen(Color.Black, 1);
        public bool Filled { get; set; } = true;

        public abstract void Draw(Graphics graphics);
        public abstract bool TryAddPoint(Point point);
        public abstract bool IsFigureOkay();

    }
    public class SimplifiedPen
    {
        public Color Color { get; set; }
        public float Width { get; set; }

        public SimplifiedPen(Color color, float width)
        {
            Color = color;
            Width = width;
        }

        public static implicit operator Pen(SimplifiedPen spen)
        {
            return new Pen(spen.Color, spen.Width);
        }
        public static implicit operator SimplifiedPen(Pen pen)
        {
            return new SimplifiedPen(pen.Color, pen.Width);
        }
    }
}
