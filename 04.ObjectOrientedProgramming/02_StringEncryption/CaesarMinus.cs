using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    public class CaesarMinus : EncryptionAlgorithm
    {
        public override string Encrypt(string text)
        {
            var encryptAlgorithm = new CaesarPlus();

            return encryptAlgorithm.Decrypt(text);
        }

        public override string Decrypt(string text)
        {
            var encryptAlgorithm = new CaesarPlus();

            return encryptAlgorithm.Encrypt(text);
        }
    }
}
