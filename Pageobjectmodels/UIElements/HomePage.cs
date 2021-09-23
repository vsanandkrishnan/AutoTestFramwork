using OpenQA.Selenium;
using Pageobjectmodels;
using SeleniumExtras.PageObjects;
namespace AutoTestFramework.UIElements
{
    public class HomePage : TestBase
    {
        public HomePage()
        {           
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How=How.CssSelector, Using = "h1.entry-title.page-title")]
        public IWebElement HeadLine { get; set; }

        [FindsBy(How=How.XPath,Using = "//img[contains(@class,'image')]")]
        public IWebElement Image { get; set; }
    }
}
