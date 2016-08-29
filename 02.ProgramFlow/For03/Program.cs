using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For03
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Input a value:");
            string input = Console.ReadLine();
            value = int.Parse(input); //assumption: the input is an integer > 0

            for (int i = 0; i <= value; i++)
            {
                if (i % (2*5) == 0)
                {
                    Console.WriteLine("Number {0} is divisible by ten", i);
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Number {0} is divisible by two", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Number {0} is divisible by five", i);
                }                                    
            }

           Console.ReadKey();
        }
    }
}
