using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes.FigureFactory
{
    abstract class FigureFactory
    {
        public int StartX { get; set; }
        public int StartY { get; set; }

        public FigureFactory(int startX, int startY)
        {
            StartX = startX;
            StartY = startY;
        }

        abstract public Figure Create();

    }
}
