using Newtonsoft.Json;
using System;

namespace FinalPaint.Classes
{
    abstract public class Figure : ICloneable
    {
        [NonSerialized]
        public Interfaces_.IMyGraphics _myGraphics;

        [JsonProperty]
        protected bool _pullable;
        [JsonProperty]
        public bool IsSelected { get; set; }
        [JsonProperty]
        public int _startX { get; set; }
        [JsonProperty]
        public int _startY { get; set; }
        [JsonProperty]
        public int _finishX { get; set; }
        [JsonProperty]
        public int _finishY { get; set; }

      
        public bool Pullable
        {
            get
            {
                return _pullable;
            }
        }

        public abstract void Draw(int finishX, int finishY);

        public abstract bool IsPointInPoly(int x, int y, int error =0);

        public abstract void AddCoordinates(int x, int y);

        public abstract object Clone();

        public abstract void Optimize();
     
    }
}
