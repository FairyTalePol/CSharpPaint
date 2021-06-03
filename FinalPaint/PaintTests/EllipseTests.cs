using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
  public  class EllipseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(25, 25, false)]
        [TestCase(7, 8, true)]
        [TestCase(-4, 7, false)]
        [TestCase(9, 9, true)]
        [TestCase(0, 1, true)]
        public void IsPointInPolyTest_ReturnsTrueIsPassed_ElseFalse(int x, int y, bool expected)
        {
            Ellipse ellipse = new Ellipse(0, 0);
            ellipse._finishX = 10;
            ellipse._finishY = 10;

            bool actual = ellipse.IsPointInPoly(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
