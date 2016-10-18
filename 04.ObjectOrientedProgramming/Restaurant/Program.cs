using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{   
   /*
    Menu has-a MenuItem
    Beverage is-a MenuItem
    Snack is-a MenuItem
    */

    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();

            Console.WriteLine("********************MENU********************");
            myMenu.printmyList();

            Console.ReadLine();
        }
    }
}
