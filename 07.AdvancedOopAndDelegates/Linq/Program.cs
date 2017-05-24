using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Horia","Yusuf","Florin","Floarea","Horia","Elena","Filimon","Sofia","Horia","Leo","Hannah","Sorin","Mircea","Alan","Sorin"};
            names.Where(name => name.EndsWith("a"));
            names.Where(name => name.StartsWith("F"));
        }

        private static bool EndsWithA(string name) =>  name.EndsWith("a");
        
    }
}
