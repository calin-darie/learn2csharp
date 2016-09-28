using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu class  "has a"  list of MenuItem objects.
            // A Beverage object  "is a"  MenuItem object.
            // A Snack object  "is a"  MenuItem object.

            var menu = new Menu();

            menu.printTheMenu();

            Console.ReadKey();
        }
    }
}
