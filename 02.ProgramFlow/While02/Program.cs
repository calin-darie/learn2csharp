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
            string temporary;
            int Number = 0;
            int sum = 0;
         
            do
            {
                Console.WriteLine("Sum is: {0}", sum);
                Console.WriteLine("Please insert a number:");
                temporary = Console.ReadLine();
                Number = int.Parse(temporary);
                sum += Number;

            }  while (Number != 0);
        }
    }
}
