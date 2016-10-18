using System;

namespace _01_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which classes have a relationship of has-a and which classes have a relationship of is-a?
            //MenuItem has a Beverage and a Snack
            //Snack is a MenuItem
            //Beverage is a MenuItem

            Beverage expresso = new Beverage("Expresso", 2.00, 3.00, 4.00);
            Beverage capuccino = new Beverage("Capuccino", 2.99, 3.99, 4.99);
            Beverage houseCoffee = new Beverage("House coffee", 1.25, 2.25, 3.25);
            Beverage icedCoffee = new Beverage("Iced coffee", 2.00, 3.00, 4.00);

            Snack muffin = new Snack("Muffin", 1.50);
            Snack bagel = new Snack("Bage", 1.95);
            Snack croissant = new Snack("Croissant", 2.95);

            int height = Console.WindowHeight;
            int width = Console.WindowWidth;
            if (width < 70)
            {
                Console.SetWindowSize(90, height);
            }

            Menu.printMenu();
            Console.ReadKey();

            Console.SetWindowSize(width, height);
        }
    }
}
