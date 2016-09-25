using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Lab 1 / Exercise 1
            // Se stieeeeee !!!!!!
            #endregion

            #region  Lab 1 / Exercise 2
            Console.WriteLine("Lab 1 / Exercise 2:");

            int quotient = 26 / 7, reminder = 26 % 7;
            Console.WriteLine("The integer quotient of 26/7 is {0} and the reminder is {1}", quotient, reminder);
            Console.WriteLine();

            double secondQuotient = 26;
            secondQuotient /= 7;
            Console.WriteLine($"The real quotient of 26/7 is {secondQuotient}");
            Console.WriteLine();
            #endregion

            #region Lab 1 / Exercise 3
            Console.WriteLine("Lab 1 / Exercise 3:");

            int kilometers = 10;
            double time = 1.5;
            Boolean thruth = true;
            
            Console.WriteLine("{0} has run {1} kilometers in {2} hours. It is {3} that he's a family man.....\r\n{0} dreams to get a diploma from his son saying '{0}, father of the year'.", "Gigi", kilometers, time, thruth.ToString().ToLower());
            Console.WriteLine();
            #endregion

            #region Lab 1 / Exercise 4
            Console.WriteLine("Lab 1 / Exercise 4:");

            var character = "Mike";

            Console.WriteLine($"{character} has run {kilometers} kilometers in {time} hours. It is {thruth.ToString().ToLower()} that he's a family man.....\r\n{character} dreams to get a diploma from his son saying '{character}, father of the year'.");
            Console.WriteLine();
            #endregion

            Console.ReadKey();
        }
    }
}
