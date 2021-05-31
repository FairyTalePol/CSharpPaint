using FinalPaint.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    abstract class Figure
    {
        protected Interfaces_.IMyGraphics _myGraphics;

        protected bool _pullable;

        protected int _startX { get; set; }
        protected int _startY { get; set; }
        public bool Pullable
        {
            get
            {
                return _pullable;
            }
        }

        public abstract void Draw(int finishX, int finishY);

    }
}
