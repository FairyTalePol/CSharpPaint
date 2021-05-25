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
        public Pen P { get; set; }
        public Point Start { get; set; }

        public FigureFactory(Pen p, Point s)
        {
            P = p;
            Start = s;
        }

        abstract public Figure Create();

    }
}
