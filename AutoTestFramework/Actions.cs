using AutoTestFramework.UIElements;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.Driver.driver  = new ChromeDriver();
            Driver.Driver.driver.Navigate().GoToUrl(Configuration.BASE_URL);
        }

        public static void FieldLoginForm(string username,string password,string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}
