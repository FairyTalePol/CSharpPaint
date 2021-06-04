using FinalPaint.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Interfaces_
{
    public interface IBuisnessLogic
    {
        void SetCurrentMode(EButtonDrawingType mode);
        void Initialize(IMyGraphics myGraphicsUI);

        bool ValidatePolygon(string algles, out string message);
        void DrawFigure(int x, int y);
        void SelectFigure(int x, int y, int polygonAngles = -1);
        void Load(Action act);
        void Save(Action act);

        void Undo();
        void Redo();


    }
}

