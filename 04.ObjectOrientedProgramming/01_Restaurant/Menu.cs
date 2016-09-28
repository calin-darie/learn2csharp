using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuList { get; set; }

        public void printTheMenu()
        {
            Console.WriteLine("\n************************** Menu **************************\n");

            foreach(var menuItem in MenuList)
            {
                menuItem.printToScreen();
            }
        }

        public Menu()
        {
            MenuList = new List<MenuItem>();
            MenuList.Add(new Beverage("Expresso", 2.00m, 3.00m, 4.00m));
            MenuList.Add(new Beverage("Capuccino", 2.99m, 3.99m, 4.99m));
            MenuList.Add(new Beverage("House coffee", 1.25m, 2.25m, 3.25m));
            MenuList.Add(new Beverage("Iced coffee", 2.00m, 3.00m, 4.00m));
            MenuList.Add(new Snack("Muffin", 1.50m));
            MenuList.Add(new Snack("Bagel", 1.95m));
            MenuList.Add(new Snack("Croissant", 2.95m));
        }

    }
}
