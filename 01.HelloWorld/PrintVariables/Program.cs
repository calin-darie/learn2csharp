using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //intiailize variables
            int kilometers = 10;
            double time = 1.5;
            bool truth = true;
            var name = "Mike";
            
            //print to console
            Console.WriteLine("{3} has ran {0} kilometers in {1} hours. It is "+ (truth.ToString()).ToLower() +
                " that he's a family man. " + 
                "He takes his brother out for a drink at a bar called Gigis Han. He and his wife are going to " +
                "have a son. His name will be {3}, just like his father's. {3} dreams to get a diploma from " +
                "his son saying '{3}, father of the year'.",kilometers,time,truth,name);
            Console.ReadKey();
        }
    }
}
