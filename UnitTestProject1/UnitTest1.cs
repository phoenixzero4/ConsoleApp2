using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test()
        {
            string a = "Hello";
            string b = "World!";
            string x = "HelloWorld!";
            ConsoleApp2.tests t = new ConsoleApp2.tests();
            a = t.concat(a, b);
           
            Assert.AreEqual(x, a);
            string copy = t.cpy(a);
            Assert.AreEqual(copy, a);
            string empty = "";
            Boolean ff = t.testEmpty(empty);
            Assert.IsFalse(ff);
           // Assert.IsFalse(t.testEmpty(empty)); // should fail
            Assert.IsTrue(t.cmpr(a, a));
          //  Assert.IsFalse(t.cmpr(a, a));  // should fail
          
          
        }
    }
}
