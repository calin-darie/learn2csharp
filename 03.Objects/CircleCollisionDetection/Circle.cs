using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCollisionDetection
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public Circle()
        {
        }

        /// <summary>
        /// computes if a point is on a circle.
        /// </summary>
        /// <param name="point">the coordinates of the point</param>
        /// <returns>boolean which if true means the point was on the circle, if false it was outside</returns>
        public bool Contains(Point point)
        {
            double distanceToPoint = this.Center.DistanceTo(point);
            return distanceToPoint <= this.Radius;
        }

        /// <summary>
        /// computes if two circles collide.
        /// </summary>
        /// <param name="otherCircle">the other circle</param>
        /// <returns>boolean which if true means the circles did collide, if false they didn't</returns>
        public bool CollidesWith(Circle otherCircle)
        {
            double distanceBetweenCenters = this.Center.DistanceTo(otherCircle.Center); ;
            double sumCircleRadii = this.Radius + otherCircle.Radius;
            return distanceBetweenCenters <= sumCircleRadii;
        }

        public bool Contains(Circle otherCircle)
            {
                double distanceBetweenCenters = this.Center.DistanceTo(otherCircle.Center);
                return distanceBetweenCenters <= this.Radius - otherCircle.Radius;
            }
    }
}
