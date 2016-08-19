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
            Console.WriteLine("Choose a number");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Type one for i as well");
            var i = int.Parse(Console.ReadLine());

            while (i > number)
            {
                Console.WriteLine("i is the best");
                i++;
            }
        }
    }
}