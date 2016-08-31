using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For01
{
    class Program
    {
        static void Main(string[] args)
        {
            //program is only for happy flow, I have to learn how to treat corner cases/exceptions

            Console.WriteLine("Input a positive number from the keyboard.");
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= number; i+=2)
            {
                Console.WriteLine("Even number between 0 and {0} is: {1}",number,i);
            }
       }
    }
}
