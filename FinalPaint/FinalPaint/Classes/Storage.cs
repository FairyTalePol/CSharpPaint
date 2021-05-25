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
        public List<List<Figure>> figuresListCopy;
        private static Storage _storage;

        private Storage ()
        {
            _figures = new List<Figure>();
            _archive = new List<List<Figure>>();
        }

        public static Storage Create()
        {
            if(_storage==null)
            {
               _storage = new Storage();
            }
            return _storage;
        
        }

        public void AddFigure(Figure figure)
        {
            List<Figure> figuresCopy = new List<Figure>(_figures);
            _archive.Add(figuresCopy);

            if (figuresListCopy == null)
            { 
                figuresListCopy = new List<List<Figure>>(_archive); 
            }

            _figures.Add(figure);     
        }

        public Figure GetFigureAt(int index)
        {
            return _figures.ElementAt(index);
        }

        public Figure GetLastFigure()
        {
            return _figures.Last();
        }

        public int GetFigureCount()
        {
            return _figures.Count;
        }

        public List<Figure> GetFiguresOneStepBack()
        {
            if (figuresListCopy == null)
            {
                figuresListCopy = new List<List<Figure>>(_archive);
            }
            figuresListCopy.RemoveAt(figuresListCopy.Count - 1);
            return _archive.ElementAt(_archive.Count - 2);
        }

        public List<Figure> GetFiguresOneStepForward()
        {
            if(figuresListCopy==null)
            {
                figuresListCopy = new List<List<Figure>>(_archive);
                return _archive.Last();
            }
            figuresListCopy.Add(_archive.ElementAt(figuresListCopy.Count));
            return figuresListCopy.Last();
        }

        public int GetFiguresCount()
        {
            return _archive.Count;
        }



    }
}
