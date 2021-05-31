using FinalPaint.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Rectangle : Figure
    {
        public Rectangle (int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
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

        }
    }
}
