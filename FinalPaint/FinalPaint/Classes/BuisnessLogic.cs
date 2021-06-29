﻿using FinalPaint.Classes.FigureFactory;
using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    public class BuisnessLogic : IBuisnessLogic
    {
        private static BuisnessLogic _bl;
        public IMyGraphics myGraphics;
        public EButtonDrawingType currentMode;
        public Storage storage;
        public Figure currentFigure;
        RastrSaveHelper saveLoad;
        Action disableUndoRedo;
        public bool EnableUndoRedo = false;
        private RestApi _r;
        private string _password;




        //private BuisnessLogic()
        //{
        //    saveLoad = RastrSaveHelper.Create();
        //    storage = Storage.Create();         
        //}
        private BuisnessLogic(/*IMyGraphics myGraphicsUI*/)
        {
            saveLoad = RastrSaveHelper.Create();
            storage = Storage.Create();
            _r = RestApi.Create();
            //myGraphics = myGraphicsUI;
        }
        public void ClearMyGraphics()
        {
            myGraphics.ClearMyGraphics();
        }
        public string GetUserPassword()
        {
            var _password = _r.GetPasswordRequest();
            return _password;
        }
        public bool ChangePassword(string newPassword)
        {
            var answer = _r.ChangePasswordRequest(newPassword);
            if (answer)
            {
                _password = newPassword;
            }
            return answer;
        }
        public void ClearUserId()
        {
            _r.ClearUserId();
        }

        public void SetCurrentMode(EButtonDrawingType mode)
        {
            currentMode = mode;
        }

        public void SetDisableUndoRedo(Action act)
        {
            disableUndoRedo = act;
        }
        public void ClearBL()
        {
            _bl = null;
        }

        public void Initialize(IMyGraphics myGraphicsUI)
        {           
            currentMode = Config.eButtonDrawingType;
            myGraphics = myGraphicsUI;      
        }

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
            foreach (var figure in figures)//проход в обратном порядке
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
        

        public int RegistrationRestApi(NewUserData newUser)
        {
            int status = _r.RegistrationRequest(newUser);
            return status;  
        }
        public int AuthorizationRestApi(string email, string password)
        {
            int answer = _r.AuthorizationRequest(email, password);
            return answer;
        }

        public SingleUserStatistics GetUserStatistics()
        {
            SingleUserStatistics statistics = _r.GetUserStatisticsRequest();
            return statistics;
        }

        public void DrawFigure(int x, int y)
        {
            if (currentFigure != null)
            {
                currentFigure._finishX = x;
                currentFigure._finishY = y;
                currentFigure.Draw(x, y);
                if (!myGraphics.IsCurrentSurfaceTemporary())
                {
                    storage.AddFigure(currentFigure, myGraphics.GetCurrentPenSize(), myGraphics.GetCurrentPenColor());
                }
            }
        }
        public void SelectFigure(int x, int y, int polygonAngles = -1)
        {
            FigureFactory.FigureFactory factory;
            switch (currentMode)
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
            currentFigure = factory.Create();
        }


        public static BuisnessLogic Create(/*IMyGraphics myGraphicsUI/*, IStorage*/ )
        {
            if (_bl == null)
            {
                _bl = new BuisnessLogic(/*myGraphicsUI*/);
            }
            return _bl;
        }
      
        public void Load(Action act)
        {
            try
            {
                saveLoad = RastrSaveHelper.Create();
                object res = saveLoad.Load();
                currentMode = EButtonDrawingType.Selection;
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
            catch (ArgumentNullException )
            {

            }
           
           
        }
        public void Save(Action act)
        {
            saveLoad = RastrSaveHelper.Create();
            act();
        }

        public void RemoteSaveForm()
        {
            RemoteSaveForm form = new RemoteSaveForm();
            form.ShowDialog();
        }

        public void SaveServer(string name, PictureType format)
        {
            string serialized = myGraphics.SaveServer(format);
            PictureData pd = new PictureData();
            pd.Picture = serialized;
            pd.Type = format;
            pd.UserId = 1;
            pd.Name = name;
            RestApi r = RestApi.Create();
            r.SavePicture(pd);
            //r.RequestTestWithPicture();


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
            myGraphics.ClearSurface();
            foreach (var figure in figures)
            {
                Figure f = myGraphics.FigureFromFWP(figure);
                f.Draw(f._finishX, f._finishY);
            }

        }
        
        

    }
}
