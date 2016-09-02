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

            switch (sex)
                {
                case "male":

                    if (age == 24)
                    {
                        Console.WriteLine("Valid guy !");
                    }
                    else
                    {
                        Console.WriteLine("Invalid guy !");
                    }
                    break;
                case "female":
                    if( age>=20 && age<=32 )
                    {
                        Console.WriteLine("Valid chick !");
                    }
                    else
                    {
                        Console.WriteLine("Invalid chick !");
                    }
                    break;
                default:
                    Console.WriteLine("I didn't get of which sex you are; you either have spelling issues or sexual identity issues.\nWell, good luck with that !");
                    break;
            }


            Console.ReadKey();
        }
    }
}
