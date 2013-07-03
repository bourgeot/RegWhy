using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegWhy;

namespace RegWhyWebApp.Tests
{
    [TestClass]
    public class GetTests
    {
        [TestMethod]
        public void JustOneGetTest()
        {
            var justOne = new  RegWhy.Get(new List<IRegWhat>
                                         {
                                             new GetLiteral("the")
                                              });
            Assert.AreEqual("the",justOne.RegExValue);
            var justOneWithParam = new RegWhy.Get(new List<IRegWhat>
                                         {
                                             new GetLiteral("the")
                                              },Get.TypeOfSearch.OnlyOne);
            Assert.AreEqual("the", justOneWithParam.RegExValue);
            var oneOrMore = new RegWhy.Get(new List<IRegWhat>
                                         {
                                             new GetLiteral("the")
                                              }, Get.TypeOfSearch.OneOrMore);
            Assert.AreEqual("(the)+", oneOrMore.RegExValue);
            var zeroOrOne = new RegWhy.Get(new List<IRegWhat>
                                         {
                                             new GetLiteral("the")
                                              }, Get.TypeOfSearch.ZeroOrOne);
            Assert.AreEqual("(the)?", zeroOrOne.RegExValue);
            var zeroOrMore = new RegWhy.Get(new List<IRegWhat>
                                         {
                                             new GetLiteral("the")
                                              }, Get.TypeOfSearch.ZeroOrMore);
            Assert.AreEqual("(the)*", zeroOrMore.RegExValue);
        }
    }
}
