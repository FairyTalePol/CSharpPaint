
using FinalPaint.Interfaces_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace FinalPaint.Classes
{
    public class Curve : Figure
    {
        [JsonProperty]
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

        public Curve(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            
            points = new List<TwoDimensionalPoint>();
            points.Add(new TwoDimensionalPoint(startX, startY));
        }
        [JsonConstructor]
        public Curve(List<TwoDimensionalPoint>list, bool pullable, bool isselected, int startx, int starty, int endx, int endy)
        {
            points = list;
            _pullable = pullable;
            IsSelected = isselected;
            _startX = startx;
            _startY = _startY;
            _finishX = endx;
            _finishX = endy;
        }


        public override void AddCoordinates(int x, int y)
        {
            foreach (var point in points)
            {
                point.X += x;
                point.Y += y;
            }
            _finishX += x;
            _finishY += y;
        }

        public override object Clone()
        {
            Curve res = new Curve(_startX, _startY);
            res.points.RemoveAt(0);
            res._finishX = _finishX;
            res._finishY = _finishY;
            res._myGraphics = _myGraphics;
            res._pullable = _pullable;
            res.IsSelected = IsSelected;
            foreach(var point in points)
            {
                res.points.Add(new TwoDimensionalPoint(point.X, point.Y));
            }
            return res;
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

        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;
            foreach (var point in points)
            {
                if (Math.Abs(x - point.X) < error && Math.Abs(y - point.Y) < error)
                {
                    res = true;
                }
            }
            return res;
        }

        public override void Optimize()
        {
           
        }
    }
}
