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

        public override object Clone()
        {
            Figure res = new Curve(new Point(_start.X, _start.Y), (Pen)_p.Clone());
            res.Pullable = _pullable;
            res.EndPoint = new Point(_end.X, _end.Y);
            return res;
        }

        public override void Draw(Graphics g, Point current)
        {

            g.DrawLine(_p, current.X, current.Y , _start.X, _start.Y);
            _start = current;
        }

        public override void Move(int moveX, int moveY)
        {
            throw new NotImplementedException();
        }
    }
}
