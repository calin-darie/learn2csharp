using System;

namespace CircleCollisionDetection
{
    class Program
    {
        static void Main()
        {
            //ex1
            Console.WriteLine("Describe a circle");
            Console.WriteLine("Enter center coordinates");
            double circleCenterX = ReadDouble("x0: ");
            double circleCenterY = ReadDouble("y0: ");
            double radius = ReadDouble("radius0: ");

            Console.WriteLine("Enter click coordinates");
            double clickPointX = ReadDouble("x: ");
            double clickPointY = ReadDouble("y: ");
            

            //where was the click comparing with the circle?-varianta 1
            //if (Math.Sqrt((clickPointX - circleCenterX)*(clickPointX - circleCenterX) + (clickPointY - circleCenterY)*(clickPointY - circleCenterY))== radius)
            //{
            //    Console.WriteLine("Your (x,y) click was exactly on the circle");
            //}
            //else if (Math.Sqrt((clickPointX - circleCenterX) * (clickPointX - circleCenterX) + (clickPointY - circleCenterY) * (clickPointY - circleCenterY)) > radius)
            //{
            //    Console.WriteLine("Your (x,y) click was outside of the circle");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Your (x,y) click was inside of the circle"); 
            //}

            //where was the click comparing with the circle?-varianta 2 care verifica doar 2 varinate nu 3 ca cea anterioara
            var distanta = Math.Sqrt((clickPointX - circleCenterX) * (clickPointX - circleCenterX) + (clickPointY - circleCenterY) * (clickPointY - circleCenterY));
            bool wasClickOnCircle = (distanta <= radius);//asociez lui wasClickOnCircle valoarea de adevar din comparatia dintre distanta si radius
            var clickMessage = wasClickOnCircle ? //daca e adevarata linia anterioara, lui clickMessage i se va asocia stringul de pe linia imediat urmatoare; altfel i se asociaza stringul de pe a doua linie urmatoare
                "Click was inside the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);
            Console.WriteLine("#######################end of ex1##############################");


            //ex 2
            Console.WriteLine("Describe another circle");
            double otherCircleCenterX = ReadDouble("x1: ");
            double otherCircleCenterY = ReadDouble("y1: ");
            double otherCircleRadius = ReadDouble("radius1: ");

            // did the circles collide? varianta 1
            if (Math.Sqrt((otherCircleCenterX - circleCenterX) * (otherCircleCenterX - circleCenterX) + (otherCircleCenterY - circleCenterY) * (otherCircleCenterY - circleCenterY)) == (otherCircleRadius + radius))
            {
                Console.WriteLine("The two circles are tangentials circles");
            }
            else if (Math.Sqrt((otherCircleCenterX - circleCenterX) * (otherCircleCenterX - circleCenterX) + (otherCircleCenterY - circleCenterY) * (otherCircleCenterY - circleCenterY)) > (otherCircleRadius + radius))
            {
                Console.WriteLine("The two circles are NOT colliding with each other");
            }
            else
            {
                Console.WriteLine("The two circles are colliding with each other");
            }

            // did the circles collide? varianta 2 doar cu 2 variante
            //var distanceBetweenTheCentersOfCircles= Math.Sqrt((otherCircleCenterX - circleCenterX)*(otherCircleCenterX  - circleCenterX) + (otherCircleCenterY - circleCenterY)*(otherCircleCenterY - circleCenterY));
            //bool didTheCirclesCollide = (distanceBetweenTheCentersOfCircles <= (radius + otherCircleRadius));
            //var collisionMessage = didTheCirclesCollide ?
            //    "The circles have collided." :
            //    "No collision between the circles.";
            //Console.WriteLine(collisionMessage);
            Console.WriteLine("#######################end of ex2##############################");
            
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
