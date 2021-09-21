using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.UIElements
{
    class TestScenariosPage
    {
        public TestScenariosPage()
        {
            PageFactory.InitElements(Driver.Driver.driver, this);
        }

        [FindsBy(How=How.XPath, Using="//header[@class='mh-loop-header']/h3/a[contains(@href,'login-form')]")]
        public IWebElement LoginForm { get; set; }

    }
}
