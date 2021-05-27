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
        public EllipseFactory(int startX, int startY) : base(startX, startY)
        {

        }
        public override Figure Create()
        {
            return new Ellipse(StartX, StartY);
        }
    }
}
