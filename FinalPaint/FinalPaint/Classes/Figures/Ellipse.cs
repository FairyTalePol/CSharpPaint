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

        public override object Clone()
        {
            Figure res = new Ellipse(new Point(_start.X, _start.Y), (Pen)_p.Clone());
            res.Pullable = _pullable;
            res.EndPoint = new Point(_end.X, _end.Y);
            return res;
        }

        public override void Draw(Graphics g, Point current)
        {
            
            g.DrawEllipse(_p, _start.X, _start.Y, current.X - _start.X, current.Y - _start.Y);

            
        }

        public override void Move(int moveX, int moveY)
        {
            throw new NotImplementedException();
        }
    }
}
