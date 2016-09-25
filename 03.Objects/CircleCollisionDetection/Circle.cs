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

        public bool Contains(Point point)
        {
            return (this.Radius >= point.DistanceTo(this.Center));
        }

        public bool Contains(Circle other)
        {
            double distanceBetweenCenters = this.Center.DistanceTo(other.Center);
            return ( distanceBetweenCenters + other.Radius <= this.Radius );
        }

        public bool CollidesWith(Circle other)
        {
            return ( this.Radius + other.Radius >= this.Center.DistanceTo(other.Center) );
        }
         

        public Circle() { } 

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}
