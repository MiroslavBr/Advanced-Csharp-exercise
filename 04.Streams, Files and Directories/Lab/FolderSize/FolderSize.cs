namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            decimal size = 0;
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                size =file.Length/1024.0m;
            }

            File.WriteAllText(outputFilePath, size.ToString() + " KB");
        }
    }
}
