using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the cartesian product of {0,1,...,20}x{20,21,...,40} :");

            for(int i=0; i<=20; i++)
            {
                for(int j=20; j<=40; j++)
                {
                    Console.Write($"({i},{j}) ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
