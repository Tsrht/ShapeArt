using FigureBasis;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawingInformation
{
    public class DrawInfo
    {
        public List<IFigureFabric> Availables = new List<IFigureFabric>();
        public IFigureFabric CurrentFabric = null;
        public Figure CurrentFigure = null;
        public Pen CurrentPen = new Pen(Color.Black, 1);
        public bool CurrentFill = true;
        public List<Figure> Figures = new List<Figure>();
        public List<Figure> Trash = new List<Figure>();
    }
}
