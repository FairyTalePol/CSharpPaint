using FinalPaint.Classes;
using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

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
        RastrSaveHelper saveLoadHelper;
        public Bitmap CurrentBitmap { get; set; }
        public bool flag;





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
                _graphics.DrawEllipse(pen, startX, startY, finishX-startX, finishY-startY);
                flag = true;
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphicsTemp.DrawEllipse(pen, startX, startY, finishX - startX, finishY - startY);
            }

            action();
            //вызовем делегата
        }
        public bool GetFlag()
        {
            bool tmp = flag;
            flag = false;
            return tmp;
        }

        public void DrawCurve(int startX, int startY, int finishX, int finishY)
        {
            _graphics.DrawLine(pen, startX, startY, finishX , finishY);
                      
            action();
        }

        public void DrawPolygon(List<TwoDimensionalPoint> points)
        {
            List<Point> adaptedPoints = new List<Point>();

            foreach (var point in points)
            {
                adaptedPoints.Add(new Point(point.X, point.Y));
            }

            if (CurrentBitmap == bitmap)
            {
                _graphics.DrawPolygon(pen, adaptedPoints.ToArray());
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphicsTemp.DrawPolygon(pen, adaptedPoints.ToArray());
            }
            action();

        }

        public void DrawPoint(int startX, int startY, int finishX, int finishY)
        {

            if (CurrentBitmap == bitmap)
            {
                _graphics.FillEllipse(new SolidBrush(pen.Color), startX-pen.Width/2, startY-pen.Width / 2, pen.Width, pen.Width);
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphics.FillEllipse(new SolidBrush(pen.Color), startX - pen.Width / 2, startY - pen.Width / 2, pen.Width, pen.Width);
            }

            action();
            //вызовем делегата
        }



        public void DrawRectangle(int startX, int startY, int finishX, int finishY)
        {
            if (CurrentBitmap == bitmap)
            {
                _graphics.DrawRectangle(pen, startX, startY, finishX, finishY);
                
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphicsTemp.DrawRectangle(pen, startX, startY, finishX , finishY );
            }

            action();
        }

        public void DrawRoundedRectangle(int startX, int startY, int finishX, int finishY)
        {           
            int radius = 10;

            RectangleF rect = new RectangleF(startX, startY, finishX, finishY);
            GraphicsPath path = GetRoundRectangle(rect, radius);

            if (CurrentBitmap == bitmap)
            {               
                _graphics.DrawPath(pen, path);               
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphicsTemp.DrawPath(pen, path);
            }

            action();
        }
        private GraphicsPath GetRoundRectangle(RectangleF baseRect, float radius)
        {
            if (radius <= 0.0F)
            {
                GraphicsPath mPath = new GraphicsPath();
                mPath.AddRectangle(baseRect);
                mPath.CloseFigure();
                return mPath;
            }

            if (radius >= (Math.Min(baseRect.Width, baseRect.Height)) / 2.0)
                return GetCapsule(baseRect);

            float diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(baseRect.Location, sizeF);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arc, 180, 90);

            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private GraphicsPath GetCapsule(RectangleF baseRect)
        {
            float diameter;
            RectangleF arc;
            GraphicsPath path = new GraphicsPath();
            try
            {
                if (baseRect.Width > baseRect.Height)
                {
                    diameter = baseRect.Height;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 90, 180);
                    arc.X = baseRect.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if (baseRect.Width < baseRect.Height)
                {
                    diameter = baseRect.Width;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 180, 180);
                    arc.Y = baseRect.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else
                {
                    path.AddEllipse(baseRect);
                }
            }
            catch (Exception ex)
            {
                path.AddEllipse(baseRect);
            }
            finally
            {
                path.CloseFigure();
            }
            return path;
        }

        public void DrawLine(int startX, int startY, int finishX, int finishY)
        {
            if (CurrentBitmap == bitmap)
            {
                _graphics.DrawLine(pen, startX, startY, finishX, finishY);
            }
            else
            {
                _graphicsTemp = Graphics.FromImage(bitmapTemp);
                _graphicsTemp.Clear(Color.White);
                _graphicsTemp.DrawImage(bitmap, 0, 0);
                _graphicsTemp.DrawLine(pen, startX, startY, finishX, finishY);
            }

            action();
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

        public Color StringToColor(string color)
        {
            Color newColor = Color.FromName(color);
            return newColor;
        }

        public string ColorToString(Color color)
        {
            string strColor = color.Name;
            return strColor;
        }
        public float GetCurrentPenSize()
        {
            float tmp = pen.Width;
            return tmp;
        }
        public string GetCurrentPenColor()
        {
            return ColorToString(pen.Color);
        }

        public void FigureFromFWP(FigureWithParametrs fwp)
        {
            
            Figure figure = fwp.GetFigure();
            Pen tmpPen = new Pen(pen.Color, pen.Width);
            pen.Color = StringToColor(fwp.GetPenColor());
            pen.Width = fwp.GetPenSize();
            figure.Draw(figure._finishX, figure._finishY);
            pen.Width = tmpPen.Width;
            pen.Color = tmpPen.Color;

        }

        public void ClearSurface()
        {
            Color c = Color.White;
            _graphics.Clear(c);
            _graphicsTemp.Clear(c);
            _graphicsTemp.DrawImage(bitmap, 0, 0);

        }

        public void Save()
        {
            saveLoadHelper = RastrSaveHelper.Create();
            saveLoadHelper.Save(bitmap);
        }

        public object Load()
        {
            saveLoadHelper = RastrSaveHelper.Create();
            Image img = saveLoadHelper.Load();
            _graphics.DrawImage(img, 0, 0);
            CurrentBitmap = bitmap;
            return img;
        }

        //public void DrawPolygon(int startX, int startY, int finishX, int finishY, int edges)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
