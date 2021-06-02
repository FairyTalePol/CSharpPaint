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

    }
}