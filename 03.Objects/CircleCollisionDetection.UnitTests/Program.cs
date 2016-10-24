using System;
using System.IO;

namespace CircleCollisionDetection
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DistanceTo(Point otherPoint)
        {
            var distance = Math.Sqrt((this.X - otherPoint.X) * (this.X - otherPoint.X) +
                                     (this.Y - otherPoint.Y) * (this.Y - otherPoint.Y));
            return distance;
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool ContainsPoint(Point point)
        {
            bool wasClickOnCircle = false;

            if (this.Radius <= point.DistanceTo(this.Center))
            {
                wasClickOnCircle = false;
            }
            else
            {
                wasClickOnCircle = true;
            }

            return wasClickOnCircle;
        }
        public bool CollidesWith(Circle other)
        {
            double RadiiSum = this.Radius + other.Radius;

            bool didTheCirclesCollide = false;

            if (RadiiSum <= this.Center.DistanceTo(other.Center))
            {
                didTheCirclesCollide = false;
            }
            else
            {
                didTheCirclesCollide = true;
            }
            return didTheCirclesCollide;
        }


    }

    class Program
    {
        static void Main()
        {
            var circle1 = ReadCircle("Enter circle1 coordinates (X/Y/Radius) separated by '/' and after press Enter: ");

            Point clickPoint = ReadPoint("Enter point coordinates (X/Y) separated by '/' and after press Enter: ");

            var clickMessage = circle1.ContainsPoint(clickPoint) ?
                "Click was on the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);

            var circle2 = ReadCircle("Enter circle2 coordinates (X/Y/Radius) separated by '/' and after press Enter: ");

            var collisionMessage = circle1.CollidesWith(circle2) ?
               "The circles have collided." :
               "No collision between the circles.";
            Console.WriteLine(collisionMessage);

            Console.ReadKey();
        }


        /// <summary>
        /// reads a string from the console and tries to parse it as a double. 
        /// if it fails, it retries indefinetly.
        /// </summary>
        /// <param name="prompt">message to show when asking for input</param>
        /// <returns></returns>
        private static double ReadDouble(string prompt)
        {
            double value;
            bool parsed;
            do
            {
                Console.WriteLine(prompt);
                parsed = double.TryParse(prompt, out value);
                if (!parsed)
                {
                    Console.WriteLine("{0} can not be converted to a double.", prompt);
                }
            }
            while (!parsed);
            return value;
        }
        static Point ReadPoint(string prompt)
        {
            // writeline prompt; read x and y; construct a point; return the point you created

            Console.WriteLine("Enter Point coordinates (X/Y) separated by '/' and after press Enter: ");
            string[] string1 = Console.ReadLine().Split('/');
            double circleCenterX = ReadDouble(string1[0]);
            double circleCenterY = ReadDouble(string1[1]);

            var circleCenter = new Point { X = circleCenterX, Y = circleCenterY };

            return circleCenter;
        }

        static Circle ReadCircle(string prompt)
        {
            // writeline prompt; read x and y; construct a point; return the point you created

            Console.WriteLine("Enter Circle coordinates (X/Y/Radius) separated by '/' and after press Enter: ");
            string[] string2 = Console.ReadLine().Split('/');
            double circleX = ReadDouble(string2[0]);
            double circleY = ReadDouble(string2[1]);
            double radiusC = ReadDouble(string2[2]);

            var point = new Point { X = circleX, Y = circleY };
            var circleCenter = new Circle { Center = point, Radius = radiusC };

            return circleCenter;
        }




    }
}
