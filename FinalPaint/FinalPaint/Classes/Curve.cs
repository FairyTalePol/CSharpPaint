using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Curve : Figure
    {
        public Curve(Point start, Pen pen)
        {
            _p = pen;
            _start = start;
            _pullable = false;
        }

        public override void Draw(Graphics g, Point current)
        {
            _g = g;

            _g.DrawLine(_p, current.X, current.Y , _start.X, _start.Y);
            _start = current;


        }
    }
}
