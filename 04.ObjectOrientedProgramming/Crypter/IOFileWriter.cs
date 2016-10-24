using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Crypter
{
    public class IOFileWriter
    {
        string Filename { get; set; }
        string Content { get; set; }

        public void WriteInFile(string Filename, string Content)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(Filename))
                {
                    streamWriter.Write(Content);
                }       
            }

            catch (Exception e)
            {
                Console.WriteLine("Error writing the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}


