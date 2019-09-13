using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalApp.Library;

namespace TddCalApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnTheAdditionofTwoNumber()
        {
            Calculator testCalculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int result;
            result = testCalculator.Add(num1, num2);
            Assert.AreEqual(5, result, "testing two integers");
        }
        [TestMethod]
        public void ShouldReturnZeroonPassingPairOfPositiveAndNegativeNumber()
        {
            Calculator testCalculator = new Calculator();
            int num1 = -3;
            int num2 = +3;
            int result;
            result = testCalculator.Add(num1, num2);
            Assert.AreEqual(0, result, "testing of pair of one positive and negative");
        }
    }
}
