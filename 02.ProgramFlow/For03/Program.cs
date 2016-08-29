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
            Console.WriteLine("please enter a nr bigger than 0:");
            string user_nr_String = Console.ReadLine();
            int user_nr = int.Parse(user_nr_String);
            Console.WriteLine("this is your interval({0},{1}):", 0, user_nr);
            for (int i = 0; i <= user_nr; i++)
            {
                if (i % (5*2) == 0)
                {
                  Console.WriteLine("Number {0} is divisible by {1} and by {2} and by {3} ", i, 10, 2, 5);
                }

                else if (i % 2 == 0)
                    { 
                        Console.WriteLine("Number {0} is divisible by 2", i);
                    } 
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Number {0} is divisible by 5", i);
                }
            }
            Console.ReadKey();
        }
    }
}
