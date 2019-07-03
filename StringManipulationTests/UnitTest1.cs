using System;
using StringManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //            5
            //AAAA
            //BBBBB
            //ABABABAB
            //BABABA
            //AAABBB
            //Class1.alternatingCharacters("AAAA");
            Class1.alternatingCharacters("AAABBB");
        }
    }
}
