using System;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Encrypts text from the input file based on specified algorithm and writes it to the output file.
        /// </summary>
        /// <param name="inputFile">the full path for the input file</param>
        /// <param name="outputFile">the full path for the output file</param>
        /// <param name="encryptionType">the type of encryption; must be Plus or Minus</param>
        /// <returns></returns>
        public static void EncryptFile(string inputFile, string outputFile, EncryptionAlgorithm.EncryptionType encryptionType)
        {
            string text = IOFileReader.Read(inputFile);
            switch (encryptionType)
            {
                case EncryptionAlgorithm.EncryptionType.Plus:
                    EncryptionAlgorithm plus = new CaesarPlus();
                    IOFileWriter.Write(outputFile, plus.encrypt(text));
                    break;
                case EncryptionAlgorithm.EncryptionType.Minus:
                    EncryptionAlgorithm minus = new CaesarMinus();
                    IOFileWriter.Write(outputFile, minus.encrypt(text));
                    break;
                default:
                    Console.WriteLine("Incorrect encryption type; must be Plus or Minus!");
                    break;
            }
        }

        /// <summary>
        /// Decrypts text from the input file based on specified algorithm and writes it to the output file.
        /// </summary>
        /// <param name="inputFile">the full path for the input file</param>
        /// <param name="outputFile">the full path for the output file</param>
        /// <param name="encryptionType">the type of decryption; must be Plus or Minus</param>
        /// <returns></returns>
        public static void DecryptFile(string inputFile, string outputFile, EncryptionAlgorithm.EncryptionType encryptionType)
        {
            string text = IOFileReader.Read(inputFile);
            switch (encryptionType)
            {
                case EncryptionAlgorithm.EncryptionType.Plus:
                    EncryptionAlgorithm plus = new CaesarPlus();
                    IOFileWriter.Write(outputFile, plus.decrypt(text));
                    break;
                case EncryptionAlgorithm.EncryptionType.Minus:
                    EncryptionAlgorithm minus = new CaesarMinus();
                    IOFileWriter.Write(outputFile, minus.decrypt(text));
                    break;
                default:
                    Console.WriteLine("Incorrect decryption type; must be Plus or Minus!");
                    break;
            }
        }
    }     
}
