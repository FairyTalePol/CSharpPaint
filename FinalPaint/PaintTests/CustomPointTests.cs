using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
   public class CustomPointTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(15, 15, true)]
        [TestCase(-4, 7, false)]
        [TestCase(5, 5, true)]
        [TestCase(75, 75, false)]
        [TestCase(101, 100, false)]
        [TestCase(9, 9, true)]
        [TestCase(53, 58, false)]
        public void IsPointOnPointTest_ReturnsTrueIsPassed_ElseFalse(int x, int y, bool expected)
        {
            CustomPoint point = new CustomPoint(10, 10);
            point._finishX = 10;
            point._finishY = 10;

            bool actual = point.IsPointInPoly(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
