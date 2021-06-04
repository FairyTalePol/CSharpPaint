using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using Newtonsoft.Json;

namespace FinalPaint.Classes
{
    public class Rectangle : Figure
    {
        public Rectangle (int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }
        [JsonConstructor]
        public Rectangle(bool pullable, bool isselected, int startx, int starty, int endx, int endy)
        {
            _pullable = pullable;
            IsSelected = isselected;
            _startX = startx;
            _startY = _startY;
            _finishX = endx;
            _finishX = endy;
        }

        public Rectangle(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
        }
        
        public override void Draw(int finishX, int finishY)
        {
           
            int width = finishX - _startX < 0 ? _startX - finishX : finishX - _startX;
            int height = finishY - _startY < 0 ? _startY - finishY : finishY - _startY;
         

            if (_startX < finishX && _startY < finishY)
            {
                _myGraphics.DrawRectangle(_startX, _startY, width, height);
            }
            else if(_startX > finishX && _startY > finishY)
            {               
                _myGraphics.DrawRectangle( finishX, finishY, width, height);
            }
            else if (_startX < finishX && _startY > finishY)
            {
                _myGraphics.DrawRectangle( _startX, finishY, width, height);
            }
            else if(_startX> finishX && _startY< finishY)
            {
                _myGraphics.DrawRectangle( finishX, _startY, width, height);
            }
            
            _finishX = finishX;
            _finishY = finishY;

        }


        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;

            if (x>=_startX&&x<=_finishX&&y>=_startY&&y<=_finishY)
            {
                res = true;
            }
            return res;
        }

        public override void AddCoordinates(int x, int y)
        {
            _startX += x;
            _startY += y;
            _finishX += x;
            _finishY += y;
        }

        public override object Clone()
        {
            Rectangle res = new Rectangle(_startX, _startY);
            res._finishX = _finishX;
            res._finishY = _finishY;
            res._myGraphics = _myGraphics;
            res._pullable = _pullable;
            res.IsSelected = IsSelected;
            return res;
        }

        public override void Optimize()
        {
            int temp;
            if (_startX>_finishX)
            {
                temp = _startX;
                _startX = _finishX;
                _finishX = temp;
            }
        
            if (_startY> _finishY)
            {
                temp = _startY;
                _startY = _finishY;
                _finishY = temp;
            }
        }
    }
}
