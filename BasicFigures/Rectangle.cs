using System;
using System.Drawing;
using FigureBasis;
using static System.Math;

namespace BasicFigures
{
    public class RectangleFabric : IFigureFabric
    {
        public Figure Produce()
        {
            return new Rectangle();
        }
    }
    public class Rectangle : Figure
    {
        public override string Name => "Прямоугольник";

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
                    graphics.FillRectangle(new SolidBrush(Pen.Color), rect);
                }
                else
                {
                    graphics.DrawRectangle(Pen, rect);
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
