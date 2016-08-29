using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While03
{
    class Program
    {
        static void Main(string[] args)
        {
            int MagicNumber = 44;
            int Number = 0;
   
            while (MagicNumber != Number) 
            {
                Console.WriteLine("Please insert a number bewteen 0 and 100:");
                Number = int.Parse(Console.ReadLine());

                if (Number == MagicNumber)
                {
                    Console.WriteLine("Congrats! This was the number");
                    break;
                }
                else
                {
                    if (MagicNumber > Number)
                    {
                        Console.WriteLine("Magic number is bigger");
                    }
                    else
                    {
                        Console.WriteLine("Magic number is smaller");
                    }
                }
            }
        }
    }
}
