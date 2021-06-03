using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    public class RoundedRectangle : Figure
    {      
        public RoundedRectangle(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }
        

        public override void Draw(int finishX, int finishY)
        {          
            int width = finishX - _startX < 0 ? _startX - finishX : finishX - _startX;
            int height = finishY - _startY < 0 ? _startY - finishY : finishY - _startY;

            if (_startX < finishX && _startY < finishY)
            {
                _myGraphics.DrawRoundedRectangle(_startX, _startY, width, height);
            }
            else if (_startX > finishX && _startY > finishY)
            {
                _myGraphics.DrawRoundedRectangle(finishX, finishY, width, height);
            }
            else if (_startX < finishX && _startY > finishY)
            {
                _myGraphics.DrawRoundedRectangle(_startX, finishY, width, height);
            }
            else if (_startX > finishX && _startY < finishY)
            {
                _myGraphics.DrawRoundedRectangle(finishX, _startY, width, height);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is RoundedRectangle rectangle &&
                   EqualityComparer<IMyGraphics>.Default.Equals(_myGraphics, rectangle._myGraphics) &&
                   _pullable == rectangle._pullable &&
                   IsSelected == rectangle.IsSelected &&
                   _startX == rectangle._startX &&
                   _startY == rectangle._startY &&
                   _finishX == rectangle._finishX &&
                   _finishY == rectangle._finishY &&
                   Pullable == rectangle.Pullable;
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
