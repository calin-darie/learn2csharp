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
            int sum = 0;

            do
            {
                try
                {
                     number = int.Parse(Console.ReadLine());
                     if (number == 0)
                         break;

                    sum += number;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!! Type only numbers, please.");
                }
            } while (true);
           
            Console.WriteLine("Sum of the above numbers is:{0}", sum);
        }
    }
}
