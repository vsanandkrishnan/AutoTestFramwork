using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestBaseLibrary.PageObjects
{
    public class LoginPage : TestBase
    {
        public IWebElement UserName => Driver.FindElement(By.Name("username"));
        public IWebElement Password => Driver.FindElement(By.Name("password"));
        public IWebElement SubmitButton => Driver.FindElement(By.CssSelector("input[type='submit']"));

        public void ClickOnSubmitButton() => this.SubmitButton.Click();

    }
}
