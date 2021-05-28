using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class CustomPoint:Figure
    {
        private Brush _brush;
        public CustomPoint(Point start, Pen pen)
        {
            _p = pen;
            _start = start;
            _pullable = true;
            _brush = new SolidBrush(_p.Color);
        }

        public override object Clone()
        {
            CustomPoint res = new CustomPoint(new Point(_start.X, _start.Y), (Pen)_p.Clone());
            res.Pullable = _pullable;
            res.EndPoint = new Point(_end.X, _end.Y);
            res._brush = (Brush)_brush.Clone();
            return res;
        }

        public override void Draw(Graphics g, Point current)
        {
            
            g.FillEllipse(_brush, _start.X-_p.Width/2, _start.Y - _p.Width / 2, _p.Width,_p.Width);
        }

        public override void Move(int moveX, int moveY)
        {
            throw new NotImplementedException();
        }
    }
}
