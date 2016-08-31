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
            int number;

            Console.WriteLine("Generated number = {0}", generatedNumber);
            Console.WriteLine("Please input a number between 0 and 99, inclusively.");
            number = int.Parse(Console.ReadLine());

            while (number != generatedNumber)
            {
                if (number > generatedNumber)
                {
                    Console.WriteLine("It's bigger. Try another.");
                    number = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (number < generatedNumber)
                    {
                        Console.WriteLine("It's smaller. Try another");
                        number = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Congratulations! You guessed the number!");
            Console.ReadKey();
        }
    }
}
