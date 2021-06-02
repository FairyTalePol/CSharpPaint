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
        [TestCase(-4, 7, false)]
        [TestCase(50, 50, true)]
        [TestCase(75, 75, false)]
        [TestCase(101, 100, false)]
        [TestCase(39, 39, true)]
        [TestCase(53, 58, false)]
        public void IsPointOnLineTest_ReturnsTrueIsPassed_ElseFalse(int x, int y, bool expected)
        {
            Line line = new Line(0, 0);
            line._finishX = 50;
            line._finishY = 50;

            bool actual = line.IsPointOnLine(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
