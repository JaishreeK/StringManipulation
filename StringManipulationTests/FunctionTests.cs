using System;
using StringManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace StringManipulationTests
{
    [TestClass]
    public class FunctionTests
    {
        Functions func = new Functions();
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

        [TestMethod()]
        public void solutionTest()
        {
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
            int r =  func.solution(A);
            Assert.AreEqual(5,r);
        }

        //[TestMethod()]
        //public void makeAnagramTest()
        //{
        //    string a = "fcrxzwscanmligyxyvym";
        //    string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
        //   func.makeAnagram(a, b);
        //    Assert.Fail();
        //}
        
    }
}
