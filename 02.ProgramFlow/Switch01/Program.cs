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
            Console.Write("please enter a person name:");
            string user_name_String = Console.ReadLine();

            switch (user_name_String)
            {
                case "calin":
                    Console.WriteLine("Calin e smecher");
                    break;
                case "paul":
                    Console.WriteLine("Paul e de treaba");
                    break;
                case "alex":
                    Console.WriteLine("Alex e fain");
                    break;
                case "teo":
                    Console.WriteLine("Teo e si mai fain :P");
                    break;
                default:
                    Console.WriteLine("nu-l cunosc pe " + user_name_String);
                    break;
            }
            Console.ReadKey();
        }
    }
}
