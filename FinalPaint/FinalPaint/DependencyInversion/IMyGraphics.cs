using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.DependencyInversion
{
    interface IMyGraphics
    {
        void DrawEllipse(int startX, int startY, int finishX, int finishY);
    }
}
