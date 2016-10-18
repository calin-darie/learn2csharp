using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Crypter
{
    public class Program
    {
        public static void EncryptFile(string InputFile, string OutputFile, EncryptionAlgorithm.EncryptionType type )
        {
            type = EncryptionAlgorithm.EncryptionType.Plus;
            IOFileReader myReader = new IOFileReader();
            IOFileWriter myWriter = new IOFileWriter();

            string MyContent = myReader.ReadFromFile(InputFile);

            CaesarPlus myAlg = new CaesarPlus();
            string newMyContent = myAlg.Increment(MyContent);

            myWriter.WriteInFile(OutputFile, newMyContent);
        }

        public static void DecryptFile(string InputFile, string OutputFile, EncryptionAlgorithm.EncryptionType type)
        {
            type = EncryptionAlgorithm.EncryptionType.Minus;

            IOFileReader myReader = new IOFileReader();
            IOFileWriter myWriter = new IOFileWriter();

            string MyContent = myReader.ReadFromFile(InputFile);

            CaesarMinus myAlg = new CaesarMinus();
            string newMyContent = myAlg.Decrement(MyContent);

            myWriter.WriteInFile(OutputFile, newMyContent);
        }

        static void Main(string[] args)
        {
/*Test using CezarMinus
            string Initial = "ABCDEFGHIJK";
            string myInputFile = "M:\\T1.txt";
            string myOutputFile = "M:\\T2.txt";
            string myVerificationFile = "M:\\T3.txt";

            IOFileWriter myWriter = new IOFileWriter();
            IOFileReader myReader = new IOFileReader();

            myWriter.WriteInFile(myInputFile, Initial);
            Program.EncryptFile(myInputFile, myOutputFile, EncryptionAlgorithm.EncryptionType.Plus);
        
            
            string MyContent = myReader.ReadFromFile(myOutputFile);
            Program.DecryptFile(myOutputFile, myVerificationFile, EncryptionAlgorithm.EncryptionType.Minus);
 */
            string Initial = "CDE";

            CaesarPlus myCezar = new CaesarPlus();
            myCezar.StringToIncrement = Initial;

            CaesarMinusReloaded myAlgCezar = new CaesarMinusReloaded();

            string newMyContent = myAlgCezar.Decrement(myCezar);

            Console.WriteLine("{0} - {1}", myCezar.StringToIncrement, newMyContent);
          

            Console.ReadLine();
        }
    }
}
