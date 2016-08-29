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
            string temporary;
            int Number = 0;
            int i = 0;

            Console.WriteLine("Please insert a number (max 100 so we don;t get bored!):");
            temporary = Console.ReadLine();
            Number = int.Parse(temporary);
            while (i < Number)
            {
                Console.WriteLine("Here we go (again) {0}", i);
                i++;
                /*It will print value "0" in an infinite loop */
            }

        }
    }
}
