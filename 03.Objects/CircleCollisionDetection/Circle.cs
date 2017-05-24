using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCollisionDetection
{
    public class Circle
    {
        //definire constructor: are acelasi nume ca si clasa si nu are return type
        public Circle(Point Center, Double Radius)
        {
            this.Center = Center;
            this.Radius = Radius;
        }

        // definire constructor gol(corp si lista de argumente goala)= default constructor
        public Circle()
        { }

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


        public double DistanceTo(Point clickPoint)
        {
            throw new NotImplementedException();
        }


        public bool Contains(Circle third_circle)
        {
            double distanceBetweenCenters = this.Center.DistanceTo(third_circle.Center);
            return distanceBetweenCenters <= this.Radius - third_circle.Radius;
        }
    }

}

