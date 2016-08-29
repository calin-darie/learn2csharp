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
          
            for (int i=0; i<=20; i=i+1)
            {
                for (int j = 20; j <= 40; j = j + 1)
                {
                    Console.WriteLine("({0}, {1})", i, j);
                }

            }
            Console.ReadKey();
            // cum fac sa am scrol bar mai mare sa pot vizualiza toare rezultatele?----> vezi proprietati consola
        }
    }
}