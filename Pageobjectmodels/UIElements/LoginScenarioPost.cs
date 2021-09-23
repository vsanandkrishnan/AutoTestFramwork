using OpenQA.Selenium;
using Pageobjectmodels;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTestFramework.UIElements
{
    public class LoginScenarioPost:TestBase
    {
        public LoginScenarioPost()
        {
            PageFactory.InitElements(Driver, this);

        }

        [FindsBy(How=How.CssSelector,Using = "input[name='userid']")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How=How.CssSelector,Using = "input[name='passid']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How=How.CssSelector,Using = "input[name='repeatpassid']")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How =How.CssSelector, Using = "input[value='LOGIN']")]
        public IWebElement LoginButton { get; set; }

    }
}
