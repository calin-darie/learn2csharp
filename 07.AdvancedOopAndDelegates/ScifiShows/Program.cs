using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScifiShows
{
    class Program
    {
        static void Main(string[] args)
        {
            var ShowList = new List<string>
            {
            "Star Trek: The Next Generation",
            "Star Trek: Voyager",
            "Battlestar Gallactica",
            "Stargate Atlantis",
            "Star Trek: Deep Space Nine",
            "Stargate Universe",
            "Futurama"
            };

            // List<string> filteredList = FilterTheList(ShowList, x => x.StartsWith("Star Trek"));
            List<string> filteredList = ShowList.Where(x => x.StartsWith("Star Trek")).ToList();

            foreach (string s in filteredList)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        //private static List<string> FilterTheList(List<string> inputList, Func<string, bool> evaluateCondition)
        //{
        //    var filteredList = new List<string>();
        //    foreach (string s in inputList)
        //    {
        //        if (evaluateCondition(s))
        //        {
        //            filteredList.Add(s);
        //        }
        //    }
        //    return filteredList;
        //}

    }
}
