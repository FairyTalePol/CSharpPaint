
using FinalPaint.Interfaces_;

namespace FinalPaint.Classes
{
    class Ellipse : Figure
    {
        public Ellipse(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;

        }

        public Ellipse(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
        }

        public override void AddCoordinates(int x, int y)
        {
            _startY += y;
            _startX += x;
            _finishX += x;
            _finishY += y;
        }

        public override object Clone()
        {
            Ellipse res = new Ellipse(_startX, _startY);
            res._finishX = _finishX;
            res._finishY = _finishY;
            res._myGraphics = _myGraphics;
            res._pullable = _pullable;
            res.IsSelected = IsSelected;
            return res;
        }

        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawEllipse(_startX, _startY, finishX, finishY);
        }
     


        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;

            if (x >= _startX && x <= _finishX && y >= _startY && y <= _finishY)
            {
                res = true;
            }
            return res;
        }

        public override void Optimize()
        {
            int temp;
            if (_startX > _finishX)
            {
                temp = _startX;
                _startX = _finishX;
                _finishX = temp;
            }

            if (_startY > _finishY)
            {
                temp = _startY;
                _startY = _finishY;
                _finishY = temp;
            }
        }
    }
}
