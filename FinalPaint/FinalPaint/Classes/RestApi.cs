using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalPaint.Classes
{
    class RestApi
    {
        private static RestApi _restApi;
        private IRestClient _restClient;
        private RestRequest _request;
        private string _userId = "0";

        private RestApi()
        {
            _restClient = new RestClient();
        }


        public static RestApi Create()
        {
            if (_restApi == null)
            {
                _restApi = new RestApi();
            }
            return _restApi;
        }
        public void ClearUserId()
        {
            _userId = "0";
        }
        public string GetUserId()
        {
            return _userId;
        }

        public int RegistrationRequest(NewUserData newUserData)
        {
            _request = new RestRequest { Resource = "https://localhost:44341/auth/register", Method = Method.POST };
            _request.AddJsonBody(newUserData);
            var response = _restClient.Execute(_request);
            if(response.StatusCode == 0 )
            {
                return -2;
            }
            if (response.StatusCode==System.Net.HttpStatusCode.OK)
            {
                var deserializedObject = new JsonSerializer().Deserialize<NewUserData>(response);
                _userId = deserializedObject.Id;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public int AuthorizationRequest(string email, string password)
        {
            _request = new RestRequest { Resource = "https://localhost:44341/auth/authorize", Method = Method.GET };
            _request.AddQueryParameter("email", email);
            _request.AddQueryParameter("password", password);
            var response = _restClient.Execute(_request);
            //id
            if (response.StatusCode == 0)
            {
                return -2;
            }

            var deserializedObject =_userId= new JsonSerializer().Deserialize<string>(response);

            if (deserializedObject != null && deserializedObject != "" && deserializedObject != "-1")
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public void RequestTestWithPicture()
        {
          

            _restClient = new RestClient();

            RestRequest request = new RestRequest { Resource = "https://localhost:44341/pictures/savepicture", Method = Method.POST };
            PictureData pd = new PictureData
            {
                UserId = 1,
                Type = PictureType.JSON,
                Picture = "Serialized picture string"

            };

            request.AddJsonBody(pd);
            var response = _restClient.Execute(request);
            var deserializedObject = response.Content;
            Console.WriteLine(deserializedObject);
        }

        public void SavePicture(PictureData pd)
        {
            _restClient = new RestClient();

            RestRequest request = new RestRequest { Resource = "https://localhost:44341/pictures/savepicture", Method = Method.POST };
           

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
            List<PictureData> deserializedObject = new JsonSerializer().Deserialize<List<PictureData>>(response);
            Console.WriteLine(deserializedObject);

        }


        public SingleUserStatistics GetUserStatisticsRequest()
        {
            _request = new RestRequest { Resource = "https://localhost:44341/auth/getStatistics", Method = Method.GET };
            _request.AddQueryParameter("_userId", _userId);
            var response = _restClient.Execute(_request);
            var deserializedObject = new JsonSerializer().Deserialize<SingleUserStatistics>(response);
            return deserializedObject;
        }
    }



    }

