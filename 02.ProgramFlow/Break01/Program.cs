using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string answer;
            var number = 0;

            while (true)
            {
                
                Console.WriteLine("Type a number");
                answer = Console.ReadLine();
                number = int.Parse(answer);
                sum = sum + number;
                Console.WriteLine("Actual sum is {0}", sum);
                if (sum > 100)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
