using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using Newtonsoft.Json;

namespace FinalPaint.Classes
{
    public class Polygon : Figure
    {
        [JsonProperty]
        private int _pointsAmount;

        [JsonProperty]
        private List<TwoDimensionalPoint> _points = new List<TwoDimensionalPoint>();
    
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
     
                temp.X = (int)(_r * Math.Cos(angle)) + _startX;
            
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

        public override void AddCoordinates(int x, int y)
        {
            _startX += x;
            _startY += y;
            _finishX += x;
            _finishY += y;
        }

        public override object Clone()
        {
            Polygon res = new Polygon(_startX, _startY,_pointsAmount);
           
            res._finishX = _finishX;
            res._finishY = _finishY;
            res._myGraphics = _myGraphics;
            res._pullable = _pullable;
            res.IsSelected = IsSelected;
            foreach (var point in _points)
            {
                res._points.Add(new TwoDimensionalPoint(point.X, point.Y));
            }
            return res;
        }

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