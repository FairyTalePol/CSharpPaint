using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
   public class Storage
    {

        private static Storage _storage;
        public List<FigureWithParametrs> _current;
        public List<List<FigureWithParametrs>> _archive;
        private int _pointer;
        private Storage()
        {
            _current = new List<FigureWithParametrs>();
            _archive = new List<List<FigureWithParametrs>>();
            _pointer = 0;
        }

        public static Storage Create()
        {
            if (_storage == null)
            {
                _storage = new Storage();
            }
            return _storage;
        }

        public void AddFigure(Figure figure, float penWidth, string color)
        {
            if (_pointer>0)
            {
           
                for (int i=0; i<_pointer; i++)
                {
                    _archive.RemoveAt(_archive.Count - 1);
                }
                foreach (var fig in _archive.Last())
                {
                    _current.Add((FigureWithParametrs) fig.Clone());
                }

                _pointer = 0;
            }


            FigureWithParametrs HeeeeeyMakarena = new FigureWithParametrs(figure, color, penWidth);
            _current.Add(HeeeeeyMakarena);

            List<FigureWithParametrs> temp = new List<FigureWithParametrs>();
            foreach (var fwp in _current)
            {
                temp.Add((FigureWithParametrs)fwp.Clone());
            }

            _archive.Add(temp);

        }

        public void Undo()
        {
            if (_pointer < _archive.Count - 1)
            {
                _pointer++;
            }
        }

        public void Redo()
        {
            if (_pointer > 0)
            {
                _pointer--;
            }
        }

        public List<FigureWithParametrs> GetCurrentList()
        {
                
            _current = _archive.ElementAt(_archive.Count - _pointer - 1);
            return _current;
        }

        public void ClearCurrentList()
        {

            _current = new List<FigureWithParametrs>();
        }
    }
}