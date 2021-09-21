using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace AutoTestFramework.UIElements
{
    class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.Driver.driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//p//a[contains(@href,'login-form')]")]
        public IWebElement LoginFormLink { get; set; }
    }
}
