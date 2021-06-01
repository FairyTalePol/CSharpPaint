using FinalPaint.Classes.FigureFactory;
using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;

namespace FinalPaint.Classes
{
    class BuisnessLogic
    {
        private static BuisnessLogic _bl;
        public IMyGraphics myGraphics;
        public EButtonDrawingType _currentMode;
        public Storage storage;
        //public Bitmap _bitmap;
        //public Bitmap _bitmapTemp;
        //public Pen _pen;
        //public Graphics _graphics;
        //public Graphics _graphicsTemp;
        public Figure _currentFigure;
        //public Dictionary<int, int> penWidth;
        RastrSaveHelper saveLoad;
        
      
        //S

        private BuisnessLogic()
        {
            Config.Configure();
            saveLoad = RastrSaveHelper.Create();
            storage = Storage.Create();
          //  penWidth = Config.penWidth;
        }

        public void SetCurrentMode(EButtonDrawingType mode)
        {
            _currentMode = mode;
        }

        public void Initialize(IMyGraphics myGraphicsUI)
        {
            //_bitmap = new Bitmap(bitmapWidth, bitmapHeight);
            //_bitmapTemp = new Bitmap(bitmapWidth, bitmapHeight);
            //_pen = Config.pen;
            //_graphics = Graphics.FromImage(_bitmap);
            //_graphicsTemp = Graphics.FromImage(_bitmapTemp);
            _currentMode = Config.eButtonDrawingType;
            myGraphics = myGraphicsUI;
           // penWidth = Config.penWidth;
        }

        //public void SetPenWidth(int width)
        //{
        //    _pen.Width = width;

        //}

        //public void ClearSurface(Color c)
        //{
        //    _graphics.Clear(c);
        //    _graphicsTemp.Clear(c);
        //    _graphicsTemp.DrawImage(_bitmap, 0, 0);

        //}

        public bool ValidatePolygon(string algles, out string message)
        {
            message = "";
            bool success = true;
            if (int.TryParse(algles, out int pointsAmount))
            {
                if (pointsAmount < 2)
                {
                    message="Polygon points set to "+ Config.DefaultAngelsForPolegon;
                    success= false;
                }
                
            }
            else
            {
                message="Polygon points set to "+ Config.DefaultAngelsForPolegon;
                success = false;
            }
            return success;

        }

        public void DrawFigure(int x, int y)
        {
            if (_currentFigure != null)
            {

                 _currentFigure.Draw(x,y);
                storage.AddFigure(_currentFigure, myGraphics.GetCurrentPenSize(), myGraphics.GetCurrentPenColor());
            }
        }

        //public void FinishFigure(Point p, ref Image img)
        //{
        //    if (_currentFigure != null)
        //    {
        //        _currentFigure.Draw(p.X, p.Y);
               
        //    }
        //}
        public void SelectFigure(int x, int y, int polygonAngles=-1)
        {
            FigureFactory.FigureFactory factory;
            switch (_currentMode)
            {
                case EButtonDrawingType.Line:
                    factory = new LineFactory(x,y, myGraphics);
                    break;
                case EButtonDrawingType.Rectangle:
                    factory = new RectangleFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Ellipse:
                    factory = new EllipseFactory(x,y, myGraphics);
                    break;
                case EButtonDrawingType.Curve:
                    factory = new CurveFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Point:
                    factory = new PointFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Polygon6:
                    factory = new PolygonFactory(x,y, myGraphics, 6);
                    break;
                case EButtonDrawingType.Polygon:
                    factory = new PolygonFactory(x, y, myGraphics, polygonAngles);
                    break;
                case EButtonDrawingType.RoundedRectangle:
                    factory = new RoundedRectangleFactory(x, y, myGraphics);
                    break;
                default:
                    factory = new LineFactory(x,y, myGraphics);
                    break;
            }
            _currentFigure = factory.Create();
        }


        public static BuisnessLogic Create()
        {
            if (_bl==null)
            {
                _bl = new BuisnessLogic();
            }
            return _bl;
        }

        public void Load(Action act)
        {
            saveLoad = RastrSaveHelper.Create();
            act();
        }
        public void Save(Action act)
        {
            saveLoad = RastrSaveHelper.Create();
            act();
        }
        
        public void Undo()
        {
            storage.Undo();
            List<FigureWithParametrs> figures = storage.GetCurrentList();
            myGraphics.ClearSurface();
            foreach(var figure in figures)
            {
                myGraphics.FigureFromFWP(figure);
            }

        }
        public void Redo()
        {
            storage.Redo();
            List<FigureWithParametrs> figures = storage.GetCurrentList();
            myGraphics.ClearSurface();
            foreach (var figure in figures)
            {
                myGraphics.FigureFromFWP(figure);
            }

        }
        

    }
}
