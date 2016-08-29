using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type numbers from 0,10");
            int number;
            int sum;
            sum = 0;

            do
            {
                string readValue = Console.ReadLine();
                number = int.Parse(readValue);
                sum = sum + number;

                //Console.WriteLine("new sum is" + sum);
            }
            while (number != 0);

            Console.WriteLine("Sum is" + sum);
            
            Console.ReadKey();

          /*  
            {
                   number = (number + number + number + number + number + number);
                    }
            while (number <= 10 && number >= 0);
           */
        }
    }
}


