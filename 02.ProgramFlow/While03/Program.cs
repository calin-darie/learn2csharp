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

            //write your solution here.



            Console.WriteLine("Congratulations! You guessed the number!");
            Console.ReadKey();
        }
    }
}
