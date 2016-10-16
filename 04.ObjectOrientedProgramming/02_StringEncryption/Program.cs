using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    class Program
    {
        public static void EncryptFile(string inputFile, string outputFile, EncryptionAlgorithm.EncryptionType encryptionType)
        {
            if (!File.Exists(inputFile))
            {
                return;
            }

            EncryptionAlgorithm encryptAlgorithm;
            if (encryptionType == EncryptionAlgorithm.EncryptionType.Plus)
            {
                encryptAlgorithm = new CaesarPlus();
            }
            else
            {
                encryptAlgorithm = new CaesarMinus();
            }

            string inputText = IOFileReader.Read(inputFile);

            IOFileWriter.Write(outputFile, encryptAlgorithm.Encrypt(inputText));
        }

        public static void DecryptFile(string inputFile, string outputFile, EncryptionAlgorithm.EncryptionType encryptionType)
        {

        }
        static void Main(string[] args)
        {
            EncryptFile("c:\\WORK\\a.txt", "c:\\WORK\\b.txt", EncryptionAlgorithm.EncryptionType.Plus);
        }
    }
}
