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
            Console.Write("Enter a name: ");
            string enteredName = Console.ReadLine();

            switch(enteredName)
            {
                case "Valentin":
                    {
                        Console.WriteLine("He likes motocicles.");
                        break;
                    }
                case "Catalin":
                    {
                        Console.WriteLine("He likes football and cooking.");
                        break;
                    }
                case "Madalin":
                    {
                        Console.WriteLine("He likes programming.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't know that guy.");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
