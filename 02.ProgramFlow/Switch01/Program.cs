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
            Console.Write("Type the name of a person: ");
            string person = Console.ReadLine();
            
            switch (person)
            {
                case "emma":
                    Console.WriteLine("Emma likes reading.");
                    break;
                case "anna":
                    Console.WriteLine("Anna loves travelling.");
                    break;
                case "dan":
                    Console.WriteLine("Dan likes playing football.");
                    break;
                case "john":
                    Console.WriteLine("John is sleeping a lot.");
                    break;
                default:
                    Console.WriteLine("I don't know anything about {0}", person);
                    break;
            }

        }
    }
}
