using System;
using System.Drawing;
using FigureBasis;

namespace BasicFigures
{
    public class PolylineFabric : IFigureFabric
    {
        public Figure Produce()
        {
            return new Polyline();
        }
    }
    public class Polyline : Figure
    {
        public override string Name => "Ломаная";

        public override void Draw(Graphics graphics)
        {
            if (IsFigureOkay())
            {
                graphics.DrawLines(Pen, Points.ToArray());
            }
        }

        public override bool IsFigureOkay()
        {
            return Points.Count > 1;
        }

        public override bool TryAddPoint(Point point)
        {
            Points.Add(point);
            return true;
        }
    }
}
