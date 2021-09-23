using OpenQA.Selenium;
using Pageobjectmodels;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.UIElements
{
    public class TestCasesPage:TestBase
    {
        public TestCasesPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//header[@class='mh-loop-header']/h3//a[contains(@href,'register-form')]")]
        public IWebElement UsernameField { get; set; }
    }
}
