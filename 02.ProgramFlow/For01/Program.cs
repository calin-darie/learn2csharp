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
            Console.WriteLine("Write a positive number:");
            var numberString=Console.ReadLine();
            var number = int.Parse(numberString);

            int x;

            for(x=0; x <= number; x++ )
            {
                if (x % 2 == 0)
                    Console.WriteLine(x);
            
            }
        }
    }
}
*//numbers between 0 and that number**// number=0; number>=x>0