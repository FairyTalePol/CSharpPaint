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
        protected bool _pullable;
        protected Pen _p { get; set; }
        protected Point _start { get; set; }
        public bool Pullable { 
            get {
                return _pullable;
            }
        }
        public abstract void Draw(Graphics g, Point current);
            
    }
}
