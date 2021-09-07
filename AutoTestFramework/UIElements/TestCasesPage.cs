using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.UIElements
{
    class TestCasesPage
    {
        public TestCasesPage()
        {
            PageFactory.InitElements(Driver.Driver.driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//header[@class='mh-loop-header']/h3//a[contains(@href,'register-form')]")]
        public IWebElement UsernameField { get; set; }
    }
}
