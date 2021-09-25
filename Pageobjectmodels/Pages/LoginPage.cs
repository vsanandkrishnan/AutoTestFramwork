using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestBaseLibrary.Pages;

namespace TestBaseLibrary.PageObjects
{
    public class LoginPage : TestBase
    {
        /// <summary>
        /// Text field Username
        /// </summary>
        public IWebElement UserName => Driver.FindElement(By.Name("username"));

        /// <summary>
        /// Text Field Password
        /// </summary>
        public IWebElement Password => Driver.FindElement(By.Name("password"));

        /// <summary>
        /// Text Field Submit Button
        /// </summary>
        public IWebElement SubmitButton => Driver.FindElement(By.CssSelector("input[type='submit']"));

        /// <summary>
        /// CRM Logo Displayed
        /// </summary>
        public IWebElement CRMLogo => Driver.FindElement(By.CssSelector(".navbar-brand"));

        /// <summary>
        /// Is CRM Logo Displayed
        /// </summary>
        /// <returns></returns>
        public bool IsCRMLogoDisplayed() => CRMLogo.Displayed;

        /// <summary>
        /// Click On SubmitButton
        /// </summary>
        public void ClickOnSubmitButton() => this.SubmitButton.Click();

        /// <summary>
        /// Login to CRM Portal
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>HomePage</returns>
        public HomePage LoginIntoCRMPortal(string userName,string password)
        {
            this.UserName.SendKeys(userName);
            this.Password.SendKeys(password);
            this.ClickOnSubmitButton();
            return new HomePage();
        }

        /// <summary>
        /// Title of home page
        /// </summary>
        /// <returns></returns>
        public string TitleOfLoginPage() => Driver.Title;

    }
}
