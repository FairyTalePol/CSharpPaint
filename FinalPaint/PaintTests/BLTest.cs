using FinalPaint.Classes;
using FinalPaint.DependencyInversion;
using FinalPaint.Interfaces_;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;

namespace PaintTests
{
    public class Tests
    {
        private BuisnessLogic _bl;
        private Mock<IMyGraphics> _myGraphicsMock;
        private Mock<IBuisnessLogic> _blMock;
        private Mock<IStorage> _storageMock;
        private Storage _storage;
        private Figure _currentFigure;
        private EButtonDrawingType _eButton;
        




        [SetUp]
        public void Setup()
        {
            _myGraphicsMock = new Mock<IMyGraphics>(MockBehavior.Strict);
            _blMock = new Mock<IBuisnessLogic>(MockBehavior.Strict);
            _storageMock = new Mock<IStorage>(MockBehavior.Strict);
            _bl = BuisnessLogic.Create();
            _storage = Storage.Create();
            //var fieldInfo = typeof(BuisnessLogic).GetField("storage", BindingFlags.NonPublic | BindingFlags.Instance);
            ////   var actualData = fieldInfo.GetValue(workClass);
            //fieldInfo.SetValue(_bl, _myGraphicsMock.Object);
            
        }
        //[Test]
        //public void UndoTest1()
        //{
        //    //List<FigureWithParametrs> fwp = new List<FigureWithParametrs>();
        //    List<FigureWithParametrs> fwp = _storage._current;
        //    fwp.Add(new FigureWithParametrs(new Ellipse(5,6, _myGraphicsMock.Object), "White", 5));
        //    fwp.Add(new FigureWithParametrs(new Ellipse(5,6, _myGraphicsMock.Object), "White", 5));
        //    FieldInfo getPointer = typeof(Storage).GetField("_pointer", BindingFlags.NonPublic | BindingFlags.Instance);
        //    getPointer.SetValue(_storage, 0);
        //    _storageMock.Setup(a => a.Undo());
        //    _bl.Undo();
        //    _storageMock.Verify(a => a.Undo(), Times.Once);
        //}

        [TestCase(EButtonDrawingType.Curve, EButtonDrawingType.Curve)]
        [TestCase(EButtonDrawingType.Ellipse, EButtonDrawingType.Ellipse)]
        [TestCase(EButtonDrawingType.Polygon6, EButtonDrawingType.Polygon6)]
        public void SetCurrentModeTest1(EButtonDrawingType exp, EButtonDrawingType mode)
        {
            _bl.SetCurrentMode(mode);
            Assert.AreEqual(_bl.currentMode, exp);
        }
        [Test]
        public void DrawFigureTest1()
        {
            _bl.currentFigure = new Ellipse(5, 6, _myGraphicsMock.Object);
            _myGraphicsMock.Setup(a => a.IsCurrentSurfaceTemporary()).Returns(true);
            _myGraphicsMock.Verify(a => a.IsCurrentSurfaceTemporary(), Times.Never);
        }
        [Test]
        public void DrawFigureTest2()
        {
            _blMock.Setup(a => a.DrawFigure(It.IsAny<int>(), It.IsAny<int>()));
            _myGraphicsMock.Verify(a => a.IsCurrentSurfaceTemporary(), Times.Never);
        }
        //[Test]
        //public void DrawFigureTest3()
        //{
        //    _myGraphicsMock.Setup(a => a.IsCurrentSurfaceTemporary()).Returns(false);
        //    _bl.currentFigure = new Ellipse(It.IsAny<int>(), It.IsAny<int>(), _myGraphicsMock.Object);
    
        //    _storageMock.Setup(a => a.AddFigure(It.IsAny<Figure>(), It.IsAny<int>(), "White"));
            
        //    _bl.DrawFigure(It.IsAny<int>(), It.IsAny<int>());

        //    //_myGraphicsMock.Verify(a => a.IsCurrentSurfaceTemporary(), Times.Once);
        //    //var penSize = _myGraphicsMock.Setup(a => a.GetCurrentPenSize()).Returns(It.IsAny<float>);
        //    //var penColor = _myGraphicsMock.Setup(a => a.GetCurrentPenColor()).Returns(It.IsAny<string>))

           
        //    _storageMock.Verify(a => a.AddFigure(It.IsAny<Figure>(), It.IsAny<int>(), It.IsAny<string>()), Times.Once);
        //}
        //[Test]
        //public void DrawFigureTest4()
        //{

        //    _myGraphicsMock.Setup(a => a.IsCurrentSurfaceTemporary()).Returns(true);
        //    _bl.DrawFigure(5, 6);
        //    _myGraphicsMock.Verify(a => a.IsCurrentSurfaceTemporary(), Times.Never);
        //}
        //[TestCase(9, 8, 9)]
        //public void DrawFigureTest5(int x, int y, int exp_finishX)
        //{
        //    _storageMock.Setup(a => a.AddFigure(_currentFigure, 45, "White"));
        //    _bl.currentFigure = new Ellipse(5, 6, _myGraphicsMock.Object);
        //    _bl.DrawFigure(x, y);
        //    var resX = _bl.currentFigure._finishX;
        //    Assert.AreEqual(exp_finishX, resX);
            
        //    //_storageMock.Verify(a => a.AddFigure(_currentFigure, 45, "White"), Times.Once);
        //}


        //[Test]
        //public void Test2()
        //{
        //    _myGraphicsMock.Setup(a => a.IsCurrentSurfaceTemporary()).Returns(true);
        //    _bl.currentFigure = new Ellipse(It.IsAny<int>(), It.IsAny<int>(), _myGraphicsMock.Object);
        //    _myGraphicsMock.Setup(a => a.DrawEllipse(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()));

        //    _bl.DrawFigure(It.IsAny<int>(), It.IsAny<int>());
        //    _myGraphicsMock.Verify(a => a.DrawEllipse(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        //    _myGraphicsMock.Verify(a => a.IsCurrentSurfaceTemporary(), Times.Once);
        //}


        [Test]
        public void SelectFigureTest1()
        {
            
            var exp = new Ellipse(5, 6, _myGraphicsMock.Object);
            _bl.currentMode = EButtonDrawingType.Ellipse;
            _bl.SelectFigure(5, 6);

            var res = _bl.currentFigure;

            Assert.AreEqual(res, exp);
        }
        [Test]
        public void SelectFigureTest2()
        {
           
            var exp = new Line(5, 6, _myGraphicsMock.Object);
            _bl.currentMode = EButtonDrawingType.Line;
            _bl.SelectFigure(5, 6, 6);

            var res = _bl.currentFigure;

            Assert.AreEqual(res, exp);
        }
        //[Test]
        //public void SelectFigureTest3()
        //{
        //    var exp = new Rectangle(5, 6, _myGraphicsMock.Object);
        //    _bl.currentMode = EButtonDrawingType.Rectangle;
        //    _bl.SelectFigure(5, 6, 6);

        //    var res = _bl.currentFigure;

        //    Assert.AreEqual(res, exp);
        //}
        //[Test]
        //public void SelectFigureTest4()
        //{
        //    var exp = new Curve(5, 6, _myGraphicsMock.Object);
        //    _bl.currentMode = EButtonDrawingType.Curve;
        //    _bl.SelectFigure(5, 6, 6);

        //    var res = _bl.currentFigure;

        //    Assert.AreEqual(res, exp);
        //}
        [Test]
        public void SelectFigureTest5()
        {

            var exp = new CustomPoint(5, 6, _myGraphicsMock.Object);
            _bl.currentMode = EButtonDrawingType.Point;
            _bl.SelectFigure(5, 6, 6);

            var res = _bl.currentFigure;

            Assert.AreEqual(res, exp);
        }
        //[Test]
        //public void SelectFigureTest6()
        //{
        //    var exp = new Polygon(5, 6, 6, _myGraphicsMock.Object);
        //    _bl.currentMode = EButtonDrawingType.Polygon;
        //    _bl.SelectFigure(5, 6, 6);

        //    var res = _bl.currentFigure;

        //    Assert.AreEqual(res, exp);
        //}
        //[Test]
        //public void SelectFigureTest7()
        //{
        //    var exp = new Polygon(5, 6, 15, _myGraphicsMock.Object);
        //    _bl.currentMode = EButtonDrawingType.Polygon;
        //    _bl.SelectFigure(5, 6, 6);

        //    var res = _bl.currentFigure;

        //    Assert.AreEqual(res, exp);
        //}
        [Test]
        public void SelectFigureTest8()
        {
            var exp = new Ellipse(5, 6, _myGraphicsMock.Object);
            _bl.currentMode = EButtonDrawingType.Ellipse;
            _bl.SelectFigure(5, 6, 6);

            var res = _bl.currentFigure;

            Assert.AreEqual(res, exp);
        }



        [Test]
        public void SelectFigureTest9()
        {
            var exp = new Ellipse(5, 6, _myGraphicsMock.Object);

            //var fieldInfo = typeof(BuisnessLogic).GetField("_currentMode", BindingFlags.NonPublic | BindingFlags.Instance);
            //fieldInfo.SetValue(_bl, EButtonDrawingType.Ellipse);
            _bl.currentMode = EButtonDrawingType.Ellipse;
            _bl.SelectFigure(5, 6, 6);

            var res = _bl.currentFigure;
            //var fieldInfoFigure = typeof(BuisnessLogic).GetField("_currentFigure", BindingFlags.NonPublic | BindingFlags.Instance);
            //var res = fieldInfoFigure.GetValue(_bl);

            Assert.AreEqual(res, exp);



        }
    }
}