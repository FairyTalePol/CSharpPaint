using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
   public class LineTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(25, 25, true)]
        [TestCase(1, 1, true)]
        [TestCase(3, 5, true)]
        [TestCase(25, 0, false)]
        [TestCase(50, 55, true)]
        [TestCase(50, 56, true)]
        public void IsPointOnLineTest_ReturnsTrueIsPassed_ElseFalse(int x, int y, bool expected)
        {
            Line line = new Line(0, 0);
            line._finishX = 100;
            line._finishY = 100;

            bool actual = line.IsPointInPoly(x, y,20);

            Assert.AreEqual(expected, actual);
        }
    }
}
