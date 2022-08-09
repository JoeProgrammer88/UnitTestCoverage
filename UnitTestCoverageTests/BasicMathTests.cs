using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestCoverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCoverage.Tests
{
    [TestClass()]
    public class BasicMathTests
    {
        [TestMethod()]
        public void Add_ValidIntegers_ReturnsSumOfTwoNumbers()
        {
            int result = BasicMath.Add(5, 3);
            Assert.AreEqual(result, 8);
        }

        [TestMethod()]
        public void Subtract_ValidIntegers_ReturnsResult()
        {
            int result = BasicMath.Subtract(5, 3);
            Assert.AreEqual(result, 2);
        }
    }
}