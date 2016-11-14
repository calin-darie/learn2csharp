using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var total = 0;
                  
            do 
            {
               
                number = int.Parse(Console.ReadLine());
                total = total + number;
            }
            while (number != 0);

            Console.WriteLine("sum is {0}", total);

            Console.ReadKey();

        }
    }
}
