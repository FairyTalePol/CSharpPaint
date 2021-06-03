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

        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;
            //////////int x1 = _startX;
            //////////int x2 = _finishX;
            //////////int y1 = _startY;
            //////////int y2 = _finishY;
            //////////if (((x-x1)*(y2-y1)-(y-y1)*(x2-x1)==0) &&((x>x1 && x<x2)||(x>x2 && x<x1)))
            //////////{
            //////////    res = true;
            //////////}
            ///
            int x1 = _startX;
            int x2 = _finishX;
            int y1 = _startY;
            int y2 = _finishY;


            if (Math.Abs(x-((y-y1)*(x2-x1)/(y2-y1) - x1)) <= error)
            {
                res = true;
            }

            return res;
        }

        public override void AddCoordinates(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
