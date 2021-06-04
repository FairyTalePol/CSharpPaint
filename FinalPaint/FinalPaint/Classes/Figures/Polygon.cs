using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;

namespace FinalPaint.Classes
{
    public class Polygon : Figure
    {
        private int _pointsAmount;
        private List<TwoDimensionalPoint> _points = new List<TwoDimensionalPoint>();
        private double _r;

        public Polygon(int x, int y, int pointsAmount, IMyGraphics mg)
        {
            _startX = x;
            _startY = y;
            _pointsAmount = pointsAmount;
            _pullable = true;
            _myGraphics = mg;
        }

        public Polygon(int startX, int startY, int pointsAmount)
        {
            _startX = startX;
            _startY = startY;
            _pointsAmount = pointsAmount;
            _pullable = true;
        }

        private void CreatePolygon(int currentX, int currentY)
        {
            _finishX = currentX;
            _finishY = currentY;
            double _r = (currentX - _startX) / 2 > (currentY - _startY) / 2 ? (currentX - _startX) / 2 : (currentY - _startY) / 2;
            _points.Clear();
            TwoDimensionalPoint temp = new TwoDimensionalPoint();
            for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / _pointsAmount)
            {
                int width = currentX - _startX;
                temp.X = (int)(_r * Math.Cos(angle)) + _startX;
                int height = currentY - _startY;
                temp.Y = ((int)(_r * Math.Sin(angle)) + _startY);
                _points.Add(new TwoDimensionalPoint((int)_r + temp.X, (int)_r + temp.Y));
            }
        }

        public override void Draw(int finishX, int finishY)
        {
            CreatePolygon(finishX, finishY);
            _myGraphics.DrawPolygon(_points);
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

        public override bool Equals(object obj)
        {
            return obj is Polygon polygon &&
                   EqualityComparer<IMyGraphics>.Default.Equals(_myGraphics, polygon._myGraphics) &&
                   _pullable == polygon._pullable &&
                   IsSelected == polygon.IsSelected &&
                   _startX == polygon._startX &&
                   _startY == polygon._startY &&
                   _finishX == polygon._finishX &&
                   _finishY == polygon._finishY &&
                   Pullable == polygon.Pullable &&
                   _pointsAmount == polygon._pointsAmount &&
                   EqualityComparer<List<TwoDimensionalPoint>>.Default.Equals(_points, polygon._points);
        }

        public override int GetHashCode()
        {
            int hashCode = -479915808;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMyGraphics>.Default.GetHashCode(_myGraphics);
            hashCode = hashCode * -1521134295 + _pullable.GetHashCode();
            hashCode = hashCode * -1521134295 + IsSelected.GetHashCode();
            hashCode = hashCode * -1521134295 + _startX.GetHashCode();
            hashCode = hashCode * -1521134295 + _startY.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishX.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishY.GetHashCode();
            hashCode = hashCode * -1521134295 + Pullable.GetHashCode();
            hashCode = hashCode * -1521134295 + _pointsAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<TwoDimensionalPoint>>.Default.GetHashCode(_points);
            return hashCode;
        }
        public override void AddCoordinates(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Optimize()
        {
            throw new NotImplementedException();
        }
    }
}