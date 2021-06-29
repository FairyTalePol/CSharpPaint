using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
   public class RequestsTests
    {
        [Test]
        public void AuthorizationRestApi()
        {

            // var r =  RestApi.Create();
            //  var RestApiMock = new Mock<RestApi>(MockBehavior.Strict);
            //  RestApiMock.Setup(f => f.AuthorizationRequest(It.IsAny<string>(), It.IsAny<string>())).Returns(It.IsAny<int>); 

            //var result = _bl.AuthorizationRestApi("", "");
            //Assert.AreEqual(-2, result);


            // r.Verify(f => f.AuthorizationRequest("", ""),Times.Once);

        }

        [Test]
        public void RegistrationRestApi()
        {
            //NewUserData a = new NewUserData();
            ///var result = _bl.RegistrationRestApi(a);

            //Assert.AreEqual(-2, result);
        }
    }
}
