using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Restaurant
{
    class Snack : MenuItem
    {
        decimal Price { get; set; }

        public override void printToScreen()
        {
            base.printToScreen();
            Console.WriteLine($" - Price: ${Price}");
        }

        public Snack(string name, decimal price) : base(name)
        {
            Price = price;
        }

        public Snack() { }

    }
}
