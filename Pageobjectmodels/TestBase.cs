using EnvironmentConfiguration;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pageobjectmodels
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


        /// <summary>
        /// Initializing the browsers bases on the browser type passed through the settings file
        /// </summary>
        public static void Initialization()
        {
            Settings.GetData();          
            string browserName = Settings.config.Browser.ToLower();
            string url = Settings.config.URL;
            string headless = Settings.config.Headless;
            if (browserName.Equals("chrome"))
            {
                chromeOptions = new ChromeOptions();
                if (!headless.Equals(""))
                {
                    chromeOptions.AddArgument(headless);
                }
                Driver = new ChromeDriver(chromeOptions);
            }else if (browserName.Equals("firefox"))
            {
                firefoxOptions = new FirefoxOptions();
                firefoxOptions.AddArgument(headless);
                Driver = new FirefoxDriver();
            }else if (browserName.Equals("edge"))
            {
                edgeOptions = new EdgeOptions();
                edgeOptions.AddArgument(headless);
                Driver = new EdgeDriver();
            }

            Driver.Navigate().GoToUrl(url);
        }

        
    }
}
