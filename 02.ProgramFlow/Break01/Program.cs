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
                Console.WriteLine("Type number to be added to the sum:");
                int number = int.Parse(Console.ReadLine());
                sum += number;
                Console.WriteLine("The sum is {0}.", sum);
                
                if (sum > 100)
                {
                    Console.WriteLine("Sum is greter than 100.");
                    break;
                }
                
            }
        }
    }
}
