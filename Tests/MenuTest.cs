using AutoTestFramework;
using AutoTestFramework.Driver;
using AutoTestFramework.UIElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MenuTest
    {
        [TestInitialize]
        public void SetUp()
        {
            Helper.InitializeDriver("edge");

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
            Driver.driver.Quit();

        }
    }
}
