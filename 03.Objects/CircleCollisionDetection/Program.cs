using System;

namespace CircleCollisionDetection
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Describe a circle");
            Console.WriteLine("Enter center coordinates");
            double circleCenterX = ReadDouble("x0: ");
            double circleCenterY = ReadDouble("y0: ");
            double radius = ReadDouble("radius: ");

            Console.WriteLine("Enter click coordinates");
            double clickPointX = ReadDouble("x: ");
            double clickPointY = ReadDouble("y: ");
            

            //where was the click comparing with the circle?
            bool wasClickOnCircle = false;
            if (Math.Sqrt((clickPointX - circleCenterX)*(clickPointX - circleCenterX) + (clickPointY - circleCenterY)*(clickPointY - circleCenterY))== radius)
            {
                wasClickOnCircle = true;
                Console.WriteLine("Your (x,y) click was exactly on the circle");
            }
            else if (Math.Sqrt((clickPointX - circleCenterX) * (clickPointX - circleCenterX) + (clickPointY - circleCenterY) * (clickPointY - circleCenterY)) > radius)
            {
                Console.WriteLine("Your (x,y) click was outside of the circle");
            }
            else 
            { 
                wasClickOnCircle = true; 
                Console.WriteLine("Your (x,y) click was inside of the circle"); 
            }

            //var clickMessage = wasClickOnCircle ? 
                //"Click was inside the circle." :
                //"Click happened outside the circle.";
            //Console.WriteLine(clickMessage);

            //Console.WriteLine("Describe another circle");
            //double otherCircleCenterX = ReadDouble("x: ");
            //double otherCircleCenterY = ReadDouble("y: ");
            //double otherCircleRadius = ReadDouble("radius: ");

            // did the circles collide?
            //bool didTheCirclesCollide = false;//todo
            //var collisionMessage = didTheCirclesCollide ?
               // "The circles have collided." :
               // "No collision between the circles.";
            //Console.WriteLine(collisionMessage);
            
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
