using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class RoundedRectangle : Figure
    {
        public RoundedRectangle(Point start, Pen pen)
        {
            _start = start;
            _p = pen;
            _pullable = true;
        }
       
        public override void Draw(Graphics g, Point current)
        {
            int radius = 10;
            _g = g;

            int width = current.X - _start.X < 0 ? _start.X - current.X : current.X - _start.X;
            int height = current.Y - _start.Y < 0 ? _start.Y - current.Y : current.Y - _start.Y;

            if (_start.X < current.X && _start.Y < current.Y)
            {
                RectangleF rect = new RectangleF(_start.X, _start.Y, width, height);
                GraphicsPath path = GetRoundRectangle(rect, radius);
                _g.DrawPath(_p, path);
            }
            else if (_start.X > current.X && _start.Y > current.Y)
            {
                RectangleF rect = new RectangleF(current.X, current.Y, width, height);
                GraphicsPath path = GetRoundRectangle(rect, radius);
                _g.DrawPath(_p, path);
            }
            else if (_start.X < current.X && _start.Y > current.Y)
            {
                RectangleF rect = new RectangleF(_start.X, current.Y, width, height);
                GraphicsPath path = GetRoundRectangle(rect, radius);
                _g.DrawPath(_p, path);
            }
            else if (_start.X > current.X && _start.Y < current.Y)
            {
                RectangleF rect = new RectangleF(current.X, _start.Y, width, height);
                GraphicsPath path = GetRoundRectangle(rect, radius);
                _g.DrawPath(_p, path);
            }
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
    }
}
