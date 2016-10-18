using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar;

namespace Caesar.UnitTests
{
    [TestClass]
    public class CaesarTests
    {
        private CaesarPlus plus = new CaesarPlus();
        string error = Ceasar.ErrorMessage.IsNullOrEmptyErrorMessage;

        [TestMethod]
        public void GivenCharacterA_WhenGetCharacterWithPlus_ThenCharacterBIsReturned()
        {
            //arrange
            char aChar= 'a';
            //act
            char getChar = plus.GetCharacter(aChar, EncryptionAlgorithm.EncryptionType.Plus);
            //assert
            Assert.AreEqual(getChar, 'b');
        }

        [TestMethod]
        public void GivenCharacterB_WhenGetCharacterWithMinus_ThenCharacterAIsReturned()
        {
            //arrange
            char aChar = 'b';
            //act
            char getChar = plus.GetCharacter(aChar, EncryptionAlgorithm.EncryptionType.Minus);
            //assert
            Assert.AreEqual(getChar, 'a');
        }

        [TestMethod]
        public void GivenSampleString_WhenEncryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string sampleString = "abcdef";
            //act            
            string encrypted = plus.encrypt(sampleString);
            //assert
            Assert.AreEqual(encrypted, "bcdefg");
        }

        [TestMethod]
        public void GivenNullString_WhenEncryptedWithCaesarPlus_ThenErrorIsReturned()
        {
            //arrange
            string nullString = (string)null;
            //act            
            string encrypted = plus.encrypt(nullString);
            //assert
            Assert.AreEqual(encrypted, error);
        }

        [TestMethod]
        public void GivenEmptyString_WhenEncryptedWithCaesarPlus_ThenErrorIsReturned()
        {
            //arrange
            string empty = "";
            //act
            string encrypted = plus.encrypt(empty);
            //assert
            Assert.AreEqual(encrypted, error);
        }

        [TestMethod]
        public void GivenStringPrintableChars_WhenEncryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string all = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}";
            string expected = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            //act
            string encrypted = plus.encrypt(all);
            //assert
            Assert.AreEqual(encrypted, expected);
        }

        [TestMethod]
        public void GivenStringAllChars_WhenEncryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string all = "";
            string expected = "";
            for (int i = 0; i <= 254; i++)
            {
                all += ((char)i).ToString();
                expected += ((char)(i + 1)).ToString();
            }            
            //act
            string encrypted = plus.encrypt(all);
            //assert
            Assert.AreEqual(encrypted, expected);
        }

        [TestMethod]
        public void GivenMultilineString_WhenEncryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string multiline = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vitae gravida purus. Nunc 
quis nunc tellus. Cras laoreet congue urna, sed bibendum felis tincidunt vel. Donec ut justo sapien. Maecenas vel ligula 
odio. Suspendisse enim diam, malesuada ut velit nec, feugiat egestas turpis. Fusce non facilisis nibh, eu tincidunt mi. 

Aenean convallis odio euismod, dapibus urna tempor, pretium libero. Praesent pulvinar, nibh et volutpat varius, felis sem 
ultricies nibh, sit amet rhoncus elit lorem sit amet leo. Fusce sed porttitor ligula. Pellentesque ut dictum diam. 

Maecenas accumsan ligula arcu, nec bibendum risus finibus sed.";
            string expected = "Mpsfn!jqtvn!epmps!tju!bnfu-!dpotfdufuvs!bejqjtdjoh!fmju/!Wjwbnvt!wjubf!hsbwjeb!qvsvt/!Ovod!rvjt!ovod!ufmmvt/!Dsbt!mbpsffu!dpohvf!vsob-!tfe!cjcfoevn!gfmjt!ujodjevou!wfm/!Epofd!vu!kvtup!tbqjfo/!Nbfdfobt!wfm!mjhvmb!pejp/!Tvtqfoejttf!fojn!ejbn-!nbmftvbeb!vu!wfmju!ofd-!gfvhjbu!fhftubt!uvsqjt/!Gvtdf!opo!gbdjmjtjt!ojci-!fv!ujodjevou!nj/!Bfofbo!dpowbmmjt!pejp!fvjtnpe-!ebqjcvt!vsob!ufnqps-!qsfujvn!mjcfsp/!Qsbftfou!qvmwjobs-!ojci!fu!wpmvuqbu!wbsjvt-!gfmjt!tfn!vmusjdjft!ojci-!tju!bnfu!sipodvt!fmju!mpsfn!tju!bnfu!mfp/!Gvtdf!tfe!qpsuujups!mjhvmb/!Qfmmfouftrvf!vu!ejduvn!ejbn/!Nbfdfobt!bddvntbo!mjhvmb!bsdv-!ofd!cjcfoevn!sjtvt!gjojcvt!tfe/";
            //act
            string encrypted = plus.encrypt(multiline);
            //assert
            Assert.AreEqual(encrypted, expected);
        }

        [TestMethod]
        public void GivenEmptyString_WhenDecryptedWithCaesarPlus_ThenErrorIsReturned()
        {
            //arrange
            string empty = "";
            //act
            string decrypted = plus.decrypt(empty);
            //assert
            Assert.AreEqual(decrypted, error);
        }

        [TestMethod]
        public void GivenStringPrintableChars_WhenDecryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string printable = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            string expected = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}";
            //act
            string decrypted = plus.decrypt(printable);
            //assert
            Assert.AreEqual(decrypted, expected);
        }

        [TestMethod]
        public void GivenStringAllChars_WhenDecryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string all = "";
            string expected = "";
            for (int i = 1; i <= 255; i++)
            {
                all += ((char)i).ToString();
                expected += ((char)(i - 1)).ToString();
            }
            //act
            string decrypted = plus.decrypt(all);
            //assert
            Assert.AreEqual(decrypted, expected);
        }

        [TestMethod]
        public void GivenMultilineString_WhenDecryptedWithCaesarPlus_ThenResultIsCorrect()
        {
            //arrange
            string multiline = @"MptuEftpmbuf!boe!mpofBmm!ojhiu!mpoh!po!uif!mblfXifsf!gph!usbjmt!boe!njtu!dsffqt-Uif!xijtumf!pg!b!cpbuDbmmt!boe!dsjft!vofoejohmz-Mjlf!tpnf!mptu!dijmeJo!ufbst!boe!uspvcmfIvoujoh!uif!ibscps(t!csfbtuBoe!uif!ibscps(t!fzft/Dbsm!Tboecvsh-!2989!.!2:78";
            string expected = @"Lost

Desolate and lone
All night long on the lake
Where fog trails and mist creeps,
The whistle of a boat
Calls and cries unendingly,
Like some lost child
In tears and trouble
Hunting the harbor's breast
And the harbor's eyes.

Carl Sandburg, 1878 - 1967";
            //act
            string decrypted = plus.decrypt(multiline);
            //assert
            Assert.AreEqual(decrypted, expected);
        }
    }
}
