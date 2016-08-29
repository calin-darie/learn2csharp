using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalinExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            int number;
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("This is an even number");
            }

            else
            {
                Console.Write("This is an uneven number ");
            }
            Console.ReadKey();
        }
    }
}
