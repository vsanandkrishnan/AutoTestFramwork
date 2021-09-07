using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.UIElements
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.Driver.driver, this);
        }

        [FindsBy(How=How.CssSelector, Using ="//a[text()='Introduction']")]
        public IWebElement Intoduction { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//a[text()='Special Elements']")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//a[text()='About']")]
        public IWebElement About { get; set; }


    }
}
