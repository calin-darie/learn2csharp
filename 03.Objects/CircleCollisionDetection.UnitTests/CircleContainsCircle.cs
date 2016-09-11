using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class CircleContainsCircle
    {
        [TestMethod]
        public void GivenCirclesAreIdentical_Contains_ReturnsTrue()
        {
            var circle = new Circle(new Point(4.98, -4.62), 3.10);
            var otherCircle = new Circle(new Point(4.98, -4.62), 3.10);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsTrue(circleContainsCircle);
        }

        [TestMethod]
        public void GivenCircleHasSameCenterAndInside_Contains_ReturnsTrue()
        {
            var circle = new Circle(new Point(3.01, 4.62), 5.67);
            var otherCircle = new Circle(new Point(3.01, 4.62), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsTrue(circleContainsCircle);
        }

        [TestMethod]
        public void GivenCircleHasSameCenterAndOutside_Contains_ReturnsFalse()
        {
            var circle = new Circle(new Point(3.01, 4.62), 5.67);
            var otherCircle = new Circle(new Point(3.01, 4.62), 9);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsFalse(circleContainsCircle);
        }

        [TestMethod]
        public void GivenCircleInsideCircle_Contains_ReturnsTrue()
        {
            var circle = new Circle(new Point(8, 10), 6);            
            var otherCircle = new Circle(new Point(4, 8), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsTrue(circleContainsCircle);
        }

        [TestMethod]
        public void GivenCircleInsideCircleAndTangent_Contains_ReturnsTrue()
        {
            var circle = new Circle(new Point(2, 1), 6);
            var otherCircle = new Circle(new Point(-3, 1), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsTrue(circleContainsCircle);
        }

        [TestMethod]
        public void GivenCircleOutsideCircleAndTangent_Contains_ReturnsFalse()
        {
            var circle = new Circle(new Point(2, 1), 6);
            var otherCircle = new Circle(new Point(9, 1), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsFalse(circleContainsCircle);
        }

        [TestMethod]
        public void GivenCircleCenterOnOtherCircle_Contains_ReturnsTrue()
        {
            var circle = new Circle(new Point(1, 1), 6);
            var otherCircle = new Circle(new Point(2, 1), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsTrue(circleContainsCircle);
        }

        [TestMethod]
        public void GivenOtherCircleCenterOnCircle_Contains_ReturnsFalse()
        {
            var circle = new Circle(new Point(1, 1), 6);
            var otherCircle = new Circle(new Point(1, 7), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsFalse(circleContainsCircle);
        }

        [TestMethod]
        public void GivenIntersectingCircles_Contains_ReturnsFalse()
        {
            var circle = new Circle(new Point(1, 1), 3);
            var otherCircle = new Circle(new Point(3, 3), 1);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsFalse(circleContainsCircle);
        }

        [TestMethod]
        public void GivenDisjointCircles_Contains_ReturnsFalse()
        {
            var circle = new Circle(new Point(-1, 8), 9);
            var otherCircle = new Circle(new Point(2, -9), 4);

            var circleContainsCircle = circle.Contains(otherCircle);

            Assert.IsFalse(circleContainsCircle);
        }
    }
}

