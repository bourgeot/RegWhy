using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetOneOrMoreTests
    {
        [TestMethod]
        public void GetOneOrMoreTest()
        {
            var zero = new RegWhy.GetOneOrMore(
               new List<IRegWhat>
                    {
                        new GetLiteral("t")
                    });

            Assert.AreEqual("t+", zero.RegExValue);
            var more = new RegWhy.GetOneOrMore(
                new List<IRegWhat>
                    {
                        new GetLiteral("http")
                    });
            Assert.AreEqual("(http)+", more.RegExValue);
        }
    }
}
