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
    public class Curve : Figure
    {
        List<TwoDimensionalPoint> points;
        public Curve(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
            points = new List<TwoDimensionalPoint>();
            points.Add(new TwoDimensionalPoint(startX, startY));
        }

        public override void AddCoordinates(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Draw(int finishX, int finishY)
        {
            points.Add(new TwoDimensionalPoint(finishX, finishY));
            _myGraphics.DrawCurve(points);
            _startX = finishX;
            _startY = finishY;

        }

        public override bool Equals(object obj)
        {
            return obj is Curve curve &&
                   EqualityComparer<IMyGraphics>.Default.Equals(_myGraphics, curve._myGraphics) &&
                   _pullable == curve._pullable &&
                   IsSelected == curve.IsSelected &&
                   _startX == curve._startX &&
                   _startY == curve._startY &&
                   _finishX == curve._finishX &&
                   _finishY == curve._finishY &&
                   Pullable == curve.Pullable &&
                   EqualityComparer<List<TwoDimensionalPoint>>.Default.Equals(points, curve.points);
        }

        public override int GetHashCode()
        {
            int hashCode = 2143573600;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMyGraphics>.Default.GetHashCode(_myGraphics);
            hashCode = hashCode * -1521134295 + _pullable.GetHashCode();
            hashCode = hashCode * -1521134295 + IsSelected.GetHashCode();
            hashCode = hashCode * -1521134295 + _startX.GetHashCode();
            hashCode = hashCode * -1521134295 + _startY.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishX.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishY.GetHashCode();
            hashCode = hashCode * -1521134295 + Pullable.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<TwoDimensionalPoint>>.Default.GetHashCode(points);
            return hashCode;
        }

        public override bool IsPointInPoly(int x, int y)
        {
            return false;
        }

        public override void Optimize()
        {
            throw new NotImplementedException();
        }
    }
}
