using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Firefox;
using Microsoft.Edge.SeleniumTools;
using System.IO;

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

       
        public static void WaitForElement(IWebDriver driver, IWebElement element, int seconds = 10, bool throwException = false)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)element));
        }

        public static void SetStyle(IWebDriver driver, IWebElement element, string style, string styeleValue)
        {
            string script = String.Format("arguments[0].style[\"{0}\"]=\"{1}\"", style, styeleValue);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            jsExecutor.ExecuteScript(script, element);
        }

        
        public static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
        {
            actions.ClickAndHold(from)
                   .MoveToElement(to)
                   .MoveByOffset(x, y)
                   .Release()
                   .Build()
                   .Perform();
        }

        
        public static string FileReaderText(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string textLines = "";
            foreach (var line in lines)
            {
                textLines += line + " ";
            }

            return textLines;
        }

        
        public static void XmlReaderStarter()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int lastIndex = currentDirectory.IndexOf("bin");

            string path = currentDirectory.Substring(0, lastIndex);

        }
    }
}
