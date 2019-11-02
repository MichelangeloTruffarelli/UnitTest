using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextExample;

namespace ExampleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            {
                bool resp = Method.Calcolo();
                Assert.AreEqual(true, resp);
            }
        }
        public void Test1()
        {
            {
                bool resp = Method.Calcolo1();
                Assert.AreEqual(false, resp);
            }
        }
        public void Test2()
        {
            {
                bool resp = Method.Calcolo2();
                Assert.AreEqual(true, resp);
            }
        }
        public void Test3()
        {
            {
                bool resp = Method.Calcolo3();
                Assert.AreEqual(false, resp);
            }
        }
    }
}
