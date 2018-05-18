using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculatorNS;

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
    }
}


