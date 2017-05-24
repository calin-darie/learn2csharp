using System;

namespace SoftwareForRestaurant_01_Lab4
{
    internal class Snack : MenuItem
    {
        public Snack(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double Price { get; set; }

        public override void printToScreen()
        {
            base.printToScreen();
            Console.WriteLine($"Price:{Price}");
        }
    }
}