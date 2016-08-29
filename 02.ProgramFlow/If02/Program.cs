using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name of the fruit:");
            string fruit = Console.ReadLine();

            if (fruit == "apple")
            {
                Console.WriteLine("Color of the apple:");
                string appleColor = Console.ReadLine();
                if (appleColor == "green")
                {
                    Console.WriteLine("Green apples are my favorite");
                }
                else if (appleColor == "red")
                {
                    Console.WriteLine("Snow White likes red apples");
                }
                else
                {
                    Console.WriteLine("I don't know such kind of apples");
                }
            }
            else if (fruit == "orange")
            {
                Console.WriteLine("Orange is sweet or sour?");
                string orangeTaste = Console.ReadLine();

                if (orangeTaste == "sweet")
                {
                    Console.WriteLine("Sweet oranges are the best");
                }
                else
                {
                    Console.WriteLine("Is the sour orange big or small?");
                    string sour = Console.ReadLine();

                    if (sour == "big")
                    {
                        Console.WriteLine("Congrats!You have a big sour orange!");
                    }
                    else
                    {
                        Console.WriteLine("Maybe you have a lime instead of an orange");
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} is not on our list. I like apples and oranges.", fruit);
            }

            Console.ReadKey();
        }
    }
}
