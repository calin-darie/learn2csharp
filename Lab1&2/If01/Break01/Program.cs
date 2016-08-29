using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Please insert a number:");
                int Number = int.Parse(Console.ReadLine());
                sum += Number;
                if (sum > 100)
                {
                    Console.WriteLine("Suma este {0}:",sum);
                    break;
                }
            }

        }
    }
}
