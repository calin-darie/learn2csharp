using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideNr
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNr = 26;
            int SecondNr = 7;
            double IntQuotient;
            double Remainder;
          
            IntQuotient = (double)FirstNr / (double)SecondNr;
            Remainder = (double)FirstNr % (double)SecondNr;
            Console.WriteLine("This is the integer quotient: {0}", (int)IntQuotient);
            Console.WriteLine("This is the remainder: {0}", Remainder);
            Console.WriteLine("This is the exact quotient with decimals: {0}", IntQuotient);
        }
    }
}
