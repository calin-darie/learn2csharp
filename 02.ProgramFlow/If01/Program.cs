using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            
            Console.WriteLine("Your sex:"); //male or female
            string sex = Console.ReadLine();
            
            if (sex == "male")
            {
                if (age == 24 )
                {
                    Console.WriteLine("Valid person.");
                }
                else
                {
                    Console.WriteLine("Invalid person.");
                }
                
            }
            else if (sex == "female")
            {
                if (age >= 20 && age <= 32)
                {
                    Console.WriteLine("Valid person.");
                }
                else
                {
                    Console.WriteLine("Invalid person.");
                }
            }

            Console.ReadKey();
        }
    }
}
