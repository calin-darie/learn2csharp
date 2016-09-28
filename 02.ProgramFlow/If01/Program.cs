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
            int Age;
            string Sex;
            string temporary;

            Console.WriteLine("Please insert your age:");
            temporary = Console.ReadLine();
            Age = int.Parse(temporary);
            Console.WriteLine("Please insert your sex (male/female):");
            Sex = Console.ReadLine();

            if (Sex.ToLower().Equals("male"))
            {
                if (Age == 24)
                {
                     Console.WriteLine("Valid person");
                }
                else
                {
                    Console.WriteLine("Invalid person");
                }
            }
            else 
                if (Sex.ToLower().Equals("female"))
                {
                    if ((Age >=20) && (Age <=32))
                    {
                     Console.WriteLine("Valid person");
                    }
                    else
                    {
                       Console.WriteLine("Invalid person");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, no aliens allowed!");
                }

            Console.ReadKey();
        }
    }
}
