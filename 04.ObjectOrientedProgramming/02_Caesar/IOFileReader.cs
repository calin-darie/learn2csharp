using System;
using System.IO;

namespace Caesar
{
    static class IOFileReader
    {
        /// <summary>
        /// reads text from a specified file.
        /// </summary>
        /// <param name="fileName">the full file path</param>
        /// <returns>the content of the file as string</returns>
        public static string Read(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                string text = System.IO.File.ReadAllText(fileName);
                return text;
            }
            else
            {
                return Ceasar.ErrorMessage.CannotReadFromFile;
            }
        }
    }
}
