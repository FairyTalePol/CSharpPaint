using FinalPaint.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;

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
        Action action;
        public Bitmap CurrentBitmap { get; set; }

        public void SwitchBitmap()
        {
            if (CurrentBitmap == bitmap)
            {
                CurrentBitmap = bitmapTemp;
                Console.WriteLine("temp bitmap set");
            }
            else
            {
                CurrentBitmap = bitmap;
                Console.WriteLine("main bitmap set");
            }
        }
        public Bitmap GetBitmap()
        {
            return CurrentBitmap;
        }

        //public Bitmap GetBitmapTemp()
        //{
        //    return bitmapTemp;
        //}

        private MyGraphics(int width, int height, Action act)
        {
            pen= Config.pen;
            penWidth = Config.penWidth;
            bitmap = new Bitmap(width, height);
            bitmapTemp = new Bitmap(width, height);
            _graphics = Graphics.FromImage(bitmap);
            _graphicsTemp = Graphics.FromImage(bitmapTemp);
            action = act;
            CurrentBitmap = bitmap;
        }


        public static MyGraphics Create(int width, int height, Action act)
        {
            _width = width;
            _height = height;
            if(_myGraphics==null)
            {
                _myGraphics = new MyGraphics(width, height, act);
            }
            return _myGraphics;
        }


        public void DrawEllipse(int startX, int startY, int finishX, int finishY)
        {

            if (CurrentBitmap == bitmap)
            {
                _graphics.DrawEllipse(pen, startX, startY, finishX, finishY);
                Console.WriteLine("drawing on main");
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphicsTemp.DrawEllipse(pen, startX, startY, finishX, finishY);
                Console.WriteLine("drawing on temp");
            }
  
            action();
            //вызовем делегата
        }



        public void DrawRectangle(int startX, int startY, int finishX, int finishY)
        {
            _graphicsTemp = Graphics.FromImage(bitmapTemp);
            _graphicsTemp.Clear(Color.White);
            _graphicsTemp.DrawImage(bitmap, 0, 0);
            _graphicsTemp.DrawRectangle(pen, startX, startY, finishX, finishY);
            action();
            //вызовем делегата
        }

        public void DrawLine(int startX, int startY, int finishX, int finishY)
        {
            _graphicsTemp = Graphics.FromImage(bitmapTemp);
            _graphicsTemp.Clear(Color.White);
            _graphicsTemp.DrawImage(bitmap, 0, 0);
            _graphicsTemp.DrawLine(pen, startX, startY, finishX, finishY);
            action();
            //вызовем делегата
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

        //public void DrawPolygon(int startX, int startY, int finishX, int finishY, int edges)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
