using APIApplication.Helpers;
using APIApplication.JsonObjects;
using Newtonsoft.Json;
using RestSharp;

namespace APIApplication
{
    public class HandleAPI<T>
    {
        /// <summary>
        /// Getting the users with the help of GET CALL
        /// </summary>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public ListOfUserResponse GetUser(string endPoint)
        {
            var apiHelper = new APIHelper<ListOfUserResponse>();
            var url = apiHelper.SetUrl(endPoint);
            var request = apiHelper.CreateGetRequest();
            var response = apiHelper.GetResponse(url, request);
            var content = apiHelper.GetContent<ListOfUserResponse>(response);
            return content;
        }

        /// <summary>
        /// Create User POST Call Method
        /// </summary>
        /// <param name="endPoint"></param>
        /// <param name="payLoad"></param>
        /// <returns></returns>
        public CreateUserResponse CreateUser(string endPoint,dynamic payLoad)
        {
            var apiHelper = new APIHelper<CreateUserResponse>();
            var url = apiHelper.SetUrl(endPoint);
            var jsonRequest = apiHelper.Serialize(payLoad);
            var request = apiHelper.CreatePostRequest(jsonRequest);
            var response = apiHelper.GetResponse(url, request);
            var content = apiHelper.GetContent<CreateUserResponse>(response);
            return content;
        }



    }
}
