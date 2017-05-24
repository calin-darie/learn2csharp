using System;

namespace CircleCollisionDetection
{
    class Program
    {//in clasa program pun toate metodele
        static Circle ReadCircle(string prompt)
        {
          Console.WriteLine(prompt);
          Point Center = ReadPoint("CenterOfCircle:");
          Double Radius= ReadDouble("RadiusOfCircle:");
           
            return new Circle(Center, Radius);
        }
        static void Main()
        {   //in static void main method am ce se executa; in afara ei dar totusi in program se pun restul metodelor
            
            Point clickPoint = ReadPoint("Enter click coordinates of the click");
            Circle circle= ReadCircle("first circle");
                               
            //where was the click comparing with the circle?-varianta 2 care verifica doar 2 varinate
            bool wasClickOnCircle = circle.ContainsPoint(clickPoint);
            var clickMessage = wasClickOnCircle ? //daca e adevarata linia anterioara, lui clickMessage i se va asocia stringul de pe linia imediat urmatoare; altfel i se asociaza stringul de pe a doua linie urmatoare
                "Click was inside the circle." :
                "Click happened outside the circle.";
            Console.WriteLine(clickMessage);
            Console.WriteLine("#######################end of ex1##############################");

            // did the circles collide? varianta 1
            Circle othercircle = ReadCircle("second circle");
            var isColliding= circle.CollidesWith(othercircle);

            if (isColliding)
                { Console.WriteLine("The two circles are colliding with each other"); }
            else
                { Console.WriteLine("The two circles are NOT colliding with each other"); }
                

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
            double clickPointX = ReadDouble("x: ");
            double clickPointY = ReadDouble("y: ");
            var givenPoint = new Point
            {
                X = clickPointX,
                Y = clickPointY
            };
            return givenPoint;
        }


    }// aici se iese din program
}  //aici se iese din namespace   
