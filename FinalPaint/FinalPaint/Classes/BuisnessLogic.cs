using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class BuisnessLogic
    {
        private static BuisnessLogic _bl;

        public EButtons _currentMode;
        public Bitmap _bitmap;
        public Bitmap _bitmapTemp;
        public Pen _pen;
        public Graphics _graphics;
        public Graphics _graphicsTemp;
        public Figure _currentFigure;
        public Dictionary<int, int> penWidth;
        RastrSaveHelper saveLoad;
        //Config conf;
        //S

        private BuisnessLogic()
        {
            saveLoad = RastrSaveHelper.Create();
        }

        public void Innitialize(int bitmapWidth, int bitmapHeight)
        {
            _bitmap = new Bitmap(bitmapWidth, bitmapHeight);
            _bitmapTemp = new Bitmap(bitmapWidth, bitmapHeight);
            //_pen = conf.Pen;
            _graphics = Graphics.FromImage(_bitmap);
            _graphicsTemp = Graphics.FromImage(_bitmapTemp);
            
            _currentMode = EButtons.Curve;
            _pen.StartCap = LineCap.Round;
            _pen.EndCap = LineCap.Round;
        }

        public BuisnessLogic Create()
        {
            if (_bl==null)
            {
                _bl = new BuisnessLogic();
            }
            return _bl;
        }


    }
}
