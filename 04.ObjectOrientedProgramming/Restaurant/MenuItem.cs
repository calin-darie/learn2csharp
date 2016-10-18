using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class MenuItem : Menu
    {
        public string MenuItemName { get; set; }

        public virtual void printToScreen()
        {
            Console.Write("{0} - ", MenuItemName);
        }

    }

    class Beverage : MenuItem
    {
        public string Size0 {get; set;}
        public string Size1 { get; set; }
        public string Size2 { get; set; }
        public double BevPrice0 { get; set; }
        public double BevPrice1 { get; set; }
        public double BevPrice2 { get; set; }

        public override void printToScreen()
        {
            base.printToScreen();
            Console.WriteLine("{0}: ${1}; {2}: ${3}; {4}: ${5}", Size0, BevPrice0.ToString("F2", CultureInfo.InvariantCulture), Size1, BevPrice1.ToString("F2", CultureInfo.InvariantCulture), Size2, BevPrice2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Snack : MenuItem
    {
        public double SnackPrice { get; set; }

        public override void printToScreen()
        { 
            base.printToScreen();
            Console.WriteLine("Price: ${0}", SnackPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

  
}
