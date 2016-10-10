using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringEncryption
{
    public class CaesarPlus : EncryptionAlgorithm
    {
        public override string Encrypt(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            var reversedText = new StringBuilder();
            foreach (char c in text)
            {
                if(c == 'z')
                {
                    reversedText.Append('a');
                }
                else
                {
                    reversedText.Append((char)(c + 1));
                }
            }

            return reversedText.ToString();
        }
    }
}
