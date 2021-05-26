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
        public List<Figure> _archive;
        private static Storage _storage;

        private Storage()
        {
            _figures = new List<Figure>();
            _archive = new List<Figure>();
        }

        public static Storage Create()
        {
            if (_storage == null)
            {
                _storage = new Storage();
            }
            return _storage;

        }

        public void AddFigure(Figure figure)
        {
            _figures.Add(figure);
            ClearArchive();
        }

        public void ClearArchive()
        {
            _archive.Clear();
        }

        public void MoveBack()
        {
            _archive.Add(_figures.Last());
            _figures.Remove(_figures.Last());
        }

        public void MoveForward()
        {
            _figures.Add(_archive.Last());
            _archive.Remove(_archive.Last());
        }

        public List<Figure> GetListOfFigures()
        {
            return _figures;
        }

        public void GetListOfFigures(List<Figure> list)
        {
            _figures = list;
        }



    }
}