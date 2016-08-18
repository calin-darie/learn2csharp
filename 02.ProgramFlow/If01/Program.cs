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
            Console.Write ("What is your age?");
            string ageAsString = (Console.ReadLine());
            int age = int.Parse(ageAsString);
            Console.WriteLine("What is your gender?");
            var gender = (Console.ReadLine());
        

            if (( age > 24) && (gender == "male"))
            {
                Console.WriteLine("You are a valid person.");
            }

            else
            {
                Console.WriteLine("You are an invalid person.");
            }

            if ((age > 20) && ( age < 32) && (gender == "female"))
            {
                Console.WriteLine("You are a valid person.");
            }
            }

        }
    }

