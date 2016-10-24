using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypter.UnitTests
{
    [TestClass]
    public class TestforCaesarMinusReloaded
    {
        [TestMethod]
        public void HowManyTimesIHaveToIncrementToDecrement()
        {
            int times = 0;
            var currentString = "a";
            var cezar = new CaesarPlus();
            do
            {
               currentString = cezar.Increment(currentString);
             
                times++;
            }
            while (currentString != "a");
            Console.WriteLine("{0}", times);

        }
    }
}
