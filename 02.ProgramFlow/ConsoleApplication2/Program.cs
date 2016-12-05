using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int limitA = 0;
            int A = 0;
            int B = 20;

           for ( A = 0; A <=20; A++)
                {
                for (B = 20; B <= 40; B++)
                    Console.WriteLine($"Output:{A},{B}");
                }
          

            Console.ReadKey();
        }
    }
}
