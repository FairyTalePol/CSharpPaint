

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

        public bool IsPointOnPoint(int x, int y)
        {
            bool res = false;

            if((x <= _startX+5 && x>=_startX-5)&&(y<=_startY+5&&y>=_startY-5))
            {
                res = true;
            }

            return res;
        }

    }
}
