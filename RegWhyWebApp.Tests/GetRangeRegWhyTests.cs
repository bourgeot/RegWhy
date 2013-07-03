using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetRangeRegWhyTests
    {
        [TestMethod]
        public void GetRangeWhyTest()
        {
            var range = new RegWhy.GetRange(new List<IRegWhat> {new GetLiteral("t")}, 1, 3);
            Assert.AreEqual("t{1,3}",range.RegExValue);
            var reg = new System.Text.RegularExpressions.Regex(range.RegExValue);
            bool firstTest = reg.IsMatch("t");
            Assert.IsTrue(firstTest);
            bool secondTest = reg.IsMatch("ttt");
            Assert.IsTrue(secondTest);
            bool thirdTest = reg.IsMatch("hjh");
            Assert.IsFalse(thirdTest);
            var rangeWord = new RegWhy.GetRange(new List<IRegWhat> { new GetLiteral("the") }, 1, 3);
            Assert.AreEqual("(the){1,3}", rangeWord.RegExValue);
           reg =new Regex(rangeWord.RegExValue);
            Assert.IsTrue(reg.IsMatch("the"));
            Assert.IsTrue(reg.IsMatch("thethe"));
            Assert.IsTrue(reg.IsMatch("tsthe"));

        }
    }
}
