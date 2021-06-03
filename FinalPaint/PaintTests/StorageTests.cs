using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
  public  class StorageTests
    {
        private Storage _storage;

        [SetUp]
        public void Setup()
        {
            _storage = Storage.Create();
        }

        [Test]
        public void AddFigureIntoListofFigureswithParamaters_ChecksCountTest1()
        {

            Figure figure = new Ellipse(5, 6);
            FigureWithParametrs fwp = new FigureWithParametrs(figure, "red", 5);
            List<FigureWithParametrs> listOffigures = new List<FigureWithParametrs>();
            listOffigures.Add(fwp);
            int actual = listOffigures.Count;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddFigureIntoListofFigureswithParamaters_ChecksCountTest2()
        {

            Figure figure1 = new Ellipse(5, 6);
            Figure figure2 = new Rectangle(9, 8);
            Figure figure3 = new Polygon(4, 6, 7);
            FigureWithParametrs fwp1 = new FigureWithParametrs(figure1, "red", 5);
            FigureWithParametrs fwp2 = new FigureWithParametrs(figure2, "green", 10);
            FigureWithParametrs fwp3 = new FigureWithParametrs(figure3, "blue", 20);
            List<FigureWithParametrs> listOffigures = new List<FigureWithParametrs>();
            listOffigures.Add(fwp1);
            listOffigures.Add(fwp2);
            listOffigures.Add(fwp3);
            int actual = listOffigures.Count;
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddFigureIntoCurrentListofFigureswithParamaters_ChecksCountOFCurrent_Test1()
        {
            Figure figure1 = new Ellipse(5, 6);

            _storage.AddFigure(figure1, 5, "red") ;
            int actual = _storage._current.Count;
            int expected = 1;
            Assert.AreEqual(expected, actual);
            _storage.ClearCurrentList();
        }

        [Test]
        public void AddFigureIntoCurrentListofFigureswithParamaters_ChecksCountOFCurrent_Test2()
        {
            Figure figure1 = new Ellipse(5, 6);
            Figure figure2 = new Rectangle(9, 8);
            Figure figure3 = new Polygon(4, 6, 7);

            _storage.AddFigure(figure1, 5, "red");
            _storage.AddFigure(figure2, 10, "green");
            _storage.AddFigure(figure3, 20, "blue");
            int actual = _storage._current.Count;
            int expected = 3;
            Assert.AreEqual(expected, actual);
            _storage.ClearCurrentList();
        }

        [Test]
        public void AddFigureIntoCurrentListofFigureswithParamaters_ChecksCountOFCurrent_Test3()
        {
            Figure figure1 = new Ellipse(5, 6);
            Figure figure2 = new Rectangle(9, 8);
            Figure figure3 = new Polygon(4, 6, 7);
            Figure figure4 = new Line(6, 99);
            Figure figure5 = new CustomPoint(5, 5);
            Figure figure6 = new Curve(6, 52);

            _storage.AddFigure(figure1, 5, "red");
            _storage.AddFigure(figure2, 10, "green");
            _storage.AddFigure(figure3, 20, "blue");
            _storage.AddFigure(figure4, 1, "purple");
            _storage.AddFigure(figure5, 15, "violet");
            _storage.AddFigure(figure6, 56, "yellow");
            int actual = _storage._current.Count;
            int expected = 6;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Undo_ChecksPrivatePointer_Test1()
        {
            FieldInfo getPointer = typeof(Storage).GetField("_pointer", BindingFlags.NonPublic | BindingFlags.Instance);
            getPointer.SetValue(_storage, 0);
            _storage.Undo();
            var actual = getPointer.GetValue(_storage);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Undo_ChecksPrivatePointer_Test2()
        {
            FieldInfo getPointer = typeof(Storage).GetField("_pointer", BindingFlags.NonPublic | BindingFlags.Instance);
            getPointer.SetValue(_storage, 0);
            _storage.Undo();
            _storage.Undo();
            _storage.Undo();
            var actual = getPointer.GetValue(_storage);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Redo_ChecksPrivatePointer_Test1()
        {
            FieldInfo getPointer = typeof(Storage).GetField("_pointer", BindingFlags.NonPublic | BindingFlags.Instance);
            getPointer.SetValue(_storage, 4);
            _storage.Redo();
            var actual = getPointer.GetValue(_storage);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Redo_ChecksPrivatePointer_Test2()
        {
            FieldInfo getPointer = typeof(Storage).GetField("_pointer", BindingFlags.NonPublic | BindingFlags.Instance);
            getPointer.SetValue(_storage, 4);
            _storage.Redo();
            _storage.Redo();
            _storage.Redo();
            var actual = getPointer.GetValue(_storage);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Redo_ChecksPrivatePointer_Test3()
        {
            FieldInfo getPointer = typeof(Storage).GetField("_pointer", BindingFlags.NonPublic | BindingFlags.Instance);
            getPointer.SetValue(_storage, 4);
            _storage.Redo();
            _storage.Redo();
            _storage.Redo();
            _storage.Redo();
            var actual = getPointer.GetValue(_storage);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetFurrentList_ChecksCurrent_Test1()
        {
            _storage.ClearCurrentList();
            Figure figure1 = new Ellipse(5, 6);
            Figure figure2 = new Rectangle(9, 8);
            Figure figure3 = new Polygon(4, 6, 7);
         
            _storage.AddFigure(figure1, 5, "red");
            _storage.AddFigure(figure2, 10, "green");
            _storage.AddFigure(figure3, 20, "blue");

            List<FigureWithParametrs> actual = _storage.GetCurrentList();

            List<FigureWithParametrs> expected = _storage._current;

            Assert.AreEqual(expected,actual);
        }


        [Test]
        public void GetFurrentList_ChecksCurrent_Test2()
        {
            _storage.ClearCurrentList();
            Figure figure1 = new Ellipse(5, 6);

            _storage.AddFigure(figure1, 5, "red");

            List<FigureWithParametrs> actual = _storage.GetCurrentList();

            List<FigureWithParametrs> expected = _storage._current;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void GetFurrentList_ChecksCurrent_Test3()
        {
            _storage.ClearCurrentList();
            Figure figure1 = new Ellipse(5, 6);
            Figure figure2 = new Rectangle(9, 8);
            Figure figure3 = new Polygon(4, 6, 7);
            Figure figure4 = new Line(6, 99);
            Figure figure5 = new CustomPoint(5, 5);
            Figure figure6 = new Curve(6, 52);

            _storage.AddFigure(figure1, 5, "red");
            _storage.AddFigure(figure2, 10, "green");
            _storage.AddFigure(figure3, 20, "blue");
            _storage.AddFigure(figure4, 1, "purple");
            _storage.AddFigure(figure5, 15, "violet");
            _storage.AddFigure(figure6, 56, "yellow");

            List<FigureWithParametrs> actual = _storage.GetCurrentList();

            List<FigureWithParametrs> expected = _storage._current;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ClearCurrentList_ChecksCountOFCurrent_Test()
        {
            _storage.ClearCurrentList();
            int actual = _storage._current.Count;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }


    }
}
