using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string answer = Console.ReadLine();
            var number = int.Parse (answer);
            int x;
            for (x =0; x <= number; x++)
                if (x % 10 == 0)
                    Console.WriteLine("Number {0} is divisible by ten", x);
                else if (x % 2 == 0)
                    Console.WriteLine("Number {0} is divisible by two", x);
                else if (x % 5 == 0)
                    Console.WriteLine("Number {0} is divisible by five", x);

            
        }
    }
}
