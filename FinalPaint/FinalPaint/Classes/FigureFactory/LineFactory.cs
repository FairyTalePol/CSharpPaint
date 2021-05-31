﻿using FinalPaint.DependencyInversion;

namespace FinalPaint.Classes.FigureFactory
{
    class LineFactory : FigureFactory
    {
        public LineFactory(int startX, int startY, IMyGraphics mg) : base(startX, startY, mg)
        {

        }
        public override Figure Create()
        {
            return new Line(StartX, StartY, _myGraphics);
        }

    }
}
