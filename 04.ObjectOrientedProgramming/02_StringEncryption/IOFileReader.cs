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
        }
    }
}
