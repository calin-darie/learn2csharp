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
            int quotient = 26 / 7;
            int remainder = 26 % 7;
            double decimals = 26.0 / 7;

            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            Console.WriteLine(decimals.ToString());
        }
    }
}   