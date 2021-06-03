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
    class Curve : Figure
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

        public override void Draw(int finishX, int finishY)
        {
            points.Add(new TwoDimensionalPoint(finishX, finishY));
            _myGraphics.DrawCurve(points);
            _startX = finishX;
            _startY = finishY;

        }

        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            return false;
        }
    }
}
