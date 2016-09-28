using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOnEnum
{
    class Program
    {
        public enum Seasons
        {
            spring,
            summer,
            autumn,
            winter,
        }

        static void Main(string[] args)
        {
            Seasons Season = Seasons.winter;
            
            Console.WriteLine("Please insert a date (format: DD-MM-YYYY):");
            DateTime myDate = Convert.ToDateTime(Console.ReadLine());

            if ((myDate.Month >= 3) && (myDate.Month <= 5))
            {
                Season = Seasons.spring;
            }
            else if ((myDate.Month > 5) && (myDate.Month <= 8))
            {
                Season = Seasons.summer;
            }
            else if ((myDate.Month > 8) && (myDate.Month <= 11))
            {
                Season = Seasons.autumn;
            }
            else
            {
                Season = Seasons.winter;
            }

            switch (Season)
            {
                case Seasons.spring:
                    Console.WriteLine("In the SPRINT you should listen to: Closer-The Chainsmokers Featuring Halsey");
                    break;
                case Seasons.summer:
                    Console.WriteLine("In the SUMMER you should listen to: Cold Water-Major Lazer Featuring Justin Bieber ");
                    break;
                case Seasons.autumn:
                    Console.WriteLine("In the AUTUMN you should listen to: Heathens-Twenty One Pilots");
                    break;
                default:
                    Console.WriteLine("In the WINTER you should listen to: Let Me Love You-Dj Snake Featuring Justin Bieber");
                    break;
            }

        }
    }
}
