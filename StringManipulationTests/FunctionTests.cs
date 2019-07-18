using System;
using StringManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulation.Tests
{
    [TestClass()]
    public class FunctionTests
    {

        Functions func = new Functions();

        [TestMethod()]
        public void makeAnagramTest()
        {
            string a = "fcrxzwscanmligyxyvym";
            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            int res = func.makeAnagram(a, b);
            Assert.AreEqual(30, res);
        }

        [TestMethod()]
        public void ExceptTest1()
        {
            string a = "fcrxzwscanmligyxyvym";
            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            var res = func.Except(a, b);
            Assert.AreEqual(20,res);
        }

        [TestMethod()]
        public void ExceptTest2()
        {
            string b = "fcrxzwscanmligyxyvym";
            string a = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            var res = func.Except(a, b);
            Assert.AreEqual(10, res);
        }


        //[TestMethod]
        //public void TestMethod1()
        //{
        //    //            5
        //    //AAAA
        //    //BBBBB
        //    //ABABABAB
        //    //BABABA
        //    //AAABBB
        //    //func.alternatingCharacters("AAAA");
        //    func.alternatingCharacters("AAABBB");
        //}



        //[TestMethod()]
        //public void makeAnagramTest1()
        //{
        //    string a = "fcrxzwscanmligyxyvym";
        //    string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
        //   func.makeAnagram(a, b);
        //    Assert.Fail();
        //}
    }
}


