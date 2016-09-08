using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your fruit:"); 
            string fruitString = Console.ReadLine();
            string fruit = fruitString;
            //Console.WriteLine("Your fruit color is:");
            //string fruitcolourString = Console.ReadLine();
            //string fruitcolour = fruitcolourString;

            if (fruit == "apple")
               {
                Console.WriteLine("What is your fruit colour?");
                string fruitcolourString = Console.ReadLine();
                string fruitcolour = fruitcolourString;
               
                if (fruitcolour == "green" )
            {
                Console.WriteLine("Green apples are my favourite");
            }
                if (fruitcolour == "red")
                    {
                Console.WriteLine("Snow White likes red apples");
            }

                Console.ReadKey();
            }
        }
    }
}
 // ar fi putut fi facut cu else if? Cum? de investigat ... 