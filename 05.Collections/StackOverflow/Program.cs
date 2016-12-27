using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for which you want to calculate factorial: ");
            string input = Console.ReadLine();
            int inputValue;
            int.TryParse(input, out inputValue);
            
            int result = factorial(inputValue);
            Console.WriteLine("Result: {0}! = {1}", input, result.ToString());
            Console.ReadLine();
        }
        static int factorial(int n)
        {
            if (n > 1)
            {
                //Let's assume now I make a mistake and call the method for n insteed of n-1:
                return factorial(n) * n;
                //This will result in a stack overfow.
            }
            else
            {
                return 1;
            }          
        }


        
    }
}
