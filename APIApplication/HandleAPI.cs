using APIApplication.JsonObjects;
using Newtonsoft.Json;
using RestSharp;

namespace APIApplication
{
    public class HandleAPI
    {
        public static string BASE_URL = @"https://reqres.in/";
        public static string END_POINT_GET = @"/api/users?page=2";

        public ListOfUserResponse GetUser()
        {
            var restClient = new RestClient(BASE_URL);
            var restRequest = new RestRequest(END_POINT_GET, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var users = JsonConvert.DeserializeObject<ListOfUserResponse>(content);
            return users;
        }

    }
}
