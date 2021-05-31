using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    public class TwoDimensionalPoint
    { 
        public int X { get; set; }
        public int Y { get; set; }

        public TwoDimensionalPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public TwoDimensionalPoint()
        {
            X = 0;
            Y = 0;
        }
    }
}
