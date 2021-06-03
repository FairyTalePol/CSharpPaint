using System;

namespace FinalPaint.Classes
{
    public class FigureWithParametrs : ICloneable
    {
        private  Figure _figure;
        private string _penColor;
        private float _penSize;


        public FigureWithParametrs(Figure figure, string penColor, float penSize)
        {
            _figure = figure;
            _penColor = penColor;
            _penSize = penSize;
        }
        public Figure GetFigure()
        {
            return _figure;
        }
        public string GetPenColor()
        {
            return _penColor;
        }
        public float GetPenSize()
        {
            return _penSize;
        }

        public object Clone()
        {
            return new FigureWithParametrs(_figure, (string) _penColor.Clone(), _penSize);
        }
    }
}
