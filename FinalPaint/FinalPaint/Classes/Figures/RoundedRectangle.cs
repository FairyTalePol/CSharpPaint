﻿using FinalPaint.Interfaces_;
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
        public RoundedRectangle(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }

        public override void AddCoordinates(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Draw(int finishX, int finishY)
        {          
            int width = finishX - _startX < 0 ? _startX - finishX : finishX - _startX;
            int height = finishY - _startY < 0 ? _startY - finishY : finishY - _startY;

            if (_startX < finishX && _startY < finishY)
            {
                _myGraphics.DrawRoundedRectangle(_startX, _startY, width, height);
            }
            else if (_startX > finishX && _startY > finishY)
            {
                _myGraphics.DrawRoundedRectangle(finishX, finishY, width, height);
            }
            else if (_startX < finishX && _startY > finishY)
            {
                _myGraphics.DrawRoundedRectangle(_startX, finishY, width, height);
            }
            else if (_startX > finishX && _startY < finishY)
            {
                _myGraphics.DrawRoundedRectangle(finishX, _startY, width, height);
            }
        }

        public override bool IsPointInPoly(int x, int y, int error = 0)
        {
            bool res = false;

            if (x >= _startX && x <= _finishX && y >= _startY && y <= _finishY)
            {
                res = true;
            }
            return res;
        }

        public override void Optimize()
        {
            throw new NotImplementedException();
        }
    }
}
