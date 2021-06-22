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
            if (_restApi == null)
            {
                _restApi = new RestApi();
            }
            return _restApi;
        }

        public void RequestTest(NewUserData newUserData)
        {
            _request = new RestRequest { Resource = "https://localhost:44341/auth/register", Method = Method.POST };
            _request.AddJsonBody(newUserData);
            var response = _restClient.Execute(_request);
            var deserializedObject = new JsonSerializer().Deserialize<NewUserData>(response);

        }

        public bool AuthorizationRequest(string email, string password)
        {
            _request = new RestRequest { Resource = "https://localhost:44341/auth/authorize", Method = Method.GET };
            _request.AddQueryParameter("email", email);
            _request.AddQueryParameter("password", password);
            var response = _restClient.Execute(_request);
            //id
            var deserializedObject = new JsonSerializer().Deserialize<string>(response);
            if (deserializedObject != null && deserializedObject != "")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
