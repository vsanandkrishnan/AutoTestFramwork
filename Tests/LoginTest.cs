using AutoTestFramework;
using AutoTestFramework.Driver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Tests
{
    [TestClass]
    public class LoginTest
    {
        IAlert alert;

        [TestInitialize]
        public void Initialize()
        {
            Helper.InitializeDriver("edge");

        }

        [TestMethod]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Helper.FieldLoginForm(Configuration.Credentials.Valid.Username, Configuration.Credentials.Valid.Password, Configuration.Credentials.Valid.Password);
            alert = Driver.driver.SwitchTo().Alert();

            //Setting Up Assert
            Assert.AreEqual(Configuration.AlertMessages.SuccessfulLogin, alert.Text);
            alert.Accept();

        }

        [Ignore]
        [TestMethod]
        public void InvalidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Helper.FieldLoginForm(Configuration.Credentials.Invalid.Username.ThirteenCharacters, Configuration.Credentials.Invalid.Password.InvalidPassWord, Configuration.Credentials.Invalid.Password.InvalidRepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();

            //Setting Up Assert
            Assert.AreEqual(Configuration.AlertMessages.Invalid14CharLogin, alert.Text);
            alert.Accept();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
