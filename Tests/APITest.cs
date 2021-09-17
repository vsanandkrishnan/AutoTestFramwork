using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using APIApplication;

namespace Tests
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void APIGetTest()
        {
            var handleAPIGET = new HandleAPI();
            var response=handleAPIGET.GetUser();
            Assert.AreEqual(2, response.page);
            Assert.AreEqual("Michael", response.data[0].first_name);

        }
    }
}
