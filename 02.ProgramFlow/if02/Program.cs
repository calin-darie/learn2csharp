using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the name of a fruit:");
            string fruit= Console.ReadLine();
            if (fruit == "apple")
                {
                    Console.WriteLine("write the color of the apple:");
                    string color = Console.ReadLine();
                    if (color == "green")
                        { Console.WriteLine("Green apples are my favourite."); }
                    else if (color == "red")
                        { Console.WriteLine("Snow White likes red apples."); }
                    else
                        { Console.WriteLine("I do not know such kinds of apples."); }

                }
            else
                {
                    if (fruit == "orange")
                    {
                        Console.WriteLine("tell me if it is sweet or sour:");
                        string taste = Console.ReadLine();
                        if (taste == "sweet")
                        { Console.WriteLine("Sweet oranges are the best"); }
                        else if (taste == "sour")
                        {
                            Console.WriteLine("tell me if there are big or small:");
                            string size = Console.ReadLine();
                            if (size == "big")
                            { Console.WriteLine("Congrats! You have a big sour orange!"); }
                            else if (size == "small")
                            { Console.WriteLine("Maybe you have a lime instead of an orange."); }
                            else
                            { Console.WriteLine("you didn't choose correct:)"); }
                        }
                        else
                        { Console.WriteLine("you didn't choose correct:)"); }
                    }
                    else
                        { Console.WriteLine("_the_name_of_the_fruit_ is not on our list. I like apples and oranges."); }
                }
            Console.ReadKey();
            // se poate seta visual studio ca atunci cand faci un block nou sa il si indenteze?
        }
    }
}
