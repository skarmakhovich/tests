using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculatorNS;
using ClassLibrary1;

namespace CalculatorNS.Tests
{
    [TestClass()]
    public class EssentialOperationsTest
    {
        [TestMethod()]
        public void SumTest()
        {
            var Calculator = new Calculator();
            var result = Calculator.Sum(1, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void minusTest()
        {
            var Calculator = new Calculator();
            var result = Calculator.Minus(1, 2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void methodWihoutFullCoverageTest()
        {
            var Calculator = new Calculator();
            var result = Calculator.methodWithoutFullCoverage(10);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void trueLogin()
        {
            var Exercise1 = new Exercise1();
            bool result = Exercise1.login("user", "pass");
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void fail30MUer()
        {
            var Exercise1 = new Exercise1();
            bool result = Exercise1.login("user1111111111111111111111111111111", "pass");
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void fail30MPass()
        {
            var Exercise1 = new Exercise1();
            bool result = Exercise1.login("user", "pass1111111111111111111111111111111");
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void blankUser()
        {
            var Exercise1 = new Exercise1();
            bool result = Exercise1.login("", "pass");
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void blankPass()
        {
            var Exercise1 = new Exercise1();
            bool result = Exercise1.login("user", "");
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void trueAsteriscs()
        {
            var Exercise2 = new Exercise2();
            string result = Exercise2.asteriscs(3);
            Assert.AreEqual("***", result);
        }
        [TestMethod()]
        public void falseAsteriscs()
        {
            var Exercise2 = new Exercise2();
            string result = Exercise2.asteriscs(-3);
            Assert.AreEqual("incorrect number", result);
        }
        [TestMethod()]
        public void truedeleteSymb()
        {
            var Exercise3 = new Exercise3();
            string result = Exercise3.deleteSymb("ba","ac");
            Assert.AreEqual("b", result);
        }
        [TestMethod()]
        public void truemultideleteSymb()
        {
            var Exercise3 = new Exercise3();
            string result = Exercise3.deleteSymb("qadeee", "vce");
            Assert.AreEqual("qad", result);
        }
    }
}


