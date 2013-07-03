using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class RegWhyClassTests
    {
        [TestMethod]
        public void BlankTest()
        {
            var rg = new RegWhy.RegWhy(new Collection<IRegWhat>() {new GetLiteral("x")});
            Assert.AreEqual("x", rg.RegExValue);
            Assert.AreEqual("", rg.GetTextToSearch());
            var regex = new Regex("x");
            Assert.AreEqual(regex.IsMatch("x"), rg.ToRegEx().IsMatch("x"));
        }

        [TestMethod]
        public void TestList()
        {
            var rg = new RegWhy.RegWhy(new Collection<IRegWhat>() { new GetLiteral("x") });
            Assert.AreEqual("x", rg.RegExValue);
            Assert.AreEqual("", rg.GetTextToSearch());
        }
}
}