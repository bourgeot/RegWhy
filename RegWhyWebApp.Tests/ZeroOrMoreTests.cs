using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class ZeroOrMoreTests
    {
        [TestMethod]
        public void ZeroOrMoreTest()
        {
            var zero = new RegWhy.GetZeroOrMore(
                new List<IRegWhat>
                    {
                        new GetLiteral("t")
                    });

            Assert.AreEqual("t?",zero.RegExValue);
            var more = new RegWhy.GetZeroOrMore(
                new List<IRegWhat>
                    {
                        new GetLiteral("http")
                    });
            Assert.AreEqual("(http)?", more.RegExValue);

        }
    }
}
