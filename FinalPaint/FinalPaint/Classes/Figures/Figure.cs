using FinalPaint.Classes.Interfaces;
using System;
using System.Drawing;

namespace FinalPaint.Classes
{
    abstract class Figure : IMovable, ICloneable
    {
        protected bool _pullable;
        protected Pen _p;
        protected Point _start;

        protected Point _end;

        public Point StartPoint
        {
            get
            {
                return _start;
            }
            set
            {
                _start = value;
            }
        }
        public Point EndPoint
        {
            get
            {
                return _end;
            }
            set
            {
                _end = value;
            }
        }
        public bool Pullable { 
            get {
                return _pullable;
            }
            set
            {
                _pullable = value;
            }
        }

        public abstract object Clone();


        public abstract void Draw(Graphics g, Point current);

        public abstract void Move(int moveX, int moveY);
    }
}
