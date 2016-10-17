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

            var encryptedText = new StringBuilder();

            foreach (char c in text)
            {
                // firts 32 ASCII characters are not printable, so we keep them as they are
                if (c < 33)
                {
                    encryptedText.Append(c);
                }
                else if (c == 'z')
                {
                    encryptedText.Append('a');
                }
                else if (c == 'Z')
                {
                    encryptedText.Append('A');
                }
                else if (c == 'ÿ')  // 'ÿ' is the last printable char in ASCII, with code 255
                {
                    encryptedText.Append('!');  // '!' is the first printable char in ASCII, with code 33
                }
                else
                {
                    encryptedText.Append((char)(c + 1));
                }
            }

            return encryptedText.ToString();
        }

        public override string Decrypt(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            var decryptedText = new StringBuilder();

            foreach (char c in text)
            {
                // firts 32 ASCII characters are not printable, so we keep them as they are
                if (c < 33)
                {
                    decryptedText.Append(c);
                }
                else if (c == 'a')
                {
                    decryptedText.Append('z');
                }
                else if (c == 'A')
                {
                    decryptedText.Append('Z');
                }
                else if (c == '!')  // '!' is the first printable char in ASCII, with code 33
                {
                    decryptedText.Append('ÿ');  // 'ÿ' is the last printable char in ASCII, with code 255
                }
                else
                {
                    decryptedText.Append((char)(c - 1));
                }
            }

            return decryptedText.ToString();
        }
    }
}
