using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class Storage
    {
        public List<Figure> _figures;
        public List<List<Figure>> _archive;
        private static Storage _storage;
        private int _pointer;

        private Storage()
        {
            _figures = new List<Figure>();
            _archive = new List<List<Figure>>();
        }

        public static Storage Create()
        {
            if (_storage == null)
            {
                _storage = new Storage();
            }
            return _storage;

        }

        private List<Figure> CloneCurrentList()
        {
            List <Figure> res = new List<Figure>();
            foreach (var figure in _figures)
            {
                res.Add((Figure)figure.Clone());
            }
            return res;
        }

        public void AddFigure(Figure figure)
        {
            if (_pointer!=0)
            {
                while(_pointer>0)
                {
                    _archive.RemoveAt(_archive.Count - 1);
                    _pointer--;
                }
            }

            _archive.Add(CloneCurrentList());
            _figures.Add((Figure)figure.Clone());
            
        }

        public void ClearArchive()
        {
            _archive.Clear();
        }

        public void MoveBack()
        {
            if (_pointer<_archive.Count())
            {
                _pointer++;
            }
  
        }

        public void MoveForward()
        {
            if (_pointer>0)
            {
                _pointer--;
            }
        }

        public List<Figure> GetListOfFigures()
        {
            List<Figure> res;
            if (_pointer==0)
            {
                res = _figures;
            }
            else
            {
                res = _archive.ElementAt(_archive.Count - 1 - _pointer);
            }
            return res;
        }

        public void SetListOfFigures(List<Figure> list)
        {
            _figures = list;
        }

        public Figure GetLast()
        {
            return _figures.Last();
        }



    }
}