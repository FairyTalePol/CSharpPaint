using FinalPaint.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Interfaces_
{
    public interface IStorage
    {
        void AddFigure(Figure figure, float penWidth, string color);

        void Undo();

        void Redo();

        List<FigureWithParametrs> GetCurrentList();
    }
}
