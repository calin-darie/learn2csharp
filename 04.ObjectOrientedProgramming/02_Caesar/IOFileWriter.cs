using System;
using System.IO;

namespace Caesar
{
    public static class IOFileWriter
    {
        /// /// <summary>
        /// tries to write specified string to a file.
        /// </summary>
        /// <param name="fileName">the full file path</param>
        /// <param name="content">the string to be written in the file</param>
        /// <returns>true or false</returns>
        public static bool TryWrite(string fileName, string content)
        {
            try
            {
                File.WriteAllText(fileName, content);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine(Caesar.ErrorMessage.CannotWriteToFile);
                return false;
            }
        }
    }
}
