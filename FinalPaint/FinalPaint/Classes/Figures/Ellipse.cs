
using FinalPaint.Interfaces_;
using System.Collections.Generic;

namespace FinalPaint.Classes
{
     public class Ellipse : Figure
    {
        public Ellipse(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;

namespace FinalPaint.Classes
{
  public  class Ellipse : Figure
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

        [JsonConstructor]
        public Ellipse(bool pullable, bool isselected, int startx, int starty, int endx, int endy)
        {
            _pullable = pullable;
            IsSelected = isselected;
            _startX = startx;
            _startY = _startY;
            _finishX = endx;
            _finishX = endy;
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
     

        public override bool Equals(object obj)
        {
            return obj is Ellipse ellipse &&
                   EqualityComparer<IMyGraphics>.Default.Equals(_myGraphics, ellipse._myGraphics) &&
                   _pullable == ellipse._pullable &&
                   IsSelected == ellipse.IsSelected &&
                   _startX == ellipse._startX &&
                   _startY == ellipse._startY &&
                   _finishX == ellipse._finishX &&
                   _finishY == ellipse._finishY &&
                   Pullable == ellipse.Pullable;
        }

        public override int GetHashCode()
        {
            int hashCode = -1288887542;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMyGraphics>.Default.GetHashCode(_myGraphics);
            hashCode = hashCode * -1521134295 + _pullable.GetHashCode();
            hashCode = hashCode * -1521134295 + IsSelected.GetHashCode();
            hashCode = hashCode * -1521134295 + _startX.GetHashCode();
            hashCode = hashCode * -1521134295 + _startY.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishX.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishY.GetHashCode();
            hashCode = hashCode * -1521134295 + Pullable.GetHashCode();
            return hashCode;
        }

        public override bool IsPointInPoly(int x, int y)
        {
            bool res = false;

            if (x >= _startX && x <= _finishX && y >= _startY && y <= _finishY)
            {
                res = true;
            }
            return res;
        public override bool IsPointInPoly(int x, int y )

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
