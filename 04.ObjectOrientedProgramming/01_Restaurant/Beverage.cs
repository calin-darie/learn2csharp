using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Restaurant
{
    class Beverage : MenuItem
    {
        decimal SmallSizePrice { get; set; }
        decimal MediumSizePrice { get; set; }
        decimal LargeSizePrice { get; set; }

        public override void printToScreen()
        {
            base.printToScreen();
            Console.WriteLine($" - Small: ${SmallSizePrice}; Medium: ${MediumSizePrice}; Large: ${LargeSizePrice}");
        }

        public Beverage(string name, decimal smallPrice, decimal mediumPrice, decimal largePrice) : base(name)
        {
            SmallSizePrice = smallPrice;
            MediumSizePrice = mediumPrice;
            LargeSizePrice = largePrice;
        }

        public Beverage() { }

    }
}
