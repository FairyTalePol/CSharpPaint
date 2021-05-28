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

        public override object Clone()
        {
            Figure res = new Line(new Point(_start.X, _start.Y), (Pen)_p.Clone());
            res.Pullable = _pullable;
            res.EndPoint = new Point(_end.X, _end.Y);
            return res;
        }

        public override void Draw(Graphics g, Point current)
        {
            
            g.DrawLine(_p, _start, current);
        }

        public override void Move(int moveX, int moveY)
        {
            throw new NotImplementedException();
        }
    }
}
