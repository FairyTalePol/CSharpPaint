using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace FinalPaint.Classes
{
    class Polygon : Figure
    {
        private int _pointsAmount;
        private int _length;
        private List<Point> _points = new List<Point>();


        public Polygon(Point start, Pen pen, int pointsAmount)
        {
            _start = start;
            _p = pen;
            _pointsAmount = pointsAmount;
            //_length = length;

        }

        public override void Draw(Graphics g, Point current)
        {
            double R = (_start.X+current.X+_start.Y+current.Y)/ (2 * Math.Sin(Math.PI / _pointsAmount));

          //double R = _length / (2 * Math.Sin(Math.PI / _pointsAmount));
          
            for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / _pointsAmount) //цикл по углу
            {
                current.X = (int)(R * Math.Cos(angle)) + _start.X; //расчет координаты x точки
                current.Y = (int)(R * Math.Sin(angle)) + _start.Y; //расчет координаты y точки
                _points.Add(new Point((int)R + current.X, (int)R + current.Y)); //добавление точки в список точек

            }
           

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawPolygon(_p, _points.ToArray());


        }
    }
}