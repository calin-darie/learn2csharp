using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            int nr;
            Console.WriteLine("enter natural numbers:");
            do
            {                
                string nrString = Console.ReadLine();
                nr= int.Parse(nrString);
                sum = sum + nr;
            }
            while (nr != 0);
            Console.WriteLine("this is the final sum:");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
