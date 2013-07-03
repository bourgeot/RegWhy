using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetSpecialCharactersTest
    {
        [TestMethod]
        public void AllValuesTest()
        {
            var allButNew = new GetSpecialCharacter(RegWhy.SpecialCharacters.AllCharactersButNewLine);
            Assert.AreEqual(".",allButNew.RegExValue);
            Assert.AreEqual("All characters but new line", allButNew.Explanation);

        }
    }
}
