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
            Console.WriteLine("Produsul cartezian este format din urmatoarele perechi de numere:");
            for (int i = 0; i < 21; i++)
            {
                for (int j = 20; j < 41; j++)
                {
                    Console.Write("({0},{1}); ", i, j);
                }
            }
        }
    }
}
