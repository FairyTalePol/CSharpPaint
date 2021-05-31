using FinalPaint.DependencyInversion;
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
        public Curve(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = false;
            _myGraphics = mg;
        }

        public override void Draw(int finishX, int finishY)
        {

            _myGraphics.DrawCurve(_startX, _startY, finishX, finishY);
            _startX = finishX;
            _startY = finishY;

        }
    }
}
