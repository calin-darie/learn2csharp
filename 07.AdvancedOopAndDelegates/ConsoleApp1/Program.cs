using System;
using System.Collections.Generic;
using System.Linq;

namespace ScifiShows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of sci-fi shows.

            List<string> scifiShows = new List<string>
            {
                "Star Trek: The Next Generation",
                "Star Trek: Voyager",
                "Star Trek: Deep Space Nine",
                "Battlestar Gallactica",
                "Doctor Who",
                "Stargate SG-1",
                "Stargate Atlantis",
                "Stargate Universe",
                "Futurama"
            };

            // Get a filtered list of shows by using LINQ.

            List<string> filteredList = scifiShows.Where(x => x.StartsWith("Star Trek")).ToList();

            // Print each show in the filtered list to the console.

            foreach (string show in filteredList)
            {
                Console.WriteLine(show);
            }
            Console.ReadLine();
        }
    }
}
