﻿
using FinalPaint.Classes;
using System.Collections.Generic;

namespace FinalPaint.DependencyInversion
{
    interface IMyGraphics
    {
        void DrawEllipse(int startX, int startY, int finishX, int finishY);
        void DrawRectangle(int startX, int startY, int finishX, int finishY);

        void DrawPoint(int startX, int startY, int finishX, int finishY);

        void DrawCurve(int startX, int startY, int finishX, int finishY);

        void DrawPolygon(List<TwoDimensionalPoint> list);
        void DrawLine(int startX, int startY, int finishX, int finishY);
    }
}
