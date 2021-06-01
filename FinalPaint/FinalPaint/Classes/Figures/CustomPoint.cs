

using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;

namespace FinalPaint.Classes
{
    class CustomPoint : Figure
    {
       
        public CustomPoint(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }
        
        public override void Draw(int finishX, int finishY)
        {
            _myGraphics.DrawPoint(_startX , _startY , finishX, finishY);
        }


    }
}
