using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class Calculatortest
    {
        Calculator calculator = new Calculator();
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(2, calculator.DoOperation(1, 1, 'a'));
            Assert.AreEqual(1.42, calculator.DoOperation(3.14, -1.72), 0.001);
            Assert.AreEqual(2.0 / 3, calculator.DoOperation(1.0 / 3, 1.0 / 3), 0.001);
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(0, calculator.DoOperation(1, 1));
            Assert.AreEqual(4.86, calculator.DoOperation(3.14, -1.72), 0.001);
            Assert.AreEqual(2.0 / 3, calculator.DoOperation(1.0 / 3, -1.0 / 3), 0.001);
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(2, calculator.DoOperation(1, 2));
            Assert.AreEqual(-5.4008, calculator.DoOperation(3.14, -1.72), 0.001);
            Assert.AreEqual(0.111, calculator.DoOperation(1.0 / 3, 1.0 / 3), 0.001);
        }

        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(2, calculator.DoOperation(4, 2));
            Assert.AreEqual(-1.826, calculator.DoOperation(3.14, -1.72), 0.001);
            Assert.AreEqual(1, calculator.DoOperation(1.0 / 3, 1.0 / 3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideException()
        {
            calculator.DoOperation(2, 0);
        }
    }
}
