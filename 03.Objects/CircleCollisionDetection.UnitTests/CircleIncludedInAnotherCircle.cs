using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleCollisionDetection.UnitTests
{
    [TestClass]
    public class CircleIncludedInAnotherCircle
    {
        [TestMethod]
        public void _IncompleteContains_GivenTwoCillidedCircles_Contains_ReturnFalse()
        {
            //arrange(given)
            var big_circle = new Circle ( new Point { X = 0, Y = 0 }, Radius: 6);
            var small_circle = new Circle (new Point { X = 0, Y = 6 }, Radius: 1);

            //act(when)
            var result = big_circle.Contains(small_circle);

            //assert(then)
            Assert.IsFalse(result);

        }
    }
}