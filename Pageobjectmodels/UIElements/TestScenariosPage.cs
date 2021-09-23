using OpenQA.Selenium;
using Pageobjectmodels;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.UIElements
{
    public class TestScenariosPage :TestBase
    {
        public TestScenariosPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How=How.XPath, Using="//header[@class='mh-loop-header']/h3/a[contains(@href,'login-form')]")]
        public IWebElement LoginForm { get; set; }

    }
}
