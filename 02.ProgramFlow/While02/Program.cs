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
            int sum = 0, curentNumber;

            Console.WriteLine("Input one number at a time and I will sum all these numbers, until you enter 0 :");

            do
            {
                curentNumber = int.Parse(Console.ReadLine());
                sum += curentNumber;
            } while (curentNumber != 0);

            Console.WriteLine($"The sum of the numbers you entered is {sum}.");

            Console.ReadKey();
        }
    }
}
