using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
    public class AutorizationRestApi
    {
        private BuisnessLogic _bl;





        [SetUp]
        public void Setup()
        {
            _bl = BuisnessLogic.Create();
        }



        [TestCase("Antonkhan@gmail.com", "qwerty",0)]
        [TestCase("qwerty@gmail.com", "qwerty",0)]
        [TestCase("anton2000@gmail.com", "qwerty", 0)]
        public void authorization(string firstName,string password, int expected)
        {

            var result = _bl.AuthorizationRestApi(firstName, password);
            Assert.AreEqual(expected, result);

        }
    }
}
