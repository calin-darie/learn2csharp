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
            string[] Names = { "Bon", "Jovi", "Arnold", "Brad", "Pitt"};
            string[] Hobbies = { "eating a lot", "drinking beer", "sleeping", "driving", "swiming" };
            
            Console.WriteLine("Please insert your name:");
            string Name = Console.ReadLine();

            switch (Name)
            {
                case "Bon":
                    Console.WriteLine("{0} loves {1}.", Names[0], Hobbies[0]);
                    break;
                case "Jovi":
                    Console.WriteLine("{0} loves {1}.", Names[1], Hobbies[1]);
                    break;
                case "Arnold":
                    Console.WriteLine("{0} loves {1}.", Names[2], Hobbies[2]);
                    break;
                case "Brad":
                    Console.WriteLine("{0} loves {1}.", Names[3], Hobbies[3]);
                    break;
                case "Pitt":
                    Console.WriteLine("{0} loves {1}.", Names[4], Hobbies[4]);
                    break;
                default:
                    Console.WriteLine("I don’t know anything about {0}", Name);
                    break;
            }

        }
    }
}
