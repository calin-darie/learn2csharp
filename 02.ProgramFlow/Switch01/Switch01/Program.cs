using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write a name\n");
                var choice = Console.ReadLine();


                switch (choice)
                {
                    case "Ana":
                        Console.WriteLine("Ana likes chess");
                        break;

                    case "Petre":
                        Console.WriteLine("Petre likes footbaal");
                        break;

                    case "Ion":
                        Console.WriteLine("Ion likes swiming");
                        break;

                    default:
                        Console.WriteLine("I don’t know anything about {0}", choice);
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
