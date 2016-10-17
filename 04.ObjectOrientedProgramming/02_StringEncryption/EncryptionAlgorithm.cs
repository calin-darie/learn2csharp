using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    public abstract class EncryptionAlgorithm
    {
        public enum EncryptionType
        {
            Plus,
            Minus
        }

        public abstract string Encrypt(String text);

        public abstract string Decrypt(String text);
    }
}
