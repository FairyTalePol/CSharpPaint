using FinalPaint.DependencyInversion;

namespace FinalPaint.Classes.FigureFactory
{
    class EllipseFactory : FigureFactory
    {
        public EllipseFactory(int startX, int startY, IMyGraphics mg) : base(startX, startY, mg)
        {

        }
        public override Figure Create()
        {
            return new Ellipse(StartX, StartY, _myGraphics);
        }
    }
}
