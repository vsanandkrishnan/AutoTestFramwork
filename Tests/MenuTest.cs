using AutoTestFramework;
using AutoTestFramework.UIElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pageobjectmodels;

namespace Tests
{
    [TestClass]
    public class MenuTest :TestBase
    {
        [TestInitialize]
        public void SetUp()
        {
            Initialization();

        }


        [TestMethod]
        public void MenuDown()
        {
            Menu menu = new Menu();
            var value = menu.TestCases.Displayed;

            Assert.IsTrue(value, "The elements are Not Displayed correctly!");
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.Quit();

        }
    }
}