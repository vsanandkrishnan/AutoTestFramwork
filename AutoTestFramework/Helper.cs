using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Firefox;
using Microsoft.Edge.SeleniumTools;
using System.IO;

namespace AutoTestFramework
{
    public static class Helper
    {
        public static void InitializeDriver(string browserName)
        {
             Driver.Driver.driver = null;

            //Handling different browsers.
            if (browserName.ToLower().Contains("chrome"))
            {
                Driver.Driver.driver = new ChromeDriver();
                Driver.Driver.driver.Navigate().GoToUrl(Configuration.BASE_URL);
            }
            else if (browserName.ToLower().Contains("firefox"))
            {
                Driver.Driver.driver = new FirefoxDriver();
                Driver.Driver.driver.Navigate().GoToUrl(Configuration.BASE_URL);
            }
            else if (browserName.ToLower().Contains("edge"))
            {
                var options = new EdgeOptions();
                options.UseChromium = true;
                Driver.Driver.driver = new EdgeDriver(options);
                Driver.Driver.driver.Navigate().GoToUrl(Configuration.BASE_URL);
            }        

        }

        public static void FieldLoginForm(string username,string password,string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }

        //Handling Explicit waits
        public static void WaitForElement (IWebDriver driver,IWebElement element, int seconds=10,bool throwException=false)
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

        //Handling Actions class
        public static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
        {
            actions.ClickAndHold(from)
                   .MoveToElement(to)
                   .MoveByOffset(x, y)
                   .Release()
                   .Build()
                   .Perform();
        }

        //File reader text
        public static string FileReaderText(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string textLines = "";
            foreach(var line in lines)
            {
                textLines += line+ " ";
            }

            return textLines;
        }

        //Xml Reader
        public static void XmlReaderStarter()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int lastIndex = currentDirectory.IndexOf("bin");

            string path = currentDirectory.Substring(0, lastIndex);

        }
    }
}
