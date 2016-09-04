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
            //initialize variables
            string friend = "";
            
            //ask for input until it is not empty
            do
            {
                Console.Write("Tell me the name of a friend: ");
                friend = Console.ReadLine();
            }
            while (friend.Trim().Length == 0);

            //return message for known values and default message for the others
            switch (friend.Trim().ToLower())
            {
                case "alex":
                    Console.WriteLine("{0} likes cars, especially BMW series 5.",friend.Trim());
                    break;
                case "arthur":
                    Console.WriteLine("{0} is a pilot during the weekends.", friend.Trim());
                    break;
                case "sorin":
                    Console.WriteLine("{0} was a practitioner of extreme sports.",friend.Trim());
                    break;
                default:
                    Console.WriteLine("I don't know anything about {0}",friend.Trim());
                    break;
            };

            Console.ReadKey();
        }
    }
}
