using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Substract(10, 5);

            Assert.AreEqual(50, result);
        }
    }
}