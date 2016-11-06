using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caesar.Specs.Steps
{
    [Binding]
    public class CaesarMinusSteps
    {
        private CaesarMinus minus = new CaesarMinus();

        [Given(@"The file contains (.*)")]
        [Given(@"The file contains:")]
        public void GivenTheFileContains(string text)
        {
            ScenarioContext.Current["text"] = text;
        }
        
        [When(@"I encrypt with CaesarMinus")]
        public void WhenIEncryptWithCaesarMinus()
        {
            string input = ScenarioContext.Current["text"].ToString();
            string encrypted = minus.encrypt(input);
            ScenarioContext.Current["result"] = encrypted;
        }
        
        [When(@"I decrypt with CaesarMinus")]
        public void WhenIDecryptWithCaesarMinus()
        {
            string input = ScenarioContext.Current["text"].ToString();
            string decrypted = minus.decrypt(input);
            ScenarioContext.Current["result"] = decrypted;
        }
        
        [Then(@"the text should be (.*)")]
        [Then(@"the text should be:")]
        public void ThenTheTextShouldBe(string expected)
        {
            string result = ScenarioContext.Current["result"].ToString();
            Assert.AreEqual(expected, result);
        }
    }
}
