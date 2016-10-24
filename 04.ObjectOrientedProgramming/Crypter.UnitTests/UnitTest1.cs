using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypter.UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMon()
        {
            int times = 0;
            var currentString = "a";
            var cezar = new CaesarPlus();
            do
            {
                cezar.Increment(currentString);
                //compare if encryption works ok
                Assert.AreEqual(currentString, cezar.Increment(currentString));
                times++;
            }
            while (currentString != "a");


        }
    }
}
