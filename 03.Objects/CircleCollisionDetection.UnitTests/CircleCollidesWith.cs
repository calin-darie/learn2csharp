using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class CircleCollidesWith
    {
        [TestMethod]
        public void GivenDisjointCircles_CollidesWith_ReturnsFalse()
        {
            var c1 = new Circle(new Point { X = -1, Y = 8 }, 9);
            var c2 = new Circle(new Point { X = 2, Y = -9 }, 8);
            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsFalse(circlesIntersect);
        }

        [TestMethod]
        public void GivenTangentCircles_CollidesWith_ReturnsTrue()
        {
            var c1 = new Circle(new Point { X = -5, Y = 0 }, 5);
            var c2 = new Circle(new Point { X = 2, Y = 0 }, 2);
            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsTrue(circlesIntersect);
        }

        [TestMethod]
        public void GivenOverlappingCircles_CollidesWith_ReturnsTrue()
        {
            var c1 = new Circle(new Point { X = -5, Y = 0 }, 8);
            var c2 = new Circle(new Point { X = 2, Y = 0 }, 7);
            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsTrue(circlesIntersect);
        }

        [TestMethod]
        public void GivenNestingCircles_CollidesWith_ReturnsTrue()
        {
            var c1 = new Circle(new Point { X = -5, Y = 0 }, 1000);
            var c2 = new Circle(new Point { X = 2, Y = 0 }, 1);
            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsTrue(circlesIntersect);
        }
    }
}
