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
        private List<Point> _points = new List<Point>();


        public Polygon(Point start, Pen pen, int pointsAmount)
        {
            _start = start;
            _p = pen;
            _pointsAmount = pointsAmount;
            _pullable = true;
        }

        private void CreatePolygon(Point current)
        {
            double r = (current.X - _start.X) / 2 > (current.Y - _start.Y) / 2 ? (current.X - _start.X) / 2 : (current.Y - _start.Y) / 2;
            _points.Clear();
            Point temp = new Point();
            for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / _pointsAmount)
            {
                int width = current.X - _start.X;
                temp.X = (int)(r * Math.Cos(angle)) + _start.X;
                int height = current.Y - _start.Y;
                temp.Y = ((int)(r * Math.Sin(angle)) + _start.Y);
                _points.Add(new Point((int)r + temp.X, (int)r + temp.Y));
            }
        }

        public override void Draw(Graphics g, Point current)
        {
            _g = g;
            CreatePolygon(current);
        //    double R = (current.X - _start.X)/2 > (current.Y - _start.Y) / 2? (current.X - _start.X) / 2: (current.Y - _start.Y) / 2;          

        //    _points.Clear();
        //    Point temp = new Point();
        //    for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / _pointsAmount)
        //    {
        //        int width = current.X - _start.X;
        //        temp.X = (int)(R * Math.Cos(angle))+_start.X; 
        //        int height = current.Y - _start.Y;
        //        temp.Y = ((int)(R * Math.Sin(angle))+_start.Y); 

        ////        if (width > height)//если фигурю сплющило горизонтально
        ////        {
        ////            temp.X = (int)(R * Math.Cos(angle)) + _start.X;
        ////            temp.Y = (int)((R * Math.Sin(angle))*( (double)height / (double)width)+ _start.Y);
        ////}
        ////        else//если фигуру сплющило вертикально
        ////        {
        ////            temp.Y = ((int)(R * Math.Sin(angle)) + _start.Y);
        ////            temp.X = (int)((R * Math.Cos(angle))* ((double)width / (double)height) + _start.X);
        ////        }
        //        _points.Add(new Point((int)R+ temp.X, (int)R+ temp.Y));        
        //    }
            _g.SmoothingMode = SmoothingMode.HighQuality;
            _g.DrawPolygon(_p, _points.ToArray());
        }
    }
}