﻿using FinalPaint.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Ellipse : Figure
    {
      public Ellipse(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
           
        }
        

        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawEllipse(_startX, _startY, finishX, finishY);
        }
    }
}
