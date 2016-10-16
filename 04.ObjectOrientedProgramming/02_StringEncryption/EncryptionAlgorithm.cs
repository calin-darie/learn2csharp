using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    public class EncryptionAlgorithm
    {
        public enum EncryptionType
        {
            Plus,
            Minus
        }

        public virtual String Encrypt(String text)
        {
            return "";
        }

        public virtual String Decrypt(String text)
        {
            return "";
        }
    }
}
