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
            Console.WriteLine("please try to guess the generated nr:");
            int user_nr=-1;// nu cred ca asta e bine; am initializat asa ca sa scap de o eroare si am zis ca oricum e in afara intervalului dar nu cred ca e corect sau elegant
            string user_nr_String = Console.ReadLine();
            user_nr = int.Parse(user_nr_String);

            while (generatedNumber!=user_nr)
            { 
                

                if (generatedNumber>user_nr)
                { Console.WriteLine("It is bigger"); }
                else if (generatedNumber < user_nr)
                { Console.WriteLine("It is smaller"); }


                user_nr_String = Console.ReadLine();
                user_nr = int.Parse(user_nr_String);
            }

            Console.WriteLine("Congratulations! You guessed the number!");
            Console.ReadKey();
        }
    }
}
