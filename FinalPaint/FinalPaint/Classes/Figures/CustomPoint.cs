

using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using Newtonsoft.Json;

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
        [JsonConstructor]
        public CustomPoint(bool pullable, bool isselected, int startx, int starty, int endx, int endy)
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
            _startX += x;
            _startY += y;
        }

        public override object Clone()
        {
            CustomPoint res = new CustomPoint(_startX, _startY);
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
