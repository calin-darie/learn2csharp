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

           int guessedNumber = 0;
            // guessedNumber =int.Parse(Console.ReadLine());

            // if (guessedNumber > generatedNumber)
            // {
            //     Console.WriteLine("Generated number is smaller");
            // }

            // if (guessedNumber < generatedNumber)
            // {
            //     Console.WriteLine("Generated number is bigger");
            // }

            Console.WriteLine("Guess a number");        

            do
            {
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber > generatedNumber)
                {
                    Console.WriteLine("Generated number is smaller");
                    Console.WriteLine("Guess again");
                }

                if (guessedNumber < generatedNumber)
                {
                    Console.WriteLine("Generated number is bigger");
                    Console.WriteLine("Guess again");

                }
                
            }
            while (generatedNumber != guessedNumber);


                //write your solution here.



                Console.WriteLine("Congratulations! You guessed the number!");
            Console.ReadKey();
        }
    }
}
