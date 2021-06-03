
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
        }
}
}
