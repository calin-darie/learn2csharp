using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCollisionDetection
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
        }

        /// <summary>
        /// computes the distance to another point.
        /// </summary>
        /// <param name="otherPoint">the coordinates of the point</param>
        /// <returns>the value of the distance between the two points</returns>
        public double DistanceTo(Point otherPoint)
        {
            double distance = Math.Sqrt((this.X - otherPoint.X) * (this.X - otherPoint.X)
                + (this.Y - otherPoint.Y) * (this.Y - otherPoint.Y));
            return distance;
        }
    }
}
