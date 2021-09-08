using AutoTestFramework;
using AutoTestFramework.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Tests
{
    public class LoginTest
    {
        IAlert alert;

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Messages.GreenMessage("Successfully Navigated to the Login form Through Menu");
            Thread.Sleep(3000);
            Actions.FieldLoginForm(Configuration.Credentials.Valid.Username, Configuration.Credentials.Valid.Password, Configuration.Credentials.Valid.Password);
            Thread.Sleep(3000);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Configuration.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();

        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}