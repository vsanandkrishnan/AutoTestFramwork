using OpenQA.Selenium;
using Pageobjectmodels;
using SeleniumExtras.PageObjects;
namespace AutoTestFramework.UIElements
{
    public class UsernameFieldPost:TestBase
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//p//a[contains(@href,'login-form')]")]
        public IWebElement LoginFormLink { get; set; }
    }
}
