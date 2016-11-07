using System;
using System.Linq;

namespace MathExtensions
{
    public static class MathEx
    {
        public static double Min(params double[] numbers)
        {
            try
            {
                return numbers.Min();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public static double Max(params double[] numbers)
        {
            try
            {
                return numbers.Max();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
    }
}
