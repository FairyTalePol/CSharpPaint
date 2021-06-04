using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
 public class RoundedRectangleTests
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
            RoundedRectangle roundRect = new RoundedRectangle(0, 0);
            roundRect._finishX = 10;
            roundRect._finishY = 10;

            bool actual = roundRect.IsPointInPoly(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
