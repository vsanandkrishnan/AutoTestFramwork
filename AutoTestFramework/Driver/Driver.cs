﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTestFramework.Driver
{
    public static  class Driver
    {
        public static IWebDriver driver = new ChromeDriver();
    }
}
