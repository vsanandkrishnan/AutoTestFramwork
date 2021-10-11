using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIApplication;
using APIApplication.JsonObjects;
using AventStack.ExtentReports;
using Tests.TestData;

namespace Tests
{
    [TestClass]
    public class APITest
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void SetUp(TestContext testContext)
        {
            var dir = testContext.TestRunDirectory;
            Reporter.SetUpExtentReport("API Regression Test", "API Regression Test", dir);
        }

        [TestInitialize]
        public void SetUpTest()
        {
            Reporter.CreateText(TestContext.TestName);
        }

        [TestMethod]
        public void APIGetTest()
        {

            var handleAPI = new HandleAPI<ListOfUserResponse>();
            var deserializedContent = handleAPI.GetUser("api/users?page=2");
            Assert.AreEqual("Michael", deserializedContent.data[0].first_name);
        }

        [TestMethod]
        public void APICreateTest()
        {
            var users = new CreateUserRequest();
            var values= CsvReaderData.CsvReaderMethod<CreateUserRequest>();
            foreach(var val in values)
            {
                users.name = val.name;
                users.job = val.job;
            }
            var handleAPI = new HandleAPI<CreateUserResponse>();
            var deserializeContent = handleAPI.CreateUser("api/users", users);
            
            Assert.AreEqual(users.name, deserializeContent.name);
            Reporter.LogToReport(Status.Info, "First Name Does not Match");
            Assert.AreEqual(users.job, deserializeContent.job);
            Reporter.LogToReport(Status.Info, "Job Description Does Not Match");
        }


        [TestCleanup]
        public void CleanUpTest()
        {
            var testStatus = TestContext.CurrentTestOutcome;
            Status logStatus;

            switch (testStatus)
            {
                case UnitTestOutcome.Failed:
                    logStatus = Status.Fail;
                    Reporter.TestStatus(logStatus.ToString());
                    break;
                case UnitTestOutcome.Passed:
                    logStatus = Status.Pass;
                    Reporter.TestStatus(logStatus.ToString());
                    break;
                default:
                    break;
            }
        }

        [ClassCleanup]
        public static void CleanUp()
        {

            Reporter.FlushReport();
        }
    }
}