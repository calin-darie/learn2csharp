using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class CircleContainsCircle
    {
        [TestMethod]
        public void GivenTwoCircles_CheckFirstContainsSecond_ReturnsFalse()
        {
            var c1 = new Circle
            {
                Center = new Point { X = 0, Y = 0 },
                Radius = 3
            };

            var c2 = new Circle
            {
                Center = new Point { X = 2.7, Y = 0},
                Radius = 1.5
            };

            var circlesAreIncluded = c1.Contains(c2);

            Assert.IsFalse(circlesAreIncluded);
        }

    }
}
