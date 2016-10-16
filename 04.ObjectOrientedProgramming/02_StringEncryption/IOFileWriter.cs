using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    public static class IOFileWriter
    {
        // writes the string "content" into the file provided as argument
        public static void Write(string filename, string content)
        {
            File.AppendAllText(filename, content);
        }
    }
}
