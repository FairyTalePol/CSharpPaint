using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes.FigureFactory
{
    class EllipseFactory : FigureFactory
    {
        public EllipseFactory(Pen p, Point s) : base(p, s)
        {

        }
        public override Figure Create()
        {
            return new Ellipse(Start, P);
        }
    }
}
