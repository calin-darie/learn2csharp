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
            Console.Write("Enter a positive number:");
            uint n = (uint)Math.Abs(int.Parse(Console.ReadLine()));  // just for funn :)

            Console.Write($"The even numbers between 0 and {n} are:");
            for (int i = 0; i <= n; i += 2)
            {
                Console.Write(" " + i + " ");
            }

            Console.ReadKey();
        }
    }
}
