using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class CollidesWith
    {
        [TestMethod]
        public void GivenDisjointCircles_CircleCollidesWith_ReturnsFalse()
        {
            var c1 = new Circle
            {
                Center = new Point {X = -1, Y = 8},
                Radius = 9
            };
            var c2 = new Circle
            {
                Center = new Point {X = 2, Y = -9},
                Radius = 8
            };

            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsFalse(circlesIntersect);
        }

        [TestMethod]
        public void GivenTangentCircles_CircleCollidesWith_ReturnsTrue()
        {
            var c1 = new Circle
            {
                Center = new Point {X = -5, Y = 0},
                Radius = 5
            };
            var c2 = new Circle
            {
                Center = new Point {X = 2, Y = 0},
                Radius = 2
            };

            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsTrue(circlesIntersect);
        }

        [TestMethod]
        public void GivenOverlappingCircles_CircleCollidesWith_ReturnsTrue()
        {
            var c1 = new Circle
            {
                Center = new Point {X = -5, Y = 0},
                Radius = 8
            };
            var c2 = new Circle
            {
                Center = new Point {X = 2, Y = 0},
                Radius = 7
            };

            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsTrue(circlesIntersect);
        }

        [TestMethod]
        public void GivenNestingCircles_CircleCollidesWith_ReturnsTrue()
        {
            var c1 = new Circle
            {
                Center = new Point {X = -5, Y = 0},
                Radius = 1000
            };
            var c2 = new Circle
            {
                Center = new Point {X = 2, Y = 0},
                Radius = 1
            };

            var circlesIntersect = c1.CollidesWith(c2);

            Assert.IsTrue(circlesIntersect);
        }
    }
}
