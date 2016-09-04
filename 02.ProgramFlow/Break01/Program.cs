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
            //initializing variables
            int sum = 0;
            int value = 0;

            /*while loop with condition always true
              will break when the sum of all input > 100*/

            while(1 == 1)
            {
                Console.Write("I'm hungry! Feed me a number: ");
                string input = Console.ReadLine();

                //test if input is an integer, if not break
                if (!(int.TryParse(input, out value)))
                {
                    Console.WriteLine("I can't eat that!");
                    break;
                }

                value = int.Parse(input);

                //compute the sum
                sum += value;
                Console.WriteLine("I'm at {0}%",sum);

                //test if the sum > 100 and break
                if (sum > 100)
                {
                    Console.WriteLine("Congrats, I've had enough.");
                    break;
                };
            }
            Console.ReadKey();
        }
    }
}
