using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For01
{
    class Program
    {
        static void Main(string[] args)
        {

            int positiveNumber;
            

            positiveNumber = int.Parse(Console.ReadLine());
           

            for (int i=0; i <= positiveNumber; i++)
            {
                //int total = i % 2;
                //bool isEven= total == 0;
                //if (isEven == true)
                //{
                //    Console.WriteLine($"Even numbers are:{i}");
                //}

                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even numbers are:{i}");
                }
                            
            }
           

               Console.ReadKey();
        }
    }
}
