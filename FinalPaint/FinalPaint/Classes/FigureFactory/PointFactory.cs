using FinalPaint.Interfaces_;

namespace FinalPaint.Classes.FigureFactory
{
    class PointFactory : FigureFactory
    {
        public PointFactory(int startX, int startY, IMyGraphics mg) : base(startX, startY, mg)
        {

        }
        public override Figure Create()
        {
            return new CustomPoint(StartX, StartY, _myGraphics);
        }

    }
}
