using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
   public class PolygonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(25, 25, true)]
        [TestCase(-4, 7, false)]
        [TestCase(50, 50, true)]
        [TestCase(75, 75, true)]
        [TestCase(101, 100, false)]
        [TestCase(47, 39, true)]
        [TestCase(53, 58, true)]
        public void IsPointInPolyTest_ReturnsTrueIsPassed_ElseFalse(int x, int y, bool expected)
        {
            Polygon poly = new Polygon(0, 0, 6);
            poly._finishX = 100;
            poly._finishY = 100;

            bool actual = poly.IsPointInPoly(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
