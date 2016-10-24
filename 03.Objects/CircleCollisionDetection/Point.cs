using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleCollisionDetection
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        //alta metoda outside static main si apoi in afara clasei program ci in clasa point
        /// <summary>
        /// calculates the distance from the current point to the point that is given as parameter instead of 4 double values from Point class; 
        /// return distance; to test this use the method of the triangle: 3, 4, 5
        /// </summary>
        /// <returns></returns> 
        public double DistanceTo(Point otherPoint)
        {
            var distance = Math.Sqrt((this.X - otherPoint.X) * (this.X - otherPoint.X) + (this.Y - otherPoint.Y) * (this.Y - otherPoint.Y));
            return distance;
        }

        public Point(double x, double y) 
        {   
            X = x;
            Y = y;
        }

        public Point(){  }    
    }

}
