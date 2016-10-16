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
                if(c < 33)
                {
                    reversedText.Append(c);
                }
                else if (c == 'z')
                {
                    reversedText.Append('a');
                }
                else if(c == 'ÿ')  // 'ÿ' is the char with ASCII code 255
                {
                    reversedText.Append('!');  // '!' is the first printable char in ASCII
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
