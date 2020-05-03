using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Texi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Taxi taxi = new Taxi();
            Assert.AreEqual(6, taxi.Cost(1,0));
            Assert.AreEqual(7, taxi.Cost(3, 0));
            Assert.AreEqual(13, taxi.Cost(10, 0));
            Assert.AreEqual(7, taxi.Cost(2, 3));
        }
    }
}
