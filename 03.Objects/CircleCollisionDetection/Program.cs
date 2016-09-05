using System;

namespace CircleCollisionDetection
{
    class Program
    {

        //static double DistanceBetweenPoints(double pointX, double pointY, double otherPointX, double otherPointY)
        //{
        //    var point = new Point
        //    {
        //        X = pointX,
        //        Y = pointY
        //    };
        //    var otherPoint = new Point
        //    {
        //        X = otherPointX,
        //        Y = otherPointY
        //    };

        //    return DistanceBetween(point, otherPoint);
        //}

        static double DistanceBetween(Point point, Point otherPoint)
        {
            var distance = Math.Sqrt((point.X - otherPoint.X) * (point.X - otherPoint.X) + (point.Y - otherPoint.Y) * (point.Y - otherPoint.Y));
            return distance;
        }


        static void Main()
        {
            Console.WriteLine("Describe a circle");
            Console.WriteLine("Enter center coordinates");
            double circleCenterX = ReadDouble("x: ");
            double circleCenterY = ReadDouble("y: ");
            double radius = ReadDouble("radius: ");
            var circleCenter = new Point(circleCenterX, circleCenterY);

            Console.WriteLine("Enter click coordinates");
            double clickPointX = ReadDouble("x: ");
            double clickPointY = ReadDouble("y: ");
            var clickPoint = new Point(clickPointX, clickPointY);

            //was the click point on the circle?
            bool wasClickOnCircle = ( radius >= DistanceBetween(clickPoint, circleCenter) );

            var clickMessage = wasClickOnCircle ?
                "Click was on the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);

            Console.WriteLine("Describe another circle");
            double otherCircleCenterX = ReadDouble("x: ");
            double otherCircleCenterY = ReadDouble("y: ");
            double otherCircleRadius = ReadDouble("radius: ");
            var otherCircleCenter = new Point(otherCircleCenterX, otherCircleCenterY);

            // did the circles collide?
            bool didTheCirclesCollide = ( radius + otherCircleRadius <= DistanceBetween(circleCenter, otherCircleCenter) );

            var collisionMessage = didTheCirclesCollide ?
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

    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point( double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
