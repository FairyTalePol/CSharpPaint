﻿using FinalPaint.Classes;
using System.Collections.Generic;

namespace FinalPaint.Interfaces_
{
    public interface IMyGraphics
    {
        object Load(object img);
        void Save();
        void BackupPen();
        void RestorePen();
        bool IsCurrentSurfaceTemporary();

        void ClearSurface();
        void DrawEllipse(int startX, int startY, int finishX, int finishY);
        void DrawRectangle(int startX, int startY, int finishX, int finishY);
        void DrawRoundedRectangle(int startX, int startY, int finishX, int finishY);

        void DrawPoint(int startX, int startY, int finishX, int finishY);

        void DrawCurve(List<TwoDimensionalPoint> points);

        void DrawPolygon(List<TwoDimensionalPoint> list);
        void DrawLine(int startX, int startY, int finishX, int finishY);
        Figure FigureFromFWP(FigureWithParametrs fwp);
        float GetCurrentPenSize();
        string GetCurrentPenColor();

        string SaveServer(PictureType format);

    }
}
