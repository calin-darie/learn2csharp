using System;
using CircleCollisionDetection;

namespace CircleCollisionDetection
{
    class Program
    {
        static void Main()
        {
            Circle circle = ReadCircle("Describe a circle");

            Point clickPoint = ReadPoint("Enter click coordinates");

            var clickMessage = circle.Contains(clickPoint) ?
                "Click was on the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);

            Circle otherCircle = ReadCircle("Describe another circle");

            var collisionMessage = circle.CollidesWith(otherCircle) ?
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
                Console.Write(prompt);
                string input = Console.ReadLine();
                parsed = double.TryParse(input, out value);
                if (!parsed)
                {
                    Console.WriteLine("'{0}' can not be converted to a {1}.", input, "double");
                }
            }
            while (!parsed);
            return value;
        }

        static Point ReadPoint (string prompt)
        {
            Console.WriteLine(prompt);
            double x = ReadDouble("x: ");
            double y = ReadDouble("y: ");
            var newPoint = new Point(x, y);
            return newPoint;
        }

        static Circle ReadCircle(string prompt)
        {
            Console.WriteLine(prompt);
            Point circleCenter = ReadPoint("Enter center coordinates");
            double radius = ReadDouble("radius: ");
            return new Circle(circleCenter, radius);
        }

    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DistanceTo(Point otherPoint)
        {
            return Math.Sqrt((this.X - otherPoint.X) * (this.X - otherPoint.X) + (this.Y - otherPoint.Y) * (this.Y - otherPoint.Y));
        }

        public Point( double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point() { }

    }
}
