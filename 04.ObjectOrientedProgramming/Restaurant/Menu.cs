using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant
{
    class Menu
    {
        public static List<MenuItem> GetMenuItems()
        {
            string[] newSize = {"Small", "Medium","Large"};
                        
            var newList = new List<MenuItem>();

            Beverage bev1 = new Beverage() { MenuItemName = "    Expresso", Size0 = newSize[0], Size1 = newSize[1], Size2 = newSize[2], BevPrice0 = 2.00, BevPrice1 = 3.00, BevPrice2 = 4.00};
            Beverage bev2 = new Beverage() { MenuItemName = "   Capuccino", Size0 = newSize[0], Size1 = newSize[1], Size2 = newSize[2], BevPrice0 = 2.99, BevPrice1 = 3.99, BevPrice2 = 4.99 };
            Beverage bev3 = new Beverage() { MenuItemName = "House coffee", Size0 = newSize[0], Size1 = newSize[1], Size2 = newSize[2], BevPrice0 = 1.25, BevPrice1 = 2.25, BevPrice2 = 3.25 };
            Beverage bev4 = new Beverage() { MenuItemName = " Iced coffee", Size0 = newSize[0], Size1 = newSize[1], Size2 = newSize[2], BevPrice0 = 2.00, BevPrice1 = 3.00, BevPrice2 = 4.00 };
              
            Snack snack1 = new Snack() { MenuItemName = "      Muffin", SnackPrice = 1.50 };
            Snack snack2= new Snack() { MenuItemName = "       Bagel", SnackPrice = 1.95 };
            Snack snack3 = new Snack() { MenuItemName = "   Croissant", SnackPrice = 2.95 };

            newList.Add(bev1); newList.Add(bev2); newList.Add(bev3); newList.Add(bev4);
            newList.Add(snack1); newList.Add(snack2); newList.Add(snack3);
            
            return newList;
        }

        public virtual void printmyList()
        {
            List<MenuItem> myList = MenuItem.GetMenuItems();

            foreach (MenuItem item in myList)
            {
                item.printToScreen();
            }

        }
    }
}
