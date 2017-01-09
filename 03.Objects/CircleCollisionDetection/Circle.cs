using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCollisionDetection
{
    public class Circle
    {
        //adaug doua proprietati: Point Center si Radius
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool ContainsPoint(Point point)
        {
            return point.DistanceTo(this.Center) <= this.Radius;
        }

        public bool CollidesWith(Circle other_circle)
        {
            return other_circle.Center.DistanceTo(this.Center) <= (this.Radius + other_circle.Radius);
        }
    }
}
