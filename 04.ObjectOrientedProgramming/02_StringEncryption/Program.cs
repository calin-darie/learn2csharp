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

            string encryptedText = encryptAlgorithm.Encrypt(inputText);

            IOFileWriter.Write(outputFile, encryptedText);
        }

        public static void DecryptFile(string inputFile, string outputFile, EncryptionAlgorithm.EncryptionType decryptionType)
        {
            if (!File.Exists(inputFile))
            {
                return;
            }

            EncryptionAlgorithm decryptAlgorithm;
            if (decryptionType == EncryptionAlgorithm.EncryptionType.Plus)
            {
                decryptAlgorithm = new CaesarPlus();
            }
            else
            {
                decryptAlgorithm = new CaesarMinus();
            }

            string inputText = IOFileReader.Read(inputFile);

            string decryptedText = decryptAlgorithm.Decrypt(inputText);

            IOFileWriter.Write(outputFile, decryptedText);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to encrypt c:\\WORK\\a.txt file with CaesarPlus algorithm !");
            Console.ReadKey();
            EncryptFile("c:\\WORK\\a.txt", "c:\\WORK\\a_EncryptPlus.txt", EncryptionAlgorithm.EncryptionType.Plus);

            Console.WriteLine("Now press any key to decrypt c:\\WORK\\a_EncryptPlus.txt file with CaesarPlus algorithm! \n\rThe resulted file should be similar with a.txt!");
            Console.ReadKey();
            DecryptFile("c:\\WORK\\a_EncryptPlus.txt", "c:\\WORK\\a_EncryptPlus_DecryptPlus.txt", EncryptionAlgorithm.EncryptionType.Plus);

            Console.WriteLine();

            Console.WriteLine("Press any key to encrypt c:\\WORK\\b.txt file with CaesarMinus algorithm !");
            Console.ReadKey();
            EncryptFile("c:\\WORK\\b.txt", "c:\\WORK\\b_EncryptMinus.txt", EncryptionAlgorithm.EncryptionType.Minus);

            Console.WriteLine("Now press any key to decrypt c:\\WORK\\b_EncryptMinus.txt file with CaesarMinus algorithm! \n\rThe resulted file should be similar with b.txt!");
            Console.ReadKey();
            DecryptFile("c:\\WORK\\b_EncryptMinus.txt", "c:\\WORK\\b_EncryptMinus_DecryptMinus.txt", EncryptionAlgorithm.EncryptionType.Minus);
        }
    }
}
