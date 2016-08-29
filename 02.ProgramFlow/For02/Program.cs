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
            for(int i = 0; i <= 20; i++)
            {
                for(int j = 20; j <= 40; j++)
                {
                    Console.Write("{0}-{1} ", i, j);
                }
            }
            Console.ReadKey();
        }
    }
}
