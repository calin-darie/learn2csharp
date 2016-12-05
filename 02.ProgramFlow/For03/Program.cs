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
            int divisibleNumber;


            divisibleNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i <= divisibleNumber; i++)
            {

                if (i % 10 == 0)
                {

                    Console.WriteLine($"Number {i} is divisible by 10");
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Number {i} is divisible by 2");
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine($"Number {i} is divisible by 5");
                    }
                }
            }


            Console.ReadKey();











        }
    }
}
