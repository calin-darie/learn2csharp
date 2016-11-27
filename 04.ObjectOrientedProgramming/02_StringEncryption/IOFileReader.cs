using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    public static class IOFileReader
    {

        // receives a file path and returns the content of the file into a string
        public static String Read(string filename)
        {
            return File.ReadAllText(filename);
        //    IEnumerable<string> linesEnumerable = File.ReadLines(filename);
        //    IEnumerator<string> linesEnumerator = linesEnumerable.GetEnumerator();

        //    bool couldMove = linesEnumerator.MoveNext();
        //    while (couldMove)
        //    {
        //        string line = linesEnumerator.Current;
        //        Console.WriteLine(line);
        //        couldMove = linesEnumerator.MoveNext();
        //    }
        //    var writer = new StreamWriter("outhere.txt");
        //    using (writer)
        //    {
        //        foreach (var line in linesEnumerable)
        //        {
        //            writer.WriteLine(line);
        //            Console.WriteLine(line);
        //        }
        //    }
        }
    }
}
