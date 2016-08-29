using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GigiOnTheRun
{
    class Program
    {
        public static void Print(string name, int kilometers, double time, bool truth)
        {
            Console.WriteLine(@"{0} has ran {1} kilometers in {2} hours. It is {3} that he's a family man. He takes his brother out for a drink at a bar called Gigis Han. He and his wife are going to have a son.
                                His name will be {0}, just like his father's. {0} dreams to get a diploma from his son saying '{0}, father of the year'. ",
                                name, kilometers, time, truth);
        }

        public static void Main(string[] args)
        {
            string name = "Gigi";
            int kilometers = 10;
            double time = 1.5;
            bool truth = true;

            Print(name, kilometers, time, truth);

            Console.WriteLine("Wanna try with Mike, press Y/N");
            string response = Console.ReadLine();
            if (response.Equals("Y"))
            {
                name = "Mike";
                Print(name, kilometers, time, truth);
            }
         }
      }
}
