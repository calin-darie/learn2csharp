using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_StringEncryption;

namespace StringEncryption.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenABCDEF_CaesarPlusReturnsBCDEFG()
        {
            string input = "abcdef";
            var sut = new CaesarPlus();

            string output = sut.Encrypt(input);

            Assert.AreEqual("bcdefg", output);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullInput_CaesarPlusTrowsException()
        {
            var sut = new CaesarPlus();

            sut.Encrypt(null);
        }

        [TestMethod]
        public void GivenLastChar_CaesarPlusReturnsFirst()
        {
            var sut = new CaesarPlus();

            string output = sut.Encrypt("z");

            Assert.AreEqual("a", output);
        }
    }
}
