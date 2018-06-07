using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var result = Program.Add(1, 2);

            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void TestMethod2()
        {

            var result = Program.Multi(3, 2);

            Assert.AreEqual(6, result);

        }
    }
}
