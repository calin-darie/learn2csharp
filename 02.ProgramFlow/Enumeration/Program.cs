using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        enum Fruits
        {
            Raspberry,
            Apple,
            Bannana,
            Blueberry,
            Orange,
            Lime
        }

        static void Main(string[] args)
        {
            //Fruits favorite;
            Console.WriteLine("Pick a fruit: Raspberry, Apple, Bannana, Blueberry, Orange, Lime");
            var favorite = Enum.Parse(typeof(Fruits), Console.ReadLine());
            //string favoriteAsString = Console.ReadLine();
            //string[] FruitsValues = Enum.GetNames(typeof(Fruits));
            //Fruits favorite;
            //try
            //{
            //    favorite = (Fruits)Enum.Parse(typeof(Fruits), favoriteAsString);
            //}
            //catch (ArgumentException)
            //{
            //    favorite = (Fruits)(-1);
            //}

            switch (favorite)
            {
                case Fruits.Apple:
                    Console.WriteLine("You picked Apple");
                    break;
                case Fruits.Bannana:
                    Console.WriteLine("You picked Bannana");
                    break;
                case Fruits.Blueberry:
                    Console.WriteLine($"You picked your favorite {favorite}");
                    break;
                case Fruits.Lime:
                    Console.WriteLine("You picked Bannana");
                    break;
                case Fruits.Orange:
                    Console.WriteLine("You picked Orange");
                    break;
                case Fruits.Raspberry:
                    Console.WriteLine("You picked Raspberry");
                    break;

                default:
                    Console.WriteLine("Your input is wrong");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
