using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocksEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type numbers between 1 and 0");
            int number;
            int product;
            product = 1;

            do
            {
                string readValue = Console.ReadLine();
                number = int.Parse(readValue);
                product = product * number;
                Console.WriteLine(" Product is " + product);
            }
            while (number != 1);

            Console.ReadKey();
        }
    }
}
            

       
;
