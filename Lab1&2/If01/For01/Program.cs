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
            Console.WriteLine("Please insert a positive number:");
            int Number = int.Parse(Console.ReadLine());
            for (int i = 0; i < Number; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine("Even numbers between 0 and {0}: {1}", Number, i);
                 }
             }
        }
    }
}
