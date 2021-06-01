namespace FinalPaint.Classes
{
    public class FigureWithParametrs
    {
        private Figure _figure;
        private string _penColor;
        private int _penSize;
        
        private void Figure(Figure figure, string penColor, int penSize)
        {
            _figure = figure;
            _penColor = penColor;
            _penSize = penSize;
        }
    }
}
