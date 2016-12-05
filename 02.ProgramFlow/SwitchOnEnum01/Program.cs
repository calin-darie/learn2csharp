using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOnEnum01
{
    enum Day
    {
        Mon, Tue, Wed, Thu, Fri, Sat, Sun
    }
    enum OneValue
    {
        Default
    }

    class Program
    {
        static void Main(string[] args)
        {
            Day day = Day.Sat;
            
            OneValue one = OneValue.Default;
            
            if(day == Day.Mon)
            {
                Console.WriteLine("A inceput saptamana!\n");
            }

            switch(day)
            {
                case Day.Mon:
                    Console.WriteLine("Azi e luni!\n");
                    break;
                case Day.Tue:
                    Console.WriteLine("Azi e marti!\n");
                    break;
                default:
                    Console.WriteLine("Azi nu e nici marti, nici luni!\n");
                    break;
            }
            Console.ReadKey();
        }
    }
}
