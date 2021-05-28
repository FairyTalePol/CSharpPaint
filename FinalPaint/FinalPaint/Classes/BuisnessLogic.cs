using FinalPaint.Classes.FigureFactory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPaint.Classes
{
    class BuisnessLogic
    {
        private static BuisnessLogic _bl;

        public EButtonDrawingType _currentMode;
        public Bitmap _bitmap;
        public Bitmap _bitmapTemp;
        public Pen _pen;
        public Graphics _graphics;
        public Graphics _graphicsTemp;
        public Figure _currentFigure;
        public Figure _selectedFigure;
        public Dictionary<int, int> penWidth;
        RastrSaveHelper saveLoad;
        Storage storage;
        
      
        //S

        private BuisnessLogic()
        {
            Config.Configure();
            storage = Storage.Create();
            saveLoad = RastrSaveHelper.Create();
            penWidth = Config.penWidth;
        }

        public void SetCurrentMode(EButtonDrawingType mode)
        {
            _currentMode = mode;
        }

        public void Innitialize(int bitmapWidth, int bitmapHeight)
        {
            _bitmap = new Bitmap(bitmapWidth, bitmapHeight);
            _bitmapTemp = new Bitmap(bitmapWidth, bitmapHeight);
            _pen = Config.pen;
            _graphics = Graphics.FromImage(_bitmap);
            _graphicsTemp = Graphics.FromImage(_bitmapTemp);
            _currentMode = Config.eButtonDrawingType;
            penWidth = Config.penWidth;
        }

        public void SetPenWidth(int width)
        {
            _pen.Width = width;

        }

        public void ClearSurface(Color c)
        {
            _graphics.Clear(c);
            _graphicsTemp.Clear(c);
            _graphicsTemp.DrawImage(_bitmap, 0, 0);

        }

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

        public void DrawFigure(Point p, ref Image img)
        {
            if (_currentFigure != null)
            {
                if (_currentFigure.Pullable == true)
                {
                    _graphicsTemp = Graphics.FromImage(_bitmapTemp);
                    _graphicsTemp.Clear(Color.White);
                    _graphicsTemp.DrawImage(_bitmap, 0, 0);
                    _currentFigure.Draw(_graphicsTemp, p);
                    img = _bitmapTemp;
                }
                else
                {

                    _currentFigure.Draw(_graphics,  p);
                   img = _bitmap;
                }
            }
        }


        public void FinishFigure(Point p)
        {
            if (_currentFigure != null)
            {
                _currentFigure.Draw(_graphics, p);
                _currentFigure.EndPoint = p;
                storage.AddFigure(_currentFigure);
            }
        }

        public void DrawFigures()
        {
            List<Figure> figures = storage.GetListOfFigures();
            foreach(var figure in figures)
            {
                figure.Draw(_graphics, figure.EndPoint);
            }
        }


        public void Undo(Color color)
        {
            ClearSurface(color);
            storage.MoveBack();
            DrawFigures();
        }

        public void Redo()
        {
            storage.MoveForward();
            DrawFigures();

        }
        public void SelectFigure(Point p, int polygonAngles=-1)
        {
            FigureFactory.FigureFactory factory;
            switch (_currentMode)
            {
                case EButtonDrawingType.Line:
                    factory = new LineFactory(_pen,p);
                    break;
                case EButtonDrawingType.Rectangle:
                    factory = new RectangleFactory(_pen, p);
                    break;
                case EButtonDrawingType.Ellipse:
                    factory = new EllipseFactory(_pen, p);
                    break;
                case EButtonDrawingType.Curve:
                    factory = new CurveFactory(_pen,p);
                    break;
                case EButtonDrawingType.Point:
                    factory = new PointFactory(_pen,p);
                    break;
                case EButtonDrawingType.Polygon6:
                    factory = new PolygonFactory(_pen, p, 6);
                    break;
                case EButtonDrawingType.Polygon:
                    factory = new PolygonFactory(_pen, p,polygonAngles);
                    break;
                case EButtonDrawingType.RoundedRectangle:
                    factory = new RoundedRectangleFactory(_pen, p);
                    break;
                default:
                    factory = new CurveFactory(_pen,p);
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

        public Image Load(ref OpenFileDialog f)
        {
            _currentFigure = null;

            saveLoad = RastrSaveHelper.Create();

            return saveLoad.Load(ref f,ref _graphics, ref _bitmap);
        }
        public void Save(Image img)
        {
            saveLoad = RastrSaveHelper.Create();
            saveLoad.Save(img);
        }


    }
}
