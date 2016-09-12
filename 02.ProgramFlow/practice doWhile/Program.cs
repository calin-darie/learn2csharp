using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Y]es or [N]o?"); 
            char answer; 
            do 
            {
                answer = Console.ReadKey().KeyChar; 
            } 
            while (answer != 'y' && answer != 'n');

            Console.WriteLine("Choose a number");
            var number = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Type one for i as well");
            var i = int.Parse (Console.ReadLine());

            while (i > number)
            {
                Console.WriteLine("i is the best");
                i++;
            }
        }
    }
}
