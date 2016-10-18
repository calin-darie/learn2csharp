using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypter.UnitTests
{
    [TestClass]
    public class CornerCases
    {
        string myInputFile = "M:\\T3.txt";
        string myOutputFile = "M:\\T4.txt";

        [TestMethod]
        public void TestEmptyString()
        {
            string Initial = "";

            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

            Program.DecryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Minus);
           
            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

            Assert.AreEqual("", MyContent);
        }

        [TestMethod]
        public void DecryptCharA()
        {
            string Initial = "A";

            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

            Program.DecryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Minus);

            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

            Assert.AreEqual("@", MyContent);
        }

        [TestMethod]
        public void EncryptCharZ()
        {
            string Initial = "Z";

            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

            Program.EncryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Plus);

            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

            Assert.AreEqual("[", MyContent);
        }

        [TestMethod]
        public void EncryptSpecialChars()
        {
            string Initial = "!@#";

            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

            Program.EncryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Plus);

            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

            Assert.AreEqual("\"A$", MyContent);
        }

        [TestMethod]
        public void EncryptMultiline()
        {
            string Initial = @"A
B
C";
            string ToCompare = @"B
C
D";

            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

            Program.EncryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Plus);

            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);

//apparently this always fails
//Expected:<B\r\nC\r\nD>. Actual:<B\vC\vD>
            Assert.AreEqual(ToCompare, MyContent);
        }

        [TestMethod]
        public void DecryptSpace()
        {
            string Initial = " ";
            IOFileWriter myWriter = new IOFileWriter();
            myWriter.WriteInFile(myInputFile, Initial);

            Program.DecryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Minus);

            IOFileReader myReader = new IOFileReader();
            string MyContent = myReader.ReadFromFile(myOutputFile);
//apparently this always fails
            Assert.AreEqual("", MyContent);
        }
    }
}
