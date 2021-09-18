using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIApplication;
using APIApplication.Helpers;
using APIApplication.JsonObjects;

namespace Tests
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void APIGetTest()
        {

            var apiHelper = new APIHelper<ListOfUserResponse>();
            var url = apiHelper.SetUrl("api/users?page=2");
            var request = apiHelper.CreateGetRequest();
            var response = apiHelper.GetResponse(url, request);
            var deserializedObject = apiHelper.GetContent<ListOfUserResponse>(response);
            Assert.AreEqual("Michael", deserializedObject.data[0].first_name);
        }

        [TestMethod]
        public void APICreateTest()
        {
            string payLoad = @"{
                                ""name"": ""morpheus"",
                                ""job"": ""leader""}";
            var apiHelper = new APIHelper<CreateUserResponse>();
            var url = apiHelper.SetUrl("api/users");
            var request = apiHelper.CreatePostRequest(payLoad);
            var response = apiHelper.GetResponse(url, request);
            var deserializeContent = apiHelper.GetContent<CreateUserResponse>(response);
            Assert.AreEqual("morpheus", deserializeContent.name);
            Assert.AreEqual("leader", deserializeContent.job);
        }
    }
}
