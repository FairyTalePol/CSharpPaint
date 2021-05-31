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
    class Line : Figure
    {
        public Line(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }


        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawLine(_startX, _startY, finishX, finishY);
        }
    }
}
