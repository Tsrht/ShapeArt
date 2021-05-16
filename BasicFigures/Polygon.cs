using System;
using System.Drawing;
using FigureBasis;

namespace BasicFigures
{
    public class PolygonFabric : IFigureFabric
    {
        public Figure Produce()
        {
            return new Polygon();
        }
    }
    public class Polygon : Figure
    {
        public override string Name => "Многоугольник";

        public override void Draw(Graphics graphics)
        {
            if (IsFigureOkay())
            {
                if (Filled)
                {
                    if (Points.Count == 2)
                    {

                        graphics.DrawPolygon(Pen, Points.ToArray());
                    }
                    graphics.FillPolygon(new SolidBrush(Pen.Color), Points.ToArray());
                }
                else
                {
                    graphics.DrawPolygon(Pen, Points.ToArray());
                }
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
