using EnvironmentConfiguration;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBaseLibrary
{
    public  class TestBase
    {
        /// <summary>
        /// IWebDriver Initialization
        /// </summary>
        public static  IWebDriver Driver { get; set; }

        /// <summary>
        /// Initilization of different browser Options
        /// </summary>
        public static ChromeOptions chromeOptions;
        public static FirefoxOptions firefoxOptions;
        public static EdgeOptions edgeOptions;


        public static WebDriverWait wait;


        /// <summary>
        /// Initializing the browsers bases on the browser type passed through the settings file
        /// </summary>
        public static void Initialization()
        {
            Settings.GetData();          
            string browserName = Settings.config.Browser.ToLower();
            string url = Settings.config.URL;
            bool headless = Settings.config.Headless;
            if (browserName.Equals("chrome"))
            {
                chromeOptions = new ChromeOptions();
                if (headless.Equals(true))
                {
                    chromeOptions.AddArgument("headless");
                }
                Driver = new ChromeDriver(chromeOptions);
            }else if (browserName.Equals("firefox"))
            {
                firefoxOptions = new FirefoxOptions();
                if (headless.Equals(true))
                {
                    firefoxOptions.AddArgument("headless");
                }
                Driver = new FirefoxDriver();
            }else if (browserName.Equals("edge"))
            {
                edgeOptions = new EdgeOptions();
                if (headless.Equals(true))
                {
                    edgeOptions.AddArgument("headless");
                }
                Driver = new EdgeDriver();
            }

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
            
        }

        /// <summary>
        /// Implicit Wait to the entire test page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="seconds"></param>
        public static void WaitExclusiveToAllElements(IWebDriver driver,int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
        
        /// <summary>
        /// Waiting for an interval with a polling time
        /// </summary>
        /// <param name="totalTime"></param>
        /// <param name="pollingTime"></param>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        /// <returns>Returns the webElement from the UI</returns>
        public static IWebElement FluentWaitForInterval(int totalTime,int pollingTime,By element,IWebDriver driver)
        {
            wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(totalTime))
            {
                PollingInterval = TimeSpan.FromSeconds(pollingTime),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            var foo = wait.Until(drv => drv.FindElement(element));

            return foo;
        }

        public static void AddHeadlessParameter(object headlessOption)
        {
            
        }
    }
}
