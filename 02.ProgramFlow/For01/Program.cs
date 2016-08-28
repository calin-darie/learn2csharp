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
            Console.WriteLine("please enter a nr bigger than 0:");
            string user_nr_String = Console.ReadLine();
            int user_nr = int.Parse(user_nr_String);
            Console.WriteLine("the following nr are even in the given interval:");

            for (int i=0; i<user_nr; i=i+2)
            { 
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            //n-am inteles de ce sa folosesc {}?
        }
    }
}
