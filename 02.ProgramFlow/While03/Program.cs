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

            Console.WriteLine($"Pretend you don't know that the lucky number is {generatedNumber}, and try to \"guess\" it:");

            int enteredNumber;

            do
            {
                enteredNumber = int.Parse(Console.ReadLine());

                if (generatedNumber > enteredNumber)
                {
                    Console.WriteLine("It's bigger! Guess again:");
                }
                else if (generatedNumber < enteredNumber)
                {
                    Console.WriteLine("It's smaller! Guess again:");
                }
            } while (enteredNumber != generatedNumber);

            Console.WriteLine("Congratulations! You guessed the lucky number !");

            Console.ReadKey();
        }
    }
}
