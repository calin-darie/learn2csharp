using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class Contains
    {

        [TestMethod]
        public void PointOnCircle()
        {
            var circle = new Circle
            {
                Center = new Point { X= 1, Y = 1 },
                Radius = 10
            };
            var point = new Point { X=  11, Y = 1 };

            var circleContainsPoint = circle.Contains(point);

            Assert.IsTrue(circleContainsPoint);
        }

        [TestMethod]
        public void GivenPointIsCircleCenter_ContainsReturnsTrue()
        {
            var circle = new Circle
            {
                Center = new Point { X= 100, Y = 100 },
                Radius = 10
            };
            var point = new Point { X=  100, Y = 100 };

            var circleContainsPoint = circle.Contains(point);

            Assert.IsTrue(circleContainsPoint);
        }

        [TestMethod]
        public void PointInsideCircle()
        {
            var circle = new Circle
            {
                Center = new Point { X= 8, Y = 1 },
                Radius = 10
            };
            var point = new Point { X=  1, Y = 8 };

            var circleContainsPoint = circle.Contains(point);

            Assert.IsTrue(circleContainsPoint);
        }

        [TestMethod]
        public void PointOutsideCircle()
        {
            var circle = new Circle
            {
                Center = new Point { X= 1, Y = 4 },
                Radius = 4
            };
            var point = new Point { X=  5, Y = 1 };

            var circleContainsPoint = circle.Contains(point);

            Assert.IsFalse(circleContainsPoint);
        }
    }
}
