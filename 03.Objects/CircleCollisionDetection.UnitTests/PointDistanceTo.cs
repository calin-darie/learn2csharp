using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class PointDistanceTo
    {
        [TestMethod]
        public void GivenDeltaX3AndDeltaY4_DistanceBetweenPointsReturns5()
        {
            var p1 = new Point { X = 0, Y = 0 };
            var p2 = new Point { X = 3, Y = 4 };

            var distance = p1.DistanceTo(p2);

            Assert.AreEqual(5, distance);
        }
    }
}
