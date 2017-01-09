using System;

namespace CircleCollisionDetection
{
    class Program
    {//in clasa program pun toate metodele
        static void Main()
        {   //in static void main method am ce se executa; in afara ei dar totusi in program se pun restul metodelor
            //ex1
            Circle circle = new Circle();//fac un cerc cu parametrii din clasa circle: centru si radius
            Point circleCenter = ReadPoint("Enter center coordinates for initial circle");
            double radius = ReadDouble("radiusinItialCircle: ");

            circle.Center = circleCenter;
            circle.Radius = radius;

            Point clickPoint = ReadPoint("Enter click coordinates of the click");

            circle.ContainsPoint(clickPoint);

            

            
            //where was the click comparing with the circle?-varianta 2 care verifica doar 2 varinate 
            var distance1 = circleCenter.DistanceTo(clickPoint);
            bool wasClickOnCircle = (distance1 <= radius);//asociez lui wasClickOnCircle valoarea de adevar din comparatia dintre distanta si radius
            var clickMessage = wasClickOnCircle ? //daca e adevarata linia anterioara, lui clickMessage i se va asocia stringul de pe linia imediat urmatoare; altfel i se asociaza stringul de pe a doua linie urmatoare
                "Click was inside the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);
            Console.WriteLine("#######################end of ex1##############################");


            //ex 2
            // did the circles collide? varianta 1
            Console.WriteLine("Describe another circle");
            Point otherCircleCenter = ReadPoint("Enter center coordinates for other point");
            double otherCircleRadius = ReadDouble("radiusAnotherCircle: ");

            var otherCircle = new Circle { Center = otherCircleCenter, Radius = otherCircleRadius };
            var isColliding= circle.CollidesWith(otherCircle);

            if (isColliding)
                { Console.WriteLine("The two circles are colliding with each other"); }
            else
                { Console.WriteLine("The two circles are NOT colliding with each other"); }
                

            //var distance = circleCenter.DistanceTo(otherPoint);
            //var radius_sum = otherCircleRadius + radius;

            //if (distance == radius_sum)
            //{
            //    Console.WriteLine("The two circles are tangentials circles");
            //} 
            //else if (distance > radius_sum)
            //{
            //    Console.WriteLine("The two circles are NOT colliding with each other");
            //}
            //else
            //{
            //    Console.WriteLine("The two circles are colliding with each other");
            //}

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

        //static bool IsPointInCircle(Point point, Point circleCenter, double circleRadius)
        //{
        //    return point.DistanceTo(circleCenter) < circleRadius;
        //}

    }// aici se iese din program
}  //aici se iese din namespace   
