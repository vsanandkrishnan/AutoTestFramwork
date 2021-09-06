using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace AutoTestFramework.UIElements
{
    public class HomePage
    {
        public HomePage()
        {           
            PageFactory.InitElements(Driver.Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector, Using = "h1.entry-title.page-title")]
        public IWebElement HeadLine { get; set; }

        [FindsBy(How=How.XPath,Using = "//img[contains(@class,'image')]")]
        public IWebElement Image { get; set; }
    }
}
