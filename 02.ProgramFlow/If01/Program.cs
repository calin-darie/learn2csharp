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
            int age;

            //test: age is integer > 0
            if (!(int.TryParse(ageString, out age)) || age <= 0)
            {
                Console.WriteLine("Age is not valid!");
            }
            else
            {
                age = int.Parse(ageString);

                Console.WriteLine("Your sex:");
                string sex = Console.ReadLine();
                
                //test: sex has expected values
                if (sex.ToLower() != "male" && sex.ToLower() != "female")
                {
                    Console.WriteLine("Sex is not valid!");
                }
                else
                {
                    //identify males over 24 and females between 20 and 32
                    if ((sex.ToLower() == "male" && age == 24)
                        || (sex.ToLower() == "female" && age >= 20 && age <= 32))
                    {
                        Console.WriteLine("Valid person");
                    }
                    else
                    {
                        Console.WriteLine("I love you just the way you are <3");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
