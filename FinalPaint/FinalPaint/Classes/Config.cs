using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    public static class Config
    {
        public static Dictionary<int, int> penWidth = new Dictionary<int, int>();
        public static Pen pen = new Pen(Color.Black, 3);
        public static SolidBrush brush = new SolidBrush(Color.Black);
        public static int dropDownPenWidth = 0;
        public static EButtons EButtons = EButtons.Curve;
        static Config()
        {
            penWidth.Add(0, 1);
            penWidth.Add(1, 5);
            penWidth.Add(2, 10);
            penWidth.Add(3, 20);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }

    }
}