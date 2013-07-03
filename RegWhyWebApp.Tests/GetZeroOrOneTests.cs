using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetZeroOrOneTests
    {
        [TestMethod]
        public void GetZeroOrOneTest()
        {
            var zero = new RegWhy.GetZeroOrOne(
               new List<IRegWhat>
                    {
                        new GetLiteral("t")
                    });

            Assert.AreEqual("t*", zero.RegExValue);
            var more = new RegWhy.GetZeroOrOne(
                new List<IRegWhat>
                    {
                        new GetLiteral("http")
                    });
            Assert.AreEqual("(http)*", more.RegExValue);
        }
    }
}
