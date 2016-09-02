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
            Console.Write("What fruit do you have? ");
            string fruitName = Console.ReadLine().ToLower().Trim();

            if(fruitName == "apple")
            {
                Console.Write("What color is your apple? ");
                string color = Console.ReadLine().ToLower().Trim();

                if(color == "green")
                {
                    Console.WriteLine("Green apples are my favourite !");
                }
                else if (color == "red")
                {
                    Console.WriteLine("Snow White likes red apples.");
                }
                else
                {
                    Console.WriteLine("I do not know such kinds of apples.");
                }
            }
            else if(fruitName == "orange")
            {
                Console.Write("Is yor orange sweet or sour? ");
                string taste = Console.ReadLine().ToLower().Trim();

                if(taste == "sweet")
                {
                    Console.WriteLine("Sweet oranges are the best!");
                }
                else if(taste == "sour")
                {
                    Console.WriteLine("Is your fruit big or small? ");
                    string size = Console.ReadLine().ToLower().Trim();

                    switch (size)
                    {
                        case "big":
                            Console.WriteLine("Congrats! You have a big sour orange!");
                            break;
                        case "small":
                            Console.WriteLine("Maybe you have a lime instead of an orange.");
                            break;
                        default:
                            Console.WriteLine("Your orange has a strange size, for sure! :)");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your orange has a strange taste, for sure! :)");
                }
            }
            else
            {
                Console.WriteLine($"{fruitName} is not on my list. I like apples and oranges.");
            }

            Console.ReadKey();
        }
    }
}
