//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing.Drawing2D;

//namespace FinalPaint.Classes
//{
//    class Polygon : Figure
//    {
//        private int _pointsAmount;
//        private List<Point> _points = new List<Point>();

//        public Polygon(int x, int y, int pointsAmount)
//        {
//            _startX = x;
//            _startY = y;
//            _pointsAmount = pointsAmount;
//            _pullable = true;
//        }

//        private void CreatePolygon(int currentX, int currentY)
//        {
//            double r = (currentX - _startX) / 2 > (currentY - _startY) / 2 ? (currentX - _startX) / 2 : (currentY - _startY) / 2;
//            _points.Clear();
//            Point temp = new Point();
//            for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / _pointsAmount)
//            {
//                int width = currentX - _startX;
//                temp.X = (int)(r * Math.Cos(angle)) + _startX;
//                int height = currentY - _startY;
//                temp.Y = ((int)(r * Math.Sin(angle)) + _startY);
//                _points.Add(new Point((int)r + temp.X, (int)r + temp.Y));
//            }
//        }

//        public override void Draw(int finishX, int finishY)
//        {
//            CreatePolygon(finishX, finishY);
//            _myGraphics.DrawPolygon(_points.ToArray());
//        }

//    }
//}