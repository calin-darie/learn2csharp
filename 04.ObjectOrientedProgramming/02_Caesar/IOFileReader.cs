using System;
using System.IO;

namespace Caesar
{
    public static class IOFileReader
    {
        /// <summary>
        /// tries to read the text from a specified file
        /// if it succeeds, it outputs the content of the file
        /// </summary>
        /// <param name="fileName">the full file path</param>
        /// <param name="content">the content of the file</param>
        /// <returns>true or false; when true, content of the file is outputed; when false, output is empty string</returns>
        public static bool TryRead(string fileName, out string content)
        {
            try
            {
                content = File.ReadAllText(fileName);
                return true;
            }
            catch (Exception)
            {
                content = "";
                return false;
            }
        }
    }
}
