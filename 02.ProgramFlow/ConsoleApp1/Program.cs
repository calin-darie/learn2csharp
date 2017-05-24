using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a person (pick Alex, Andrew or Danielle): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Alex":
                    Console.WriteLine("Alex likes skiing");
                    break;

                case "Andrew":
                    Console.WriteLine("Andrew likes reading books");
                    break;

                case "Danielle":
                    Console.WriteLine("Danielle likes C# programming");
                    break;


                default:
                    Console.WriteLine($"I don’t know anything about {choice}");
                    break;

            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
