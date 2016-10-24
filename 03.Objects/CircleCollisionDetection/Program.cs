using System;

namespace CircleCollisionDetection
{
    class Program
    {//in clasa program pun toate metodele
        static void Main()
        {   //in static void main am ce se executa; in afara ei dar totusi in program se pun restul metodelor
            //ex1

            Point circleCenter = ReadPoint("Enter center coordinates for initial circle");
            double radius = ReadDouble("radiusinItialCircle: ");
            
            Point clickPoint = ReadPoint("Enter click coordinates of the click");

            
            //where was the click comparing with the circle?-varianta 2 care verifica doar 2 varinate 
            var distance1 = circleCenter.DistanceTo(clickPoint);
            bool wasClickOnCircle = (distance1 <= radius);//asociez lui wasClickOnCircle valoarea de adevar din comparatia dintre distanta si radius
            var clickMessage = wasClickOnCircle ? //daca e adevarata linia anterioara, lui clickMessage i se va asocia stringul de pe linia imediat urmatoare; altfel i se asociaza stringul de pe a doua linie urmatoare
                "Click was inside the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);
            Console.WriteLine("#######################end of ex1##############################");


            //ex 2
            //Console.WriteLine("Describe another circle");
            //double otherCircleCenterX = ReadDouble("xanothercircle: ");
            //double otherCircleCenterY = ReadDouble("yanothercircle: ");
            //double otherCircleRadius = ReadDouble("radiusAnotherCircle: ");

            //// did the circles collide? varianta 1
            //if (Math.Sqrt((otherCircleCenterX - circleCenterX) * (otherCircleCenterX - circleCenterX) + (otherCircleCenterY - circleCenterY) * (otherCircleCenterY - circleCenterY)) == (otherCircleRadius + radius))
            //{
            //    Console.WriteLine("The two circles are tangentials circles");
            //}
            //else if (Math.Sqrt((otherCircleCenterX - circleCenterX) * (otherCircleCenterX - circleCenterX) + (otherCircleCenterY - circleCenterY) * (otherCircleCenterY - circleCenterY)) > (otherCircleRadius + radius))
            //{
            //    Console.WriteLine("The two circles are NOT colliding with each other");
            //}
            //else
            //{
            //    Console.WriteLine("The two circles are colliding with each other");
            //}

            // did the circles collide? varianta 2 doar cu 2 variante
            //var distanceBetweenTheCentersOfCircles= Math.Sqrt((otherCircleCenterX - circleCenterX)*(otherCircleCenterX  - circleCenterX) + (otherCircleCenterY - circleCenterY)*(otherCircleCenterY - circleCenterY));
            //bool didTheCirclesCollide = (distanceBetweenTheCentersOfCircles <= (radius + otherCircleRadius));
            //var collisionMessage = didTheCirclesCollide ?
            //    "The circles have collided." :
            //    "No collision between the circles.";
            //Console.WriteLine(collisionMessage);
            Console.WriteLine("#######################end of ex2##############################");
            
            Console.ReadKey();
        }//aici se iese din main

        //alta metoda outside static main
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

        private static Point ReadPoint(string consoleInput)
        {
            //Console.WriteLine("Describe the initial circle");
            Console.WriteLine(consoleInput);
            double clickPointX = ReadDouble("xclick: ");
            double clickPointY = ReadDouble("yclick: ");
            var givenPoint = new Point
            {
                X = clickPointX,
                Y = clickPointY
            };
            return givenPoint;
        }

        //alta metoda outside static main
        /// <summary>
        /// calculates the distance between two points
        /// return distance; to test this use the method of the triangle: 3, 4, 5
        /// </summary>
        /// <returns></returns>     
        //static double DistanceBetweenPoints(double pointX, double pointY, double otherPointX, double otherPointY)
        //{
        //    var distance = Math.Sqrt((pointX - otherPointX)*(pointX - otherPointX) + (pointY - otherPointY)*(pointY - otherPointY));
        //    return distance;
        //}

       
    }// aici se iese din program
}  //aici se iese din namespace   
