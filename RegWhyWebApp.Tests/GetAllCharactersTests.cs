using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetAllCharactersTests
    {
        [TestMethod]
        public void GetAllCharacterTest()
        {
            var all = new RegWhy.RegWhy(new Collection<IRegWhat>
                                            {
                                                new GetLiteral(RegWhy.SpecialCharacters.AllCharactersButNewLine)
                                            });
            Assert.AreEqual(".",all.RegExValue);
            Assert.AreEqual("Get exactly .", all.Explanation);
        }
    }
}
