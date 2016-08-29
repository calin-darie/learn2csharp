using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While02
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int sum = 0;

            do
            {
                Console.WriteLine("Input a number:");
                string input = Console.ReadLine();

                //test if the input is an integer
                if (int.TryParse(input, out value))
                {
                    value = int.Parse(input);
                    sum += value;
                }
                else
                {
                    Console.WriteLine("Value is not valid.");
                }
            }
            while (value != 0);

            Console.WriteLine("Sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
