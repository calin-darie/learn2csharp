using System;
using System.Collections.Generic;

namespace _01_Restaurant
{
    class Menu
    {
        public static List<MenuItem> MenuItems = new List<MenuItem>();        

        public static void printMenu()
        {
            string header = "******************MENU******************";
            MenuItem.centerText(header,"   ",header.Length);
            foreach (MenuItem item in MenuItems)
            {
                item.printToScreen();
            }
        }

    }
}
