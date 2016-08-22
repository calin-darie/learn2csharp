using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your gender?");
            var gender = (Console.ReadLine());
            Console.WriteLine("What is your age?");
            string ageAsString = (Console.ReadLine());
            int age = int.Parse(ageAsString);

            /*   if answer is Not male then do not print valid or not valid
             * */

            if (gender == "male")
            /*Console.WriteLine ("What is your age?")
             * */
            {
                if (age >= 24)
                {
                    Console.WriteLine("You are a valid person.");
                }



                else
                {

                    Console.WriteLine("You are an invalid person.");
                }
            }

            if (gender == "female")
            {
                if ((age <= 32) && (age >= 20))
                {
                    Console.WriteLine("You are a valid person.");
                }
                else
                {
                    Console.WriteLine("You are an invalid person.");
                }
            }

            Console.ReadKey();

        }

    }
}

