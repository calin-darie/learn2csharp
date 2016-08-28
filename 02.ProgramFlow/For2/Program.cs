using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    class Program
    {
        static void Main(string[] args)
        {     
          
            for (int i=0; i<=40; i=i+1)
            {
                for (int j = 0; j <= 40; j = j + 1)
                {   
                    if (i <20 && j<20)
                    {
                        Console.WriteLine("these are the pairs from zero to 20:");
                        Console.WriteLine("({0}, {1})", i, j);
                    }
                    else if(i==20 && j==20)
                    {
                        Console.WriteLine("({0}, {1})", i, j);
                        Console.WriteLine("these are the pairs from 20 to 40:");
                        Console.WriteLine("({0}, {1})", i, j);
                    }
                    else
                    { Console.WriteLine("({0}, {1})", i, j); }
                }

            }
            Console.ReadKey();
            // cum fac sa am scrol bar mai mare sa pot vizualiza toare rezultatele?
        }
    }
}