using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rox! What a wonderful day to learn C#!!!");
            Console.ReadKey();

            // LAB 1 EXERCISES

         //exercise 2 - number division 

            Console.Write("Enter Value for A: ");
            string userTypesA = Console.ReadLine();
            double A = Convert.ToDouble(userTypesA);


            Console.Write("Enter Value for B: ");
            string userTypesB = Console.ReadLine();
            double B = Convert.ToDouble(userTypesB); ;

            var Quotient = A / B;
            var Remainder = A % B;

            Console.WriteLine("The QUOTIENT Result for Exercise 1 is: " + Quotient);
            Console.WriteLine("The REMAINDER Result for Exercise 1 is: " + Remainder);

            Console.ReadKey();

         //exercise 3 - text output

            Console.Write("Enter Value for Name: ");
            string userTypesName = Console.ReadLine();
            var myName = Convert.ToString(userTypesName);

            Console.Write("Enter Value for Kilometers: ");
            string userTypeskilometers = Console.ReadLine();
            var myKilometers = Convert.ToInt32(userTypeskilometers);

            Console.Write("Enter Value for Time: ");
            string userTypesTime = Console.ReadLine();
            var myTime = Convert.ToDouble(userTypesTime);

            Console.Write("Enter Value for Truth: ");
            string userTypesTruth = Console.ReadLine();
            var myTruth = Convert.ToBoolean(userTypesTruth);

            Console.WriteLine(myName + " has ran " + myKilometers + " kilometers in " + myTime + " hours. It is " + myTruth + " that he's a family man. He takes his brother out for a drink at a bar called Gigis Han. He and his wife are going to have a son. His name will be " + myName + ", just like his father's. " + myName + " dreams to get a diploma from his son saying '" + myName + ", father of the year'.");

            Console.ReadKey();
// Console.WriteLine("{0} are {1} de ani. {0} il chema.", name, age);  => Gigi are 24 de ani. Gigi il chema.

        }
    }
}
