using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using System.Collections.Generic;

namespace FinalPaint.Classes
{
    public class Rectangle : Figure
    {
        public Rectangle (int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }

        public Rectangle(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
        }
        
        public override void Draw(int finishX, int finishY)
        {
           
            int width = finishX - _startX < 0 ? _startX - finishX : finishX - _startX;
            int height = finishY - _startY < 0 ? _startY - finishY : finishY - _startY;
            if (_startX < finishX && _startY < finishY)
            {
                _myGraphics.DrawRectangle(_startX, _startY, width, height);
            }
            else if(_startX > finishX && _startY > finishY)
            {               
                _myGraphics.DrawRectangle( finishX, finishY, width, height);
            }
            else if (_startX < finishX && _startY > finishY)
            {
                _myGraphics.DrawRectangle( _startX, finishY, width, height);
            }
            else if(_startX> finishX && _startY< finishY)
            {
                _myGraphics.DrawRectangle( finishX, _startY, width, height);
            }
            
            _finishX = finishX;
            _finishY = finishY;

        }


        public override bool IsPointInPoly(int x, int y)
        {
            bool res = false;

            if (x>=_startX&&x<=_finishX&&y>=_startY&&y<=_finishY)
            {
                res = true;
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
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
    }
}
