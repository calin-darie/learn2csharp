using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class CircleContainsPoint
    {
        [TestMethod]
        public void GivenPointIsCircleCenter_Contains_ReturnsTrue()
        {
            var circle = new Circle
            {
                Center = new Point { X= 100, Y = 100 },
                Radius = 10
            };
            var point = new Point { X=  100, Y = 100 };

            var circleContainsPoint = circle.ContainsPoint(point);

            Assert.IsTrue(circleContainsPoint);
        }

        [TestMethod]
        public void GivenPointInsideCircle_Contains_ReturnsTrue()
        {
            var circle = new Circle
            {
                Center = new Point { X= 8, Y = 1 },
                Radius = 10
            };
            var point = new Point { X=  1, Y = 8 };

            var circleContainsPoint = circle.ContainsPoint(point);

            Assert.IsTrue(circleContainsPoint);
        }

        [TestMethod]
        public void GivenPointOutsideCircle_Contains_ReturnsFalse()
        {
            var circle = new Circle
            {
                Center = new Point { X= 1, Y = 4 },
                Radius = 4
            };
            var point = new Point { X=  5, Y = 1 };

            var circleContainsPoint = circle.ContainsPoint(point);

            Assert.IsFalse(circleContainsPoint);
        }

        [TestMethod]
        public void GivenPointOnCircle_Contains_ReturnsTrue()
        {
            var circle = new Circle
            {
                Center = new Point { X = 1, Y = 1 },
                Radius = 10
            };
            var point = new Point { X = 11, Y = 1 };

            var circleContainsPoint = circle.ContainsPoint(point);

            Assert.IsTrue(circleContainsPoint);
        }
    }
}
