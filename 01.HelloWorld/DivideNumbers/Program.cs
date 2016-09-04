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
            /*divides 26 by 7 and prints to the console the integer quotient and the remainder
            and also the exact quotient with decimals*/

            //intialize variables
            int dividend = 26;

            float floatDivisor = 7;
            float exactQuotient = dividend / floatDivisor;

            int intDivisor = 7;
            int integerQuotient = dividend / intDivisor;
            int remainder = dividend % intDivisor;


            Console.WriteLine("The integer quotient of the division {0}/{1} is {2} and the remainder {3}", dividend, intDivisor, integerQuotient, remainder);
            Console.WriteLine("The exact quotient of the division {0}/{1} is {2}", dividend, floatDivisor, exactQuotient);
            Console.ReadKey();
        }
    }
}
