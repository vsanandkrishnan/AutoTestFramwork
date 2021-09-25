using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBaseLibrary.Pages;
using TestBaseLibrary.PageObjects;
using TestBaseLibrary;
using System.Threading;
using EnvironmentConfiguration;

namespace Tests
{
    [TestClass]
    public class CRMLOginTest :TestBase
    {
        LoginPage page;
        HomePage homePage;

        public static string userName;
        public static string password;

        [TestInitialize]
        public void SetUp()
        {
            Initialization();
            page = new LoginPage();
            var userDetails=XMlConfiguration.GetUserDetails();
            foreach(var user in userDetails.userList)
            {
                if (user.UserId == 1)
                {
                    userName = user.UserName;
                    password = user.Password;
                }
            }

            
        }

        [TestMethod]
        public void LoginToCRM()
        {
            page.IsCRMLogoDisplayed();
            Assert.AreEqual(page.TitleOfLoginPage(), "CRMPRO - CRM software for customer relationship management, sales, and support.");
            homePage= page.LoginIntoCRMPortal(userName, password);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
