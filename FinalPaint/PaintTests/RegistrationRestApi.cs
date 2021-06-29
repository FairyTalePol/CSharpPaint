using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
    public class RegistrationRestApi
    {
        private BuisnessLogic _bl;





        [SetUp]
        public void Setup()
        {
            _bl = BuisnessLogic.Create();
        }


        [Test]
        public void registration()
        {
            
            NewUserData newUser = new NewUserData();


            newUser.Email = "antontest@gmail.com";
            newUser.UserPassword = "qwerty";
            newUser.FirstName = "vasia";
            newUser.LastName = "zora";
            var result = _bl.RegistrationRestApi(newUser);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void registration2()
        {

            NewUserData newUser = new NewUserData();


            newUser.Email = "masha1234@gmail.com";
            newUser.UserPassword = "qwerty";
            newUser.FirstName = "masha";
            newUser.LastName = "mashova";
            var result = _bl.RegistrationRestApi(newUser);

            Assert.AreEqual(0, result);
        }
    }
}
