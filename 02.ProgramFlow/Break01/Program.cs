using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
                {
                    if (sum > 100)

                        break;

                }
            }
            Console.WriteLine("The sum is: " + sum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
