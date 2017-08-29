using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;

namespace Test
{
    [TestClass]
    public class ClientTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(new Clientes().sayHello(), "hola");
        }
    }
}
