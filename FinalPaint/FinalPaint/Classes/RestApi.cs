using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Windows.Forms;

namespace FinalPaint.Classes
{
    class RestApi
    {
        private static RestApi _restApi;
        private IRestClient _restClient;
        private RestRequest _request;

        private RestApi()
        {
            _restClient = new RestClient();
        }


        public static RestApi Create()
        {
            if(_restApi==null)
            {
                _restApi = new RestApi();
            }
            return _restApi;
        }

        public void RequestTest()
        {
            _request = new RestRequest { Resource = "https://localhost:44341/auth/register", Method = Method.POST };
            NewUserData newUserData = new NewUserData
            {
                Email = "egorusdnepr9@gmail.com",
                FirstName = "Mariia",
                LastName = "Yakovenko",
                UserPassword = "I_HATE_IT"
            };

     

            _request.AddJsonBody(newUserData);
            var response = _restClient.Execute(_request);
            var deserializedObject = new JsonSerializer().Deserialize<NewUserData>(response);
            Console.WriteLine(deserializedObject.Id);

        }

    }
}
