using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a natural number:");
            string stringNumber = Console.ReadLine();
            //aici ar trebui verificat daca se poate face conversia; ex userul poate introduce 2.2
            int number = int.Parse(stringNumber);
            if (number < 0)
                { Console.WriteLine("This is not a valid nr"); }
            else
                {
                    int i = 0;

                    //write your solution
                    //make a while loop
                    while (i <= number)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                }
            

            /* the condition should be that i is less and equal than number
            inside the loop print i and increment variable i */

            Console.ReadKey();
        }
    }
}
