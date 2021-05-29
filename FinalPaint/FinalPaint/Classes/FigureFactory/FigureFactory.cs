using FinalPaint.DependencyInversion;


namespace FinalPaint.Classes.FigureFactory
{
    abstract class FigureFactory
    {
        public int StartX { get; set; }
        public int StartY { get; set; }

        protected IMyGraphics _myGraphics;

        public FigureFactory(int startX, int startY, IMyGraphics myGraphics)
        {
            StartX = startX;
            StartY = startY;
            _myGraphics = myGraphics;
        }

        abstract public Figure Create();

    }
}
