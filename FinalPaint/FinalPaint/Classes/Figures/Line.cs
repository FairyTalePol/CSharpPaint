using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    public class Line : Figure
    {
        public Line(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }

        public Line(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
        }


        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawLine(_startX, _startY, finishX, finishY);
        }

        public bool IsPointOnLine(int x, int y)
        {
            bool res = false;
            if(_startX>=_finishX&&_startY>=_finishY)
            {
                (_startX, _startY) = (_finishX, _finishY);
            }
            if (x >= _startX && x <= _finishX && y >= _startY && y <= _finishY)
            {
                res = true;
            }
            return res;
        }
    }
}
