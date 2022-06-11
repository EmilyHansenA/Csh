using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        void Test(string str, int result)
        {
            Assert.AreEqual(result, StackCalculator.StackCalculator.Calculator(str));
        }

        [TestMethod]
        public void TestMethod1()
        {
            Test("23+5*", 25);
        }
    }
}
