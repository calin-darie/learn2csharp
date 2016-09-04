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
            Console.WriteLine("What fruit would you like?");
            string fruit = Console.ReadLine();

            if (fruit.ToLower() == "apple")
            {
                Console.WriteLine("What color?");
                string color = Console.ReadLine();
                if (color.ToLower() == "green")
                {
                    Console.WriteLine("Green apples are my favourite.");
                }
                else if (color.ToLower() == "red")
                {
                    Console.WriteLine("Snow White likes red apples.");
                }
                else
                {
                    Console.WriteLine("I do not know such apples.");
                }
            }
            else if (fruit.ToLower() == "orange")
            {
                Console.WriteLine("Sweet or sour?");
                string taste = Console.ReadLine();
                if (taste.ToLower() == "sweet")
                {
                    Console.WriteLine("Sweet oranges are the best.");
                }
                else if (taste.ToLower() == "sour")
                {
                    Console.WriteLine("Big or small?");
                    string size = Console.ReadLine();
                    if (size.ToLower() == "big")
                    {
                        Console.WriteLine("Congrats! You have a big sour orange!");
                    }
                    else if (size.ToLower() == "small")
                    {
                        Console.WriteLine("Maybe you have a lime instead of an orange!");
                    }
                    else
                    {
                        Console.WriteLine("Tthis is not a size I understand. Maybe you're from the US?");
                    }
                }
                else
                {
                    Console.WriteLine("I don't know about {0} oranges.",taste);
                }
            }
            else
            {
                fruit = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(fruit.ToLower());
                Console.WriteLine("{0} is not on our list. I like apples and oranges.",fruit);
            }

                Console.ReadKey();
        }
    }
}
