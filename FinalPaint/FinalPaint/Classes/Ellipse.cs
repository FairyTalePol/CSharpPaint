using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Ellipse : Figure
    {
      public Ellipse(Point start, Pen pen)
        {
            _p = pen;
            _start = start;
            _pullable = true;
        }
        
        public override void Draw(Graphics g, Point current)
        {
            _g = g;
            _g.DrawEllipse(_p, _start.X, _start.Y, current.X - _start.X, current.Y - _start.Y);

            
        }
    }
}
