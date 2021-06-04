using FinalPaint.Interfaces_;

namespace FinalPaint.Classes.FigureFactory
{
    class CurveFactory : FigureFactory
    {
        public CurveFactory(int startX, int startY, IMyGraphics mg) : base(startX, startY, mg)
        {

        }
        public override Figure Create()
        {
            return new Curve(StartX, StartY, _myGraphics);
        }
    }
}
