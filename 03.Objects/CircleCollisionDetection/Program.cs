using System;

namespace CircleCollisionDetection
{
    class Program
    {
        static void Main()
        {
            var circle = ReadCircle("Describe a circle");
            var clickPoint = ReadPoint("Enter click coordinates");
            bool wasClickOnCircle = circle.Contains(clickPoint);

            var clickMessage = wasClickOnCircle ? 
                "Click was on the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);

            var otherCircle = ReadCircle("Describe another circle");
            bool didTheCirclesCollide = circle.CollidesWith(otherCircle);

            var collisionMessage = didTheCirclesCollide ?
                "The circles have collided." :
                "No collision between the circles.";
            Console.WriteLine(collisionMessage);

            bool isCircleContained = circle.Contains(otherCircle);

            var containsMessage = isCircleContained ?
                "The second circle is inside the first." :
                "The second circle is outside the first.";
            Console.WriteLine(containsMessage);

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

        /// <summary>
        /// prompts for point coordinates and returns the Point object.
        /// </summary>
        /// <param name="prompt">message to show when asking for input</param>
        /// <returns>the point object created</returns>
        private static Point ReadPoint(string prompt)
        {            
            Console.WriteLine(prompt);
            double X = ReadDouble("x: ");
            double Y = ReadDouble("y: ");

            var point = new Point(X, Y);

            return point;
        }

        /// <summary>
        /// prompts for circle coordinates and radius and returns the Circle object.
        /// </summary>
        /// <param name="prompt">message to show when asking for input</param>
        /// <returns>the circle object created</returns>
        private static Circle ReadCircle(string prompt)
        {
            Console.WriteLine(prompt);
            var circleCenter = ReadPoint("Enter center coordinates");
            double circleRadius = ReadDouble("radius: ");

            var circle = new Circle(circleCenter, circleRadius);

            return circle;
        }
    }
}
