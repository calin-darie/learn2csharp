using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Caesar.UnitTests
{
    [TestClass]
    public class IOFileWriterUnitTests
    {
        static string testDirectory = "WriteTestFiles";
        static string testFilesDirectory;

        [ClassInitialize()]
        public static void IOFileWriterUnitTestsInitialize(TestContext testContext)
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
        public void GivenPathIsNull_WhenWriting_FalseIsReturned()
        {
            //arrange
            string path = null;

            //act
            string content = "";
            bool result = IOFileWriter.TryWrite(path, content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenPathIsInvalid_WhenWriting_FalseIsReturned()
        {
            //arrange
            string path = @"";

            //act
            string content = "";
            bool result = IOFileWriter.TryWrite(path, content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenPathIsDirectory_WhenWriting_FalseIsReturned()
        {
            //arrange
            string path = testFilesDirectory;

            //act
            string content = "";
            bool result = IOFileWriter.TryWrite(path, content);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenFileDoesNotExist_WhenWriting_FileIsCreated()
        {
            //arrange
            string text = "File did not exist.";
            string filePath = @"DoesNotExist.txt";
            string path = Path.Combine(testFilesDirectory, filePath);

            //act
            bool result = IOFileWriter.TryWrite(path, text);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenFileExistsAndIsEmpty_WhenWriting_ContentIsOverwritten()
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
            string content = "File was empty!";
            bool result = IOFileWriter.TryWrite(path, content);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenFileExistsAndIsNotEmpty_WhenWriting_ContentIsOverwritten()
        {
            //arrange
            string text = "This file is not empty!";
            string filePath = @"ExistingFileTest.txt";
            string path = Path.Combine(testFilesDirectory, filePath);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(text);
            }

            //act
            string content = "The content was overwritten.";
            bool result = IOFileWriter.TryWrite(path, content);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenFileReadOnly_WhenWriting_FalseIsReturned()
        {
            //arrange
            string text = "This file is read-only!";
            string filePath = @"ReadOnlyFileTest.txt";
            string path = Path.Combine(testFilesDirectory, filePath);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(text);
            }
            File.SetAttributes(path, FileAttributes.ReadOnly);

            //act
            string content = "The content was overwritten.";
            bool result = IOFileWriter.TryWrite(path, content);

            //assert
            Assert.IsFalse(result);
        }
    }
}
