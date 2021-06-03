

using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;

namespace FinalPaint.Classes
{
  public  class CustomPoint : Figure
    {
       
        public CustomPoint(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }

        public CustomPoint(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
        }

        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawPoint(_startX , _startY , finishX, finishY);
        }

        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;

            if ((x <= _startX + error && x >= _startX - error) && (y <= _startY + error && y >= _startY - error))
            {
                res = true;
            }

            return res;
        }

        public override void AddCoordinates(int x, int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
