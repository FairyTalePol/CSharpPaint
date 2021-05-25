using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes.FigureFactory
{
    class PolygonFactory : FigureFactory
    {
        public int Corners { get; set; }
        public PolygonFactory(Pen p, Point s, int corners) : base(p, s)
        {
            Corners = corners;
        }
        public override Figure Create()
        {
            return new Polygon(Start, P, Corners);
        }

    }
}

