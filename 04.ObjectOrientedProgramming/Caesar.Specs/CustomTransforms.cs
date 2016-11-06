using TechTalk.SpecFlow;
using System.IO;

namespace Caesar.Specs
{
    [Binding]
    public class CustomTransforms
    {
        [StepArgumentTransformation]
        public FileInfo FileInfoTransform(string path)
        {
            FileInfo filePath = new FileInfo(path);
            
            if (!filePath.Exists)
            {
                string folder = filePath.DirectoryName;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                FileStream fs = filePath.Create();
                fs.Close();
            }

            return filePath;
        }
    }
}
