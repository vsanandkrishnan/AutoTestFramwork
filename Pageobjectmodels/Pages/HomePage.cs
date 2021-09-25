using OpenQA.Selenium;

namespace TestBaseLibrary.Pages
{
    public class HomePage :TestBase
    {
        /// <summary>
        /// CRMPROLogo Text on Homepage
        /// </summary>
        public IWebElement CRMPROLogoText => Driver.FindElement(By.CssSelector("td.logo_text"));

        /// <summary>
        /// Home Tile on Home Page
        /// </summary>
        public IWebElement HomeTile => Driver.FindElement(By.XPath("//a[@title='Home']"));


        /// <summary>
        /// Returns boolean value
        /// </summary>
        /// <returns></returns>
        public bool IsCRMPROLogoText() => CRMPROLogoText.Displayed;

        /// <summary>
        /// Returns boolean value
        /// </summary>
        /// <returns></returns>
        public bool IsHomeTileDisplayed() => HomeTile.Displayed;


    }
}
