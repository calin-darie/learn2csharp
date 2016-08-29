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
            int number = int.Parse(Console.ReadLine());
            int i = 0;

            while (i <= number)
            {
             Console.Write("Number {0} in the [0,{1}] range is:", i, number);
             Console.WriteLine(i);
             //if we forget to increment i in the while llop, we'll have an infinite loop
             i++;
            }
            Console.ReadKey();
        }
    }
}
