﻿using FinalPaint.Interfaces_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    public class RoundedRectangle : Figure
    {      
        public RoundedRectangle(int startX, int startY, IMyGraphics mg)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
            _myGraphics = mg;
        }

        public RoundedRectangle(int startX, int startY)
        {
            _startX = startX;
            _startY = startY;
            _pullable = true;
        }

        [JsonConstructor]
        public RoundedRectangle(bool pullable, bool isselected, int startx, int starty, int endx, int endy)
        {
            _pullable = pullable;
            IsSelected = isselected;
            _startX = startx;
            _startY = _startY;
            _finishX = endx;
            _finishX = endy;
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
            RoundedRectangle res = new RoundedRectangle(_startX, _startY);
            res._finishX = _finishX;
            res._finishY = _finishY;
            res._myGraphics = _myGraphics;
            res._pullable = _pullable;
            res.IsSelected = IsSelected;
            return res;
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

        public override bool Equals(object obj)
        {
            return obj is RoundedRectangle rectangle &&
                   EqualityComparer<IMyGraphics>.Default.Equals(_myGraphics, rectangle._myGraphics) &&
                   _pullable == rectangle._pullable &&
                   IsSelected == rectangle.IsSelected &&
                   _startX == rectangle._startX &&
                   _startY == rectangle._startY &&
                   _finishX == rectangle._finishX &&
                   _finishY == rectangle._finishY &&
                   Pullable == rectangle.Pullable;
        }

        public override int GetHashCode()
        {
            int hashCode = -1288887542;
            hashCode = hashCode * -1521134295 + EqualityComparer<IMyGraphics>.Default.GetHashCode(_myGraphics);
            hashCode = hashCode * -1521134295 + _pullable.GetHashCode();
            hashCode = hashCode * -1521134295 + IsSelected.GetHashCode();
            hashCode = hashCode * -1521134295 + _startX.GetHashCode();
            hashCode = hashCode * -1521134295 + _startY.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishX.GetHashCode();
            hashCode = hashCode * -1521134295 + _finishY.GetHashCode();
            hashCode = hashCode * -1521134295 + Pullable.GetHashCode();
            return hashCode;
        }

        public override bool IsPointInPoly(int x, int y)
        {
            bool res = false;

            if (x >= _startX && x <= _finishX && y >= _startY && y <= _finishY)
            {
                res = true;
            }
            return res;
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
            int temp;
            if (_startX > _finishX)
            {
                temp = _startX;
                _startX = _finishX;
                _finishX = temp;
            }

            if (_startY > _finishY)
            {
                temp = _startY;
                _startY = _finishY;
                _finishY = temp;
            }
        }
    }
}
