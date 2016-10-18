namespace Caesar
{
    public class EncryptionAlgorithm
    {
        public enum EncryptionType { Plus, Minus }

        public virtual string encrypt(string text)
        {
            return text;
        }
        public virtual string decrypt(string text)
        {
            return text;
        }
    }
}
