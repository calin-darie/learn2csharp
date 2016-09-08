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

            Console.WriteLine("Your gender:"); //male or female
            string genderString = Console.ReadLine();
            string gender = genderString;

            //write here your solution
            if (age == 24 && gender == "male" || age == 20 && gender == "female" )
            {
                Console.WriteLine("Valid Person");
            }
            else { 
                Console.WriteLine("Invalid Person");
            }
            
            
            Console.ReadKey();
        }
    }
}
