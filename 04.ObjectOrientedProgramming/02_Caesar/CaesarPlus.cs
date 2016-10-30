using System;

namespace Caesar
{
    public class CaesarPlus : EncryptionAlgorithm
    {
        /// <summary>
        /// Takes a character and based on encryption type either increments or decrements it by one.
        /// </summary>
        /// <param name="character">the character to be encrypted</param>
        /// <param name="type">the type of encryption; must be Plus or Minus</param>
        /// <returns>encrypted string</returns>
        public char GetCharacter(char character, EncryptionType type)
        {
            switch (type)
            {
                case EncryptionType.Plus:
                    ++character;
                    break;
                case EncryptionType.Minus:
                    --character;
                    break;
                default:
                    break;
            }
            return character;            
        }

        /// <summary>
        /// Takes a string and increments every character of the string by one.
        /// </summary>
        /// <param name="text">the string to be encrypted</param>
        /// <returns>encrypted string</returns>
        public override string encrypt(string text)
        {
            string encrypted = "";
            if (!String.IsNullOrEmpty(text))
            {                
                foreach (char c in text)
                {
                    encrypted += GetCharacter(c, EncryptionType.Plus);
                }
                return encrypted;
            }
            else
            {
                return Caesar.ErrorMessage.IsNullOrEmptyErrorMessage;
            }
        }

        /// <summary>
        /// Takes a string encrypted with CaesarPlus and decrypts it (decrement characters by one)
        /// </summary>
        /// <param name="text">the string to be decrypted</param>
        /// <returns>decrypted string</returns>
        public override string decrypt(string text)
        {
            string decrypted = "";
            if (!String.IsNullOrEmpty(text))
            {
                foreach (char c in text)
                {
                    decrypted += GetCharacter(c, EncryptionType.Minus);
                }
                return decrypted;
            }
            else
            {
                return Caesar.ErrorMessage.IsNullOrEmptyErrorMessage;
            }
        }
    }
}
