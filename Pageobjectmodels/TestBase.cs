using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pageobjectmodels
{
    public  class TestBase
    {
        public static  IWebDriver Driver { get; set; }

        public TestBase()
        {


        }
        public static void Initialization()
        {
            string browserName = "chrome";
            

        }
    }
}
