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
            Console.WriteLine("Please insert your favorite fruit:");
            string Fruit = Console.ReadLine();
            if (Fruit.Equals("apple"))
            {
                Console.WriteLine("Please insert the apple color:");
                string Color = Console.ReadLine();
                if (Color.Equals("green"))
                {
                    Console.WriteLine("Green apples are my favourite.");
                }
                else if (Color.Equals("red"))
                {
                    Console.WriteLine("Snow White likes red apples.");
                }
                else
                {
                    Console.WriteLine("I do not know such kinds of apples.");
                }
            }
            else if (Fruit.Equals("orange"))
            {
                Console.WriteLine("How is the orange, sweet or sour?");
                string Taste = Console.ReadLine();
                if (Taste.Equals("sweet"))
                {
                    Console.WriteLine("Sweet oranges are the best.");
                }
                else if (Taste.Equals("sour"))
                {
                    Console.WriteLine("How is the orange, big or small?");
                    string Shape = Console.ReadLine();
                    if (Shape.Equals("big"))
                    {
                        Console.WriteLine("Congrats! You have a big sour orange!");
                    }
                    else if (Shape.Equals("small"))
                    {
                        Console.WriteLine("Maybe you have a lime instead of an orange.");
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
            else
            {
                Console.WriteLine("{0} is not on our list. I like apples and oranges", Fruit);
            }

        Console.ReadKey();
    }
    }
}
