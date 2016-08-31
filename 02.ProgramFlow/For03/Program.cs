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
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {

                if (i % 10 == 0)
                {
                    Console.WriteLine("Number {0} is divisible by ten.", i);
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Number {0} is divisible by five.", i);
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine("Number {0} is divisible by two.", i);
                    }
                }
            }
            
        }
    }
}
