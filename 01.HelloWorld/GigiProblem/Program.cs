using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigi
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = 10;
            double time = 1.5;
            Boolean truth = true;
            var name = "Gigi";

            Console.WriteLine("{0} has ran {1} kilometers in {2} hours.", name,kilometers, time);

            Console.WriteLine("It is {0} that {1} is a family man", truth, name);

            Console.WriteLine("His name will be {0}, just like his father's.", name);

            Console.WriteLine("{0} dreams to get a diploma from his son saying {0} father of the year.", name);

        }
    }
}
