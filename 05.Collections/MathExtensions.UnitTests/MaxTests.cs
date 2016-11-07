using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.UnitTests
{
    [TestClass]
    public class MaxTests
    {
        [TestMethod]
        public void Max_ReturnsLargestNumber()
        {
            var max = MathEx.Max(4, 3, 1, 2);

            Assert.AreEqual(4, max);
        }
        [TestMethod]
        public void Max_ReturnsLargestNumber_WhenLastNumberIsMax()
        {
            var max = MathEx.Max(6.90, -3.12, 2.00, -1.45, -4.56, 12.09);

            Assert.AreEqual(12.09, max);
        }
        [TestMethod]
        public void Max_ReturnsLargestNumber_WhenFirstNumberIsMax()
        {
            var max = MathEx.Max(1.10, 0, -1.10);

            Assert.AreEqual(1.10, max);
        }
        [TestMethod]
        public void Max_ReturnsLargestNumber_WhenCalledWithOneArgument()
        {
            var max = MathEx.Max(-666.66);

            Assert.AreEqual(-666.66, max);
        }
        [TestMethod]
        public void Max_ReturnsZero_WhenCalledWithNoArguments()
        {
            var max = MathEx.Max();

            Assert.AreEqual(0, max);
        }
        [TestMethod]
        public void Max_ReturnsZero_WhenCalledWithZero()
        {
            var max = MathEx.Max(0);

            Assert.AreEqual(0, max);
        }
    }
}
