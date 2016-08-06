using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            Console.Write("Enter Value for A: ");
            string userTypesA = Console.ReadLine();
           double A = Convert.ToDouble(userTypesA);


            Console.Write("Enter Value for B: ");
            string userTypesB = Console.ReadLine();
            double B = Convert.ToDouble(userTypesB); ;

            var myResult = A / B;

            Console.WriteLine("The Result for Exercise 1 is: " + myResult);

            Console.ReadKey();


        }
    }
}
