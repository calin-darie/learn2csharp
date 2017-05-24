using System;
using System.Collections.Generic;

namespace SoftwareForRestaurant_01_Lab4
{
    public class Menu
    {
        //definesc constructor
        //public Menu(string Name)
        //{
        //  this.Name = name; 
        //}

        //definire field de tip List<MenuItem> cu numele MenuItems si cu valoare initiala o noua lista goala de tip MenuItem
        private List<MenuItem> MenuItems= new List<MenuItem>();


        //constructor default
        public Menu()
        { }


        //MenuItems.Add("expresso");
        //MenuItems.Add("capucino");
        //MenuItems.Add("house coffee");
        //MenuItems.Add("ice coffee");
       // MenuItems.Add("mouffin");
        //MenuItems.Add("baget");
        //MenuItems.Add("croissant");




        internal void AddBeverage(string name, double priceSmall, double priceMedium, double priceLarge)
        {
            //am creat obicet nou de tip baverage si l-am stocat intr-o variabila de tip MenuItem; si asta e posibil pt ca baverage e mostenit din MenuItem
            MenuItem bav = new Baverage(name, priceSmall, priceMedium, priceLarge);
            MenuItems.Add(bav);
        }

        internal void AddSnack(string name, double price)
        {
            MenuItem snack = new Snack(name, price);
            MenuItems.Add(snack);
        }


        internal void printToScreen()
        {
            foreach (var MenuItem in MenuItems)
                MenuItem.printToScreen();
        }

    }
}