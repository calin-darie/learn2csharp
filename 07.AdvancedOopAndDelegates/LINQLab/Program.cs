using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store the following names in a list or array, or anything else IEnumerable.
            //Horia, Yusuf, Florin, Floarea, Horia, Elena, Filimon, Sofia, Horia, Leo, Hannah, Sorin, Mircea, Alan, Sorin
            List<string> namesList = new List<string>
            {
                "Horia",
                "Yusuf",
                "Florin",
                "Floarea",
                "Horia",
                "Elena",
                "Filimon",
                "Sofia",
                "Horia",
                "Leo",
                "Hannah",
                "Sorin",
                "Mircea",
                "Alan",
                "Sorin"
            };

            //Write LINQ queries that return:
            //-the names ending in "a": Horia, Floarea, ... hint: filtering using .Where(
            //-all the names, transformed to uppercase: HORIA, YUSUF, FLORIN, ... hint: projection using .Select(
            //-the letter count for each name: 5, 5, 6, ...hint: projection using .Select(
            //-the names ending in "n", transformed to uppercase: FLORIN, ...hint: filtering followed by projection.you may chain the operations like this names.Where(...).Select(...)
            //-all distinct names
            //-the name count
            //-the distinct name count

            List<string> namesEndingIna = namesList.Where(x => x.EndsWith("a")).ToList();
            List<string> namesToUppercase = namesList.Select(x => x.ToUpper()).ToList();
            List<string> namesLength = namesList.Select(x => x.Length.ToString()).ToList();
            List<string> namesEndingInnToUppercase = namesList.Where(x => x.EndsWith("n")).Select(x => x.ToUpper()).ToList();
            List<string> distinctNames = namesList.Distinct().ToList();
            int namesCount = namesList.Count;
            int distinctNamesCount = distinctNames.Count;

            Console.WriteLine("the names ending in 'a':");
            WriteValuesInList(namesEndingIna);

            Console.WriteLine("all the names, transformed to uppercase:");
            WriteValuesInList(namesToUppercase);

            Console.WriteLine("the letter count for each name::");
            WriteValuesInList(namesLength);

            Console.WriteLine("the names ending in 'n', transformed to uppercase:");
            WriteValuesInList(namesEndingInnToUppercase);

            Console.WriteLine("all distinct names:");
            WriteValuesInList(distinctNames);

            Console.WriteLine($"There are {namesCount} total names, out of which {distinctNamesCount} are distinct.");
        }

        static void WriteValuesInList(List<string> list)
        {
            foreach (string name in list)
            {    
               Console.Write(name + " ");
            }
            Console.WriteLine();
        }
}
}
