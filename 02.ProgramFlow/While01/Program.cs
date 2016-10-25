using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your number is:");
            int i = 0; // se initializeaza
            int number = int.Parse(Console.ReadLine());  //se citeste numarul
           

            while (i <= number)
            // atata timp cat "i" este mai mic sau egal cu "number" se executa; (daca era "do {} while" -> se afiseaza cel putin un numar)
            {
                Console.WriteLine(i);
                i++;    // if i++ is not added, we create an infinite loop showing the initialized value of "i"
            }
            Console.WriteLine("Incorect number"); 
          
            //write your solution
            //make a while loop
            /* the condition should be that i is less and equal than number
            inside the loop print i and increment variable i */
            
            Console.ReadKey();
        }
    }
}

/* while (i <= number)
         {
           Console.WriteLine(i);
            i++; 
         } */
