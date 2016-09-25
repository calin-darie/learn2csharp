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

        public double DistanceTo(Point otherPoint)
        {
            return Math.Sqrt((this.X - otherPoint.X) * (this.X - otherPoint.X) + (this.Y - otherPoint.Y) * (this.Y - otherPoint.Y));
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point() { }
    }
}
