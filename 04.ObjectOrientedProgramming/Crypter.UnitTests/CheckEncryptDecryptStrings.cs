using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypter.UnitTests
{
    [TestClass]
    public class CheckEncryptDecryptStrings
    {
        [TestMethod]
        public void TestEncryptABCD()
        {
           string Initial = "ABCD";

           EncryptionAlgorithm myAlg = new EncryptionAlgorithm();
           string MyContent = myAlg.EncryptString(Initial);

           Assert.AreEqual("BCDE", MyContent);
        }

        [TestMethod]
        public void TestDecryptBCDE()
        {
            string Initial = "BCDE";

            EncryptionAlgorithm myAlg = new EncryptionAlgorithm();
            string MyContent = myAlg.DecryptString(Initial);

            Assert.AreEqual("ABCD", MyContent);
        }

        [TestMethod]
        public void TestEncryptDecryptBCDE()
        {
            string Initial = "ABCD";

            EncryptionAlgorithm myAlg = new EncryptionAlgorithm();
            string MyContent = myAlg.EncryptString(Initial);
            string MyContent1 = myAlg.DecryptString(MyContent);

            Assert.AreEqual("ABCD", MyContent1);
        }
    }
}
