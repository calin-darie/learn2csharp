using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter
{
    public class EncryptionAlgorithm
    {
        public enum EncryptionType
        {
            Plus,
            Minus
        }
        
        public string String { get; set; }

        public virtual String EncryptString(String text)
        {
            CaesarPlus myAlg = new CaesarPlus();
            string newMyContent = myAlg.Increment(text);

            return newMyContent;
        }

        public virtual String DecryptString(String text)
        {
            CaesarMinus myAlg = new CaesarMinus();
            string newMyContent = myAlg.Decrement(text);

            return newMyContent;
        }
    }

   public class CaesarPlus : EncryptionAlgorithm
    {
        public string StringToIncrement { get; set; }
        
        public string Increment (string StringToIncrement)
        {
            string result = "";
            Char[] textArray = StringToIncrement.ToArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i]++;
                result += textArray[i];
            }

            return result;
        }
    }

    class CaesarMinus : EncryptionAlgorithm
    {
        public string StringToDecrement { get; set; }

        public string Decrement (string StringToDecrement)
        {
            string result = "";
            Char[] textArray = StringToDecrement.ToArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i]--;
                result += textArray[i];
            }

            return result;
        }
    }

    class CaesarMinusReloaded : CaesarPlus
    {
        public string Decrement(CaesarPlus Cezar)
        {
            string result = Cezar.StringToIncrement;
            string temp = "";
            for (int i = 0; i < 65535; i++) //pt 65535 vezi Unittestul TestForCaesarMinusReloaded
            {
                temp = Cezar.Increment(result);
                result = temp;
            }
            return result;

        }
    }
}
