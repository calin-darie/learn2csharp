using System;

namespace SoftwareForRestaurant_01_Lab4
{
    internal class Baverage : MenuItem
    {
        public Baverage(string name, double priceSmall, double priceMedium, double priceLarge)
        {
            Name = name;
            PriceSmall = priceSmall;
            PriceMedium = priceMedium;
            PriceLarge = priceLarge;
        }

        public double PriceSmall { get; set; }
        public double PriceMedium { get; set; }
        public double PriceLarge { get; set; }

        public override void printToScreen()
        {
            base.printToScreen();
            Console.WriteLine($"Small:{PriceSmall}, Medium: {PriceMedium}, Large:{PriceLarge}");
        }

        
    }
}