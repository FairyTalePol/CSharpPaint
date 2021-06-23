using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
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

        public void RequestTestWithPicture()
        {
            IRestClient _restClient;

            _restClient = new RestClient();

            RestRequest request = new RestRequest { Resource = "https://localhost:44341/pictures/savepicture", Method = Method.POST };
            PictureData pd = new PictureData
            {
                UserId = 1,
                Type = "JSON",
                Picture = "Serialized picture string"

            };

            request.AddJsonBody(pd);
            var response = _restClient.Execute(request);
            var deserializedObject = response.Content;
            Console.WriteLine(deserializedObject);
        }


        public void RequestTestGetAllPictures()
        {
            IRestClient _restClient;

            _restClient = new RestClient();

            RestRequest request = new RestRequest { Resource = "https://localhost:44341/pictures/userid", Method = Method.GET };


            request.AddQueryParameter("userId", "1");
            var response = _restClient.Execute(request);
            List<PictureData> deserializedObject= new JsonSerializer().Deserialize<List<PictureData>>(response);
            Console.WriteLine(deserializedObject);

        }



    }
}
