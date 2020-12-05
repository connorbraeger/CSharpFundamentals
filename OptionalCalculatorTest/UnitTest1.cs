using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptionalCalculator;

namespace OptionalCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            int addInt = calc.Add(1, 2);
            Assert.AreEqual(3, addInt);
            int testInt2 = calc.Add(1, 2, 3);
            Assert.AreEqual(6, testInt2);
            double adddoub = calc.Add(1.5, 2.5);
            Assert.AreEqual(4.0, adddoub);
            double testDoub2 = calc.Add(1.5, 2.5, 3.5);
            Assert.AreEqual(7.5, testDoub2);
        }
    }
}
