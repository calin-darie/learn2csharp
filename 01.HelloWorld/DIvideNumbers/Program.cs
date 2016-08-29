using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvideNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 26;
            int Num2 = 7;
            int ResultInt = Num1 / Num2;
            int ResultRemainder = Num1 % Num2;
            float Num3 = 26;
            float Num4 = 7;
            float ResultWithDecimal = Num3 / Num4;
            Console.WriteLine("26:7 is {0} and the remainder is {1}", ResultInt, ResultRemainder);
            Console.WriteLine("26:7 is {0}", ResultWithDecimal);
            Console.ReadKey();
        }
    }
}
