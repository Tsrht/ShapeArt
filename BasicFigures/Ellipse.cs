using System;
using System.Drawing;
using FigureBasis;
using static System.Math;

namespace BasicFigures
{
    public class EllipseFabric : IFigureFabric
    {
        public Figure Produce()
        {
            return new Ellipse();
        }
    }
    public class Ellipse : Figure
    {
        public override string Name => "Эллипс";

        public override void Draw(Graphics graphics)
        {
            if (IsFigureOkay())
            {
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(
                    Min(Points[0].X, Points[1].X),
                    Min(Points[0].Y, Points[1].Y),
                    Max(Points[0].X, Points[1].X) - Min(Points[0].X, Points[1].X),
                    Max(Points[0].Y, Points[1].Y) - Min(Points[0].Y, Points[1].Y)
                    );
                if (Filled)
                {
                    graphics.FillEllipse(new SolidBrush(Pen.Color), rect);
                }
                else
                {
                    graphics.DrawEllipse(Pen, rect);
                }
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
