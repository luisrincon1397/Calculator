using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void Add_X_and_Y_ReturnSum()
        {
            Assert.AreEqual(2, calculator.DoOperation(1, 1, "a"));
            Assert.AreEqual(1.42, calculator.DoOperation(3.14, -1.72, "a"), 0.001);
            Assert.AreEqual(2.0 / 3, calculator.DoOperation(1.0 / 3, 1.0 / 3, "a"), 0.001);
        }

        [TestMethod]
        public void Subtract_X_and_Y_ReturnRest()
        {
            Assert.AreEqual(0, calculator.DoOperation(1, 1, "s"));
            Assert.AreEqual(4.86, calculator.DoOperation(3.14, -1.72, "s"), 0.001);
            Assert.AreEqual(2.0 / 3, calculator.DoOperation(1.0 / 3, -1.0 / 3, "s"), 0.001);
        }

        [TestMethod]
        public void Multiply_X_and_Y_ReturnProduct()
        {
            Assert.AreEqual(2, calculator.DoOperation(1, 2, "m"));
            Assert.AreEqual(-5.4008, calculator.DoOperation(3.14, -1.72, "m"), 0.001);
            Assert.AreEqual(0.111, calculator.DoOperation(1.0 / 3, 1.0 / 3, "m"), 0.001);
        }

        [TestMethod]
        public void Divide_X_and_Y_ReturnDivision()
        {
            Assert.AreEqual(2, calculator.DoOperation(4, 2, "d"));
            Assert.AreEqual(-1.826, calculator.DoOperation(3.14, -1.72, "d"), 0.001);
            Assert.AreEqual(1, calculator.DoOperation(1.0 / 3, 1.0 / 3, "d"));
        }
    }
}
