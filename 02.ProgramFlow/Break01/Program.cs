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
            while(true)
            {   Console.WriteLine("please enter a nr bigger than 0:");
                string user_nr_String = Console.ReadLine();
                int user_nr = int.Parse(user_nr_String);
                sum = sum + user_nr;
                Console.WriteLine("this is the sum until now" + sum);
                if (sum >= 100)
                { 
                    break; 
                }  
            }
            Console.WriteLine("the sum is >=100--->stop counting");
            Console.ReadKey();
        }
        
    }
}
