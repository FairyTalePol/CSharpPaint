using FinalPaint.Interfaces_;
using Newtonsoft.Json;
using System;

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

        [JsonConstructor]
        public Line(bool pullable, bool isselected, int startx, int starty, int endx, int endy)
        {
            _pullable = pullable;
            IsSelected = isselected;
            _startX = startx;
            _startY = _startY;
            _finishX = endx;
            _finishX = endy;
        }


        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawLine(_startX, _startY, finishX, finishY);
        }

        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;

            int x1 = _startX;
            int x2 = _finishX;
            int y1 = _startY;
            int y2 = _finishY;

           
            if (Math.Abs(x-((y-y1)*(x2-x1)/(y2-y1) + x1)) <= error)
            {
                res = true;
            }

            return res;
        }

        public override void AddCoordinates(int x, int y)
        {
            _startX += x;
            _startY += y;
            _finishX += x;
            _finishY += y;
        }

        public override object Clone()
        {
            Line res = new Line(_startX, _startY);
            res._finishX = _finishX;
            res._finishY = _finishY;
            res._myGraphics = _myGraphics;
            res._pullable = _pullable;
            res.IsSelected = IsSelected;
            return res;
        }

        public override void Optimize()
        {
         
        }
    }
}
