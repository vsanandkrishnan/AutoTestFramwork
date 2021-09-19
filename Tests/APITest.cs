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

            var handleAPI = new HandleAPI<ListOfUserResponse>();
            var deserializedContent=handleAPI.GetUser("api/users?page=2");
            Assert.AreEqual("Michael", deserializedContent.data[0].first_name);
        }

        [TestMethod]
        public void APICreateTest()
        {
            string payLoad = @"{
                                ""name"": ""morpheus"",
                                ""job"": ""leader""}";
            var handleAPI = new HandleAPI<CreateUserResponse>();
            var deserializeContent = handleAPI.CreateUser("api/users", payLoad);
            Assert.AreEqual("morpheus", deserializeContent.name);
            Assert.AreEqual("leader", deserializeContent.job);
        }
    }
}
