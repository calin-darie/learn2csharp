using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For01
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Input a value:");
            string input = Console.ReadLine();
            value = int.Parse(input); //assumption: the input is an integer > 0

            Console.WriteLine("Even numbers between 0 and {0}:",value);
            for (int i = 0; i <= value; i += 2)
            {
                Console.Write("{0} ",i);
            }
            Console.ReadKey();
        }
    }
}
