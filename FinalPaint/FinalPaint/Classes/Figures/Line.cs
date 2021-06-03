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

        
        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawLine(_startX, _startY, finishX, finishY);
        }

        public override bool Equals(object obj)
        {
            return obj is Line line &&
                   EqualityComparer<IMyGraphics>.Default.Equals(_myGraphics, line._myGraphics) &&
                   _pullable == line._pullable &&
                   IsSelected == line.IsSelected &&
                   _startX == line._startX &&
                   _startY == line._startY &&
                   _finishX == line._finishX &&
                   _finishY == line._finishY &&
                   Pullable == line.Pullable;
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
            return false;
        }
    }
}
