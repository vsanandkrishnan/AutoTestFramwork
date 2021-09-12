using AutoTestFramework;
using AutoTestFramework.Driver;
using AutoTestFramework.UIElements;
using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class MenuBarTest
    {
        

        [SetUp]
        public void SetUp()
        {
            Helper.InitializeDriver("edge");

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
