using AutoTestFramework.UIElements;
using System.Threading;

namespace AutoTestFramework
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            Driver.Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            NavigateTo.LoginFormThroughTheMenu();

            Messages.GreenMessage("Successfully Navigated to the Login form Through Menu");

            Thread.Sleep(3000);

            Driver.Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            NavigateTo.LoginFormThroughThePost();

            Messages.GreenMessage("Successfully Navigated to the Login form Through Post");

            Thread.Sleep(3000);

            Driver.Driver.driver.Quit();
        }
    }
}
