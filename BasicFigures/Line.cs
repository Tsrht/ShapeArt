using System;
using System.Drawing;
using FigureBasis;

namespace BasicFigures
{
    public class LineFabric : IFigureFabric
    {
        public Figure Produce()
        {
            return new Line();
        }
    }
    public class Line : Figure
    {
        public override string Name => "Отрезок";

        public override void Draw(Graphics graphics)
        {
            if (IsFigureOkay())
            {
                graphics.DrawLine(Pen, Points[0], Points[1]);
            }
        }

        public override bool IsFigureOkay()
        {
            return Points.Count == 2;
        }

        public override bool TryAddPoint(Point point)
        {
            if (Points.Count < 2)
            {
                Points.Add(point);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
