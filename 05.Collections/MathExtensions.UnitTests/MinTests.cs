using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.UnitTests
{
    [TestClass]
    public class MinTests
    {
        [TestMethod]
        public void Min_ReturnsSmallestNumber()
        {
            var min = MathEx.Min(4, 3, 1, 2);

            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void Min_ReturnsSmallestNumber_WhenLastNumberIsMin()
        {
            var min = MathEx.Min(6.90, -3.12, 12.09, 2.00, -1.45, -4.56);

            Assert.AreEqual(-4.56, min);
        }
        [TestMethod]
        public void Min_ReturnsSmallestNumber_WhenFirstNumberIsMin()
        {
            var min = MathEx.Min(-1.10, 0, 1.10);

            Assert.AreEqual(-1.10, min);
        }
        [TestMethod]
        public void Min_ReturnsSmallestNumber_WhenCalledWithOneArgument()
        {
            var min = MathEx.Min(-666.66);

            Assert.AreEqual(-666.66, min);
        }
        [TestMethod]
        public void Min_ReturnsZero_WhenCalledWithNoArguments()
        {
            var min = MathEx.Min();

            Assert.AreEqual(0, min);
        }
        [TestMethod]
        public void Min_ReturnsZero_WhenCalledWithZero()
        {
            var min = MathEx.Min(0);

            Assert.AreEqual(0, min);
        }
    }
}
