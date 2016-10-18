using System;
using System.IO;

namespace Caesar
{
    public static class IOFileWriter
    {
        /// <summary>
        /// writes specified string to a file.
        /// </summary>
        /// <param name="fileName">the full file path</param>
        /// <param name="content">the string to be written in the file</param>
        /// <returns></returns>
        public static void Write(string fileName, string content)
        {
            if (!String.IsNullOrEmpty(fileName) && Directory.Exists(Path.GetDirectoryName(fileName)))
            {
                System.IO.File.WriteAllText(fileName, content);
            }
            else
            {
                Console.WriteLine(Ceasar.ErrorMessage.CannotWriteToFile);
            }
        }
    }
}
