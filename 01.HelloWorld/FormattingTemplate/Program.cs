using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = 10; 
            double time = 1.5;
            bool truth = true;
            string name = "Gigi";

            Console.WriteLine("{0} has ran {1} kilometers in {2} hours. It is {3} that he's a family man." +
            "He takes his brother out for a drink at a bar called Gigis Han. He and his wife are going to have a son." +
            "His name will be {0}, just like his father's. {0} dreams to get a diploma from his son saying '{0}, father of the year'.", name, kilometers, time, truth);
        }
    }
}
