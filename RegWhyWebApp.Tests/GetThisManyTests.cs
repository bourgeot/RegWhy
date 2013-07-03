using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetThisManyTests
    {
        [TestMethod]
        public void TestBasicFunction()
        {
            var getbasic = new RegWhy.GetThisMany(new List<IRegWhat>{new GetLiteral(".")}, 1);
            Assert.AreEqual(".",getbasic.RegExValue);
            var getmultiple = new RegWhy.GetThisMany(new List<IRegWhat> { new GetLiteral("t") }, 3);
            Assert.AreEqual("ttt", getmultiple.RegExValue);
            var getThe = new RegWhy.GetThisMany(new List<IRegWhat> { new GetLiteral("t"), new GetLiteral("h"),new GetLiteral("e") }, 1);
            Assert.AreEqual("the", getThe.RegExValue);
        }
    }
}
