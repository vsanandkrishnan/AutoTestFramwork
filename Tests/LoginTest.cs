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
            Actions.FieldLoginForm(Configuration.Credentials.Valid.Username, Configuration.Credentials.Valid.Password, Configuration.Credentials.Valid.Password);
            alert = Driver.driver.SwitchTo().Alert();

            //Setting Up Assert
            Assert.AreEqual(Configuration.AlertMessages.SuccessfulLogin, alert.Text);
            alert.Accept();

        }

        [Test]
        public void InvalidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FieldLoginForm(Configuration.Credentials.Invalid.Username.ThirteenCharacters, Configuration.Credentials.Invalid.Password.InvalidPassWord, Configuration.Credentials.Invalid.Password.InvalidRepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();

            //Setting Up Assert
            Assert.AreEqual(Configuration.AlertMessages.Invalid14CharLogin, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}