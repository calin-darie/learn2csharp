using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            int number;

            //test: input is integer > 0
            if (!(int.TryParse(input, out number)) || number <= 0)
            {
                Console.WriteLine("Number is not valid!");
            }
            else
            {
                number = int.Parse(input);
                int i = 0;

                //write your solution
                //make a while loop
                /* the condition should be that i is less and equal than number
                inside the loop print i and increment variable i */

                Console.WriteLine("Listing all numbers between 0 and {0}:", number);
                while (i <= number)
                {
                    Console.WriteLine("{0}", i);
                    i++; //if this statemen was missing we would get an infinite loop
                }
            }
            Console.ReadKey();
        }
    }
}
