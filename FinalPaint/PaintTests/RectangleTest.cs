using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
    public class RectangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(25,25,false)]
        [TestCase(7, 8, true)]
        [TestCase(-4, 7, false)]
        [TestCase(9, 9, true)]
        [TestCase(0, 1, true)]
        public void IsPointInPolyTest_ReturnsTrueIsPassed_ElseFalse(int x, int y, bool expected)
        {
            Rectangle rect = new Rectangle(0,0);
            rect._finishX = 10;
            rect._finishY = 10;

            bool actual = rect.IsPointInPoly(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
