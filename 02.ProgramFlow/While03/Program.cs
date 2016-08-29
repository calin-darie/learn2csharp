using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int generatedNumber = r.Next(100); //random number in range [0-99]
            int value;

            Console.WriteLine("Guess the number:");
            string input = Console.ReadLine();
            value = int.Parse(input); //assumption: the input is an integer > 0

            while (value != generatedNumber)
            {
                if (value < generatedNumber)
                    Console.WriteLine("Higher!");
                else
                    Console.WriteLine("Lower");
                Console.WriteLine("Guess again:");
                string newInput = Console.ReadLine();
                value = int.Parse(newInput); //assumption: the input is an integer > 0;
            }
            Console.WriteLine("Congratulations! You guessed the number!");
                                    
            Console.ReadKey();
        }
    }
}
