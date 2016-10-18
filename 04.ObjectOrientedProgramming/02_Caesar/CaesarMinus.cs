using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    public class CaesarMinus : EncryptionAlgorithm
    {
        /// <summary>
        /// Takes a string and decrements every character of the string by one.
        /// Uses the CaesarPlus decryption method which decrements every character by one.
        /// </summary>
        /// <param name="text">the string to be encrypted</param>
        /// <returns>encrypted string</returns>
        public override string encrypt(string text)
        {
            CaesarPlus plus = new CaesarPlus();
            return plus.decrypt(text);
        }

        /// <summary>
        /// Takes a string encrypted with CaesarMinus and decrypts it (increment string characters by one).
        /// Uses the CaesarPlus decryption method which increments every character by one.
        /// </summary>
        /// <param name="text">the string to be decrypted</param>
        /// <returns>decrypted string</returns>
        public override string decrypt(string text)
        {
            CaesarPlus plus = new CaesarPlus();
            return plus.encrypt(text);
        }
    }
}
