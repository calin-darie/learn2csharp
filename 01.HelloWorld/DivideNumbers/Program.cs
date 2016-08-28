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
            int remainder = 26 - quotient * 7;
            double quotientdec = 26.0 / 7;
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("Quotient with decimals: " + quotientdec);
        }
    }
}
