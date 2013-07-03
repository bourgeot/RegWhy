using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class LiteralTests
    {
        [TestMethod]
        public void LiteralTest()
        {
            var lit =new  RegWhy.GetLiteral("test");
            Assert.AreEqual("test",lit.RegExValue);
            Assert.AreEqual("Get exactly test",lit.Explanation);
            
            
        }
        [ExpectedException(typeof(FormatException))]
        public void ExpectLiteralError()
        {
            var lit = new RegWhy.GetLiteral("");
        }
    }
}
