using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Rectangle : Figure
    {
        public Rectangle (Point start, Pen pen)
        {
            _start = start;
            _p = pen;
            _pullable = true;
        }
        public override void Draw(Graphics g, Point current)
        {
           
            int width = current.X - _start.X < 0 ? _start.X - current.X : current.X - _start.X;
            int height = current.Y - _start.Y < 0 ? _start.Y - current.Y : current.Y - _start.Y;
            if (_start.X < current.X && _start.Y < current.Y)
            {
                g.DrawRectangle(_p, _start.X, _start.Y, width, height);
            }
            else if(_start.X > current.X && _start.Y > current.Y)
            {
                g.DrawRectangle(_p, current.X, current.Y, width, height);

            }
            else if (_start.X < current.X && _start.Y > current.Y)
            {
                g.DrawRectangle(_p, _start.X, current.Y, width, height);
            }
            else if(_start.X>current.X&&_start.Y<current.Y)
            {
                g.DrawRectangle(_p, current.X, _start.Y, width, height);
            }

        }
    }
}
