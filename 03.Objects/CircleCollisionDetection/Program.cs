using System;

namespace CircleCollisionDetection
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Describe a circle");
            Console.WriteLine("Enter center coordinates");
            double circleCenterX = ReadDouble("x: ");
            double circleCenterY = ReadDouble("y: ");
            double radius = ReadDouble("radius: ");

            Console.WriteLine("Enter click coordinates");
            double clickPointX = ReadDouble("x: ");
            double clickPointY = ReadDouble("y: ");

            //was the click point on the circle?
            bool wasClickOnCircle = false;//todo

            var clickMessage = wasClickOnCircle ? 
                "Click was on the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);

            Console.WriteLine("Describe another circle");
            double otherCircleCenterX = ReadDouble("x: ");
            double otherCircleCenterY = ReadDouble("y: ");
            double otherCircleRadius = ReadDouble("radius: ");

            // did the circles collide?
            bool didTheCirclesCollide = false;//todo
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
}
