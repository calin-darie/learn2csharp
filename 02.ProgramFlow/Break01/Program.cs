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
            Console.WriteLine("Enter several numbers; the program will stop when the sum of the numbers you entered exceeds 100.");

            int sum = 0, v;

            while (true)
            {
                //read from the keyboard
                v = int.Parse(Console.ReadLine());
                //add the value to the variable sum 
                sum += v;
                // test if the sum is greater than 100 break the loop
                if (sum > 100)
                {
                    break;
                }
            }

            Console.WriteLine("  well, this just happened!");

            Console.ReadKey();
        }
    }
}
