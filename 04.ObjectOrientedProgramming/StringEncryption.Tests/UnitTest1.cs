using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_StringEncryption;

namespace StringEncryption.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullInput_CaesarPlusEncrypt_TrowsException()
        {
            var sut = new CaesarPlus();

            sut.Encrypt(null);
        }

        [TestMethod]
        public void GivenABCDEF_CaesarPlusEncrypt_ReturnsBCDEFG()
        {
            string input = "abcdef";
            var sut = new CaesarPlus();

            string output = sut.Encrypt(input);

            Assert.AreEqual("bcdefg", output);
        }

        [TestMethod]
        public void GivenLastSmallLetter_CaesarPlusEncrypt_ReturnsFirstLetter()
        {
            var sut = new CaesarPlus();

            string output = sut.Encrypt("z");

            Assert.AreEqual("a", output);
        }

        [TestMethod]
        public void GivenLastBigLetter_CaesarPlusEncrypt_ReturnsFirstLetter()
        {
            var sut = new CaesarPlus();

            string output = sut.Encrypt("Z");

            Assert.AreEqual("A", output);
        }

        [TestMethod]
        public void GivenNonLetters_CaesarPlusEncrypt_ReturnsRightChars()
        {
            var sut = new CaesarPlus();

            string output = sut.Encrypt(".,190}");

            Assert.AreEqual("/-2:1~", output);
        }

        [TestMethod]
        public void GivenLastPrintableAsciiCodeChar_CaesarPlusEncrypt_ReturnsFirstPrintableAsciiCodeChar()
        {
            var sut = new CaesarPlus();

            string output = sut.Encrypt("ÿ");

            Assert.AreEqual("!", output);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullInput_CaesarPlusDecrypt_TrowsException()
        {
            var sut = new CaesarPlus();

            sut.Decrypt(null);
        }

        [TestMethod]
        public void GivenBCDEFG_CaesarPlusDecrypt_ReturnsABCDEF()
        {
            string input = "bcdefg";
            var sut = new CaesarPlus();

            string output = sut.Decrypt(input);

            Assert.AreEqual("abcdef", output);
        }

        [TestMethod]
        public void GivenFirstSmallLetter_CaesarPlusDecrypt_ReturnsLastLetter()
        {
            var sut = new CaesarPlus();

            string output = sut.Decrypt("a");

            Assert.AreEqual("z", output);
        }

        [TestMethod]
        public void GivenFirstBigLetter_CaesarPlusDecrypt_ReturnsLastLetter()
        {
            var sut = new CaesarPlus();

            string output = sut.Decrypt("A");

            Assert.AreEqual("Z", output);
        }

        [TestMethod]
        public void GivenNonLetters_CaesarPlusDecrypt_ReturnsRightChars()
        {
            var sut = new CaesarPlus();

            string output = sut.Decrypt(".,190}");

            Assert.AreEqual("-+08/|", output);
        }

        [TestMethod]
        public void GivenFirstPrintableAsciiCodeChar_CaesarPlusDecrypt_ReturnsLastPrintableAsciiCodeChar()
        {
            var sut = new CaesarPlus();

            string output = sut.Decrypt("!");

            Assert.AreEqual("ÿ", output);
        }

    }
}
