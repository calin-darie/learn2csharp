using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareForRestaurant_01_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var reastaurant_menu = new Menu();
            reastaurant_menu.AddBeverage(name: "shake", priceSmall: 7.5, priceMedium: 0.5, priceLarge: 0.5);
            reastaurant_menu.AddSnack(name: "burger", price: 15.5);
            reastaurant_menu.printToScreen();
            Console.ReadKey();
        }
    }
}
