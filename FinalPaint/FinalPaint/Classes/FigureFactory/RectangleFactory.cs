using FinalPaint.Interfaces_;


namespace FinalPaint.Classes.FigureFactory
{
    class RectangleFactory : FigureFactory
    {
        public RectangleFactory(int startX, int startY, IMyGraphics mg) : base(startX, startY, mg)
        {

        }
        public override Figure Create()
        {
            return new Rectangle(StartX, StartY, _myGraphics);
        }

    }
}

