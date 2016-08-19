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
            Console.WriteLine("Name a fruit");
            var fruit = (Console.ReadLine());


            if (fruit == "apple")
            {
                Console.WriteLine("what is the colour?");
                var colour = (Console.ReadLine());

                if (colour == "green")

                    Console.WriteLine("Green apples are my favourite.");

                else if (colour == "red")

                    Console.WriteLine("Snow White likes red apples.");



                else

                    Console.WriteLine("I do not know such kinds of apples.");
            }


            else if (fruit == "orange")
            {
                Console.WriteLine("What is its taste?");
                var taste = (Console.ReadLine());

                if (taste == "sweet")

                    Console.WriteLine("Sweet oranges are the best");


                if (taste == "sour")

                    Console.WriteLine("What is its size?");
                var size = (Console.ReadLine());

                if (size == "big")


                    Console.WriteLine("Congrats! You have a big sour orange!");

                else


                    Console.WriteLine("Too bad!");
            }
        }

    }

}

