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
            Console.Write("Enter a positive number:");
            uint n = (uint)Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 0; i <= n; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"The number {i} is divisible by ten.");
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"The number {i} is divisible by two.");
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine($"The number {i} is divisible by five.");
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
