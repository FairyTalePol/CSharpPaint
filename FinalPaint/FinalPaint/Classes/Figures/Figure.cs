using FinalPaint.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    abstract public class Figure
    {
        public Interfaces_.IMyGraphics _myGraphics;

        protected bool _pullable;

        public bool IsSelected { get; set; }

        public int _startX { get; set; }
        public int _startY { get; set; }

        public int _finishX { get; set; }
        public int _finishY { get; set; }
        public bool Pullable
        {
            get
            {
                return _pullable;
            }
        }

        public abstract void Draw(int finishX, int finishY);

        public abstract bool IsPointInPoly(int x, int y);

    }
}
