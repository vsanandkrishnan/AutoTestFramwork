using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIApplication
{
    public class HandleAPI
    {
        public static string BASE_URL = @"https://reqres.in/";
        public static string END_POINT = @"/api/users?page";

        public ListOfUserDTO GetUser()
        {
            var restClient = new RestClient(BASE_URL);
            var restRequest = new RestRequest(END_POINT, Method.GET);

            restRequest.AddHeader("Accept", "application/json");

            restRequest.RequestFormat = DataFormat.Json;



            IRestResponse response = restClient.Execute(restRequest);

            var content = response.Content;

            var users = JsonConvert.DeserializeObject<ListOfUserDTO>(content);

            return users;

        }
    }
}
