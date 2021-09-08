using AutoTestFramework;
using AutoTestFramework.Driver;
using AutoTestFramework.UIElements;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class MenuBarTest
    {
        

        [SetUp]
        public void SetUp()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Configuration.BASE_URL);

        }

        [Test]
        public void MenuTest()
        {
            Menu menu = new Menu();
            var value = menu.TestCases.Displayed;

            Assert.IsTrue(value, "The elements are Not Displayed correctly!");

            

        }

        [TearDown]
        public void TearDown()
        {
            Driver.driver.Quit();

        }

    }
}
