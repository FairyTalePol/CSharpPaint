
using System.Drawing;
using System.Windows.Forms;

namespace FinalPaint.DependencyInversion
{
    interface IMyGraphics
    {
        Bitmap GetBitmap();

        void SetSavedBitmap(ref OpenFileDialog f);
        void DrawEllipse(int startX, int startY, int finishX, int finishY);
        void DrawRectangle(int startX, int startY, int finishX, int finishY);
        //void DrawPolygon(int startX, int startY, int finishX, int finishY, int edges);
        void DrawLine(int startX, int startY, int finishX, int finishY);
    }
}
