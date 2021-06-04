using FinalPaint.Interfaces_;


namespace FinalPaint.Classes.FigureFactory
{
    class PolygonFactory : FigureFactory
    {
        public int Corners { get; set; }
        public PolygonFactory(int startX, int startY, IMyGraphics mg, int corners) : base(startX, startY, mg)
        {
            Corners = corners;
        }
        public override Figure Create()
        {
            return new Polygon(StartX, StartY, Corners,_myGraphics);
        }

    }
}

