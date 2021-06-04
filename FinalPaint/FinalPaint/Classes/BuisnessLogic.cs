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
        Action disableUndoRedo;
        public bool EnableUndoRedo = false;


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

        public void SetDisableUndoRedo(Action act)
        {
            disableUndoRedo = act;
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
                    message = "Polygon points set to " + Config.DefaultAngelsForPolegon;
                    success = false;
                }

            }
            else
            {
                message = "Polygon points set to " + Config.DefaultAngelsForPolegon;
                success = false;
            }
            return success;

        }

        public void MoveSelectedFigure(int x, int y)
        {
            List<FigureWithParametrs> figures = storage.GetCurrentList();


            List<FigureWithParametrs> temp = new List<FigureWithParametrs>();
            foreach (var fwp in figures)
            {
                temp.Add((FigureWithParametrs)fwp.Clone());
            }



            foreach (var figure in temp)
            {
                if (figure.GetFigure().IsSelected)
                {
                    figure.FigureAddCoordinates(x, y);
                }     
            }

            storage.AddCurrent(temp);

            myGraphics.ClearSurface();
            foreach (var figure in temp)
            {
                Figure f = myGraphics.FigureFromFWP(figure);
                f.Draw(f._finishX, f._finishY);
                myGraphics.RestorePen();
            }
        }

        public void SetSelection(int x, int y)
        {
             List<FigureWithParametrs> figures = storage.GetCurrentList();
            foreach (var figure in figures)
            {
                figure.SetFigureSelection(false);
            }
            figures.Reverse();
            foreach (var figure in figures)
            {
                if (figure.GetFigure().IsPointInPoly(x,y,Convert.ToInt32(figure.GetPenSize()/2)))
                {
                    figure.SetFigureSelection(true);
                    break;
                }
                else
                {
                    figure.SetFigureSelection(false);
                }
            }
            figures.Reverse();

        }

        public void Clear()
        {
            List<FigureWithParametrs> clean = new List<FigureWithParametrs>();
            storage.AddCurrent(clean);
           
        }

        public void DrawFigure(int x, int y)
        {
            if (_currentFigure != null)
            {
                _currentFigure._finishX = x;
                _currentFigure._finishY = y;
                _currentFigure.Draw(x, y);
                if (!myGraphics.IsCurrentSurfaceTemporary())
                {
                    storage.AddFigure(_currentFigure, myGraphics.GetCurrentPenSize(), myGraphics.GetCurrentPenColor());
                }
            }
        }

        //public void FinishFigure(Point p, ref Image img)
        //{
        //    if (_currentFigure != null)
        //    {
        //        _currentFigure.Draw(p.X, p.Y);

        //    }
        //}
        public void SelectFigure(int x, int y, int polygonAngles = -1)
        {
            FigureFactory.FigureFactory factory;
            switch (_currentMode)
            {
                case EButtonDrawingType.Line:
                    factory = new LineFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Rectangle:
                    factory = new RectangleFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Ellipse:
                    factory = new EllipseFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Curve:
                    factory = new CurveFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Point:
                    factory = new PointFactory(x, y, myGraphics);
                    break;
                case EButtonDrawingType.Polygon6:
                    factory = new PolygonFactory(x, y, myGraphics, 6);
                    break;
                case EButtonDrawingType.Polygon:
                    factory = new PolygonFactory(x, y, myGraphics, polygonAngles);
                    break;
                case EButtonDrawingType.RoundedRectangle:
                    factory = new RoundedRectangleFactory(x, y, myGraphics);
                    break;
                default:
                    factory = new LineFactory(x, y, myGraphics);
                    break;
            }
            _currentFigure = factory.Create();
        }


        public static BuisnessLogic Create()
        {
            if (_bl == null)
            {
                _bl = new BuisnessLogic();
            }
            return _bl;
        }
      
        public void Load(Action act)
        {
            try
            {
                saveLoad = RastrSaveHelper.Create();
                object res = saveLoad.Load();
                _currentMode = EButtonDrawingType.Selection;
                Clear();
                myGraphics.ClearSurface();
                if (res is string)
                {
                    
                    List<FigureWithParametrs> list = MyJsonSerializer.Deserilize_((string)res);
                    storage.Deserialize(list);
                    foreach (var figure in storage.GetCurrentList())
                    {
                        Figure f = myGraphics.FigureFromFWP(figure);
                        f.Draw(f._finishX, f._finishY);
                        myGraphics.RestorePen();
                    }
                    EnableUndoRedo = true;
                    disableUndoRedo();
                }
                else
                {
                  
                    myGraphics.Load(res);
                    storage.Deserialize(new List<FigureWithParametrs>());
                    EnableUndoRedo = false;
                    disableUndoRedo();


                }
                act();
            }
            catch (ArgumentNullException e)
            {

            }
           
           
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
            storage.ClearCurrentList();
            myGraphics.ClearSurface();
            foreach (var figure in figures)
            {
                Figure f = myGraphics.FigureFromFWP(figure);
                f.Draw(f._finishX, f._finishY);
                myGraphics.RestorePen();
            }

        }
        public void Redo()
        {
            storage.Redo();
            List<FigureWithParametrs> figures = storage.GetCurrentList();
            //storage.ClearCurrentList();
            myGraphics.ClearSurface();
            foreach (var figure in figures)
            {
                Figure f = myGraphics.FigureFromFWP(figure);
                f.Draw(f._finishX, f._finishY);
            }

        }
        
        

    }
}
