using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Windows.Forms;

namespace FinalPaint.Classes
{
    class RestApi
    {
  
        public void RequestTest()
        {
            IRestClient _restClient;
 
            _restClient = new RestClient();


            RestRequest request = new RestRequest { Resource = "https://localhost:44341/auth/register", Method = Method.POST };
            NewUserData newUserData = new NewUserData
            {
                Email = "egorusdnepr9@gmail.com",
                FirstName = "Mariia",
                LastName = "Yakovenko",
                UserPassword = "I_HATE_IT"
            };

     

            request.AddJsonBody(newUserData);
            var response = _restClient.Execute(request);
            var deserializedObject = new JsonSerializer().Deserialize<NewUserData>(response);
            Console.WriteLine(deserializedObject.Id);

        }
    }
}
