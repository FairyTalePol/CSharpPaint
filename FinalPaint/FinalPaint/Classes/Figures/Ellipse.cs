
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

        public override void AddCoordinates(int x, int y)
        {
            throw new System.NotImplementedException();
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
}
}
