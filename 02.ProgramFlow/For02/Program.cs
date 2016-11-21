using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 0; i <= 20; i++)
            for (j = 20; j <= 40; j++) 
            {
                Console.WriteLine("{0},{1}", i,j);
            }
            Console.WriteLine();

        }
    }
}
