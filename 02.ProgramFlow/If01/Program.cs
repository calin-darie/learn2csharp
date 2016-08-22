using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Your sex:"); //male or female
            string sex = Console.ReadLine();

            //write here your solution
            if (age >= 20 && age <= 32)
            {
                if (sex == "male")
                { Console.WriteLine("Valid person! this is a 24 years male"); }
                else
                { Console.WriteLine("Valid person!this is a young female :P"); }
            }

            else
            { Console.WriteLine("Invalid person!"); }

            Console.ReadKey();
            // ar mai trebui tratate si exceptiile: cand se introduce formatul gresit de la tastatura
            // intrebari: se poate si fara {}?

        }
    }
}
