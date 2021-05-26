using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Line : Figure
    {
        public Line(Point start, Pen p)
        {
            _start = start;
            _p = p;
            _pullable = true;
            
        }
        public override void Draw(Graphics g, Point current)
        {
            
            g.DrawLine(_p, _start, current);
        }
    }
}
