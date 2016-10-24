using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Crypter
{
    public class IOFileReader
    {
       public string Filename { get; set; }
       public string result { get; set; }

       public string ReadFromFile(string Filename)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(Filename, Encoding.ASCII))
                {
                    result = streamReader.ReadToEnd();
                }
               
            }

            catch (Exception e)
            {
                Console.WriteLine("Error reading the file:");
                Console.WriteLine(e.Message);
            }

            return result;
          }
    }
}
