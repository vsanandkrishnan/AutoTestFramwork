using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Firefox;
using Microsoft.Edge.SeleniumTools;
using System.IO;
using AutoTestFramework.UIElements;

namespace Helpers.UIHelper
{
    public static class UIHelper
    {
        public static object SeleniumExtras { get; private set; }

        public static void FieldLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }

        public static void SetStyle(IWebDriver driver, IWebElement element, string style, string styeleValue)
        {
            string script = String.Format("arguments[0].style[\"{0}\"]=\"{1}\"", style, styeleValue);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            jsExecutor.ExecuteScript(script, element);
        }
    }
}
