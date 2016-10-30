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

        //todo: test with different numbers of arguments, e.g. three or six, or no arguments
    }
}
