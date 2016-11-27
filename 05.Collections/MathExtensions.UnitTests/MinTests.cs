using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathExtensions.UnitTests
{
    [TestClass]
    public class MinTests
    {
        [TestMethod]
        public void GivenSomeIntegers_Min_ReturnsSmallestNumber()
        {
            var min = MathEx.Min(4, 3, 1, 2);

            Assert.AreEqual(1, min);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GivenNullInput_Min_TrowsException()
        {
            var min = MathEx.Min();
        }

        [TestMethod]
        public void GivenADouble_Min_ReturnsIt()
        {
            var min = MathEx.Min(-9999999.9999999);

            Assert.AreEqual(-9999999.9999999, min);
        }
    }
}
