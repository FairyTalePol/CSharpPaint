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
       
        protected Graphics _g { get; set; }
        protected Pen _p { get; set; }
        protected Point _start { get; set; }
        public abstract void Draw(Graphics g, Point current);
            
    }
}
