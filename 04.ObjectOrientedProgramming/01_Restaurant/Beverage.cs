using System;

namespace _01_Restaurant
{
    class Beverage : MenuItem
    {
        private double SmallPrice { get; set; }
        private double MediumPrice { get; set; }
        private double LargePrice { get; set; }

        public Beverage(string name, double smallPrice, double mediumPrice, double largePrice)
        {
            this.Name = name;
            this.SmallPrice = smallPrice;
            this.MediumPrice = mediumPrice;
            this.LargePrice = largePrice;
            Menu.MenuItems.Add(this);
        }

        public override void printToScreen()
        {
            string menuInfo = this.Name + " - Small: $" + this.SmallPrice.ToString("N2")
                + "; Medium: $" + this.MediumPrice.ToString("N2")
                + "; Large: $" + this.LargePrice.ToString("N2") + ";";
            MenuItem.centerText(menuInfo, this.Name);
        }
    }
}
