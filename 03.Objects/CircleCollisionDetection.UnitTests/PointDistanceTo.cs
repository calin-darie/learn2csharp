using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class PointDistanceTo
    {
        [TestMethod]
        public void GivenDeltaX4AndDeltaY3_DistanceBetweenPointsReturns5()
        {
            var p1 = new Point { X = 1, Y = 4 };
            var p2 = new Point { X = 5, Y = 1 };

            var distance = p1.DistanceTo(p2);

            Assert.AreEqual(5, distance);
        }
    }
}
