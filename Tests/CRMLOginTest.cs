using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestBaseLibrary;
using TestBaseLibrary.PageObjects;


namespace Tests
{
    [TestClass]
    public class CRMLOginTest :TestBase
    {
        LoginPage page;

        [TestInitialize]
        public void SetUp()
        {
            Initialization();
        }

        [TestMethod]
        public void LoginToCRM()
        {
            page = new LoginPage();
            page.UserName.SendKeys("batchautomation");
            page.Password.SendKeys("Test@12345");
           // page.CLickOnSubmitButton();

        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
