using System;

namespace _01_Restaurant
{
    class Snack : MenuItem
    {
        private double Price { get; set; }

        public Snack(string name, double price)
        {
            this.Name = name;
            this.Price = price;
            Menu.MenuItems.Add(this);
        }
        
        public override void printToScreen()
        {
            string menuInfo = this.Name + " - Price: $" + this.Price.ToString("N2") + ";";
            MenuItem.centerText(menuInfo,this.Name);
        }
    }
}
