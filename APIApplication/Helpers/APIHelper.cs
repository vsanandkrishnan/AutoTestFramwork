using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIApplication.Helpers
{
    public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public  string baseUrl = "https://reqres.in/";


        /// <summary>
        /// Setting the URL with the endpoint
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns>restClient</returns>
        public RestClient SetUrl(string endPoint)
        {
            var url = Path.Combine(baseUrl, endPoint);
            var restClient = new RestClient(url);
            return restClient;
        }


        /// <summary>
        /// Setting up the rest request for POST
        /// </summary>
        /// <param name="payLoad"></param>
        /// <returns>RestRequest</returns>
        public RestRequest CreatePostRequest(string payLoad)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payLoad, ParameterType.RequestBody);
            return restRequest;
        }


        /// <summary>
        /// GET Request API 
        /// </summary>
        /// <returns>RestRequest</returns>
        public RestRequest CreateGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        /// <summary>
        /// PUT Request API
        /// </summary>
        /// <param name="payLoad"></param>
        /// <returns></returns>
        public RestRequest CreatePutRequest(string payLoad)
        {
            var restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payLoad, ParameterType.RequestBody);
            return restRequest;
        }

        /// <summary>
        /// DELETE Request API
        /// </summary>
        /// <returns></returns>
        public RestRequest CreateDeleteRequest()
        {
            var restRequest = new RestRequest(Method.DELETE);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        /// <summary>
        /// Getting the response
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns>Response</returns>
        public IRestResponse GetResponse(RestClient client,RestRequest request)
        {
           return client.Execute(request);
        }


        /// <summary>
        /// Deserialize the request
        /// </summary>
        /// <typeparam name="DataObjects"></typeparam>
        /// <param name="response"></param>
        /// <returns>Deserialized Object</returns>
        public DataObjects GetContent<DataObjects>(IRestResponse response)
        {
            var content = response.Content;
            DataObjects dataObject = JsonConvert.DeserializeObject<DataObjects>(content);
            return dataObject;

        }
    }
}
