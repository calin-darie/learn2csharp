using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26DevidedBy7_lab1_ex2
{/*ex2 from lab1*/
    class Program
    {
        static void Main(string[] args)
        {
            /*first part of the exercise;*/
            int A= 26;
            int B = 7;
            int quotient = A / B;
            int remainer = A % B;
            Console.WriteLine("The quotient of "+ A + "/"+ B+ " is "+ quotient);
            Console.WriteLine("The remainer of " + A + "/" + B + " is " + remainer);

            /*second part of the exercise;*/
            double C = 26;
            double D = 7;
            double result = C / D;
            Console.WriteLine("The result of " + A + " / " + B + " is " + result);

            Console.ReadKey();

        }
    }
}
