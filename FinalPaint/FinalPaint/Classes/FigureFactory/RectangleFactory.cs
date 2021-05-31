using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes.FigureFactory
{
    class RectangleFactory : FigureFactory
    {
        public RectangleFactory(int startX, int startY, IMyGraphics mg) : base(startX, startY, mg)
        {

        }
        public override Figure Create()
        {
            return new Rectangle(StartX, StartY, _myGraphics);
        }

    }
}

