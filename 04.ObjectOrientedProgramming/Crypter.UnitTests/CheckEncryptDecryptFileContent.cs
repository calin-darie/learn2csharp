using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypter.UnitTests
{
    [TestClass]
    public class CheckEncryptDecryptFileContent
    {
        [TestMethod]
        public void TestEncryptFileContent()
        {
            string Initial = "ABCD";
            string myInputFile = "M:\\T3.txt";
            string myOutputFile = "M:\\T4.txt";

//write in file the "ABCD" value
            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

//encrypt the file content
            Program.EncryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Plus);

//read encrypted string            
            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

//compare if encryption works ok
            Assert.AreEqual("BCDE", MyContent);
        }

        [TestMethod]
        public void TestDecryptFileContent()
        {
            string Initial = "BCDE";
            string myInputFile = "M:\\T3.txt";
            string myOutputFile = "M:\\T4.txt";

//write in file the "BCDE" value
            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

//decrypt the file content
            Program.DecryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Minus);

//read decrypted string            
            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

//compare if decryption works ok
            Assert.AreEqual("ABCD", MyContent);
        }

    }
}
