using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            Driver.Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            menu.Selectors.Click();

            var value = Configuration.Credentials.Invalid.Username.FourCharacters;
        }
    }
}
