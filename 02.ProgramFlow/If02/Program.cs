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
            Console.WriteLine("Your fruit is:");
            string fruit = Console.ReadLine();
            //Console.ReadKey();

            if (fruit == "apple")
            {
                Console.WriteLine("Color of the apple is:");
                string color = Console.ReadLine();
             if (color == "green")
             {
                 Console.WriteLine("Green apples are my favourite.");
             }
             if (color == "red")
             {
                 Console.WriteLine("Snow White likes red apples!");
             }
             else
             {
                 Console.WriteLine("I do not know such kind of apples.");
             }
            }
            if (fruit == "orange")
            {
                Console.WriteLine("Is the orange sweet, or sour?");
                string taste = Console.ReadLine();
                if (taste == "sweet")
                {
                    Console.WriteLine("Sweet oranges are the best.");
                }
                if (taste =="sour")
                {
                    Console.WriteLine("Is the orange big or small?");
                    string size = Console.ReadLine();
                    if (size == "big")
                    {
                        Console.WriteLine("Congrats! You have a big sour orange!");
                    }
                    if (size == "small")
                    {
                        Console.WriteLine("Maybe you have a lime instead of an orange!");
                    }               
                }
            }
            else
            {
                Console.WriteLine("_the_name_of_the_fruit_is not on our list. I like apples and oranges.");
            }
        }
    }
}
