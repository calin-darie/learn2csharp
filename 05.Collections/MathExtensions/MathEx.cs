using System;

namespace MathExtensions
{
    public static class MathEx
    {
        /*todo: use the params keyword to make this function variadic
         * that is, make it take a variable number of arguments */
        public static double Min(params double[] numbers)//double a, double b, double c, double d)
        {
            if (numbers.Length == 0)
            {
                throw new IndexOutOfRangeException("Min() method was invoked without any parameter. Cannot calculate the minimum of NO value! ");
            }

            if (numbers.Length == 1)
            {
                return numbers[0];
            }
            else
            {
                var min = numbers[0];

                for(int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            }

            // Or as you suggested, using System.Linq;  return numbers.Min();
        }
    }
}
