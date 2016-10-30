using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caesar.UnitTests
{
    [TestClass]
    public class IOFileReaderUnitTests
    {
        static string testDirectory = "ReadTestFiles";
        static string testFilesDirectory;

        [ClassInitialize()]
        public static void IOFileReaderUnitTestsInitialize(TestContext testContext)
        {
            testFilesDirectory = Path.Combine(testContext.TestRunDirectory, testDirectory);
            Directory.CreateDirectory(testFilesDirectory);
        }

        [ClassCleanup()]
        public static void IOFileWriterUnitTestsCleanup()
        {
            var directory = new DirectoryInfo(testFilesDirectory);
            foreach (var info in directory.GetFileSystemInfos("*", SearchOption.AllDirectories))
            {
                info.Attributes = FileAttributes.Normal;
            }

            directory.Delete(true);
        }

        [TestMethod]
        public void GivenPathIsNull_WhenReading_FalseIsReturned()
        {
            //arrange
            string path = null;

            //act
            string content = "";
            bool result = IOFileReader.TryRead(path, out content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenPathIsInvalid_WhenReading_FalseIsReturned()
        {
            //arrange
            string path = @"";

            //act
            string content = "";
            bool result = IOFileReader.TryRead(path, out content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenPathIsDirectory_WhenReading_FalseIsReturned()
        {
            //arrange
            string path = testFilesDirectory;

            //act
            string content = "";
            bool result = IOFileReader.TryRead(path, out content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenFileDoesNotExist_WhenReading_FalseIsReturned()
        {
            //arrange
            string path = @"X:\CaesarIncorrectPathTest\doesNotExist.txt";

            //act
            string content = "";
            bool result = IOFileReader.TryRead(path, out content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenFileIsEmpty_WhenReading_EmptyIsReturned()
        {
            //arrange
            string text = "";
            string filePath = @"EmptyFileTest.txt";
            string path = Path.Combine(testFilesDirectory, filePath);           

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(text);
            }

            //act
            string content = "";
            bool result = IOFileReader.TryRead(path, out content);
            
            //assert
            string expected = text;
            Assert.IsTrue(result);
            Assert.AreEqual(expected, content);
        }

        [TestMethod]
        public void GivenFileIsNotEmpty_WhenReading_ContentIsReturned()
        {
            //arrange
            string text = "This file is not empty!";
            string filePath = @"FileTest.txt";
            string path = Path.Combine(testFilesDirectory, filePath);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(text);
            }

            //act
            string content = "";
            bool result = IOFileReader.TryRead(path, out content);

            //assert
            string expected = text;
            Assert.IsTrue(result);
            Assert.AreEqual(expected, content);
        }
    }
}
