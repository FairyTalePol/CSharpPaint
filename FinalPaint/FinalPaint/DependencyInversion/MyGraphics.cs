using FinalPaint.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.DependencyInversion
{
    class MyGraphics : IMyGraphics
    {
        private static MyGraphics _myGraphics;
        Graphics _graphics;
        Graphics _graphicsTemp;
        public Pen pen;
        public Bitmap bitmap;
        public Bitmap bitmapTemp;
        static int _width;
        static int _height;
        public Dictionary<int, int> penWidth;


        private MyGraphics(int width, int height)
        {
            pen= Config.pen;
            penWidth = Config.penWidth;
            bitmap = new Bitmap(width, height);
            bitmapTemp = new Bitmap(width, height);
            _graphics = Graphics.FromImage(bitmap);
            _graphicsTemp = Graphics.FromImage(bitmapTemp);
        }


        public static MyGraphics Create(int width, int height)
        {
            _width = width;
            _height = height;
            if(_myGraphics!=null)
            {
                _myGraphics = new MyGraphics(width, height);
            }
            return new MyGraphics(_width, _height);
        }


        public void DrawEllipse(int startX, int startY, int finishX, int finishY)
        {
            _graphicsTemp.DrawEllipse(pen, startX, startY, finishX, finishY);

        }

        public void SetPenWidth(int width)
        {
            pen.Width = width;

        }

       public void ClearSurface(Color c)
        {
            _graphics.Clear(c);
            _graphicsTemp.Clear(c);
            _graphicsTemp.DrawImage(bitmap, 0, 0);

        }
    }
}
