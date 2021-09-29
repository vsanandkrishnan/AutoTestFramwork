using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBaseLibrary.Pages;
using TestBaseLibrary.PageObjects;
using TestBaseLibrary;
using System.Threading;
using EnvironmentConfiguration;
using Helpers.Enums;
using EnvironmentConfiguration.Configurationfiles;

namespace Tests
{
    [TestClass]
    public class CRMLOginTest :TestBase
    {
        /// <summary>
        /// Page Initialization
        /// </summary>
        LoginPage page;
        HomePage homePage;

        /// <summary>
        /// Initializing UserName and PassWord
        /// </summary>
        public static string userName;
        public static string password;

        public static UserDetails userDetails => XMlConfiguration.GetUserDetails(ConfigFiles.UserFiles.ToString());

        [TestInitialize]
        public void SetUp()
        {
            Initialization();
            WaitExclusiveToAllElements(Driver, 10);
            page = new LoginPage();
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
