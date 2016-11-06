using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar;
using System.IO;

namespace Caesar.Specs
{
    [Binding]
    public class CaesarPlusSteps
    {
        private EncryptionAlgorithm.EncryptionType encryptionType = new EncryptionAlgorithm.EncryptionType();

        [Given(@"A file is located at (.*)")]
        public void GivenAFileIsLocatedAtLocation(FileInfo inputFile)
        {
            ScenarioContext.Current["inputFile"] = inputFile;
        }

        [Given(@"the file contains (.*)")]
        [Given(@"the file contains:")]
        public void GivenTheFileContainsText(string contentOfFile)
        {
            string input = ScenarioContext.Current["inputFile"].ToString();
            string content = File.ReadAllText(input);
            
            if (content != contentOfFile)
            {
                File.WriteAllText(input, contentOfFile);
            }
        }

        [When(@"encrypted with CaesarPlus to (.*)")]
        public void WhenEncryptedWithCaesarPlusToLocation(string outputFile)
        {
            encryptionType = EncryptionAlgorithm.EncryptionType.Plus;
            string inputFile = ScenarioContext.Current["inputFile"].ToString();
            
            Program.EncryptFile(inputFile, outputFile, encryptionType);
        }   
        
        [When(@"decrypted with CaesarPlus to (.*)")]
        public void WhenDecryptedWithCaesarPlusToLocation(string outputFile)
        {
            encryptionType = EncryptionAlgorithm.EncryptionType.Plus;
            string inputFile = ScenarioContext.Current["inputFile"].ToString();

            Program.DecryptFile(inputFile, outputFile, encryptionType);
        }

        [Then(@"the text in the (.*) should be (.*)")]
        [Then(@"the text in the (.*) should be:")]
        public void ThenTheTextShouldBeEncryptedToLocation(string outputFile, string expectedResult)
        {
            string result = File.ReadAllText(outputFile);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
